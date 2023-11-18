namespace Components
{
    partial class frmListBox
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
            this.lstBoxCarros = new System.Windows.Forms.ListBox();
            this.lbCarro = new System.Windows.Forms.Label();
            this.txbCarro = new System.Windows.Forms.TextBox();
            this.btnAdc = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxCarros
            // 
            this.lstBoxCarros.FormattingEnabled = true;
            this.lstBoxCarros.Location = new System.Drawing.Point(12, 12);
            this.lstBoxCarros.Name = "lstBoxCarros";
            this.lstBoxCarros.Size = new System.Drawing.Size(120, 160);
            this.lstBoxCarros.TabIndex = 0;
            // 
            // lbCarro
            // 
            this.lbCarro.AutoSize = true;
            this.lbCarro.Location = new System.Drawing.Point(138, 12);
            this.lbCarro.Name = "lbCarro";
            this.lbCarro.Size = new System.Drawing.Size(35, 13);
            this.lbCarro.TabIndex = 1;
            this.lbCarro.Text = "Carro:";
            // 
            // txbCarro
            // 
            this.txbCarro.Location = new System.Drawing.Point(141, 28);
            this.txbCarro.Name = "txbCarro";
            this.txbCarro.Size = new System.Drawing.Size(120, 20);
            this.txbCarro.TabIndex = 2;
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(141, 54);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(120, 23);
            this.btnAdc.TabIndex = 3;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(141, 83);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(141, 112);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(120, 23);
            this.btnObter.TabIndex = 5;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(141, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 492);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.txbCarro);
            this.Controls.Add(this.lbCarro);
            this.Controls.Add(this.lstBoxCarros);
            this.Name = "frmListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxCarros;
        private System.Windows.Forms.Label lbCarro;
        private System.Windows.Forms.TextBox txbCarro;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Button btnLimpar;
    }
}