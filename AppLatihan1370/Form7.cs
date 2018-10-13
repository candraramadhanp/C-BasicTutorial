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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Hanya boleh menginputkan angka!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hasil, suhu;
            suhu = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                hasil = suhu * 1.8 + 32;
                label5.Text = hasil.ToString() + "oF";
            }
            else if (radioButton2.Checked == true)
            {
                hasil = (suhu - 32) / 1.8;
                label5.Text = hasil.ToString() + "oC";
            }
            else if (radioButton3.Checked == true)
            {
                hasil = suhu + 273.5 ;
                label5.Text = hasil.ToString() + "oK";
            }
            else if (radioButton4.Checked == true)
            {
                hasil = suhu - 273.5;
                label5.Text = hasil.ToString() + "oC";
            }
            else
            {
                MessageBox.Show("Silahkan pilih menu converter");
            }
        }
    }
}
