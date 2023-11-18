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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnObterData_Click(object sender, EventArgs e)
        {
            txbDataCompleta.Text = dttpData.Text;
            //obter dia mes e ano
            txbDia.Text = dttpData.Value.Day.ToString();
            txbMes.Text = dttpData.Value.Month.ToString();
            txbAno.Text = dttpData.Value.Year.ToString();
        }

        private void btnSetarData_Click(object sender, EventArgs e)
        {
            if (txbDia.Text == "" && txbMes.Text == "" && txbAno.Text == "")
            {
                MessageBox.Show("Dia, Mês e Ano  não informado!");
                txbAno.Focus();
                txbMes.Focus();
                txbDia.Focus();
            }
            else
            {
                if (txbDia.Text != "")
                {
                    if (txbMes.Text != "")
                    {
                        if (txbAno.Text != "")
                        {
                            //Criando tipo data, convertendo em int os parametros de textbox de data coletada
                            DateTime data = new DateTime(Int32.Parse(txbAno.Text), Int32.Parse(txbMes.Text), Int32.Parse(txbDia.Text));
                            dttpData.Value = data;
                            ;
                        }
                        else
                        {
                            MessageBox.Show("Ano  não informado!");
                            txbAno.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mês não informado!");
                        txbMes.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Dia não informado!");
                    txbDia.Focus();
                }
            }
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            dttpData.Text = DateTime.Today.ToString();
           /* txbAno.Text = "";
            txbMes.Text = "";
            txbDia.Text = "";
            txbDataCompleta.Text = "";*/
        }
    }
}
