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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Integracion integracion = new Integracion();

                
                double a = double.Parse(A_txt.Text);
                double b = double.Parse(B_txt.Text);
                int n = int.Parse(N_txt.Text);

               
                if (n < 2 || n > 4)
                {
                    MessageBox.Show("Por favor, ingrese un grado válido (2, 3 o 4).", "Grado no soportado");
                    return;
                }

               
                double resultado = integracion.MetodoCuadraturaGaussiana(a, b, n);
                Resultado_txt.Text = resultado.ToString("N10");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de que todos los campos tengan números válidos.", "Error de formato");
            }
        }
    }
}
