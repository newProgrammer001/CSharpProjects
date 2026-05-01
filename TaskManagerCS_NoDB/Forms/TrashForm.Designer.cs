namespace TaskManagerCS.Forms;

partial class TrashForm
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
        this.dgvTrash = new System.Windows.Forms.DataGridView();
        this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnRestoreSelected = new System.Windows.Forms.Button();
        this.btnRestoreAll = new System.Windows.Forms.Button();
        this.btnEmptyTrash = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.panelHeader = new System.Windows.Forms.Panel();
        this.panelBottom = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).BeginInit();
        this.panelHeader.SuspendLayout();
        this.panelBottom.SuspendLayout();
        this.SuspendLayout();
        
        
        
        
        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
        this.panelHeader.Controls.Add(this.lblTitle);
        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new System.Drawing.Size(800, 60);
        this.panelHeader.TabIndex = 0;
        
        
        
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(110, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Trash Bin";
        
        
        
        this.dgvTrash.AllowUserToAddRows = false;
        this.dgvTrash.AllowUserToDeleteRows = false;
        this.dgvTrash.AllowUserToResizeRows = false;
        this.dgvTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTrash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.dgvTrash.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvTrash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dgvTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvTrash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvTrash.ColumnHeadersHeight = 40;
        this.dgvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        this.dgvTrash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect});
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvTrash.DefaultCellStyle = dataGridViewCellStyle2;
        this.dgvTrash.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvTrash.EnableHeadersVisualStyles = false;
        this.dgvTrash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        this.dgvTrash.Location = new System.Drawing.Point(0, 60);
        this.dgvTrash.Name = "dgvTrash";
        this.dgvTrash.RowHeadersVisible = false;
        this.dgvTrash.RowTemplate.Height = 35;
        this.dgvTrash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvTrash.Size = new System.Drawing.Size(800, 310);
        this.dgvTrash.TabIndex = 1;
        
        
        
        this.colSelect.HeaderText = "Select";
        this.colSelect.Name = "colSelect";
        this.colSelect.FillWeight = 30F;
        
        
        
        this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
        this.panelBottom.Controls.Add(this.btnRestoreSelected);
        this.panelBottom.Controls.Add(this.btnRestoreAll);
        this.panelBottom.Controls.Add(this.btnEmptyTrash);
        this.panelBottom.Controls.Add(this.btnClose);
        this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panelBottom.Location = new System.Drawing.Point(0, 370);
        this.panelBottom.Name = "panelBottom";
        this.panelBottom.Size = new System.Drawing.Size(800, 80);
        this.panelBottom.TabIndex = 2;
        
        
        
        this.btnRestoreSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
        this.btnRestoreSelected.FlatAppearance.BorderSize = 0;
        this.btnRestoreSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRestoreSelected.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnRestoreSelected.ForeColor = System.Drawing.Color.White;
        this.btnRestoreSelected.Location = new System.Drawing.Point(20, 20);
        this.btnRestoreSelected.Name = "btnRestoreSelected";
        this.btnRestoreSelected.Size = new System.Drawing.Size(150, 40);
        this.btnRestoreSelected.TabIndex = 0;
        this.btnRestoreSelected.Text = "Restore Selected";
        this.btnRestoreSelected.UseVisualStyleBackColor = false;
        this.btnRestoreSelected.Click += new System.EventHandler(this.btnRestoreSelected_Click);
        
        
        
        this.btnRestoreAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnRestoreAll.FlatAppearance.BorderSize = 0;
        this.btnRestoreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnRestoreAll.ForeColor = System.Drawing.Color.White;
        this.btnRestoreAll.Location = new System.Drawing.Point(180, 20);
        this.btnRestoreAll.Name = "btnRestoreAll";
        this.btnRestoreAll.Size = new System.Drawing.Size(150, 40);
        this.btnRestoreAll.TabIndex = 1;
        this.btnRestoreAll.Text = "Restore All";
        this.btnRestoreAll.UseVisualStyleBackColor = false;
        this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
        
        
        
        this.btnEmptyTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
        this.btnEmptyTrash.FlatAppearance.BorderSize = 0;
        this.btnEmptyTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnEmptyTrash.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnEmptyTrash.ForeColor = System.Drawing.Color.White;
        this.btnEmptyTrash.Location = new System.Drawing.Point(340, 20);
        this.btnEmptyTrash.Name = "btnEmptyTrash";
        this.btnEmptyTrash.Size = new System.Drawing.Size(150, 40);
        this.btnEmptyTrash.TabIndex = 2;
        this.btnEmptyTrash.Text = "Empty Trash";
        this.btnEmptyTrash.UseVisualStyleBackColor = false;
        this.btnEmptyTrash.Click += new System.EventHandler(this.btnEmptyTrash_Click);
        
        
        
        this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
        this.btnClose.FlatAppearance.BorderSize = 0;
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnClose.ForeColor = System.Drawing.Color.White;
        this.btnClose.Location = new System.Drawing.Point(630, 20);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(150, 40);
        this.btnClose.TabIndex = 3;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = false;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        
        
        
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.dgvTrash);
        this.Controls.Add(this.panelBottom);
        this.Controls.Add(this.panelHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.White;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "TrashForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Trash Bin";
        ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).EndInit();
        this.panelHeader.ResumeLayout(false);
        this.panelHeader.PerformLayout();
        this.panelBottom.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView dgvTrash;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
    private System.Windows.Forms.Panel panelBottom;
    private System.Windows.Forms.Button btnRestoreSelected;
    private System.Windows.Forms.Button btnRestoreAll;
    private System.Windows.Forms.Button btnEmptyTrash;
    private System.Windows.Forms.Button btnClose;
}
