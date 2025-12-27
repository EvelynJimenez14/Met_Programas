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
    public partial class Metodo_Horner : Form
    {
        public Metodo_Horner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p0, p1, p2, ErrorMaximo;
            int NumMaxIter;
            bool Result;
            MetSolEc metodos = new MetSolEc();



            float[] coeficientes = textCoeficientes.Text.Split(',')              // Separa el texto por comas
                               .Select(float.Parse)     // Convierte cada parte en un float
                               .ToArray();
            int grado = int.Parse(textGrado.Text);
            p0 = float.Parse(textBox1.Text);
            p1 = float.Parse(textBox3.Text);
            p2 = float.Parse(textBox5.Text);

            ErrorMaximo = float.Parse(ErrMaxtxt.Text);
            NumMaxIter = int.Parse(NuMaxItertxt.Text);

            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoHorner(grado, coeficientes, p0,p1,p2, dataGridView1);
        }

        private void Metodo_Horner_Load(object sender, EventArgs e)
        {

        }
    }
}
