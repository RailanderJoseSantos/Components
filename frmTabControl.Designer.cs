namespace Components
{
    partial class frmTabControl
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
            this.txbNomeAba = new System.Windows.Forms.TextBox();
            this.btnNovaAba = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletarAtual = new System.Windows.Forms.Button();
            this.nmDControlador = new System.Windows.Forms.NumericUpDown();
            this.btnAlternar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDControlador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomeAba
            // 
            this.txbNomeAba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeAba.Location = new System.Drawing.Point(12, 37);
            this.txbNomeAba.Name = "txbNomeAba";
            this.txbNomeAba.Size = new System.Drawing.Size(265, 27);
            this.txbNomeAba.TabIndex = 1;
            // 
            // btnNovaAba
            // 
            this.btnNovaAba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaAba.Location = new System.Drawing.Point(310, 37);
            this.btnNovaAba.Name = "btnNovaAba";
            this.btnNovaAba.Size = new System.Drawing.Size(151, 27);
            this.btnNovaAba.TabIndex = 2;
            this.btnNovaAba.Text = "Nova Aba";
            this.btnNovaAba.UseVisualStyleBackColor = true;
            this.btnNovaAba.Click += new System.EventHandler(this.btnNovaAba_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 570);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletarAtual
            // 
            this.btnDeletarAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAtual.Location = new System.Drawing.Point(467, 37);
            this.btnDeletarAtual.Name = "btnDeletarAtual";
            this.btnDeletarAtual.Size = new System.Drawing.Size(151, 27);
            this.btnDeletarAtual.TabIndex = 4;
            this.btnDeletarAtual.Text = "Deletar Aba";
            this.btnDeletarAtual.UseVisualStyleBackColor = true;
            this.btnDeletarAtual.Click += new System.EventHandler(this.btnDeletarAtual_Click);
            // 
            // nmDControlador
            // 
            this.nmDControlador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDControlador.Location = new System.Drawing.Point(12, 84);
            this.nmDControlador.Name = "nmDControlador";
            this.nmDControlador.Size = new System.Drawing.Size(41, 27);
            this.nmDControlador.TabIndex = 5;
            this.nmDControlador.ValueChanged += new System.EventHandler(this.nmDControlador_ValueChanged);
            // 
            // btnAlternar
            // 
            this.btnAlternar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternar.Location = new System.Drawing.Point(624, 37);
            this.btnAlternar.Name = "btnAlternar";
            this.btnAlternar.Size = new System.Drawing.Size(151, 27);
            this.btnAlternar.TabIndex = 6;
            this.btnAlternar.Text = "Alternar";
            this.btnAlternar.UseVisualStyleBackColor = true;
            this.btnAlternar.Click += new System.EventHandler(this.btnAlternar_Click);
            // 
            // frmTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 704);
            this.Controls.Add(this.btnAlternar);
            this.Controls.Add(this.nmDControlador);
            this.Controls.Add(this.btnDeletarAtual);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnNovaAba);
            this.Controls.Add(this.txbNomeAba);
            this.Name = "frmTabControl";
            this.Text = "TabControl";
            this.Load += new System.EventHandler(this.frmTabControl_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDControlador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomeAba;
        private System.Windows.Forms.Button btnNovaAba;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeletarAtual;
        private System.Windows.Forms.NumericUpDown nmDControlador;
        private System.Windows.Forms.Button btnAlternar;
    }
}