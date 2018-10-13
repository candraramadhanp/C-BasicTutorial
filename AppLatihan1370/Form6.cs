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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hasil, angkaPertama, angkaKedua;
            angkaPertama = Convert.ToInt32(textBox1.Text);
            angkaKedua = Convert.ToInt32(textBox2.Text);

            hasil = angkaPertama + angkaKedua;

            label5.Text = hasil.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Hanya boleh menginputkan angka!");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Hanya boleh menginputkan angka!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hasil, angkaPertama, angkaKedua;
            angkaPertama = Convert.ToInt32(textBox1.Text);
            angkaKedua = Convert.ToInt32(textBox2.Text);

            hasil = angkaPertama - angkaKedua;

            label5.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hasil, angkaPertama, angkaKedua;
            angkaPertama = Convert.ToInt32(textBox1.Text);
            angkaKedua = Convert.ToInt32(textBox2.Text);

            hasil = angkaPertama / angkaKedua;

            label5.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hasil, angkaPertama, angkaKedua;
            angkaPertama = Convert.ToInt32(textBox1.Text);
            angkaKedua = Convert.ToInt32(textBox2.Text);

            hasil = angkaPertama * angkaKedua;

            label5.Text = hasil.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
