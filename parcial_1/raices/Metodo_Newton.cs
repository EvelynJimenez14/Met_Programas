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
    public partial class Metodo_Newton : Form
    {
        public Metodo_Newton()
        {
            InitializeComponent();
        }

        private void Metodo_Newton_Load(object sender, EventArgs e)
        {

        }

        private void NuMaxItertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrMaxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, ErrorMaximo;
            int NumMaxIter;
            bool Result;
            MetSolEc metodos = new MetSolEc();

            a = float.Parse(Atxt.Text);

            ErrorMaximo = float.Parse(ErrMaxtxt.Text);
            NumMaxIter = int.Parse(NuMaxItertxt.Text);

            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoNewton(a, this.dataGridView1);

        }
    }
}
