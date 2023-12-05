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
    public partial class frmToolStripContainer : Form
    {
        public frmToolStripContainer()
        {
            InitializeComponent();
        }

        private void frmToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> bf = new List<ToolStrip>();
            //elementos painel de cima
            int qntPainelCima = toolStripContainer1.TopToolStripPanel.Controls.Count;
            for(int i = 0; i < qntPainelCima; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                toolStripContainer1.TopToolStripPanel.Controls[i].Visible = true;
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
