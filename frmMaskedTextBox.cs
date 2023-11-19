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
    public partial class frmMaskedTextBox : Form
    {
        public frmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (ckbOpcao.Checked)
            {
                mskTxbSenha.TextMaskFormat= MaskFormat.ExcludePromptAndLiterals;
                msktbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mskTxbSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
                msktbCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            string msg = "";
            if(mskTxbSenha != null)
            {
                msg="Senha: "+ mskTxbSenha.Text;
            }
            if(msktbCpf.Text!=null)
            {
                msg+= " CPF: "+msktbCpf.Text;
            }

            MessageBox.Show(msg);
        }
    }
}
