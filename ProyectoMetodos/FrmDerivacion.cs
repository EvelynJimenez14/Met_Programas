using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmDerivadas : Form
    {
        public FrmDerivadas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDerivadas.Rows.Clear();

                double x0 = double.Parse(txtX0.Text);
                double h = double.Parse(txtH.Text);
                int n = int.Parse(txtN.Text);

                for (int i = 0; i < n; i++)
                {
                    double xi = x0 + (i * h);
                    double fi = Funcion(xi);

                    // Derivada 2 puntos
                    double d2;
                    if (i == 0)
                        d2 = Derivadas_Numericas.Derivada_Dos_Puntos((float)xi, (float)h); // adelante
                    else if (i == n - 1)
                        d2 = Derivadas_Numericas.Derivada_Dos_Puntos_Atras((float)xi, (float)h); // atrás
                    else
                        d2 = Derivadas_Numericas.Derivada_Tres_Puntos_Centrada((float)xi, (float)h); // centrada

                    // Derivada 3 puntos
                    double d3;
                    if (i == 0)
                        d3 = Derivadas_Numericas.Derivada_Tres_Puntos((float)xi, (float)h); // adelante
                    else if (i == n - 1)
                        d3 = Derivadas_Numericas.Derivada_Tres_Puntos_Atras((float)xi, (float)h); // atrás
                    else
                        d3 = Derivadas_Numericas.Derivada_Tres_Puntos_Centrada((float)xi, (float)h); // centrada

                    // Derivada 5 puntos
                    double d5;
                    if (i == 0)
                        d5 = Derivadas_Numericas.Derivada_Cinco_Puntos_Adelante((float)xi, (float)h); // adelante
                    else if (i == n - 1)
                        d5 = Derivadas_Numericas.Derivada_Cinco_Puntos_Atras((float)xi, (float)h); // atrás
                    else
                        d5 = Derivadas_Numericas.Derivada_Cinco_Puntos_Centrada((float)xi, (float)h); // centrada

                    double dExacta = Derivadas_Numericas.DerivadaExacta((float)xi);

                    dgvDerivadas.Rows.Add(
                        xi.ToString("F4"),
                        fi.ToString("F6"),
                        d2.ToString("F6"),
                        d3.ToString("F6"),
                        d5.ToString("F6"),
                        dExacta.ToString("F6")
                    );
                }
            }
            catch
            {
                MessageBox.Show("Error en los datos de entrada.");
            }
        }

        private double Funcion(double x)
        {
            // f(x) = 3x^3 + cos(2x - 8) * e^x
            return 3 * Math.Pow(x, 3) + Math.Cos(2 * x - 8) * Math.Exp(x);
        }
    }
}
