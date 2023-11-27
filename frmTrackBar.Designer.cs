namespace Components
{
    partial class frmTrackBar
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
            this.trkb1 = new System.Windows.Forms.TrackBar();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnDefinir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkb1)).BeginInit();
            this.SuspendLayout();
            // 
            // trkb1
            // 
            this.trkb1.Location = new System.Drawing.Point(12, 18);
            this.trkb1.Maximum = 100;
            this.trkb1.Name = "trkb1";
            this.trkb1.Size = new System.Drawing.Size(181, 45);
            this.trkb1.TabIndex = 0;
            this.trkb1.Scroll += new System.EventHandler(this.trkb1_Scroll);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(12, 69);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 101);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "-";
            // 
            // btnDefinir
            // 
            this.btnDefinir.Location = new System.Drawing.Point(118, 69);
            this.btnDefinir.Name = "btnDefinir";
            this.btnDefinir.Size = new System.Drawing.Size(75, 23);
            this.btnDefinir.TabIndex = 3;
            this.btnDefinir.Text = "Definir";
            this.btnDefinir.UseVisualStyleBackColor = true;
            this.btnDefinir.Click += new System.EventHandler(this.btnDefinir_Click);
            // 
            // frmTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 505);
            this.Controls.Add(this.btnDefinir);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.trkb1);
            this.Name = "frmTrackBar";
            this.Text = "TrackBar";
            this.Load += new System.EventHandler(this.frmTrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkb1;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnDefinir;
    }
}