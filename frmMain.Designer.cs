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
            this.lblOutput = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colReported = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWeekStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvolution = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.colEvolution,
            this.colDescription});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1037, 734);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // colReported
            // 
            this.colReported.HeaderText = "Reported";
            this.colReported.Name = "colReported";
            this.colReported.ReadOnly = true;
            this.colReported.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colWeekStartDate
            // 
            this.colWeekStartDate.HeaderText = "Week Start Date";
            this.colWeekStartDate.Name = "colWeekStartDate";
            this.colWeekStartDate.ReadOnly = true;
            this.colWeekStartDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeekEndDate
            // 
            this.colWeekEndDate.HeaderText = "Week End Date";
            this.colWeekEndDate.Name = "colWeekEndDate";
            this.colWeekEndDate.ReadOnly = true;
            this.colWeekEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkedTime
            // 
            this.colWorkedTime.HeaderText = "Worked Time";
            this.colWorkedTime.Name = "colWorkedTime";
            this.colWorkedTime.ReadOnly = true;
            this.colWorkedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeekBalance
            // 
            this.colWeekBalance.HeaderText = "Week Balance";
            this.colWeekBalance.Name = "colWeekBalance";
            this.colWeekBalance.ReadOnly = true;
            this.colWeekBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEvolution
            // 
            this.colEvolution.HeaderText = "Evolution";
            this.colEvolution.Name = "colEvolution";
            this.colEvolution.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 734);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeekBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewImageColumn colEvolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Button button1;
    }
}

