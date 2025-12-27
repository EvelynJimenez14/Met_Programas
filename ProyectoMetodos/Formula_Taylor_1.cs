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
    public partial class Formula_Taylor_1 : Form
    {
        public Formula_Taylor_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x0, x, b, incremento;
            Taylor formulatay = new Taylor();
            float Result;

            x0 = float.Parse(x0txt.Text);
            x = float.Parse(xtxt.Text);
            b = float.Parse(btxt.Text);
            incremento = float.Parse(incrementotxt.Text);

            Result = formulatay.FormulaTaylor1(x0, x, b, incremento, this.dataGridView1);
            this.WindowState = FormWindowState.Maximized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formula_Taylor_2_Load(object sender, EventArgs e)
        {

        }
    }
}
