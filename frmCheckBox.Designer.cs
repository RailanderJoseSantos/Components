namespace Components
{
    partial class frmCheckBox
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
            this.chkbOnibus = new System.Windows.Forms.CheckBox();
            this.chkbNavio = new System.Windows.Forms.CheckBox();
            this.chkbAviao = new System.Windows.Forms.CheckBox();
            this.btnTraspMarcados = new System.Windows.Forms.Button();
            this.chkbCarro = new System.Windows.Forms.CheckBox();
            this.chkbMoto = new System.Windows.Forms.CheckBox();
            this.chkbTodos = new System.Windows.Forms.CheckBox();
            this.btnFrmFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkbOnibus
            // 
            this.chkbOnibus.AutoSize = true;
            this.chkbOnibus.Location = new System.Drawing.Point(12, 95);
            this.chkbOnibus.Name = "chkbOnibus";
            this.chkbOnibus.Size = new System.Drawing.Size(59, 17);
            this.chkbOnibus.TabIndex = 1;
            this.chkbOnibus.Text = "Ônibus";
            this.chkbOnibus.UseVisualStyleBackColor = true;
            // 
            // chkbNavio
            // 
            this.chkbNavio.AutoSize = true;
            this.chkbNavio.Location = new System.Drawing.Point(12, 72);
            this.chkbNavio.Name = "chkbNavio";
            this.chkbNavio.Size = new System.Drawing.Size(54, 17);
            this.chkbNavio.TabIndex = 2;
            this.chkbNavio.Text = "Navio";
            this.chkbNavio.UseVisualStyleBackColor = true;
            // 
            // chkbAviao
            // 
            this.chkbAviao.AutoSize = true;
            this.chkbAviao.Location = new System.Drawing.Point(12, 49);
            this.chkbAviao.Name = "chkbAviao";
            this.chkbAviao.Size = new System.Drawing.Size(53, 17);
            this.chkbAviao.TabIndex = 3;
            this.chkbAviao.Text = "Avião";
            this.chkbAviao.UseVisualStyleBackColor = true;
            // 
            // btnTraspMarcados
            // 
            this.btnTraspMarcados.Location = new System.Drawing.Point(196, 35);
            this.btnTraspMarcados.Name = "btnTraspMarcados";
            this.btnTraspMarcados.Size = new System.Drawing.Size(126, 31);
            this.btnTraspMarcados.TabIndex = 4;
            this.btnTraspMarcados.Text = "Trasportes Marcados";
            this.btnTraspMarcados.UseVisualStyleBackColor = true;
            this.btnTraspMarcados.Click += new System.EventHandler(this.btnTraspMarcados_Click);
            // 
            // chkbCarro
            // 
            this.chkbCarro.AutoSize = true;
            this.chkbCarro.Location = new System.Drawing.Point(12, 3);
            this.chkbCarro.Name = "chkbCarro";
            this.chkbCarro.Size = new System.Drawing.Size(51, 17);
            this.chkbCarro.TabIndex = 5;
            this.chkbCarro.Text = "Carro";
            this.chkbCarro.UseVisualStyleBackColor = true;
            // 
            // chkbMoto
            // 
            this.chkbMoto.AutoSize = true;
            this.chkbMoto.Location = new System.Drawing.Point(12, 26);
            this.chkbMoto.Name = "chkbMoto";
            this.chkbMoto.Size = new System.Drawing.Size(50, 17);
            this.chkbMoto.TabIndex = 6;
            this.chkbMoto.Text = "Moto";
            this.chkbMoto.UseVisualStyleBackColor = true;
            // 
            // chkbTodos
            // 
            this.chkbTodos.AutoSize = true;
            this.chkbTodos.Location = new System.Drawing.Point(12, 118);
            this.chkbTodos.Name = "chkbTodos";
            this.chkbTodos.Size = new System.Drawing.Size(144, 17);
            this.chkbTodos.TabIndex = 7;
            this.chkbTodos.Text = "Marcar/Desmarcar todos";
            this.chkbTodos.UseVisualStyleBackColor = true;
            this.chkbTodos.CheckedChanged += new System.EventHandler(this.chkbTodos_CheckedChanged);
            // 
            // btnFrmFilho
            // 
            this.btnFrmFilho.Location = new System.Drawing.Point(209, 104);
            this.btnFrmFilho.Name = "btnFrmFilho";
            this.btnFrmFilho.Size = new System.Drawing.Size(71, 31);
            this.btnFrmFilho.TabIndex = 8;
            this.btnFrmFilho.Text = "Abrir Form";
            this.btnFrmFilho.UseVisualStyleBackColor = true;
            this.btnFrmFilho.Click += new System.EventHandler(this.btnFrmFilho_Click);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 525);
            this.Controls.Add(this.btnFrmFilho);
            this.Controls.Add(this.chkbTodos);
            this.Controls.Add(this.chkbMoto);
            this.Controls.Add(this.chkbCarro);
            this.Controls.Add(this.btnTraspMarcados);
            this.Controls.Add(this.chkbAviao);
            this.Controls.Add(this.chkbNavio);
            this.Controls.Add(this.chkbOnibus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraspMarcados;
        public System.Windows.Forms.CheckBox chkbOnibus;
        public System.Windows.Forms.CheckBox chkbNavio;
        public System.Windows.Forms.CheckBox chkbAviao;
        public System.Windows.Forms.CheckBox chkbCarro;
        public System.Windows.Forms.CheckBox chkbMoto;
        public System.Windows.Forms.CheckBox chkbTodos;
        private System.Windows.Forms.Button btnFrmFilho;
    }
}