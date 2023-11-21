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
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
            label1.Text= Properties.Resources.User.ToString();
            label2.Text= Properties.Resources.Password.ToString();
            pctb1.Image = Properties.Resources.fazenda;
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            pctb1.Image = Properties.Resources.cow;
        }

        private void btnImg2_Click(object sender, EventArgs e)
        {
            pctb1.Image = Properties.Resources.avestruz;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a pasta: ");
            pctb1.ImageLocation =
            folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
