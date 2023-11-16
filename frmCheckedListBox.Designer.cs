namespace Components
{
    partial class frmCheckedListBox
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
            this.chklbTransportes = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSelecionado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnNovoTransporte = new System.Windows.Forms.Button();
            this.txbNovoTransp = new System.Windows.Forms.TextBox();
            this.lblDigiteNomeTransp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chklbTransportes
            // 
            this.chklbTransportes.FormattingEnabled = true;
            this.chklbTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trêm"});
            this.chklbTransportes.Location = new System.Drawing.Point(12, 12);
            this.chklbTransportes.Name = "chklbTransportes";
            this.chklbTransportes.Size = new System.Drawing.Size(121, 409);
            this.chklbTransportes.TabIndex = 0;
            // 
            // btnMostrarSelecionado
            // 
            this.btnMostrarSelecionado.Location = new System.Drawing.Point(152, 11);
            this.btnMostrarSelecionado.Name = "btnMostrarSelecionado";
            this.btnMostrarSelecionado.Size = new System.Drawing.Size(146, 30);
            this.btnMostrarSelecionado.TabIndex = 1;
            this.btnMostrarSelecionado.Text = "Mostrar Selecionados";
            this.btnMostrarSelecionado.UseVisualStyleBackColor = true;
            this.btnMostrarSelecionado.Click += new System.EventHandler(this.btnMostrarSelecionado_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(152, 47);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 30);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(152, 83);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(146, 30);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "Resetar Lista";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnNovoTransporte
            // 
            this.btnNovoTransporte.Location = new System.Drawing.Point(152, 391);
            this.btnNovoTransporte.Name = "btnNovoTransporte";
            this.btnNovoTransporte.Size = new System.Drawing.Size(146, 30);
            this.btnNovoTransporte.TabIndex = 4;
            this.btnNovoTransporte.Text = "Adicionar novo transporte";
            this.btnNovoTransporte.UseVisualStyleBackColor = true;
            this.btnNovoTransporte.Click += new System.EventHandler(this.btnNovoTransporte_Click);
            // 
            // txbNovoTransp
            // 
            this.txbNovoTransp.Location = new System.Drawing.Point(152, 365);
            this.txbNovoTransp.Name = "txbNovoTransp";
            this.txbNovoTransp.Size = new System.Drawing.Size(145, 20);
            this.txbNovoTransp.TabIndex = 5;
            this.txbNovoTransp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNovoTransp_KeyPress);
            // 
            // lblDigiteNomeTransp
            // 
            this.lblDigiteNomeTransp.AutoSize = true;
            this.lblDigiteNomeTransp.Location = new System.Drawing.Point(149, 339);
            this.lblDigiteNomeTransp.Name = "lblDigiteNomeTransp";
            this.lblDigiteNomeTransp.Size = new System.Drawing.Size(131, 13);
            this.lblDigiteNomeTransp.TabIndex = 6;
            this.lblDigiteNomeTransp.Text = "Digite um novo transporte:";
            // 
            // frmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.lblDigiteNomeTransp);
            this.Controls.Add(this.txbNovoTransp);
            this.Controls.Add(this.btnNovoTransporte);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarSelecionado);
            this.Controls.Add(this.chklbTransportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbTransportes;
        private System.Windows.Forms.Button btnMostrarSelecionado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnNovoTransporte;
        private System.Windows.Forms.TextBox txbNovoTransp;
        private System.Windows.Forms.Label lblDigiteNomeTransp;
    }
}