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
    public partial class frmTrackBar : Form
    {
        public frmTrackBar()
        {
            InitializeComponent();
        }

        private void trkb1_Scroll(object sender, EventArgs e)
        {
            txbValor.Text = trkb1.Value.ToString();
            lbl1.Text = trkb1.Value.ToString();
        }

        private void btnDefinir_Click(object sender, EventArgs e)
        {
            try
            {
                int valorDefinido = Int32.Parse(txbValor.Text);
                if(valorDefinido >= trkb1.Minimum)
                {
                    if (valorDefinido <= trkb1.Maximum)
                    {
                        trkb1.Value = Int32.Parse(txbValor.Text);
                    }
                    else
                    {
                        MessageBox.Show("O valor informado: "+valorDefinido+" é maior que o máximo: "+ trkb1.Maximum);
                    }
                }
                else
                {
                    MessageBox.Show("O valor informado: " + valorDefinido + " é menor que o mínimo: " + trkb1.Minimum);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTrackBar_Load(object sender, EventArgs e)
        {
            txbValor.Text = trkb1.Value.ToString();
        }
    }
}
