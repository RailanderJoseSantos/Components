﻿using System;
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
    public partial class frmPrincipal : Form
    {
        /*Aula62
         * protected int index =0;
        protected Dictionary<int, String> dic = new Dictionary<int, String>();*/
        public int num;
        public frmPrincipal()
        {
            InitializeComponent();
            num = 0;
        }
        public void setListaVeiculos(string valores)
        {
            if(!valores.Equals(tbListaVeiculos.Text) )//SE for difrente
            {
                tbListaVeiculos.Text = valores;
            }
        }
        public void adicionaNaLista()
        {
            if (tbNmVeiculo.Text != "")
            {
                tbListaVeiculos.Text += tbNmVeiculo.Text + ",  ";//Concatena com anterior e n subistitui
                //dic.Add(index, tbNmVeiculo.Text);
                //veiculos+= tbNmVeiculo.Text+", ";
                tbNmVeiculo.Clear();
                tbNmVeiculo.Focus();
               // index++;
            }
            else
            {
                MessageBox.Show("Você não digitou nada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNmVeiculo.Focus();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionaNaLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (tbListaVeiculos.Text != "")
            {
                DialogResult resposta =  
                    MessageBox.Show("Tem certeza que deseja limpar toda a lista?","Confirmar ou Cancelar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    //dic.Clear();
                    tbListaVeiculos.Clear();
                    tbListaVeiculos.Focus();
                }
            }
            else
            {
                MessageBox.Show("Não há o que limpar!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void tbListaVeiculos_KeyDown(object sender, KeyEventArgs e)
        {
            tbNmVeiculo.Focus();
        }

        /*Aula62
         private void btVerLista_Click(object sender, EventArgs e)
         {
             if (dic.Count > 0)//ver se lista tem algo
             {
                 DialogResult resposta =
                                  MessageBox.Show("Deseja exibir a lista?", "Confirmar ou Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (resposta == DialogResult.Yes)
                 {
                     string conteudoLista = "";
                     for (int i = 0; i < dic.Count; i++)
                     {
                         conteudoLista+= dic[i].ToString()+", ";
                     }
                     MessageBox.Show(conteudoLista.ToString(), "Veículos no Dictionary:");
                 }
             }
             else
             {
                 MessageBox.Show("Lista está vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 tbNmVeiculo.Focus();
             }
         }*/
        private void btVerLista_Click(object sender, EventArgs e)
        {
            if (tbListaVeiculos.TextLength > 0)//ver se lista tem algo
            {
                DialogResult resposta =
                                 MessageBox.Show("Deseja exibir a lista?", "Confirmar ou Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    frmVeiculos frmVei = new frmVeiculos(tbListaVeiculos.Text, this); //this passa a propria classe
                    frmVei.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lista está vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNmVeiculo.Focus();
            }

        }
        private void tbNmVeiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                adicionaNaLista();
            }
        }

        private void btnValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quantidade de caractéres do form filho: "+num.ToString());
        }

        private void sbmnComponentes_Checkbox_Click(object sender, EventArgs e)
        {
            frmCheckBox frmCheckb   = new frmCheckBox();
            frmCheckb.ShowDialog();
        }

        private void submnCheckedListBox_Click(object sender, EventArgs e)
        {
            frmCheckedListBox frmChkLB = new frmCheckedListBox();
            frmChkLB.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComboBox frmCb = new frmComboBox();
            frmCb.ShowDialog();
        }

        private void mnDatetimePicker_Click(object sender, EventArgs e)
        {
            frmDateTimePicker frmdtmp = new frmDateTimePicker();
            frmdtmp.ShowDialog();
        }

        private void mnLinkLabel_Click_1(object sender, EventArgs e)
        {
            frmLinkLabel frmLinkLabel = new frmLinkLabel();
            frmLinkLabel.ShowDialog();
        }
    }
}