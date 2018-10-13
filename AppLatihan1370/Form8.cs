using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLatihan1370
{
    public partial class Form8 : Form
    {
        private bool status = false;

        public Form8()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Enabled = true;
                listBox1.Items.Add("    - " + checkBox1.Text);
            }
            else
            {
                groupBox2.Enabled = false;
                listBox1.Items.Remove("    - " + checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Enabled = true;
                listBox1.Items.Add("    - " + checkBox2.Text);
            }
            else
            {
                groupBox2.Enabled = false;
                listBox1.Items.Remove("    - " + checkBox2.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                groupBox2.Enabled = true;
                listBox1.Items.Add("    - " + checkBox4.Text);
            }
            else
            {
                groupBox2.Enabled = false;
                listBox1.Items.Remove("    - " + checkBox4.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox2.Enabled = true;
                listBox1.Items.Add("    - " + checkBox3.Text);
            }
            else
            {
                groupBox2.Enabled = false;
                listBox1.Items.Remove("    - " + checkBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double book1, book2, book3, book4, hasil;
            string pembayaran = "";

            
            if (checkBox1.Checked == true)
            {
                book1 = Convert.ToInt32("65300");
            }
            else
            {
                book1 = Convert.ToInt32("0");
            }

            if (checkBox2.Checked == true)
            {
                book2 = Convert.ToInt32("42750");
            }
            else
            {
                book2 = Convert.ToInt32("0");
            }

            if (checkBox3.Checked == true)
            {
                book3 = Convert.ToInt32("85225");
            }
            else
            {
                book3 = Convert.ToInt32("0");
            }

            if (checkBox4.Checked == true)
            {
                book4 = Convert.ToInt32("50000");
            }
            else
            {
                book4 = Convert.ToInt32("0");
            }

            if (radioButton1.Checked == true)
            {
                pembayaran = radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                pembayaran = radioButton2.Text;
            }
            
            hasil = book1 + book2 + book3 + book4;

            List<string> lt = new List<string>();
            string str = null;
            foreach (var item in listBox1.Items)
            {
                lt.Add(item.ToString()); //store the items in the list
                str += item + "\r\n";    //store the items in the string
            }

            MessageBox.Show("You Purchased : " + Environment.NewLine + str + 
                Environment.NewLine + "Total Payment : Rp." + hasil.ToString() +
                Environment.NewLine + "Payment Mode : " + pembayaran + 
                Environment.NewLine + "Comment : " + textBox1.Text
                );
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
 
        }
    }
}
