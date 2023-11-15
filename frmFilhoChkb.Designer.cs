namespace Components
{
    partial class frmFilhoChkb
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
            this.chkbTodos = new System.Windows.Forms.CheckBox();
            this.chkbMoto = new System.Windows.Forms.CheckBox();
            this.chkbCarro = new System.Windows.Forms.CheckBox();
            this.chkbAviao = new System.Windows.Forms.CheckBox();
            this.chkbNavio = new System.Windows.Forms.CheckBox();
            this.chkbOnibus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbTodos
            // 
            this.chkbTodos.AutoSize = true;
            this.chkbTodos.Location = new System.Drawing.Point(12, 127);
            this.chkbTodos.Name = "chkbTodos";
            this.chkbTodos.Size = new System.Drawing.Size(144, 17);
            this.chkbTodos.TabIndex = 13;
            this.chkbTodos.Text = "Marcar/Desmarcar todos";
            this.chkbTodos.UseVisualStyleBackColor = true;
            // 
            // chkbMoto
            // 
            this.chkbMoto.AutoSize = true;
            this.chkbMoto.Location = new System.Drawing.Point(12, 35);
            this.chkbMoto.Name = "chkbMoto";
            this.chkbMoto.Size = new System.Drawing.Size(50, 17);
            this.chkbMoto.TabIndex = 12;
            this.chkbMoto.Text = "Moto";
            this.chkbMoto.UseVisualStyleBackColor = true;
            this.chkbMoto.CheckedChanged += new System.EventHandler(this.chkbMoto_CheckedChanged);
            // 
            // chkbCarro
            // 
            this.chkbCarro.AutoSize = true;
            this.chkbCarro.Location = new System.Drawing.Point(12, 12);
            this.chkbCarro.Name = "chkbCarro";
            this.chkbCarro.Size = new System.Drawing.Size(51, 17);
            this.chkbCarro.TabIndex = 11;
            this.chkbCarro.Text = "Carro";
            this.chkbCarro.UseVisualStyleBackColor = true;
            this.chkbCarro.CheckedChanged += new System.EventHandler(this.chkbCarro_CheckedChanged);
            // 
            // chkbAviao
            // 
            this.chkbAviao.AutoSize = true;
            this.chkbAviao.Location = new System.Drawing.Point(12, 58);
            this.chkbAviao.Name = "chkbAviao";
            this.chkbAviao.Size = new System.Drawing.Size(53, 17);
            this.chkbAviao.TabIndex = 10;
            this.chkbAviao.Text = "Avião";
            this.chkbAviao.UseVisualStyleBackColor = true;
            this.chkbAviao.CheckedChanged += new System.EventHandler(this.chkbAviao_CheckedChanged);
            // 
            // chkbNavio
            // 
            this.chkbNavio.AutoSize = true;
            this.chkbNavio.Location = new System.Drawing.Point(12, 81);
            this.chkbNavio.Name = "chkbNavio";
            this.chkbNavio.Size = new System.Drawing.Size(54, 17);
            this.chkbNavio.TabIndex = 9;
            this.chkbNavio.Text = "Navio";
            this.chkbNavio.UseVisualStyleBackColor = true;
            this.chkbNavio.CheckedChanged += new System.EventHandler(this.chkbNavio_CheckedChanged);
            // 
            // chkbOnibus
            // 
            this.chkbOnibus.AutoSize = true;
            this.chkbOnibus.Location = new System.Drawing.Point(12, 104);
            this.chkbOnibus.Name = "chkbOnibus";
            this.chkbOnibus.Size = new System.Drawing.Size(59, 17);
            this.chkbOnibus.TabIndex = 8;
            this.chkbOnibus.Text = "Ônibus";
            this.chkbOnibus.UseVisualStyleBackColor = true;
            this.chkbOnibus.CheckedChanged += new System.EventHandler(this.chkbOnibus_CheckedChanged);
            // 
            // frmFilhoChkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 321);
            this.Controls.Add(this.chkbTodos);
            this.Controls.Add(this.chkbMoto);
            this.Controls.Add(this.chkbCarro);
            this.Controls.Add(this.chkbAviao);
            this.Controls.Add(this.chkbNavio);
            this.Controls.Add(this.chkbOnibus);
            this.Name = "frmFilhoChkb";
            this.Text = "frmFilho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbTodos;
        private System.Windows.Forms.CheckBox chkbMoto;
        private System.Windows.Forms.CheckBox chkbCarro;
        private System.Windows.Forms.CheckBox chkbAviao;
        private System.Windows.Forms.CheckBox chkbNavio;
        private System.Windows.Forms.CheckBox chkbOnibus;
    }
}