﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmBackGroundWorker : Form
    {
        int cont = 0;
        int max = 5000;
        public frmBackGroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0;i < max;i++)
            {
                cont++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnIniciar.Enabled = true;
            MessageBox.Show("W1 Trabalho terminado!");
            label1.Text = "W1 Terminado";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnIniciar.Enabled = false;
            label1.Text = "W1 Trabalhando...";
            label2.Text = cont.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ( ! backgroundWorker1.IsBusy)//SE NÃO TIVER OCUPADO
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
