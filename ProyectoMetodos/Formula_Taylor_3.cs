using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Formula_Taylor_3 : Form
    {
        public Formula_Taylor_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0, x, b, incremento;
            Taylor formulatay = new Taylor();
            double Result;

            x0 = double.Parse(x0txt.Text);
            x = double.Parse(xtxt.Text);
            b = double.Parse(btxt.Text);
            incremento = double.Parse(incrementotxt.Text);

            Result = formulatay.FormulaTaylor3(x0, x, b, incremento, this.DataGridView2);
        }

        private void incrementotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void xtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void x0txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
