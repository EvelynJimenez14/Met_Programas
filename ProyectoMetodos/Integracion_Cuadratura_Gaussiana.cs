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
    public partial class Integracion_Cuadratura_Gaussiana : Form
    {
        public Integracion_Cuadratura_Gaussiana()
        {
            InitializeComponent();
        }

        private void Integracion_Cuadratura_Gaussiana_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();

            float a = float.Parse(A_txt.Text.ToString());
            float b = float.Parse(B_txt.Text.ToString());

            float resultado = integracion.MetodoCuadraturaGaussiana(a, b);
            Resultado_txt.Text = resultado.ToString();
        }
    }
}
