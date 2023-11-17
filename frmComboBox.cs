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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnMostrarSelecionado_Click(object sender, EventArgs e)
        {
            if (cmbTransportes.Text != "") { 
                MessageBox.Show(cmbTransportes.Text);
            }
            else
            {
                MessageBox.Show("Nada foi selecionado!");
            }
        }

        private void btnLimparElementos_Click(object sender, EventArgs e)
        {
            if (cmbTransportes.Items.Count > 0)
            {
                cmbTransportes.Items.Clear();
                cmbTransportes.Text = "";
            }
            else
            {
                MessageBox.Show("Não há o que limpar!");

            }
        }

        private void btnResetarElementos_Click(object sender, EventArgs e)
        {
            cmbTransportes.Items.Add("Carro");
            cmbTransportes.Items.Add("Avião");
            cmbTransportes.Items.Add("Navio");
            cmbTransportes.Items.Add("Ônibus");
            cmbTransportes.Items.Add("Trêm");
        }

        private void cmbTransportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTransporte.Text = cmbTransportes.Text;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Se txtBox não tiver vazio
            if(!txbTransporte.Text.Equals(""))
            {   //se não tiver o valor ja inserido
                if (! cmbTransportes.Items.Contains(txbTransporte.Text) ){
                    cmbTransportes.Items.Add(txbTransporte.Text);
                    MessageBox.Show("Veículo cadastrado!");
                }
                else
                {
                    MessageBox.Show("O veículo "+cmbTransportes.Text+" já existe!");
                }
            }
        }
    }
}
