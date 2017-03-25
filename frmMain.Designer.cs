namespace WeeklyTimeUtility
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblOutput = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(13, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "label1";
            this.lblOutput.Visible = false;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReported,
            this.colWeekStartDate,
            this.colWeekEndDate,
            this.colWorkedTime,
            this.colWeekBalance,
            this.colBalance,
            this.colDescription,
            this.colEdit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1037, 734);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // colReported
            // 
            this.colReported.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReported.HeaderText = "Reported";
            this.colReported.Name = "colReported";
            this.colReported.ReadOnly = true;
            this.colReported.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReported.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReported.Width = 57;
            // 
            // colWeekStartDate
            // 
            this.colWeekStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWeekStartDate.HeaderText = "Week Start";
            this.colWeekStartDate.Name = "colWeekStartDate";
            this.colWeekStartDate.ReadOnly = true;
            this.colWeekStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWeekStartDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWeekStartDate.Width = 67;
            // 
            // colWeekEndDate
            // 
            this.colWeekEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWeekEndDate.HeaderText = "Week End";
            this.colWeekEndDate.Name = "colWeekEndDate";
            this.colWeekEndDate.ReadOnly = true;
            this.colWeekEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWeekEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWeekEndDate.Width = 64;
            // 
            // colWorkedTime
            // 
            this.colWorkedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colWorkedTime.HeaderText = "Worked Time";
            this.colWorkedTime.Name = "colWorkedTime";
            this.colWorkedTime.ReadOnly = true;
            this.colWorkedTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWorkedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWorkedTime.Width = 77;
            // 
            // colWeekBalance
            // 
            this.colWeekBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colWeekBalance.DefaultCellStyle = dataGridViewCellStyle4;
            this.colWeekBalance.HeaderText = "Week Balance";
            this.colWeekBalance.Name = "colWeekBalance";
            this.colWeekBalance.ReadOnly = true;
            this.colWeekBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWeekBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWeekBalance.Width = 85;
            // 
            // colBalance
            // 
            this.colBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBalance.Width = 52;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEdit.Width = 50;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 734);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblOutput);
            this.Name = "frmMain";
            this.Text = "Weekly Time Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}

