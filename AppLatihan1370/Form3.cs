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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboJurusan.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Ada Form Yang Kosong");
            }
            else
            {
                lbJurusanIn.Text = comboJurusan.SelectedItem.ToString();
                lbNamaIn.Text = textNama.Text;
            }
        }

        private void comboJurusan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
