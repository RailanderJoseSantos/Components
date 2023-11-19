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
            this.lwProdutos.Size = new System.Drawing.Size(667, 224);
            this.lwProdutos.TabIndex = 0;
            this.lwProdutos.UseCompatibleStateImageBehavior = false;
            this.lwProdutos.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 40;
            // 
            // colProduto
            // 
            this.colProduto.Text = "Produto";
            this.colProduto.Width = 250;
            // 
            // colQtde
            // 
            this.colQtde.Text = "Quantidade";
            this.colQtde.Width = 80;
            // 
            // colPreco
            // 
            this.colPreco.Text = "Preço";
            this.colPreco.Width = 120;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 496);
            this.Controls.Add(this.lwProdutos);
            this.Name = "frmListView";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwProdutos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colProduto;
        private System.Windows.Forms.ColumnHeader colQtde;
        private System.Windows.Forms.ColumnHeader colPreco;
    }
}