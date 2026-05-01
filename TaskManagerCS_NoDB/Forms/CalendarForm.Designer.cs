namespace TaskManagerCS.Forms;

partial class CalendarForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.panelHeader = new System.Windows.Forms.Panel();
        this.lblDate = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();
        this.pnlCalendarContainer = new System.Windows.Forms.Panel();
        this.pnlTimeline = new System.Windows.Forms.Panel();
        this.pnlScheduleGrid = new System.Windows.Forms.Panel();
        this.panelHeader.SuspendLayout();
        this.pnlCalendarContainer.SuspendLayout();
        this.SuspendLayout();
        
        
        
        
        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
        this.panelHeader.Controls.Add(this.lblDate);
        this.panelHeader.Controls.Add(this.btnClose);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(900, 70);
        this.panelHeader.TabIndex = 0;
        
        
        
        this.lblDate.AutoSize = true;
        this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDate.ForeColor = System.Drawing.Color.White;
        this.lblDate.Location = new System.Drawing.Point(20, 18);
        this.lblDate.Name = "lblDate";
        this.lblDate.Size = new System.Drawing.Size(182, 32);
        this.lblDate.TabIndex = 0;
        this.lblDate.Text = "Monday, Apr 28";
        
        
        
        this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        this.btnClose.FlatAppearance.BorderSize = 0;
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnClose.ForeColor = System.Drawing.Color.White;
        this.btnClose.Location = new System.Drawing.Point(780, 15);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(100, 40);
        this.btnClose.TabIndex = 1;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = false;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        
        
        
        this.pnlCalendarContainer.AutoScroll = true;
        this.pnlCalendarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.pnlCalendarContainer.Controls.Add(this.pnlScheduleGrid);
        this.pnlCalendarContainer.Controls.Add(this.pnlTimeline);
        this.pnlCalendarContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlCalendarContainer.Location = new System.Drawing.Point(0, 70);
        this.pnlCalendarContainer.Name = "pnlCalendarContainer";
        this.pnlCalendarContainer.Size = new System.Drawing.Size(900, 630);
        this.pnlCalendarContainer.TabIndex = 1;
        
        
        
        this.pnlTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
        this.pnlTimeline.Location = new System.Drawing.Point(0, 0);
        this.pnlTimeline.Name = "pnlTimeline";
        this.pnlTimeline.Size = new System.Drawing.Size(80, 1440); 
        this.pnlTimeline.TabIndex = 0;
        this.pnlTimeline.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimeline_Paint);
        
        
        
        this.pnlScheduleGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.pnlScheduleGrid.Location = new System.Drawing.Point(80, 0);
        this.pnlScheduleGrid.Name = "pnlScheduleGrid";
        this.pnlScheduleGrid.Size = new System.Drawing.Size(800, 1440);
        this.pnlScheduleGrid.TabIndex = 1;
        this.pnlScheduleGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScheduleGrid_Paint);
        
        
        
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(900, 700);
        this.Controls.Add(this.pnlCalendarContainer);
        this.Controls.Add(this.panelHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.White;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "CalendarForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Day View Calendar";
        this.panelHeader.ResumeLayout(false);
        this.panelHeader.PerformLayout();
        this.pnlCalendarContainer.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel pnlCalendarContainer;
    private System.Windows.Forms.Panel pnlTimeline;
    private System.Windows.Forms.Panel pnlScheduleGrid;
}
