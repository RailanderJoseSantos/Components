using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmCheckBox : Form
    {
        List<CheckBox> transpCheckboxs = new List<CheckBox>();
        public frmCheckBox()
        {
            InitializeComponent();
            transpCheckboxs.Add(chkbCarro);
            transpCheckboxs.Add(chkbMoto);
            transpCheckboxs.Add(chkbAviao);
            transpCheckboxs.Add(chkbNavio);
            transpCheckboxs.Add(chkbOnibus);
        }

        private void btnTraspMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
           /* if(chkbCarro.Checked) txt += chkbCarro.Text +" - ";
            if(chkbMoto.Checked)  txt += chkbMoto.Text +" - ";
            if(chkbAviao.Checked) txt += chkbAviao.Text +" - ";
            if(chkbNavio.Checked) txt += chkbNavio.Text +" - ";
            if(chkbOnibus.Checked)txt+= chkbOnibus.Text +" - ";*/
            //alternativa usando lista de chekbox
            foreach(CheckBox t in transpCheckboxs)//percorre toda lista
            {
                if (t.Checked)//verifica cada elemento se marcado
                {
                    txt+= t.Text + " - ";
                }
            }
            if (txt.Length == 0)
            {
                txt = "Nenhum checkbox marcado!";
            }
            MessageBox.Show(txt);
        }

        protected void marca_desmarca_todos(bool op)
        {
                /*chkbCarro.Checked = op;
                chkbMoto.Checked  = op;
                chkbAviao.Checked = op;
                chkbNavio.Checked = op;
                chkbOnibus.Checked = op;*/
                //alternatica com list de checkbox
                foreach(CheckBox c in transpCheckboxs)
                {
                    c.Checked = op;
                }
        }
        private void chkbTodos_CheckedChanged(object sender, EventArgs e)
        {
            marca_desmarca_todos(chkbTodos.Checked ? true : false);
        }

        private void btnFrmFilho_Click(object sender, EventArgs e)
        {
            frmFilhoChkb fFilho = new frmFilhoChkb();
            fFilho.ShowDialog();
        }
    }
}
