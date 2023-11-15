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
    public partial class frmFilhoChkb : Form
    {
        public frmCheckBox fpai;//formulario pai
        public frmFilhoChkb()
        {
            InitializeComponent();
            //relacionando componentes do form pai para o filho (este)
            //tornar todos publicos la no form pai
            /*OpenForms: procura formulario aberto*/
            try{            
                fpai = Application.OpenForms["frmCheckBox"] as frmCheckBox;
                this.chkbCarro.Checked = fpai.chkbCarro.Checked;//pega exatamente msm status
                this.chkbMoto.Checked = fpai.chkbMoto.Checked;
                this.chkbAviao.Checked = fpai.chkbAviao.Checked;
                this.chkbNavio.Checked = fpai.chkbNavio.Checked;
                this.chkbOnibus.Checked = fpai.chkbOnibus.Checked;
            }catch{
                MessageBox.Show("O formulario não foi aberto");
            }
        }

        private void chkbCarro_CheckedChanged(object sender, EventArgs e)
        {
            //estando no filho, o que fizer nele refletir no pai
            fpai.chkbCarro.Checked = this.chkbCarro.Checked;
        }

        private void chkbMoto_CheckedChanged(object sender, EventArgs e)
        {
            fpai.chkbMoto.Checked = this.chkbMoto.Checked;
        }

        private void chkbAviao_CheckedChanged(object sender, EventArgs e)
        {
            fpai.chkbAviao.Checked = this.chkbAviao.Checked;
        }

        private void chkbNavio_CheckedChanged(object sender, EventArgs e)
        {
            fpai.chkbNavio.Checked = this.chkbNavio.Checked;
        }

        private void chkbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            fpai.chkbOnibus.Checked = this.chkbOnibus.Checked;
        }
    }
}
