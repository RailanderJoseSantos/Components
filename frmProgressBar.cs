using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Components
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnDefineValor_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txbValor.Text) <= pgBar.Maximum)
            {
                if (Int32.Parse(txbValor.Text) >= pgBar.Minimum)
                {
                    pgBar.Value = Int32.Parse(txbValor.Text);
                }
                else
                {
                    MessageBox.Show("O valor não pode ser menor que o limite que é: " + pgBar.Minimum);
                }
            }
            else
            {
                MessageBox.Show("O valor não pode ser maior que o limite que é: "+ pgBar.Maximum);
            }
         }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            pgBar.Value = 0;
            pgBar.Maximum = Int32.Parse(txbValor.Text);
            for ( int i = 0; i <= pgBar.Maximum; i++)
            {
                Thread.Sleep(100);
                pgBar.Value= i;
                lblPorcent.Text = i.ToString();
            }
        }

    }
}
