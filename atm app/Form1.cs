using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sifre = "0000";
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = true;
            maskedTextBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            maskedTextBox1.PasswordChar = '*';
            checkBox1.Visible = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.PasswordChar = '\0';
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                if (maskedTextBox1.Text == sifre)
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ŞİFRENİZ HATALIDIR! TEKRAR DENEYİNİZ..");
                   
                }
               

            }




        }
    }
}