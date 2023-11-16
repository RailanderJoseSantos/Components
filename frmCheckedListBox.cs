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
    public partial class frmCheckedListBox : Form
    {
        protected string statusLista="";
        protected int contaLetras = 0;
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnMostrarSelecionado_Click(object sender, EventArgs e)
        {
            string selecionados = "";
            foreach(string s in chklbTransportes.CheckedItems)//percorre todos selecionados
            {
                selecionados += s+", ";
            }
            if (selecionados.Equals(""))
            {
                selecionados = "Nenhum checkbox selecionado!";
            }
            MessageBox.Show(selecionados);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //verifica se ja esta limpo
            if (! statusLista.Equals("limpar"))
            {
                chklbTransportes.Items.Clear();//limpa todos os checkedbox (os checkbox somem)
                statusLista = "limpar";//informa limpada, assim pode ser resetada se preciso
            }
            else
            {
                MessageBox.Show("Não há o que limpar!");
            }
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            /*o resetar deve voltar todos os itens padroes*/

            //evita duplo reset e ficar repetido
            if (! statusLista.Equals("resetar"))
            {
                /*object carro = "Carro";
                object aviao = "Avião";
                object navio = "Navio";
                object onibus = "Ônibus";
                object trem = "Trêm";
                chklbTransportes.Items.Add(carro, true);
                chklbTransportes.Items.Add(aviao, true);
                chklbTransportes.Items.Add(navio, true);
                chklbTransportes.Items.Add(onibus, true);
                chklbTransportes.Items.Add(trem, true);
                /*/

                //Alternativa usando lista
                List<string> listaString = new List<string>();
                listaString.Add("Carro");
                listaString.Add("Avião");
                listaString.Add("Navio");
                listaString.Add("Ônibus");
                listaString.Add("Trêm");

                //colocando a lista inteira no checkeListbox
                chklbTransportes.Items.AddRange(listaString.ToArray());

                //informa ja resetada assim não pode resetar denovo antes do limpar
                statusLista = "resetar";
            }
            else
            {
                MessageBox.Show("Não há o que resetar!");
            }
        }

        private void btnNovoTransporte_Click(object sender, EventArgs e)
        {
            //se tiver algo escrito
            if( !this.txbNovoTransp.Text.Equals(""))
            {
                if (chklbTransportes.Items.Contains(txbNovoTransp.Text) ){
                    MessageBox.Show("Já tem um meio de transporte chamado", txbNovoTransp.Text);
                    
                }else
                {
                    chklbTransportes.Items.Add(txbNovoTransp.Text, false);
                }
            }
            contaLetras =0;
            txbNovoTransp.Text="";
            btnNovoTransporte.Focus();
        }

        private void txbNovoTransp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Coloca em minusculo
            if (char.IsUpper(e.KeyChar) ) {
                e.KeyChar = char.ToLower(e.KeyChar);
            }

            //se digitou letra e foi primeira difitação
            if(contaLetras==0)
            {
                if (char.IsLetter(e.KeyChar))
                {
                    //pegue o valor e trasnforme em maiusculo (passar para o txbox não precisa tratar)
                    e.KeyChar = char.ToUpper(e.KeyChar);
                    contaLetras++;
                }
            }else{
                e.KeyChar = char.ToLower(e.KeyChar);
            }
            //Se não digitar letra zera contador pra evitar apagar e ficar primeira letra minuscula
            if ( (char.IsLetter(e.KeyChar)==false) ){//se não for letra
                if (char.IsNumber(e.KeyChar) == false) { //Se não for numero
                    contaLetras++;//aumenta contador pra forçar minusculo
                }
            }
        }
    }
}
