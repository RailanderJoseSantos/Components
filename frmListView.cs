using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Components
{
    public partial class frmListView : Form
    {

        public frmListView()
        {
            InitializeComponent();
        }
        void cadastraProduto()
        {
            if (txbProduto.Text != "")
            {
                if (txbQuant.Text != "")
                {
                    if (txbPreco.Text != "")
                    {
                        // Verifica se existe, se sim aumenta estoque, se não cadastra
                        bool existe = false;
                        foreach (ListViewItem item in lwProdutos.Items )
                        {
                            if (item.SubItems[1].Text == txbProduto.Text)
                            {
                                int qtdd = Int32.Parse(item.SubItems[2].Text);
                                qtdd += 1;
                                item.SubItems[2].Text = qtdd.ToString();
                                item.SubItems[3].Text = txbPreco.Text;
                                existe = true;
                                limpar();
                                return;
                            }
                        }
                        if (!existe)
                        {
                            string[] produto = new string[4];
                            produto[0] = lwProdutos.Items.Count.ToString();
                            produto[1] = txbProduto.Text;
                            produto[2] = txbQuant.Text;
                            produto[3] = txbPreco.Text;
                            ListViewItem listViewProd = new ListViewItem(produto);
                            lwProdutos.Items.Add(listViewProd);
                            limpar();
                        }
                    }
                else
                {
                    MessageBox.Show("Informe o preço do produto!");
                    txbPreco.Focus();
                }
                }
                else
                {
                    MessageBox.Show("Informe a quantidade em estoque!");
                    txbQuant.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informe o nome do produto!");
                txbProduto.Focus();
            }
        }
        private void limpar()
        {
            txbId.Clear();
            txbProduto.Clear();
            txbQuant.Clear();
            txbPreco.Clear();
            txbProduto.Focus();
        }
        private void obter()
        {
            txbId.Text = lwProdutos.SelectedItems[0].SubItems[0].Text;
            txbProduto.Text = lwProdutos.SelectedItems[0].SubItems[1].Text;
            txbQuant.Text = lwProdutos.SelectedItems[0].SubItems[2].Text;
            txbPreco.Text = lwProdutos.SelectedItems[0].SubItems[3].Text;
        }
        private void btnAdc_Click(object sender, EventArgs e)
        {
            cadastraProduto();
        }

        private void btnRemov_Click(object sender, EventArgs e)
        {
            lwProdutos.Items.RemoveAt(lwProdutos.SelectedIndices[0]);
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            // [0] refere-se a linha selecionada e  em subitem[Indice] acessa coluna
            obter(); 
        }

        private void lwProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //So passa as informações se maior que 0, evitando erro
            if (lwProdutos.SelectedItems.Count > 0)
            {
                obter();
            }
         }
    }
}
