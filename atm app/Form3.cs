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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string islem;
        public int bakiye=1500;
        int cekilentutar,yatirilantutar;
       
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Kiade();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr= new Form2();
            fr.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text= islem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text == "Çekmek İstediğiniz Tutarı Giriniz:")
            {
                cekilentutar = int.Parse(maskedTextBox1.Text);
                if (cekilentutar > bakiye)
                {
                    MessageBox.Show("Yetersiz Bakiye");
                }
                else
                {
                    bakiye = bakiye - cekilentutar;
                    MessageBox.Show("Güncel Bakiyeniz: " + bakiye);
                }
                button3.Visible = true;
                button2.Visible= true;
              
            }
            else
            {
                yatirilantutar= int.Parse(maskedTextBox1.Text);
                bakiye = bakiye + yatirilantutar;
                MessageBox.Show("Güncel Bakiyeniz: " + bakiye);
                button3.Visible = true;
                button2.Visible = true;

            }
        }
    }
}
