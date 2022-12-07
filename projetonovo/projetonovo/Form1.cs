using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetonovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            primeiraMensagem.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botao1_Click(object sender, EventArgs e)
           
        {
            primeiraMensagem.Visible = true;
            primeiraMensagem.Text = "uma nova mensagem";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.Text = "chega";
        }

        
        {
           
        }
    }
}
