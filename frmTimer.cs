using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmTimer : Form
    {
        protected int num, px, py;
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            num = 0;
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btnSetar_Click(object sender, EventArgs e)
        {
            if (int.Parse(numericUpDown1.Value.ToString()) > 0) {
                px += (int)numericUpDown1.Value;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            num = 0;
            timer1.Stop();
            label1.Text = "-";
            timer1.Start();
            timer2.Interval = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            px++;

            pictureBox1.Location = new Point(px, py);
            if(pictureBox1.Location.X == 575)
            {
                pictureBox1.Location = new Point(575, py);
            }
            lblX.Text = pictureBox1.Location.X.ToString();
            lbly.Text = pictureBox1.Location.Y.ToString();
        }
    }
}
