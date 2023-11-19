namespace Components
{
    partial class frmListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "29,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "120"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "35",
            "500"}, -1);
            this.lwProdutos = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbQuant = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.btnAdc = new System.Windows.Forms.Button();
            this.btnRemov = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.rdId = new System.Windows.Forms.RadioButton();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdPreco = new System.Windows.Forms.RadioButton();
            this.rdQnt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lwProdutos
            // 
            this.lwProdutos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colProduto,
            this.colQtde,
            this.colPreco});
            this.lwProdutos.FullRowSelect = true;
            this.lwProdutos.GridLines = true;
            this.lwProdutos.HideSelection = false;
            this.lwProdutos.HoverSelection = true;
            this.lwProdutos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lwProdutos.Location = new System.Drawing.Point(12, 12);
            this.lwProdutos.MultiSelect = false;
            this.lwProdutos.Name = "lwProdutos";
            this.lwProdutos.Size = new System.Drawing.Size(514, 189);
            this.lwProdutos.TabIndex = 0;
            this.lwProdutos.UseCompatibleStateImageBehavior = false;
            this.lwProdutos.View = System.Windows.Forms.View.Details;
            this.lwProdutos.SelectedIndexChanged += new System.EventHandler(this.lwProdutos_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 81;
            // 
            // colProduto
            // 
            this.colProduto.Text = "Produto";
            this.colProduto.Width = 273;
            // 
            // colQtde
            // 
            this.colQtde.Text = "Quantidade";
            this.colQtde.Width = 81;
            // 
            // colPreco
            // 
            this.colPreco.Text = "Preço";
            this.colPreco.Width = 371;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço:";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(15, 309);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(44, 20);
            this.txbId.TabIndex = 5;
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(102, 309);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(188, 20);
            this.txbProduto.TabIndex = 6;
            // 
            // txbQuant
            // 
            this.txbQuant.Location = new System.Drawing.Point(311, 309);
            this.txbQuant.Name = "txbQuant";
            this.txbQuant.Size = new System.Drawing.Size(62, 20);
            this.txbQuant.TabIndex = 7;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(410, 309);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(62, 20);
            this.txbPreco.TabIndex = 8;
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(12, 369);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(75, 23);
            this.btnAdc.TabIndex = 9;
            this.btnAdc.Text = "Cadastrar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // btnRemov
            // 
            this.btnRemov.Location = new System.Drawing.Point(12, 398);
            this.btnRemov.Name = "btnRemov";
            this.btnRemov.Size = new System.Drawing.Size(75, 23);
            this.btnRemov.TabIndex = 10;
            this.btnRemov.Text = "Deletar";
            this.btnRemov.UseVisualStyleBackColor = true;
            this.btnRemov.Click += new System.EventHandler(this.btnRemov_Click);
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(12, 427);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 11;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // rdId
            // 
            this.rdId.AutoSize = true;
            this.rdId.Location = new System.Drawing.Point(112, 361);
            this.rdId.Name = "rdId";
            this.rdId.Size = new System.Drawing.Size(34, 17);
            this.rdId.TabIndex = 13;
            this.rdId.TabStop = true;
            this.rdId.Text = "Id";
            this.rdId.UseVisualStyleBackColor = true;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(112, 384);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(53, 17);
            this.rdNome.TabIndex = 14;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // rdPreco
            // 
            this.rdPreco.AutoSize = true;
            this.rdPreco.Location = new System.Drawing.Point(112, 407);
            this.rdPreco.Name = "rdPreco";
            this.rdPreco.Size = new System.Drawing.Size(53, 17);
            this.rdPreco.TabIndex = 15;
            this.rdPreco.TabStop = true;
            this.rdPreco.Text = "Preco";
            this.rdPreco.UseVisualStyleBackColor = true;
            // 
            // rdQnt
            // 
            this.rdQnt.AutoSize = true;
            this.rdQnt.Location = new System.Drawing.Point(112, 430);
            this.rdQnt.Name = "rdQnt";
            this.rdQnt.Size = new System.Drawing.Size(80, 17);
            this.rdQnt.TabIndex = 16;
            this.rdQnt.TabStop = true;
            this.rdQnt.Text = "Quantidade";
            this.rdQnt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ordenar por:";
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdQnt);
            this.Controls.Add(this.rdPreco);
            this.Controls.Add(this.rdNome);
            this.Controls.Add(this.rdId);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.btnRemov);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbQuant);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwProdutos);
            this.Name = "frmListView";
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwProdutos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQtde;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbQuant;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button btnRemov;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.RadioButton rdId;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdPreco;
        private System.Windows.Forms.RadioButton rdQnt;
        private System.Windows.Forms.Label label5;
    }
}