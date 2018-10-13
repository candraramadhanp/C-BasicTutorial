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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            if (pilihLaki.Checked == true)
            {
                MessageBox.Show("Hello Mr. " + textNama.Text);
            }
            else if(pilihPerempuan.Checked == true)
            {
                MessageBox.Show("Hello Mrs. " + textNama.Text);
            }
            else
            {
                MessageBox.Show("Please select your gender first!");
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            textNama.Text = "";
            pilihLaki.Checked = false;
            pilihPerempuan.Checked = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
