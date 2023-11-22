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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void btnSelecionado_Click(object sender, EventArgs e)
        {
            String gb1, gb2;
            gb1= gb2 = "Nada Selecionado";
            if (groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text != "")
            {
                gb1 = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            }
            if (groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text != "")
            {
                gb2 = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            }
            textBox1.Text = gb1+" "+" "+ gb2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qual, qual2;
            qual = qual2 = "Nada selecionado";
          foreach (RadioButton radioButton in groupBox1.Controls)
            {
                if (radioButton.Checked){
                    qual = radioButton.Text;
                }
            }
            foreach (RadioButton radioButton in groupBox2.Controls)
            {
                if (radioButton.Checked)
                {
                    qual2= radioButton.Text;
                }
            }
            MessageBox.Show("Controle 1: "+qual+" Controle 2: "+qual2);
        }
    }
}
