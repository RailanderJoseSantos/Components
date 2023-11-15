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
    public partial class frmVeiculos : Form
    {
        protected string vlr;
        protected frmPrincipal refFrmPrincipal;
        public frmVeiculos(String vNomes,frmPrincipal frmP)//PAssa um tipo da classe pra poder usar o metodo
        {
            InitializeComponent();
            tbLista.Text = vNomes;
            //O tipo que recebe como parametro passa para a variavel local deste forms permiteindo ser usada por todos aqui
            refFrmPrincipal = frmP;
            /*Tentei usar metodo setTBveiculos aqi mas n da pq deve acontecer so qnd fechar*/
        }

        private void frmVeiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            vlr = tbLista.Text;
            //So de acessar a janela ja vai mudar o valor de num la do formulario pai
            refFrmPrincipal.num = tbLista.Text.Length;
            refFrmPrincipal.setListaVeiculos(vlr);
        }

        private void frmVeiculos_TextChanged(object sender, EventArgs e)
        {
            //se quisesse implementar qnd digitar algo no txtbox
        }
    }
}
