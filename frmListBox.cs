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
    public partial class frmListBox : Form
    {
        List<string> listCar = new List<string>(); 
        void limparListBox()
        {
            listCar.Clear();
            lstBoxCarros.DataSource = null;
            lstBoxCarros.DataSource = listCar;
        }
        public frmListBox()
        {
            InitializeComponent();
            preencherListBox();
        }
        private void preencherListBox()
        {
            listCar.Clear();
            lstBoxCarros.DataSource = null;
            listCar.Add("HRV");
            listCar.Add("Golf");
            listCar.Add("Focus");
            lstBoxCarros.DataSource = listCar;
        }
        private void btnAdc_Click(object sender, EventArgs e)
        {
            //verifica vazio
            if (txbCarro.Text != "")
            {   //testa se ja existe
                if (lstBoxCarros.Items.Contains(txbCarro.Text) == false)
                {
                    listCar.Add(txbCarro.Text);
                    //limpa a listBox e atuakliza
                    limparListBox();
                    txbCarro.Clear();
                }
                else
                {
                    MessageBox.Show("Esse carro já está incluso na listagem!");
                    txbCarro.Focus();
                    txbCarro.Clear();
                }
            }
            else
            {
                MessageBox.Show("Você deve digitar algo antes..");
                txbCarro.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //obter certeza q ja selecionou o certo sim prossegue, não permite escolher
            DialogResult resposta = 
                MessageBox.Show("Tem certeza que quer remover: "+lstBoxCarros.Text+" ? Confirmar exclusão: [Sim] - Escolher outro marque: [Não] - Voltar: [Cancelar]"
                    , "Responda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    //ver se selecionou algo na lista -1 não 
            if (lstBoxCarros.SelectedIndex != -1 )
            {
                //Se optar por remover
                if (resposta == DialogResult.Yes)
                {
                    if (lstBoxCarros.Items.Count > 0)
                    {
                        listCar.RemoveAt(lstBoxCarros.SelectedIndex);
                        limparListBox();
                    }
                    else
                    {
                        MessageBox.Show("Não há o que remover!");
                    }
            }
            else
            {
                if(resposta == DialogResult.Cancel)
                {
                    return;
                }
            }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um carro na listagem.");
            }
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            if (lstBoxCarros.Text != txbCarro.Text)
            {
                txbCarro.Text = lstBoxCarros.Text;
            }
            else
            {
                MessageBox.Show("Esse carro já consta como obtido!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (lstBoxCarros.Items.Count > 0)
            {
                listCar.Clear();
                limparListBox();
            }
            else
            {
                DialogResult resposta = MessageBox.Show("A ListBox está vazia! Marque Sim para resetar ou não para Sair","Responda:", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if(resposta == DialogResult.Yes)
                {
                    preencherListBox();
                }
                else
                {
                    return;
                }
            
            }
        }
    }
}
