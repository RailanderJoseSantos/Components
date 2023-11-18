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
    public partial class frmLinkLabel : Form
    {
        public frmLinkLabel()
        {
            InitializeComponent();
            //multiplos links em unico label
            lklSearch.Links.Add(0,6, "https://www.google.com.br/search?");// La no label exibido: nome google inicia em 0 e tem tamanho 6
            lklSearch.Links.Add(9, 7, "https://www.youtube.com/results?search_query=");
            lklSearch.Links.Add(19, 7, "https://open.spotify.com/search/");
            lklSearch.Links[2].Enabled = false;
        }

        private void lklSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txbNome.Text != "")
            {
                System.Diagnostics.Process.Start("https://open.spotify.com/search/" + txbNome.Text);
                lklSite.LinkVisited = true;
            }
            else
            {
                MessageBox.Show("Nada foi informado na caixa de pesquisa.");
                txbNome.Focus();
            }
        }

        private void lklCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            lklCalculadora.LinkVisited = true;
        }

        private void lklSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txbNome.Text != "")
            {
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString()+txbNome.Text);
                //Para apontar qual dos nomes sera marcado como visutado 
                LinkLabel ll = (LinkLabel)sender; //passa o sender (nome do label) clicado para ll
                ll.LinkVisited= true;//marca o mesmo como visitado
            }
            else
            {
                MessageBox.Show("Nada foi informado na caixa de pesquisa.");
                txbNome.Focus();
            }
        }
    }
}
