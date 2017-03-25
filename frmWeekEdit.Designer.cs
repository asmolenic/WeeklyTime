namespace WeeklyTimeUtility
{
    partial class frmWeekEdit
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
            this.components = new System.ComponentModel.Container();
            this.grpDaysRem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnpaid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatutory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblWeekIndex = new System.Windows.Forms.Label();
            this.lblWeekInterval = new System.Windows.Forms.Label();
            this.lblDaysReq = new System.Windows.Forms.Label();
            this.lblDaysReqVal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.grpDaysRem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDaysRem
            // 
            this.grpDaysRem.Controls.Add(this.label3);
            this.grpDaysRem.Controls.Add(this.cmbUnpaid);
            this.grpDaysRem.Controls.Add(this.label2);
            this.grpDaysRem.Controls.Add(this.cmbStatutory);
            this.grpDaysRem.Controls.Add(this.label1);
            this.grpDaysRem.Controls.Add(this.cmbState);
            this.grpDaysRem.Location = new System.Drawing.Point(155, 316);
            this.grpDaysRem.Name = "grpDaysRem";
            this.grpDaysRem.Size = new System.Drawing.Size(414, 197);
            this.grpDaysRem.TabIndex = 0;
            this.grpDaysRem.TabStop = false;
            this.grpDaysRem.Text = " Vacation Days ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unpaid holiday";
            // 
            // cmbUnpaid
            // 
            this.cmbUnpaid.FormattingEnabled = true;
            this.cmbUnpaid.Location = new System.Drawing.Point(180, 61);
            this.cmbUnpaid.Name = "cmbUnpaid";
            this.cmbUnpaid.Size = new System.Drawing.Size(77, 21);
            this.cmbUnpaid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statutory holiday";
            // 
            // cmbStatutory
            // 
            this.cmbStatutory.FormattingEnabled = true;
            this.cmbStatutory.Location = new System.Drawing.Point(89, 61);
            this.cmbStatutory.Name = "cmbStatutory";
            this.cmbStatutory.Size = new System.Drawing.Size(85, 21);
            this.cmbStatutory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "State holiday";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(15, 61);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(68, 21);
            this.cmbState.TabIndex = 0;
            // 
            // lblWeekIndex
            // 
            this.lblWeekIndex.AutoSize = true;
            this.lblWeekIndex.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekIndex.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblWeekIndex.Location = new System.Drawing.Point(12, 9);
            this.lblWeekIndex.Name = "lblWeekIndex";
            this.lblWeekIndex.Size = new System.Drawing.Size(98, 33);
            this.lblWeekIndex.TabIndex = 1;
            this.lblWeekIndex.Text = "Week #";
            this.lblWeekIndex.Click += new System.EventHandler(this.lblWeekIndex_Click);
            // 
            // lblWeekInterval
            // 
            this.lblWeekInterval.AutoSize = true;
            this.lblWeekInterval.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekInterval.Location = new System.Drawing.Point(140, 9);
            this.lblWeekInterval.Name = "lblWeekInterval";
            this.lblWeekInterval.Size = new System.Drawing.Size(98, 33);
            this.lblWeekInterval.TabIndex = 2;
            this.lblWeekInterval.Text = "interval";
            // 
            // lblDaysReq
            // 
            this.lblDaysReq.AutoSize = true;
            this.lblDaysReq.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDaysReq.Location = new System.Drawing.Point(12, 65);
            this.lblDaysReq.Name = "lblDaysReq";
            this.lblDaysReq.Size = new System.Drawing.Size(145, 26);
            this.lblDaysReq.TabIndex = 3;
            this.lblDaysReq.Text = "Days required:";
            this.toolTip1.SetToolTip(this.lblDaysReq, "Adjustable via the Vacation Days section");
            // 
            // lblDaysReqVal
            // 
            this.lblDaysReqVal.AutoSize = true;
            this.lblDaysReqVal.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysReqVal.Location = new System.Drawing.Point(163, 65);
            this.lblDaysReqVal.Name = "lblDaysReqVal";
            this.lblDaysReqVal.Size = new System.Drawing.Size(23, 26);
            this.lblDaysReqVal.TabIndex = 4;
            this.lblDaysReqVal.Text = "5";
            this.toolTip1.SetToolTip(this.lblDaysReqVal, "Adjustable via the Vacation Days section");
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 195);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // frmWeekEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 695);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblDaysReqVal);
            this.Controls.Add(this.lblDaysReq);
            this.Controls.Add(this.lblWeekInterval);
            this.Controls.Add(this.lblWeekIndex);
            this.Controls.Add(this.grpDaysRem);
            this.Name = "frmWeekEdit";
            this.Text = "Week Edit";
            this.Load += new System.EventHandler(this.frmWeekEdit_Load);
            this.grpDaysRem.ResumeLayout(false);
            this.grpDaysRem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDaysRem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnpaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatutory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblWeekIndex;
        public System.Windows.Forms.Label lblWeekInterval;
        private System.Windows.Forms.Label lblDaysReq;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDaysReqVal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}