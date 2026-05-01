using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TaskManagerCS.Data;
using TaskManagerCS.Models;
using Task = TaskManagerCS.Models.Task;

namespace TaskManagerCS;

public partial class Form1 : Form
{
    private List<Task> _allTasks;
    private BindingList<Task> _displayedTasks;
    private readonly int _userId;
    private bool _showingAllTasks = false;

    public Form1(int userId)
    {
        _userId = userId;
        InitializeComponent();
        
        _allTasks = new List<Task>();
        _displayedTasks = new BindingList<Task>();
        dgvTasks.AutoGenerateColumns = false;
        dgvTasks.Columns.Clear();
        dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TaskName", HeaderText = "Task Name", Name = "TaskName" });
        dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TaskProgress", HeaderText = "Progress", Name = "TaskProgress" });
        dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Priority", HeaderText = "Priority", Name = "Priority" });
        var dateCol = new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Due Date & Time", Name = "DueDate" };
        dateCol.DefaultCellStyle.Format = "g";
        dgvTasks.Columns.Add(dateCol);
        
        dgvTasks.DataSource = _displayedTasks;

        LoadTasks();
    }

    
    private void LoadTasks()
    {
        _allTasks.Clear();
        var dbTasks = Database.GetTasksForUser(_userId);
        _allTasks.AddRange(dbTasks);
        
        FilterTasksByDate();
    }

    private void FilterTasksByDate()
    {
        _displayedTasks.Clear();
        DateTime selectedDate = monthCalendar.SelectionStart.Date;
        
        foreach (var t in _allTasks)
        {
            if (_showingAllTasks || t.DueDate.Date == selectedDate)
            {
                _displayedTasks.Add(t);
            }
        }
    }

    private void btnShowAll_Click(object? sender, EventArgs e)
    {
        _showingAllTasks = true;
        FilterTasksByDate();
    }

    private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
    {
        _showingAllTasks = false;
        FilterTasksByDate();
        ClearFields();
    }

