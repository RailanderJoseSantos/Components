namespace Components
{
    partial class frmMonthCalendar
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
            this.mcalenCalendarioMes = new System.Windows.Forms.MonthCalendar();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btnObterData = new System.Windows.Forms.Button();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mcalenCalendarioMes
            // 
            this.mcalenCalendarioMes.Location = new System.Drawing.Point(18, 18);
            this.mcalenCalendarioMes.MaxSelectionCount = 30;
            this.mcalenCalendarioMes.Name = "mcalenCalendarioMes";
            this.mcalenCalendarioMes.TabIndex = 0;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(257, 67);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(167, 20);
            this.txb1.TabIndex = 1;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(257, 93);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(167, 20);
            this.txb2.TabIndex = 2;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(257, 18);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(167, 23);
            this.btnObterData.TabIndex = 3;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(257, 119);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(167, 20);
            this.txb3.TabIndex = 4;
            // 
            // frmMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 479);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.mcalenCalendarioMes);
            this.Name = "frmMonthCalendar";
            this.Text = "MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcalenCalendarioMes;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.TextBox txb3;
    }
}