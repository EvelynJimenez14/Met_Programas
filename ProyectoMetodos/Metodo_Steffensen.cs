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
    public partial class Metodo_Steffensen : Form
    {
        public Metodo_Steffensen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p0, ErrorMaximo;
            int NumMaxIter;
            bool Result;

            MetSolEc metodos = new MetSolEc();

            p0 = float.Parse(P0txt.Text);

            NumMaxIter = int.Parse(NuMaxItertxt.Text);
            ErrorMaximo = float.Parse(ErrMaxtxt.Text);

            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoSteffensen(p0, this.dataGridView1);
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

        private void Metodo_Steffensen_Load(object sender, EventArgs e)
        {

        }
    }
}
