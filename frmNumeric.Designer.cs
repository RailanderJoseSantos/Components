namespace Components
{
    partial class frmNumeric
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
            this.numUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.btnDefinirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown1
            // 
            this.numUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown1.Location = new System.Drawing.Point(12, 42);
            this.numUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(73, 22);
            this.numUpDown1.TabIndex = 0;
            this.numUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(242, 46);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(185, 22);
            this.txbValor.TabIndex = 1;
            this.txbValor.Text = "0";
            this.txbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDefinirValor
            // 
            this.btnDefinirValor.Location = new System.Drawing.Point(433, 45);
            this.btnDefinirValor.Name = "btnDefinirValor";
            this.btnDefinirValor.Size = new System.Drawing.Size(133, 23);
            this.btnDefinirValor.TabIndex = 2;
            this.btnDefinirValor.Text = "Definir Valor";
            this.btnDefinirValor.UseVisualStyleBackColor = true;
            this.btnDefinirValor.Click += new System.EventHandler(this.btnDefinirValor_Click);
            // 
            // frmNumeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 608);
            this.Controls.Add(this.btnDefinirValor);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.numUpDown1);
            this.Name = "frmNumeric";
            this.Text = "Numeric";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown1;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button btnDefinirValor;
    }
}