    private DateTime GetCombinedDateTime()
    {
        return new DateTime(
            dtpDate.Value.Year,
            dtpDate.Value.Month,
            dtpDate.Value.Day,
            dtpTime.Value.Hour,
            dtpTime.Value.Minute,
            dtpTime.Value.Second);
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTaskName.Text) ||
            string.IsNullOrWhiteSpace(cmbProgress.Text) ||
            string.IsNullOrWhiteSpace(cmbPriority.Text))
        {
            MessageBox.Show("All fields must be filled to add a task.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DateTime dueDateTime = GetCombinedDateTime();
        string taskType = cmbTaskType.Text;
        DateTime? startTime = taskType == "Event" ? GetCombinedStartDateTime() : null;
        DateTime? endTime = taskType == "Event" ? GetCombinedEndDateTime() : null;

        int newId = Database.AddTask(
            txtTaskName.Text.Trim(),
            cmbProgress.Text.Trim(),
            cmbPriority.Text.Trim(),
            _userId,
            dueDateTime,
            taskType,
            startTime,
            endTime);

        var task = new Task(
            newId,
            txtTaskName.Text.Trim(),
            cmbProgress.Text.Trim(),
            cmbPriority.Text.Trim(),
            _userId,
            dueDateTime,
            false,
            taskType,
            startTime,
            endTime);

        _allTasks.Add(task);
        FilterTasksByDate();
        dgvTasks.ClearSelection();
        ClearFields();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count == 0)
        {
            MessageBox.Show("No task selected to update.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedTask = dgvTasks.SelectedRows[0].DataBoundItem as Task;
        if (selectedTask != null)
        {
            string newName     = txtTaskName.Text.Trim();
            string newProgress = cmbProgress.Text.Trim();
            string newPriority = cmbPriority.Text.Trim();
            DateTime dueDateTime = GetCombinedDateTime();
            string taskType = cmbTaskType.Text;
            DateTime? startTime = taskType == "Event" ? GetCombinedStartDateTime() : null;
            DateTime? endTime = taskType == "Event" ? GetCombinedEndDateTime() : null;

            Database.UpdateTask(selectedTask.Id, _userId, newName, newProgress, newPriority, dueDateTime, taskType, startTime, endTime);

            selectedTask.TaskName     = newName;
            selectedTask.TaskProgress = newProgress;
            selectedTask.Priority     = newPriority;
            selectedTask.DueDate      = dueDateTime;
            selectedTask.TaskType     = taskType;
            selectedTask.StartTime    = startTime;
            selectedTask.EndTime      = endTime;

            dgvTasks.Refresh();
            dgvTasks.ClearSelection();
            ClearFields();
        }
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count == 0)
        {
            MessageBox.Show("No task selected to delete.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedTask = dgvTasks.SelectedRows[0].DataBoundItem as Task;
        if (selectedTask != null)
        {
            Database.DeleteTask(selectedTask.Id, _userId); 
            _allTasks.Remove(selectedTask);
            FilterTasksByDate();
            dgvTasks.ClearSelection();
            ClearFields();
        }
    }

    private void btnTrashAll_Click(object? sender, EventArgs e)
    {
        var confirmResult = MessageBox.Show("Are you sure you want to move all tasks to the trash?",
                                     "Confirm Trash All",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (confirmResult == DialogResult.Yes)
        {
            Database.TrashAllTasks(_userId);
            LoadTasks();
            ClearFields();
        }
    }

    private void btnTrashBin_Click(object? sender, EventArgs e)
    {
        var trashForm = new TaskManagerCS.Forms.TrashForm(_userId);
        trashForm.ShowDialog();
        
        LoadTasks();
    }

    private void btnOpenCalendar_Click(object? sender, EventArgs e)
    {
        var calendarForm = new TaskManagerCS.Forms.CalendarForm(_userId, monthCalendar.SelectionStart);
        calendarForm.ShowDialog();
        
        LoadTasks();
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        dgvTasks.ClearSelection();
        ClearFields();
    }

    private void ClearFields()
    {
        txtTaskName.Clear();
        cmbTaskType.SelectedIndex = 0; 
        cmbProgress.SelectedIndex = -1;
        cmbPriority.SelectedIndex = -1;
        dtpDate.Value = monthCalendar.SelectionStart;
        dtpTime.Value = DateTime.Now;
        dtpStartTime.Value = DateTime.Now;
        dtpEndTime.Value = DateTime.Now.AddHours(1);
    }

    private void cmbTaskType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        bool isEvent = cmbTaskType.Text == "Event";
        
        
        lblDueTime.Visible = !isEvent;
        dtpTime.Visible = !isEvent;
        
        lblStartTime.Visible = isEvent;
        dtpStartTime.Visible = isEvent;
        lblEndTime.Visible = isEvent;
        dtpEndTime.Visible = isEvent;
        
        lblDueDate.Text = isEvent ? "Event Date:" : "Due Date:";
    }

    private DateTime GetCombinedStartDateTime()
    {
        return new DateTime(
            dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day,
            dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
    }

    private DateTime GetCombinedEndDateTime()
    {
        return new DateTime(
            dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day,
            dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);
    }

    private void dgvTasks_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count > 0)
        {
            var selectedTask = dgvTasks.SelectedRows[0].DataBoundItem as Task;
            if (selectedTask != null)
            {
                txtTaskName.Text = selectedTask.TaskName;
                cmbTaskType.Text = selectedTask.TaskType;
                cmbProgress.Text = selectedTask.TaskProgress;
                cmbPriority.Text = selectedTask.Priority;
                dtpDate.Value = selectedTask.DueDate.Date;
                dtpTime.Value = selectedTask.DueDate;
                
                if (selectedTask.TaskType == "Event" && selectedTask.StartTime.HasValue && selectedTask.EndTime.HasValue)
                {
                    dtpStartTime.Value = selectedTask.StartTime.Value;
                    dtpEndTime.Value = selectedTask.EndTime.Value;
                }
            }
        }
        else
        {
            ClearFields();
        }
    }

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        var loginForm = new TaskManagerCS.Forms.LoginForm();
        loginForm.Show();
        this.Close();
    }
}
