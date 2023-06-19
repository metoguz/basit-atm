using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int bakiye;

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Kiade();
           
        }
        
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 fr= new Form3();
            bakiye= fr.bakiye;
            checkBox1.Visible= false;
            checkBox2.Visible= false;
            checkBox3.Visible= false;
            checkBox4.Visible= false;
            label2.Text=bakiye.ToString();
            label1.Visible = true; label2.Visible= true;
            button2.Visible=true;
            button1.Visible=true;
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 fr= new Form3();
            fr.islem = "Çekmek İstediğiniz Tutarı Giriniz:";
            fr.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 fr=new Form3();
            fr.islem = "Yatırmak İstediğiniz Tutarı Giriniz";
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islemmenusu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Kiade();

        }
        public void islemmenusu()
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            label2.Text = bakiye.ToString();
            label1.Visible = false; label2.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }
        public void Kiade()
        {
            MessageBox.Show("Lütfen Kartınzı Alınız..");
            Application.Exit();
        }
        
    }
  
}
