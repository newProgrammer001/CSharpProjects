using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskManagerCS.Data;
using TaskManagerCS.Models;
using Task = TaskManagerCS.Models.Task;

namespace TaskManagerCS.Forms;

public partial class CalendarForm : Form
{
    private readonly int _userId;
    private readonly DateTime _selectedDate;
    private const int HourHeight = 60; 

    public CalendarForm(int userId, DateTime selectedDate)
    {
        _userId = userId;
        _selectedDate = selectedDate.Date;
        InitializeComponent();
        
        lblDate.Text = _selectedDate.ToString("dddd, MMM dd, yyyy");
        
        
        pnlCalendarContainer.VerticalScroll.Value = Math.Min(8 * HourHeight, pnlCalendarContainer.VerticalScroll.Maximum);
        
        LoadAndDisplayTasks();
    }

    private void LoadAndDisplayTasks()
    {
        
        var cards = pnlScheduleGrid.Controls.OfType<Panel>().ToList();
        foreach (var card in cards) pnlScheduleGrid.Controls.Remove(card);

        
        var allTasks = Database.GetTasksForUser(_userId);
        var dailyTasks = allTasks.Where(t => t.DueDate.Date == _selectedDate).OrderBy(t => t.DueDate).ToList();

        foreach (var task in dailyTasks)
        {
            CreateTaskCard(task);
        }
    }

    private void CreateTaskCard(Task task)
    {
        bool isEvent = task.TaskType == "Event";
        DateTime startTime = (isEvent && task.StartTime.HasValue) ? task.StartTime.Value : task.DueDate;
        DateTime endTime = (isEvent && task.EndTime.HasValue) ? task.EndTime.Value : startTime.AddHours(1);

        int startHour = startTime.Hour;
        int startMinute = startTime.Minute;
        
        
        double durationMinutes = (endTime - startTime).TotalMinutes;
        if (durationMinutes <= 0) durationMinutes = 60; 

        Panel card = new Panel();
        card.Width = pnlScheduleGrid.Width - 40;
        card.Height = (int)Math.Max(30, durationMinutes - 2); 
        card.Left = 10;
        card.Top = (startHour * HourHeight) + startMinute;
        
        
        card.BackColor = task.Priority switch
        {
            "High" => Color.FromArgb(220, 53, 69),   
            "Medium" => Color.FromArgb(255, 193, 7), 
            _ => Color.FromArgb(40, 167, 69)         
        };

        
        card.Padding = new Padding(10, 5, 10, 5);
        
        Label lblName = new Label();
        lblName.Text = task.TaskName;
        lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblName.ForeColor = Color.White;
        lblName.AutoSize = true;
        lblName.Dock = DockStyle.Top;
        
        Label lblTime = new Label();
        lblTime.Text = isEvent 
            ? $"{startTime:HH:mm} - {endTime:HH:mm}"
            : $"{startTime:HH:mm} (To-Do)";
        lblTime.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        lblTime.ForeColor = Color.FromArgb(230, 230, 230);
        lblTime.AutoSize = true;
        lblTime.Dock = DockStyle.Bottom;

        card.Controls.Add(lblName);
        card.Controls.Add(lblTime);
        
        
        ToolTip tt = new ToolTip();
        string info = isEvent 
            ? $"{task.TaskName}\nType: Event\nTime: {startTime:t} to {endTime:t}"
            : $"{task.TaskName}\nType: To-Do\nDue: {startTime:t}";
        tt.SetToolTip(card, info + $"\nPriority: {task.Priority}\nStatus: {task.TaskProgress}");

        pnlScheduleGrid.Controls.Add(card);
        card.BringToFront();
    }

    private void pnlTimeline_Paint(object sender, PaintEventArgs e)
    {
        using Font font = new Font("Segoe UI", 9F, FontStyle.Bold);
        using SolidBrush brush = new SolidBrush(Color.DarkGray);
        
        for (int i = 0; i < 24; i++)
        {
            string timeText = i.ToString("D2") + ":00";
            e.Graphics.DrawString(timeText, font, brush, 10, i * HourHeight + 5);
        }
    }

    private void pnlScheduleGrid_Paint(object sender, PaintEventArgs e)
    {
        using Pen pen = new Pen(Color.FromArgb(50, 50, 50), 1);
        
        for (int i = 0; i <= 24; i++)
        {
            int y = i * HourHeight;
            e.Graphics.DrawLine(pen, 0, y, pnlScheduleGrid.Width, y);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
