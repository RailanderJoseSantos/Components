namespace Components
{
    partial class frmDateTimePicker
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
            this.dttpData = new System.Windows.Forms.DateTimePicker();
            this.btnObterData = new System.Windows.Forms.Button();
            this.txbDataCompleta = new System.Windows.Forms.TextBox();
            this.txbMes = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.txbDia = new System.Windows.Forms.TextBox();
            this.btnHoje = new System.Windows.Forms.Button();
            this.btnSetarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dttpData
            // 
            this.dttpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttpData.Location = new System.Drawing.Point(12, 12);
            this.dttpData.Name = "dttpData";
            this.dttpData.Size = new System.Drawing.Size(267, 22);
            this.dttpData.TabIndex = 0;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(313, 11);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(127, 23);
            this.btnObterData.TabIndex = 1;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // txbDataCompleta
            // 
            this.txbDataCompleta.Location = new System.Drawing.Point(12, 54);
            this.txbDataCompleta.Name = "txbDataCompleta";
            this.txbDataCompleta.Size = new System.Drawing.Size(267, 20);
            this.txbDataCompleta.TabIndex = 2;
            // 
            // txbMes
            // 
            this.txbMes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txbMes.Location = new System.Drawing.Point(103, 94);
            this.txbMes.Name = "txbMes";
            this.txbMes.Size = new System.Drawing.Size(85, 20);
            this.txbMes.TabIndex = 3;
            // 
            // txbAno
            // 
            this.txbAno.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txbAno.Location = new System.Drawing.Point(194, 94);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(85, 20);
            this.txbAno.TabIndex = 4;
            // 
            // txbDia
            // 
            this.txbDia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txbDia.Location = new System.Drawing.Point(12, 94);
            this.txbDia.Name = "txbDia";
            this.txbDia.Size = new System.Drawing.Size(85, 20);
            this.txbDia.TabIndex = 5;
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(313, 92);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(127, 23);
            this.btnHoje.TabIndex = 6;
            this.btnHoje.Text = "Data de Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // btnSetarData
            // 
            this.btnSetarData.Location = new System.Drawing.Point(313, 54);
            this.btnSetarData.Name = "btnSetarData";
            this.btnSetarData.Size = new System.Drawing.Size(127, 23);
            this.btnSetarData.TabIndex = 8;
            this.btnSetarData.Text = "Setar Data";
            this.btnSetarData.UseVisualStyleBackColor = true;
            this.btnSetarData.Click += new System.EventHandler(this.btnSetarData_Click);
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 473);
            this.Controls.Add(this.btnSetarData);
            this.Controls.Add(this.btnHoje);
            this.Controls.Add(this.txbDia);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.txbDataCompleta);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.dttpData);
            this.Name = "frmDateTimePicker";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dttpData;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.TextBox txbDataCompleta;
        private System.Windows.Forms.TextBox txbMes;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.TextBox txbDia;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.Button btnSetarData;
    }
}