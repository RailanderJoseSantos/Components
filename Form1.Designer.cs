namespace Components
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbNmVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbListaVeiculos = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btVerLista = new System.Windows.Forms.Button();
            this.btnValNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmnComponentes_Checkbox = new System.Windows.Forms.ToolStripMenuItem();
            this.submnCheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatetimePicker = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLinkLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(188, 77);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbNmVeiculo
            // 
            this.tbNmVeiculo.Location = new System.Drawing.Point(12, 80);
            this.tbNmVeiculo.Name = "tbNmVeiculo";
            this.tbNmVeiculo.Size = new System.Drawing.Size(170, 20);
            this.tbNmVeiculo.TabIndex = 1;
            this.tbNmVeiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNmVeiculo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um veículo:";
            // 
            // tbListaVeiculos
            // 
            this.tbListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaVeiculos.Location = new System.Drawing.Point(12, 106);
            this.tbListaVeiculos.Multiline = true;
            this.tbListaVeiculos.Name = "tbListaVeiculos";
            this.tbListaVeiculos.ReadOnly = true;
            this.tbListaVeiculos.Size = new System.Drawing.Size(251, 303);
            this.tbListaVeiculos.TabIndex = 3;
            this.tbListaVeiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbListaVeiculos_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btVerLista
            // 
            this.btVerLista.Location = new System.Drawing.Point(191, 415);
            this.btVerLista.Name = "btVerLista";
            this.btVerLista.Size = new System.Drawing.Size(75, 23);
            this.btVerLista.TabIndex = 5;
            this.btVerLista.Text = "Ver Lista";
            this.btVerLista.UseVisualStyleBackColor = true;
            this.btVerLista.Click += new System.EventHandler(this.btVerLista_Click);
            // 
            // btnValNum
            // 
            this.btnValNum.Location = new System.Drawing.Point(110, 415);
            this.btnValNum.Name = "btnValNum";
            this.btnValNum.Size = new System.Drawing.Size(75, 23);
            this.btnValNum.TabIndex = 6;
            this.btnValNum.Text = "Valor Num";
            this.btnValNum.UseVisualStyleBackColor = true;
            this.btnValNum.Click += new System.EventHandler(this.btnValNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnComponentes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnComponentes
            // 
            this.mnComponentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmnComponentes_Checkbox,
            this.submnCheckedListBox,
            this.comboBoxToolStripMenuItem,
            this.mnDatetimePicker,
            this.mnLinkLabel});
            this.mnComponentes.Name = "mnComponentes";
            this.mnComponentes.Size = new System.Drawing.Size(94, 20);
            this.mnComponentes.Text = "Componentes";
            // 
            // sbmnComponentes_Checkbox
            // 
            this.sbmnComponentes_Checkbox.Name = "sbmnComponentes_Checkbox";
            this.sbmnComponentes_Checkbox.Size = new System.Drawing.Size(180, 22);
            this.sbmnComponentes_Checkbox.Text = "Checkbox";
            this.sbmnComponentes_Checkbox.Click += new System.EventHandler(this.sbmnComponentes_Checkbox_Click);
            // 
            // submnCheckedListBox
            // 
            this.submnCheckedListBox.Name = "submnCheckedListBox";
            this.submnCheckedListBox.Size = new System.Drawing.Size(180, 22);
            this.submnCheckedListBox.Text = "CheckedListBox";
            this.submnCheckedListBox.Click += new System.EventHandler(this.submnCheckedListBox_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // mnDatetimePicker
            // 
            this.mnDatetimePicker.Name = "mnDatetimePicker";
            this.mnDatetimePicker.Size = new System.Drawing.Size(180, 22);
            this.mnDatetimePicker.Text = "DateTimePicker";
            this.mnDatetimePicker.Click += new System.EventHandler(this.mnDatetimePicker_Click);
            // 
            // mnLinkLabel
            // 
            this.mnLinkLabel.Name = "mnLinkLabel";
            this.mnLinkLabel.Size = new System.Drawing.Size(180, 22);
            this.mnLinkLabel.Text = "Label/LinkLabel";
            this.mnLinkLabel.Click += new System.EventHandler(this.mnLinkLabel_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 448);
            this.Controls.Add(this.btnValNum);
            this.Controls.Add(this.btVerLista);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbListaVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNmVeiculo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - Janela1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbNmVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbListaVeiculos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btVerLista;
        private System.Windows.Forms.Button btnValNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnComponentes;
        private System.Windows.Forms.ToolStripMenuItem sbmnComponentes_Checkbox;
        private System.Windows.Forms.ToolStripMenuItem submnCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDatetimePicker;
        private System.Windows.Forms.ToolStripMenuItem mnLinkLabel;
    }
}

