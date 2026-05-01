namespace TaskManagerCS;

partial class Form1
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.panelSidebar = new System.Windows.Forms.Panel();
        this.btnLogout = new System.Windows.Forms.Button();
        this.btnShowAll = new System.Windows.Forms.Button();
        this.btnTrashAll = new System.Windows.Forms.Button();
        this.btnTrashBin = new System.Windows.Forms.Button();
        this.btnOpenCalendar = new System.Windows.Forms.Button();
        this.monthCalendar = new System.Windows.Forms.MonthCalendar();
        this.lblTitle = new System.Windows.Forms.Label();
        this.panelMain = new System.Windows.Forms.Panel();
        this.dgvTasks = new System.Windows.Forms.DataGridView();
        this.panelInput = new System.Windows.Forms.Panel();
        this.lblFormTitle = new System.Windows.Forms.Label();
        this.btnClear = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnAdd = new System.Windows.Forms.Button();
        this.cmbPriority = new System.Windows.Forms.ComboBox();
        this.lblPriority = new System.Windows.Forms.Label();
        this.cmbProgress = new System.Windows.Forms.ComboBox();
        this.lblProgress = new System.Windows.Forms.Label();
        this.dtpTime = new System.Windows.Forms.DateTimePicker();
        this.lblDueTime = new System.Windows.Forms.Label();
        this.dtpDate = new System.Windows.Forms.DateTimePicker();
        this.lblDueDate = new System.Windows.Forms.Label();
        this.txtTaskName = new System.Windows.Forms.TextBox();
        this.lblTaskName = new System.Windows.Forms.Label();
        this.lblTaskType = new System.Windows.Forms.Label();
        this.cmbTaskType = new System.Windows.Forms.ComboBox();
        this.lblStartTime = new System.Windows.Forms.Label();
        this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
        this.lblEndTime = new System.Windows.Forms.Label();
        this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
        
        this.panelSidebar.SuspendLayout();
        this.panelMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
        this.panelInput.SuspendLayout();
        this.SuspendLayout();
        
        
        
        
        this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
        this.panelSidebar.Controls.Add(this.btnOpenCalendar);
        this.panelSidebar.Controls.Add(this.btnTrashBin);
        this.panelSidebar.Controls.Add(this.btnTrashAll);
        this.panelSidebar.Controls.Add(this.btnLogout);
        this.panelSidebar.Controls.Add(this.btnShowAll);
        this.panelSidebar.Controls.Add(this.monthCalendar);
        this.panelSidebar.Controls.Add(this.lblTitle);
        this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelSidebar.Location = new System.Drawing.Point(0, 0);
        this.panelSidebar.Name = "panelSidebar";
        this.panelSidebar.Padding = new System.Windows.Forms.Padding(20);
        this.panelSidebar.Size = new System.Drawing.Size(280, 720);
        this.panelSidebar.TabIndex = 0;
        
        
        
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(20, 30);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(199, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Task Manager";
        
        
        
        this.monthCalendar.Location = new System.Drawing.Point(25, 100);
        this.monthCalendar.Name = "monthCalendar";
        this.monthCalendar.TabIndex = 1;
        this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
        
        
        
        this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnShowAll.FlatAppearance.BorderSize = 0;
        this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnShowAll.ForeColor = System.Drawing.Color.White;
        this.btnShowAll.Location = new System.Drawing.Point(25, 275);
        this.btnShowAll.Name = "btnShowAll";
        this.btnShowAll.Size = new System.Drawing.Size(227, 40);
        this.btnShowAll.TabIndex = 2;
        this.btnShowAll.Text = "Show All Tasks";
        this.btnShowAll.UseVisualStyleBackColor = false;
        this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
        
        
        
        this.btnTrashAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
        this.btnTrashAll.FlatAppearance.BorderSize = 0;
        this.btnTrashAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnTrashAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTrashAll.ForeColor = System.Drawing.Color.White;
        this.btnTrashAll.Location = new System.Drawing.Point(25, 330);
        this.btnTrashAll.Name = "btnTrashAll";
        this.btnTrashAll.Size = new System.Drawing.Size(227, 40);
        this.btnTrashAll.TabIndex = 4;
        this.btnTrashAll.Text = "Trash All Tasks";
        this.btnTrashAll.UseVisualStyleBackColor = false;
        this.btnTrashAll.Click += new System.EventHandler(this.btnTrashAll_Click);
        
        
        
        this.btnTrashBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        this.btnTrashBin.FlatAppearance.BorderSize = 0;
        this.btnTrashBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnTrashBin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTrashBin.ForeColor = System.Drawing.Color.White;
        this.btnTrashBin.Location = new System.Drawing.Point(25, 385);
        this.btnTrashBin.Name = "btnTrashBin";
        this.btnTrashBin.Size = new System.Drawing.Size(227, 40);
        this.btnTrashBin.TabIndex = 5;
        this.btnTrashBin.Text = "Open Trash Bin";
        this.btnTrashBin.UseVisualStyleBackColor = false;
        this.btnTrashBin.Click += new System.EventHandler(this.btnTrashBin_Click);
        
        
        
        this.btnOpenCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        this.btnOpenCalendar.FlatAppearance.BorderSize = 0;
        this.btnOpenCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnOpenCalendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnOpenCalendar.ForeColor = System.Drawing.Color.White;
        this.btnOpenCalendar.Location = new System.Drawing.Point(25, 440);
        this.btnOpenCalendar.Name = "btnOpenCalendar";
        this.btnOpenCalendar.Size = new System.Drawing.Size(227, 40);
        this.btnOpenCalendar.TabIndex = 6;
        this.btnOpenCalendar.Text = "Open Day View";
        this.btnOpenCalendar.UseVisualStyleBackColor = false;
        this.btnOpenCalendar.Click += new System.EventHandler(this.btnOpenCalendar_Click);
        
        
        
        this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
        this.btnLogout.Location = new System.Drawing.Point(25, 650);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(227, 40);
        this.btnLogout.TabIndex = 3;
        this.btnLogout.Text = "Logout";
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        
        
        
        this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.panelMain.Controls.Add(this.dgvTasks);
        this.panelMain.Controls.Add(this.panelInput);
        this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelMain.Location = new System.Drawing.Point(280, 0);
        this.panelMain.Name = "panelMain";
        this.panelMain.Padding = new System.Windows.Forms.Padding(30);
        this.panelMain.Size = new System.Drawing.Size(800, 720);
        this.panelMain.TabIndex = 1;
        
        
        
        this.dgvTasks.AllowUserToAddRows = false;
        this.dgvTasks.AllowUserToDeleteRows = false;
        this.dgvTasks.AllowUserToResizeRows = false;
        this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvTasks.ColumnHeadersHeight = 40;
        this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle2;
        this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvTasks.EnableHeadersVisualStyles = false;
        this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.dgvTasks.Location = new System.Drawing.Point(30, 30);
        this.dgvTasks.MultiSelect = false;
        this.dgvTasks.Name = "dgvTasks";
        this.dgvTasks.ReadOnly = true;
        this.dgvTasks.RowHeadersVisible = false;
        this.dgvTasks.RowTemplate.Height = 35;
        this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvTasks.Size = new System.Drawing.Size(740, 420);
        this.dgvTasks.TabIndex = 0;
        this.dgvTasks.SelectionChanged += new System.EventHandler(this.dgvTasks_SelectionChanged);
        
        
        
        this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
        this.panelInput.Controls.Add(this.lblFormTitle);
        this.panelInput.Controls.Add(this.btnClear);
        this.panelInput.Controls.Add(this.btnDelete);
        this.panelInput.Controls.Add(this.btnUpdate);
        this.panelInput.Controls.Add(this.btnAdd);
        this.panelInput.Controls.Add(this.cmbPriority);
        this.panelInput.Controls.Add(this.lblPriority);
        this.panelInput.Controls.Add(this.cmbProgress);
        this.panelInput.Controls.Add(this.lblProgress);
        this.panelInput.Controls.Add(this.dtpTime);
        this.panelInput.Controls.Add(this.lblDueTime);
        this.panelInput.Controls.Add(this.dtpDate);
        this.panelInput.Controls.Add(this.cmbTaskType);
        this.panelInput.Controls.Add(this.lblTaskType);
        this.panelInput.Controls.Add(this.dtpStartTime);
        this.panelInput.Controls.Add(this.lblStartTime);
        this.panelInput.Controls.Add(this.dtpEndTime);
        this.panelInput.Controls.Add(this.lblEndTime);
        this.panelInput.Controls.Add(this.lblDueDate);
        this.panelInput.Controls.Add(this.txtTaskName);
        this.panelInput.Controls.Add(this.lblTaskName);
        this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelInput.Location = new System.Drawing.Point(30, 450);
        this.panelInput.Name = "panelInput";
        this.panelInput.Size = new System.Drawing.Size(740, 240);
        this.panelInput.TabIndex = 1;
        
        
        
        this.lblFormTitle.AutoSize = true;
        this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblFormTitle.ForeColor = System.Drawing.Color.White;
        this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
        this.lblFormTitle.Name = "lblFormTitle";
        this.lblFormTitle.Size = new System.Drawing.Size(126, 21);
        this.lblFormTitle.TabIndex = 14;
        this.lblFormTitle.Text = "Task Details";
        
        
        
        this.lblTaskName.AutoSize = true;
        this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblTaskName.ForeColor = System.Drawing.Color.LightGray;
        this.lblTaskName.Location = new System.Drawing.Point(190, 50);
        this.lblTaskName.Name = "lblTaskName";
        this.lblTaskName.Size = new System.Drawing.Size(73, 17);
        this.lblTaskName.TabIndex = 0;
        this.lblTaskName.Text = "Task Name:";
        
        
        
        this.lblTaskType.AutoSize = true;
        this.lblTaskType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblTaskType.ForeColor = System.Drawing.Color.LightGray;
        this.lblTaskType.Location = new System.Drawing.Point(20, 50);
        this.lblTaskType.Name = "lblTaskType";
        this.lblTaskType.Size = new System.Drawing.Size(38, 17);
        this.lblTaskType.TabIndex = 15;
        this.lblTaskType.Text = "Type:";
        
        
        
        this.cmbTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
        this.cmbTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbTaskType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.cmbTaskType.ForeColor = System.Drawing.Color.White;
        this.cmbTaskType.FormattingEnabled = true;
        this.cmbTaskType.Items.AddRange(new object[] {
            "To-Do",
            "Event"});
        this.cmbTaskType.Location = new System.Drawing.Point(20, 70);
        this.cmbTaskType.Name = "cmbTaskType";
        this.cmbTaskType.Size = new System.Drawing.Size(150, 25);
        this.cmbTaskType.TabIndex = 16;
        this.cmbTaskType.SelectedIndexChanged += new System.EventHandler(this.cmbTaskType_SelectedIndexChanged);
        
        
        
        this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.txtTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
        this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtTaskName.ForeColor = System.Drawing.Color.White;
        this.txtTaskName.Location = new System.Drawing.Point(190, 70);
        this.txtTaskName.Name = "txtTaskName";
        this.txtTaskName.Size = new System.Drawing.Size(530, 25);
        this.txtTaskName.TabIndex = 1;
        
        
        
        this.lblDueDate.AutoSize = true;
        this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDueDate.ForeColor = System.Drawing.Color.LightGray;
        this.lblDueDate.Location = new System.Drawing.Point(20, 110);
        this.lblDueDate.Name = "lblDueDate";
        this.lblDueDate.Size = new System.Drawing.Size(66, 17);
        this.lblDueDate.TabIndex = 2;
        this.lblDueDate.Text = "Date:";
        
        
        
        this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpDate.Location = new System.Drawing.Point(20, 130);
        this.dtpDate.Name = "dtpDate";
        this.dtpDate.Size = new System.Drawing.Size(150, 25);
        this.dtpDate.TabIndex = 3;
        
        
        
        this.lblDueTime.AutoSize = true;
        this.lblDueTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDueTime.ForeColor = System.Drawing.Color.LightGray;
        this.lblDueTime.Location = new System.Drawing.Point(190, 110);
        this.lblDueTime.Name = "lblDueTime";
        this.lblDueTime.Size = new System.Drawing.Size(67, 17);
        this.lblDueTime.TabIndex = 4;
        this.lblDueTime.Text = "Due Time:";
        
        
        
        this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        this.dtpTime.Location = new System.Drawing.Point(190, 130);
        this.dtpTime.Name = "dtpTime";
        this.dtpTime.ShowUpDown = true;
        this.dtpTime.Size = new System.Drawing.Size(150, 25);
        this.dtpTime.TabIndex = 5;
        
        
        
        this.lblStartTime.AutoSize = true;
        this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblStartTime.ForeColor = System.Drawing.Color.LightGray;
        this.lblStartTime.Location = new System.Drawing.Point(190, 110);
        this.lblStartTime.Name = "lblStartTime";
        this.lblStartTime.Size = new System.Drawing.Size(69, 17);
        this.lblStartTime.TabIndex = 17;
        this.lblStartTime.Text = "Start Time:";
        this.lblStartTime.Visible = false;
        
        
        
        this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        this.dtpStartTime.Location = new System.Drawing.Point(190, 130);
        this.dtpStartTime.Name = "dtpStartTime";
        this.dtpStartTime.ShowUpDown = true;
        this.dtpStartTime.Size = new System.Drawing.Size(150, 25);
        this.dtpStartTime.TabIndex = 18;
        this.dtpStartTime.Visible = false;
        
        
        
        this.lblEndTime.AutoSize = true;
        this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblEndTime.ForeColor = System.Drawing.Color.LightGray;
        this.lblEndTime.Location = new System.Drawing.Point(360, 110);
        this.lblEndTime.Name = "lblEndTime";
        this.lblEndTime.Size = new System.Drawing.Size(64, 17);
        this.lblEndTime.TabIndex = 19;
        this.lblEndTime.Text = "End Time:";
        this.lblEndTime.Visible = false;
        
        
        
        this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        this.dtpEndTime.Location = new System.Drawing.Point(360, 130);
        this.dtpEndTime.Name = "dtpEndTime";
        this.dtpEndTime.ShowUpDown = true;
        this.dtpEndTime.Size = new System.Drawing.Size(150, 25);
        this.dtpEndTime.TabIndex = 20;
        this.dtpEndTime.Visible = false;
        
        
        
        this.lblProgress.AutoSize = true;
        this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblProgress.ForeColor = System.Drawing.Color.LightGray;
        this.lblProgress.Location = new System.Drawing.Point(20, 170);
        this.lblProgress.Name = "lblProgress";
        this.lblProgress.Size = new System.Drawing.Size(63, 17);
        this.lblProgress.TabIndex = 6;
        this.lblProgress.Text = "Progress:";
        
        
        
        this.cmbProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
        this.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbProgress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.cmbProgress.ForeColor = System.Drawing.Color.White;
        this.cmbProgress.FormattingEnabled = true;
        this.cmbProgress.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Done"});
        this.cmbProgress.Location = new System.Drawing.Point(20, 190);
        this.cmbProgress.Name = "cmbProgress";
        this.cmbProgress.Size = new System.Drawing.Size(120, 25);
        this.cmbProgress.TabIndex = 7;
        
        
        
        this.lblPriority.AutoSize = true;
        this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblPriority.ForeColor = System.Drawing.Color.LightGray;
        this.lblPriority.Location = new System.Drawing.Point(150, 170);
        this.lblPriority.Name = "lblPriority";
        this.lblPriority.Size = new System.Drawing.Size(53, 17);
        this.lblPriority.TabIndex = 8;
        this.lblPriority.Text = "Priority:";
        
        
        
        this.cmbPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
        this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.cmbPriority.ForeColor = System.Drawing.Color.White;
        this.cmbPriority.FormattingEnabled = true;
        this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
        this.cmbPriority.Location = new System.Drawing.Point(150, 190);
        this.cmbPriority.Name = "cmbPriority";
        this.cmbPriority.Size = new System.Drawing.Size(140, 25);
        this.cmbPriority.TabIndex = 9;
        
        
        
        this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(300, 185);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(100, 35);
        this.btnAdd.TabIndex = 10;
        this.btnAdd.Text = "Add Task";
        this.btnAdd.UseVisualStyleBackColor = false;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        
        
        
        this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(410, 185);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(100, 35);
        this.btnUpdate.TabIndex = 11;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = false;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        
        
        
        this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(520, 185);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(100, 35);
        this.btnDelete.TabIndex = 12;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = false;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        
        
        
        this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnClear.ForeColor = System.Drawing.Color.White;
        this.btnClear.Location = new System.Drawing.Point(630, 185);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(100, 35);
        this.btnClear.TabIndex = 13;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = false;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        
        
        
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(1080, 720);
        this.Controls.Add(this.panelMain);
        this.Controls.Add(this.panelSidebar);
        this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.White;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Task Manager - Premium Edition";
        this.panelSidebar.ResumeLayout(false);
        this.panelSidebar.PerformLayout();
        this.panelMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
        this.panelInput.ResumeLayout(false);
        this.panelInput.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelSidebar;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.MonthCalendar monthCalendar;
    private System.Windows.Forms.Button btnShowAll;
    private System.Windows.Forms.Button btnTrashAll;
    private System.Windows.Forms.Button btnTrashBin;
    private System.Windows.Forms.Button btnOpenCalendar;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.DataGridView dgvTasks;
    private System.Windows.Forms.Panel panelInput;
    private System.Windows.Forms.Label lblTaskName;
    private System.Windows.Forms.TextBox txtTaskName;
    private System.Windows.Forms.Label lblDueDate;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.Label lblDueTime;
    private System.Windows.Forms.DateTimePicker dtpTime;
    private System.Windows.Forms.Label lblProgress;
    private System.Windows.Forms.ComboBox cmbProgress;
    private System.Windows.Forms.Label lblPriority;
    private System.Windows.Forms.ComboBox cmbPriority;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblTaskType;
    private System.Windows.Forms.ComboBox cmbTaskType;
    private System.Windows.Forms.Label lblStartTime;
    private System.Windows.Forms.DateTimePicker dtpStartTime;
    private System.Windows.Forms.Label lblEndTime;
    private System.Windows.Forms.DateTimePicker dtpEndTime;
}
