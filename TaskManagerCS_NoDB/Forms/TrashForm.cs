using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TaskManagerCS.Data;
using TaskManagerCS.Models;
using Task = TaskManagerCS.Models.Task;

namespace TaskManagerCS.Forms;

public partial class TrashForm : Form
{
    private BindingList<Task> _trashedTasks;
    private readonly int _userId;

    public TrashForm(int userId)
    {
        _userId = userId;
        InitializeComponent();
        
        _trashedTasks = new BindingList<Task>();
        dgvTrash.AutoGenerateColumns = false;
        
        
        dgvTrash.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TaskName", HeaderText = "Task Name", Name = "TaskName" });
        dgvTrash.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TaskProgress", HeaderText = "Progress", Name = "TaskProgress" });
        dgvTrash.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Priority", HeaderText = "Priority", Name = "Priority" });
        
        var dateCol = new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Due Date & Time", Name = "DueDate" };
        dateCol.DefaultCellStyle.Format = "g";
        dgvTrash.Columns.Add(dateCol);

        dgvTrash.DataSource = _trashedTasks;
        LoadTrashedTasks();
    }

    private void LoadTrashedTasks()
    {
        _trashedTasks.Clear();
        var tasks = Database.GetTrashedTasksForUser(_userId);
        foreach (var t in tasks)
        {
            _trashedTasks.Add(t);
        }
    }

    private void btnRestoreSelected_Click(object? sender, EventArgs e)
    {
        bool anyRestored = false;
        foreach (DataGridViewRow row in dgvTrash.Rows)
        {
            
            if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value == true)
            {
                var task = row.DataBoundItem as Task;
                if (task != null)
                {
                    Database.RestoreTask(task.Id, _userId);
                    anyRestored = true;
                }
            }
        }
        
        if (anyRestored)
        {
            LoadTrashedTasks();
            MessageBox.Show("Selected tasks have been restored.", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Please select at least one task to restore by checking its box.", "None Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnRestoreAll_Click(object? sender, EventArgs e)
    {
        if (_trashedTasks.Count == 0) return;

        var confirmResult = MessageBox.Show("Are you sure you want to restore all trashed tasks?", "Confirm Restore All", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirmResult == DialogResult.Yes)
        {
            foreach (var task in _trashedTasks)
            {
                Database.RestoreTask(task.Id, _userId);
            }
            LoadTrashedTasks();
            MessageBox.Show("All tasks have been restored.", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnEmptyTrash_Click(object? sender, EventArgs e)
    {
        if (_trashedTasks.Count == 0) return;

        var confirmResult = MessageBox.Show("WARNING: This will permanently delete all tasks in the trash. This action cannot be undone.\n\nAre you sure you want to empty the trash?", 
                                            "Confirm Empty Trash", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
        if (confirmResult == DialogResult.Yes)
        {
            Database.HardDeleteAllTrashedTasks(_userId);
            LoadTrashedTasks();
            MessageBox.Show("Trash has been emptied.", "Empty Trash", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}
