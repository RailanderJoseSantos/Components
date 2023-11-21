namespace Components
{
    partial class frmPictureBox
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
            this.pctb1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImg2 = new System.Windows.Forms.Button();
            this.btnImg1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctb1
            // 
            this.pctb1.Location = new System.Drawing.Point(12, 4);
            this.pctb1.Name = "pctb1";
            this.pctb1.Size = new System.Drawing.Size(600, 400);
            this.pctb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb1.TabIndex = 0;
            this.pctb1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btnImg2
            // 
            this.btnImg2.Location = new System.Drawing.Point(15, 495);
            this.btnImg2.Name = "btnImg2";
            this.btnImg2.Size = new System.Drawing.Size(75, 23);
            this.btnImg2.TabIndex = 4;
            this.btnImg2.Text = "Imagem 2";
            this.btnImg2.UseVisualStyleBackColor = true;
            this.btnImg2.Click += new System.EventHandler(this.btnImg2_Click);
            // 
            // btnImg1
            // 
            this.btnImg1.Location = new System.Drawing.Point(15, 463);
            this.btnImg1.Name = "btnImg1";
            this.btnImg1.Size = new System.Drawing.Size(75, 23);
            this.btnImg1.TabIndex = 3;
            this.btnImg1.Text = "Imagem 1";
            this.btnImg1.UseVisualStyleBackColor = true;
            this.btnImg1.Click += new System.EventHandler(this.btnImg1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informar Caminho:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImg2);
            this.Controls.Add(this.btnImg1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctb1);
            this.Name = "frmPictureBox";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImg2;
        private System.Windows.Forms.Button btnImg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}