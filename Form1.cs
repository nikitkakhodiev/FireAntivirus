using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAntivirus__nanananana_dorogi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ратник_от_лаффа form = new ратник_от_лаффа();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            регистрация  form = new регистрация();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d_jl form = new d_jl();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Главное_меню form = new Главное_меню();
            form.Show();
        }
    }
}
