﻿namespace Components
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbNmVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbListaVeiculos = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btVerLista = new System.Windows.Forms.Button();
            this.btnValNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnListView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmnComponentes_Checkbox = new System.Windows.Forms.ToolStripMenuItem();
            this.submnCheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatetimePicker = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLinkLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnlistBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(251, 95);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbNmVeiculo
            // 
            this.tbNmVeiculo.Location = new System.Drawing.Point(16, 98);
            this.tbNmVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tbNmVeiculo.Name = "tbNmVeiculo";
            this.tbNmVeiculo.Size = new System.Drawing.Size(225, 22);
            this.tbNmVeiculo.TabIndex = 1;
            this.tbNmVeiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNmVeiculo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um veículo:";
            // 
            // tbListaVeiculos
            // 
            this.tbListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaVeiculos.Location = new System.Drawing.Point(16, 130);
            this.tbListaVeiculos.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaVeiculos.Multiline = true;
            this.tbListaVeiculos.Name = "tbListaVeiculos";
            this.tbListaVeiculos.ReadOnly = true;
            this.tbListaVeiculos.Size = new System.Drawing.Size(333, 372);
            this.tbListaVeiculos.TabIndex = 3;
            this.tbListaVeiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbListaVeiculos_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(20, 511);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btVerLista
            // 
            this.btVerLista.Location = new System.Drawing.Point(255, 511);
            this.btVerLista.Margin = new System.Windows.Forms.Padding(4);
            this.btVerLista.Name = "btVerLista";
            this.btVerLista.Size = new System.Drawing.Size(100, 28);
            this.btVerLista.TabIndex = 5;
            this.btVerLista.Text = "Ver Lista";
            this.btVerLista.UseVisualStyleBackColor = true;
            this.btVerLista.Click += new System.EventHandler(this.btVerLista_Click);
            // 
            // btnValNum
            // 
            this.btnValNum.Location = new System.Drawing.Point(147, 511);
            this.btnValNum.Margin = new System.Windows.Forms.Padding(4);
            this.btnValNum.Name = "btnValNum";
            this.btnValNum.Size = new System.Drawing.Size(100, 28);
            this.btnValNum.TabIndex = 6;
            this.btnValNum.Text = "Valor Num";
            this.btnValNum.UseVisualStyleBackColor = true;
            this.btnValNum.Click += new System.EventHandler(this.btnValNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnListView,
            this.componentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(376, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnListView
            // 
            this.mnListView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem9,
            this.toolStripMenuItem8,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.sbmnComponentes_Checkbox,
            this.submnCheckedListBox,
            this.comboBoxToolStripMenuItem,
            this.mnDatetimePicker,
            this.mnLinkLabel,
            this.mnlistBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.toolStripMenuItem11});
            this.mnListView.Name = "mnListView";
            this.mnListView.Size = new System.Drawing.Size(115, 24);
            this.mnListView.Text = "Componentes";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem10.Text = "Checkbox";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.sbmnComponentes_Checkbox_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem9.Text = "CheckedListBox";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.submnCheckedListBox_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem8.Text = "ComboBox";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem7.Text = "DateTimePicker";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.mnDatetimePicker_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem6.Text = "Label/LinkLabel";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.mnLinkLabel_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem5.Text = "ListBox";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.mnlistBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem4.Text = "ListView";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem3.Text = "MaskedTextBox";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem2.Text = "MonthCalendar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem1.Text = "NumericUpDown";
            // 
            // sbmnComponentes_Checkbox
            // 
            this.sbmnComponentes_Checkbox.Name = "sbmnComponentes_Checkbox";
            this.sbmnComponentes_Checkbox.Size = new System.Drawing.Size(206, 26);
            this.sbmnComponentes_Checkbox.Text = "Checkbox";
            this.sbmnComponentes_Checkbox.Click += new System.EventHandler(this.sbmnComponentes_Checkbox_Click);
            // 
            // submnCheckedListBox
            // 
            this.submnCheckedListBox.Name = "submnCheckedListBox";
            this.submnCheckedListBox.Size = new System.Drawing.Size(206, 26);
            this.submnCheckedListBox.Text = "CheckedListBox";
            this.submnCheckedListBox.Click += new System.EventHandler(this.submnCheckedListBox_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // mnDatetimePicker
            // 
            this.mnDatetimePicker.Name = "mnDatetimePicker";
            this.mnDatetimePicker.Size = new System.Drawing.Size(206, 26);
            this.mnDatetimePicker.Text = "DateTimePicker";
            this.mnDatetimePicker.Click += new System.EventHandler(this.mnDatetimePicker_Click);
            // 
            // mnLinkLabel
            // 
            this.mnLinkLabel.Name = "mnLinkLabel";
            this.mnLinkLabel.Size = new System.Drawing.Size(206, 26);
            this.mnLinkLabel.Text = "Label/LinkLabel";
            this.mnLinkLabel.Click += new System.EventHandler(this.mnLinkLabel_Click_1);
            // 
            // mnlistBoxToolStripMenuItem
            // 
            this.mnlistBoxToolStripMenuItem.Name = "mnlistBoxToolStripMenuItem";
            this.mnlistBoxToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.mnlistBoxToolStripMenuItem.Text = "ListBox";
            this.mnlistBoxToolStripMenuItem.Click += new System.EventHandler(this.mnlistBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(206, 26);
            this.toolStripMenuItem11.Text = "PictureBox";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarToolStripMenuItem,
            this.radioButtonToolStripMenuItem,
            this.trackBarToolStripMenuItem,
            this.triViewToolStripMenuItem,
            this.splitContainerToolStripMenuItem,
            this.tabControlToolStripMenuItem,
            this.tableLayoutPanelToolStripMenuItem,
            this.toolStripMenuItem12,
            this.backGroundWorkerToolStripMenuItem,
            this.timerToolStripMenuItem});
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.componentsToolStripMenuItem.Text = "Components";
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // triViewToolStripMenuItem
            // 
            this.triViewToolStripMenuItem.Name = "triViewToolStripMenuItem";
            this.triViewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.triViewToolStripMenuItem.Text = "TreeView";
            this.triViewToolStripMenuItem.Click += new System.EventHandler(this.triViewToolStripMenuItem_Click);
            // 
            // splitContainerToolStripMenuItem
            // 
            this.splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            this.splitContainerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.splitContainerToolStripMenuItem.Text = "SplitContainer";
            this.splitContainerToolStripMenuItem.Click += new System.EventHandler(this.splitContainerToolStripMenuItem_Click);
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // tableLayoutPanelToolStripMenuItem
            // 
            this.tableLayoutPanelToolStripMenuItem.Name = "tableLayoutPanelToolStripMenuItem";
            this.tableLayoutPanelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tableLayoutPanelToolStripMenuItem.Text = "TableLayoutPanel";
            this.tableLayoutPanelToolStripMenuItem.Click += new System.EventHandler(this.tableLayoutPanelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem12.Text = "TooStripContainer";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // backGroundWorkerToolStripMenuItem
            // 
            this.backGroundWorkerToolStripMenuItem.Name = "backGroundWorkerToolStripMenuItem";
            this.backGroundWorkerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backGroundWorkerToolStripMenuItem.Text = "BackGroundWorker";
            this.backGroundWorkerToolStripMenuItem.Click += new System.EventHandler(this.backGroundWorkerToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 551);
            this.Controls.Add(this.btnValNum);
            this.Controls.Add(this.btVerLista);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbListaVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNmVeiculo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - Janela1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbNmVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbListaVeiculos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btVerLista;
        private System.Windows.Forms.Button btnValNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnListView;
        private System.Windows.Forms.ToolStripMenuItem sbmnComponentes_Checkbox;
        private System.Windows.Forms.ToolStripMenuItem submnCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDatetimePicker;
        private System.Windows.Forms.ToolStripMenuItem mnLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem mnlistBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableLayoutPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem backGroundWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
    }
}

