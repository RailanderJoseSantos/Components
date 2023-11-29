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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hrv");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pólo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Wolksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeview1 = new System.Windows.Forms.TreeView();
            this.btnAdicionarPai = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbNoPai = new System.Windows.Forms.TextBox();
            this.txbNoFilho = new System.Windows.Forms.TextBox();
            this.btnAdicionarFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeview1
            // 
            this.treeview1.Location = new System.Drawing.Point(12, 22);
            this.treeview1.Name = "treeview1";
            treeNode1.Name = "hrv";
            treeNode1.Tag = "h-hrv";
            treeNode1.Text = "Hrv";
            treeNode2.Name = "fit";
            treeNode2.Tag = "h-fit";
            treeNode2.Text = "Fit";
            treeNode3.Name = "honda";
            treeNode3.Tag = "h";
            treeNode3.Text = "Honda";
            treeNode4.Name = "golf";
            treeNode4.Tag = "w-golf";
            treeNode4.Text = "Golf";
            treeNode5.Name = "polo";
            treeNode5.Tag = "w-polo";
            treeNode5.Text = "Pólo";
            treeNode6.Name = "wolksvagem";
            treeNode6.Tag = "w";
            treeNode6.Text = "Wolksvagem";
            this.treeview1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeview1.Size = new System.Drawing.Size(133, 332);
            this.treeview1.TabIndex = 0;
            this.treeview1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview1_AfterSelect);
            // 
            // btnAdicionarPai
            // 
            this.btnAdicionarPai.Location = new System.Drawing.Point(193, 49);
            this.btnAdicionarPai.Name = "btnAdicionarPai";
            this.btnAdicionarPai.Size = new System.Drawing.Size(123, 23);
            this.btnAdicionarPai.TabIndex = 1;
            this.btnAdicionarPai.Text = "Adicionar pai";
            this.btnAdicionarPai.UseVisualStyleBackColor = true;
            this.btnAdicionarPai.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(193, 107);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(123, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(656, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(656, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 22);
            this.textBox2.TabIndex = 4;
            // 
            // txbNoPai
            // 
            this.txbNoPai.Location = new System.Drawing.Point(193, 148);
            this.txbNoPai.Name = "txbNoPai";
            this.txbNoPai.Size = new System.Drawing.Size(123, 22);
            this.txbNoPai.TabIndex = 5;
            // 
            // txbNoFilho
            // 
            this.txbNoFilho.Location = new System.Drawing.Point(193, 187);
            this.txbNoFilho.Name = "txbNoFilho";
            this.txbNoFilho.Size = new System.Drawing.Size(123, 22);
            this.txbNoFilho.TabIndex = 6;
            // 
            // btnAdicionarFilho
            // 
            this.btnAdicionarFilho.Location = new System.Drawing.Point(193, 78);
            this.btnAdicionarFilho.Name = "btnAdicionarFilho";
            this.btnAdicionarFilho.Size = new System.Drawing.Size(123, 23);
            this.btnAdicionarFilho.TabIndex = 7;
            this.btnAdicionarFilho.Text = "Adicionar Filho";
            this.btnAdicionarFilho.UseVisualStyleBackColor = true;
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarFilho);
            this.Controls.Add(this.txbNoFilho);
            this.Controls.Add(this.txbNoPai);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionarPai);
            this.Controls.Add(this.treeview1);
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
    }
}