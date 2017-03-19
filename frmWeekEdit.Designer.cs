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
            this.grpDaysRem = new System.Windows.Forms.GroupBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnpaid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatutory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDaysRem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDaysRem
            // 
            this.grpDaysRem.Controls.Add(this.lblOut);
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
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(310, 42);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(34, 13);
            this.lblOut.TabIndex = 6;
            this.lblOut.Text = "lblOut";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "5      {1,0,2}";
            // 
            // frmWeekEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 695);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpDaysRem);
            this.Name = "frmWeekEdit";
            this.Text = "frmWeekEdit";
            this.Load += new System.EventHandler(this.frmWeekEdit_Load);
            this.grpDaysRem.ResumeLayout(false);
            this.grpDaysRem.PerformLayout();
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
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label label4;
    }
}