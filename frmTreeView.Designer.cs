namespace Components
{
    partial class frmTreeView
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Hrv");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Pólo");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Wolksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.treeview1 = new System.Windows.Forms.TreeView();
            this.btnAdicionarPai = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbNoPai = new System.Windows.Forms.TextBox();
            this.txbNoFilho = new System.Windows.Forms.TextBox();
            this.btnAdicionarFilho = new System.Windows.Forms.Button();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeview1
            // 
            this.treeview1.Location = new System.Drawing.Point(9, 18);
            this.treeview1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeview1.Name = "treeview1";
            treeNode13.Name = "hrv";
            treeNode13.Tag = "h-hrv";
            treeNode13.Text = "Hrv";
            treeNode14.Name = "fit";
            treeNode14.Tag = "h-fit";
            treeNode14.Text = "Fit";
            treeNode15.Name = "honda";
            treeNode15.Tag = "h";
            treeNode15.Text = "Honda";
            treeNode16.Name = "golf";
            treeNode16.Tag = "w-golf";
            treeNode16.Text = "Golf";
            treeNode17.Name = "polo";
            treeNode17.Tag = "w-polo";
            treeNode17.Text = "Pólo";
            treeNode18.Name = "wolksvagem";
            treeNode18.Tag = "w";
            treeNode18.Text = "Wolksvagem";
            this.treeview1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.treeview1.Size = new System.Drawing.Size(101, 270);
            this.treeview1.TabIndex = 0;
            this.treeview1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview1_AfterSelect);
            // 
            // btnAdicionarPai
            // 
            this.btnAdicionarPai.Location = new System.Drawing.Point(145, 40);
            this.btnAdicionarPai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionarPai.Name = "btnAdicionarPai";
            this.btnAdicionarPai.Size = new System.Drawing.Size(92, 19);
            this.btnAdicionarPai.TabIndex = 1;
            this.btnAdicionarPai.Text = "Adicionar pai";
            this.btnAdicionarPai.UseVisualStyleBackColor = true;
            this.btnAdicionarPai.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(145, 87);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(92, 19);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txbNoPai
            // 
            this.txbNoPai.Location = new System.Drawing.Point(145, 120);
            this.txbNoPai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNoPai.Name = "txbNoPai";
            this.txbNoPai.Size = new System.Drawing.Size(93, 20);
            this.txbNoPai.TabIndex = 5;
            // 
            // txbNoFilho
            // 
            this.txbNoFilho.Location = new System.Drawing.Point(145, 152);
            this.txbNoFilho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNoFilho.Name = "txbNoFilho";
            this.txbNoFilho.Size = new System.Drawing.Size(93, 20);
            this.txbNoFilho.TabIndex = 6;
            // 
            // btnAdicionarFilho
            // 
            this.btnAdicionarFilho.Location = new System.Drawing.Point(145, 63);
            this.btnAdicionarFilho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionarFilho.Name = "btnAdicionarFilho";
            this.btnAdicionarFilho.Size = new System.Drawing.Size(92, 19);
            this.btnAdicionarFilho.TabIndex = 7;
            this.btnAdicionarFilho.Text = "Adicionar Filho";
            this.btnAdicionarFilho.UseVisualStyleBackColor = true;
            this.btnAdicionarFilho.Click += new System.EventHandler(this.btnAdicionarFilho_Click);
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(241, 87);
            this.btnRemoverSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(92, 19);
            this.btnRemoverSelecionado.TabIndex = 8;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRemoverSelecionado);
            this.Controls.Add(this.btnAdicionarFilho);
            this.Controls.Add(this.txbNoFilho);
            this.Controls.Add(this.txbNoPai);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionarPai);
            this.Controls.Add(this.treeview1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTreeView";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeview1;
        private System.Windows.Forms.Button btnAdicionarPai;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbNoPai;
        private System.Windows.Forms.TextBox txbNoFilho;
        private System.Windows.Forms.Button btnAdicionarFilho;
        private System.Windows.Forms.Button btnRemoverSelecionado;
    }
}