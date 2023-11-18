namespace Components
{
    partial class frmLinkLabel
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lklSite = new System.Windows.Forms.LinkLabel();
            this.lklCalculadora = new System.Windows.Forms.LinkLabel();
            this.lklSearch = new System.Windows.Forms.LinkLabel();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // lklSite
            // 
            this.lklSite.AutoSize = true;
            this.lklSite.Location = new System.Drawing.Point(12, 65);
            this.lklSite.Name = "lklSite";
            this.lklSite.Size = new System.Drawing.Size(58, 13);
            this.lklSite.TabIndex = 2;
            this.lklSite.TabStop = true;
            this.lklSite.Text = "Nosso Site";
            this.lklSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSite_LinkClicked);
            // 
            // lklCalculadora
            // 
            this.lklCalculadora.AutoSize = true;
            this.lklCalculadora.Location = new System.Drawing.Point(87, 65);
            this.lklCalculadora.Name = "lklCalculadora";
            this.lklCalculadora.Size = new System.Drawing.Size(63, 13);
            this.lklCalculadora.TabIndex = 3;
            this.lklCalculadora.TabStop = true;
            this.lklCalculadora.Text = "Calculadora";
            this.lklCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCalculadora_LinkClicked);
            // 
            // lklSearch
            // 
            this.lklSearch.AutoSize = true;
            this.lklSearch.Location = new System.Drawing.Point(12, 110);
            this.lklSearch.Name = "lklSearch";
            this.lklSearch.Size = new System.Drawing.Size(131, 13);
            this.lklSearch.TabIndex = 4;
            this.lklSearch.TabStop = true;
            this.lklSearch.Text = "Google - Youtube - Spotify";
            this.lklSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSearch_LinkClicked);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(15, 25);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(182, 20);
            this.txbNome.TabIndex = 5;
            // 
            // frmLinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 467);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lklSearch);
            this.Controls.Add(this.lklCalculadora);
            this.Controls.Add(this.lklSite);
            this.Controls.Add(this.lblNome);
            this.Name = "frmLinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel lklSite;
        private System.Windows.Forms.LinkLabel lklCalculadora;
        private System.Windows.Forms.LinkLabel lklSearch;
        private System.Windows.Forms.TextBox txbNome;
    }
}