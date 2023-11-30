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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            /*TreeNode raizEstados = treeview1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeview1.Nodes.Add("Cores");
            raizEstados.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("MG");
            estado1.Name = "MG";

            TreeNode estado2 = raizEstados.Nodes.Add("RJ");
            estado1.Name = "RJ";

            TreeNode estado3 = raizEstados.Nodes.Add("SC");
            estado1.Name = "SC";*/
            List<string> list = new List<string>();
            foreach(TreeNode tn  in treeview1.Nodes)
            {
                list.Add(tn.Name);
            }
            if (txbNoPai.Text != "")
            {
                if (list.Contains(txbNoPai.Text) == false)
                {
                    TreeNode tnode = treeview1.Nodes.Add(txbNoPai.Text);
                    tnode.Name = txbNoPai.Text;
                    txbNoPai.Clear();
                }
                else
                {
                    MessageBox.Show("Já existe um nó raiz com esse nome");
                }
            }
            else
            {
                MessageBox.Show("No pai não tem nome");
                txbNoPai.Focus();
            }

        }

        private void treeview1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = e.Node.Text;
            if (e.Node.Tag != null)
            {
                textBox2.Text = e.Node.Tag.ToString();

            }
        }

        private void btnAdicionarFilho_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                treeview1.Nodes.Remove(treeview1.SelectedNode) );
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                treeview1.Nodes.Remove(treeview1.Nodes[""]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
