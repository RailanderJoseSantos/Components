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
        private void btnRevelarSenha_Click(object sender, EventArgs e)
        {
            if (mskTxbSenha.PasswordChar.Equals('*'))
            {
                mskTxbSenha.PasswordChar = '\0';
                btnRevelarSenha.Text = "Ocultar Senha";
            }
            else
            {
                mskTxbSenha.PasswordChar = '*';
                btnRevelarSenha.Text = "Mostrar Senha";
            }

        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            if (ckbOpcao.Checked)
            {
                msktbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                msktbCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            string msg = "";

            if (msktbCpf.Text != null)
            {
                msg += " CPF: " + msktbCpf.Text;
            }

            MessageBox.Show(msg);
        }
    }
}
