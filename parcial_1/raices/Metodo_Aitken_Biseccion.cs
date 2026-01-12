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
    public partial class Metodo_Aitken_Biseccion : Form
    {
        public Metodo_Aitken_Biseccion()
        {
            InitializeComponent();
        }

        private void Metodo_Aitken_Biseccion_Load(object sender, EventArgs e)
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

        private void Btxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, ErrorMaximo;
            int NumMaxIter;
            bool Result;
            MetSolEc metodos = new MetSolEc();

            a = float.Parse(Atxt.Text);
            b = float.Parse(Btxt.Text);

            ErrorMaximo = float.Parse(ErrMaxtxt.Text);
            NumMaxIter = int.Parse(NuMaxItertxt.Text);

            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoAitkenBiseccion(a, b, this.dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
