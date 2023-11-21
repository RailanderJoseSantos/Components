namespace Components
{
    partial class frmProgressBar
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
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.btnDefineValor = new System.Windows.Forms.Button();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 183);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(507, 28);
            this.pgBar.TabIndex = 0;
            this.pgBar.Value = 100;
            // 
            // btnDefineValor
            // 
            this.btnDefineValor.Location = new System.Drawing.Point(12, 78);
            this.btnDefineValor.Name = "btnDefineValor";
            this.btnDefineValor.Size = new System.Drawing.Size(86, 23);
            this.btnDefineValor.TabIndex = 1;
            this.btnDefineValor.Text = "Definir Valor";
            this.btnDefineValor.UseVisualStyleBackColor = true;
            this.btnDefineValor.Click += new System.EventHandler(this.btnDefineValor_Click);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(12, 52);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(86, 20);
            this.txbValor.TabIndex = 2;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 229);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcent.Location = new System.Drawing.Point(525, 183);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(28, 16);
            this.lblPorcent.TabIndex = 4;
            this.lblPorcent.Text = "0%";
            this.lblPorcent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 419);
            this.Controls.Add(this.lblPorcent);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.btnDefineValor);
            this.Controls.Add(this.pgBar);
            this.Name = "frmProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Button btnDefineValor;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblPorcent;
    }
}