using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Metodo_Muller : Form
    {
        public Metodo_Muller()
        {
            InitializeComponent();
        }

        private void Metodo_Muller_Load(object sender, EventArgs e)
        {

        }

        private void NuMaxItertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrMaxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p0, p1, p2, ErrorMaximo;
            int NumMaxIter;
            bool Result;
            MetSolEc metodos = new MetSolEc();

            p0 = float.Parse(textBox1.Text);
            p1 = float.Parse(textBox3.Text);
            p2 = float.Parse(textBox5.Text);

            ErrorMaximo = float.Parse(ErrMaxtxt.Text);
            NumMaxIter = int.Parse(NuMaxItertxt.Text);

            Complex p0C = new Complex(p0, 0);
            Complex p1C = new Complex(p1, 0);
            Complex p2C = new Complex(p2, 0);



            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoMuller(p0C, p1C, p2C,ref dataGridView1);

        }
    }
}
