namespace Components
{
    partial class frmComboBox
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
            this.cmbTransportes = new System.Windows.Forms.ComboBox();
            this.btnMostrarSelecionado = new System.Windows.Forms.Button();
            this.btnLimparElementos = new System.Windows.Forms.Button();
            this.btnResetarElementos = new System.Windows.Forms.Button();
            this.txbTransporte = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTransportes
            // 
            this.cmbTransportes.FormattingEnabled = true;
            this.cmbTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trêm"});
            this.cmbTransportes.Location = new System.Drawing.Point(12, 24);
            this.cmbTransportes.Name = "cmbTransportes";
            this.cmbTransportes.Size = new System.Drawing.Size(247, 21);
            this.cmbTransportes.TabIndex = 0;
            this.cmbTransportes.SelectedIndexChanged += new System.EventHandler(this.cmbTransportes_SelectedIndexChanged);
            // 
            // btnMostrarSelecionado
            // 
            this.btnMostrarSelecionado.Location = new System.Drawing.Point(265, 24);
            this.btnMostrarSelecionado.Name = "btnMostrarSelecionado";
            this.btnMostrarSelecionado.Size = new System.Drawing.Size(159, 23);
            this.btnMostrarSelecionado.TabIndex = 1;
            this.btnMostrarSelecionado.Text = "Mostrar Selecionado";
            this.btnMostrarSelecionado.UseVisualStyleBackColor = true;
            this.btnMostrarSelecionado.Click += new System.EventHandler(this.btnMostrarSelecionado_Click);
            // 
            // btnLimparElementos
            // 
            this.btnLimparElementos.Location = new System.Drawing.Point(265, 53);
            this.btnLimparElementos.Name = "btnLimparElementos";
            this.btnLimparElementos.Size = new System.Drawing.Size(159, 23);
            this.btnLimparElementos.TabIndex = 2;
            this.btnLimparElementos.Text = "Limpar Elementos";
            this.btnLimparElementos.UseVisualStyleBackColor = true;
            this.btnLimparElementos.Click += new System.EventHandler(this.btnLimparElementos_Click);
            // 
            // btnResetarElementos
            // 
            this.btnResetarElementos.Location = new System.Drawing.Point(265, 82);
            this.btnResetarElementos.Name = "btnResetarElementos";
            this.btnResetarElementos.Size = new System.Drawing.Size(159, 23);
            this.btnResetarElementos.TabIndex = 3;
            this.btnResetarElementos.Text = "Resetar Elementos";
            this.btnResetarElementos.UseVisualStyleBackColor = true;
            this.btnResetarElementos.Click += new System.EventHandler(this.btnResetarElementos_Click);
            // 
            // txbTransporte
            // 
            this.txbTransporte.Location = new System.Drawing.Point(265, 126);
            this.txbTransporte.Name = "txbTransporte";
            this.txbTransporte.Size = new System.Drawing.Size(159, 20);
            this.txbTransporte.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(265, 152);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(159, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar Transporte";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 300);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbTransporte);
            this.Controls.Add(this.btnResetarElementos);
            this.Controls.Add(this.btnLimparElementos);
            this.Controls.Add(this.btnMostrarSelecionado);
            this.Controls.Add(this.cmbTransportes);
            this.Name = "frmComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTransportes;
        private System.Windows.Forms.Button btnMostrarSelecionado;
        private System.Windows.Forms.Button btnLimparElementos;
        private System.Windows.Forms.Button btnResetarElementos;
        private System.Windows.Forms.TextBox txbTransporte;
        private System.Windows.Forms.Button btnAdicionar;
    }
}