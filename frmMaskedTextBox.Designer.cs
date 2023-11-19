namespace Components
{
    partial class frmMaskedTextBox
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
            this.mskTxbSenha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msktbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.ckbOpcao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mskTxbSenha
            // 
            this.mskTxbSenha.Location = new System.Drawing.Point(15, 37);
            this.mskTxbSenha.Name = "mskTxbSenha";
            this.mskTxbSenha.PasswordChar = '*';
            this.mskTxbSenha.Size = new System.Drawing.Size(146, 20);
            this.mskTxbSenha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // msktbCpf
            // 
            this.msktbCpf.Location = new System.Drawing.Point(15, 72);
            this.msktbCpf.Mask = "000,000,000-00";
            this.msktbCpf.Name = "msktbCpf";
            this.msktbCpf.Size = new System.Drawing.Size(146, 20);
            this.msktbCpf.TabIndex = 2;
            this.msktbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(290, 55);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ckbOpcao
            // 
            this.ckbOpcao.AutoSize = true;
            this.ckbOpcao.Location = new System.Drawing.Point(177, 55);
            this.ckbOpcao.Name = "ckbOpcao";
            this.ckbOpcao.Size = new System.Drawing.Size(94, 17);
            this.ckbOpcao.TabIndex = 4;
            this.ckbOpcao.Text = "Somente texto";
            this.ckbOpcao.UseVisualStyleBackColor = true;
            // 
            // frmMaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 492);
            this.Controls.Add(this.ckbOpcao);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.msktbCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTxbSenha);
            this.Name = "frmMaskedTextBox";
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTxbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktbCpf;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.CheckBox ckbOpcao;
    }
}