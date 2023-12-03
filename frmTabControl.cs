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
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void btnNovaAba_Click(object sender, EventArgs e)
        {
            if (txbNomeAba.Text != "")
            {
                TabPage page = new TabPage();
                page.Text =txbNomeAba.Text;
                page.Name =txbNomeAba.Text;
                page.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(page);
                txbNomeAba.Clear();
                definirMax();
            }
            else
            {
                MessageBox.Show("Informe o nome da página");
                txbNomeAba.Focus();
            }
        }

        private void btnDeletarAtual_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            definirMax();
        }

        private void btnAlternar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex =   Int32.Parse(nmDControlador.Value.ToString() );
        }

        private void definirMax()
        {
            nmDControlador.Maximum = tabControl1.TabPages.Count-1;
        }

        private void frmTabControl_Load(object sender, EventArgs e)
        {
            definirMax();
        }

        private void nmDControlador_ValueChanged(object sender, EventArgs e)
        {
            if(nmDControlador.Value > tabControl1.TabPages.Count)
            {
                nmDControlador.Value = tabControl1.TabPages.Count;
            }
        }
    }
}
