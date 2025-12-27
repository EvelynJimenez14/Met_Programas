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
    public partial class Formula_Taylor_0 : Form
    {
        public Formula_Taylor_0()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

            Result= formulatay.FormulaTaylor(x0, x, b, incremento, this.dataGridView1);

            
        }

        private void Btxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrMaxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuMaxItertxt_TextChanged(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void incrementotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Formula_Taylor_0_Load(object sender, EventArgs e)
        {

        }
    }
}
