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
    public partial class frmNumericUpDown : Form
    {
        public frmNumericUpDown()
        {
            InitializeComponent();
        }

        private void btnDefinirValor_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(txbValor.Text) <= numUpDown1.Maximum)
            {
                if (Decimal.Parse(txbValor.Text) >= numUpDown1.Minimum)
                {
                    numUpDown1.Value = Decimal.Parse(txbValor.Text);
                }
                else
                {
                    MessageBox.Show("O valor " + txbValor.Text + " é menor que o mínimo permitido: " + numUpDown1.Minimum);
                    txbValor.Clear();
                }
            }
            else
            {
                MessageBox.Show("O valor "+ txbValor.Text +" é maior que o máximo permitido: "+numUpDown1.Maximum);
                txbValor.Clear();
            }

        }
    }
}
