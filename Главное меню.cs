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
    public partial class Главное_меню : Form
    {
        public Главное_меню()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _64Gram form = new _64Gram();
            form.Show();
        }
    }
}
