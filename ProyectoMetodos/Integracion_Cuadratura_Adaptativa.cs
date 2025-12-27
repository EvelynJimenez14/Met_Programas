using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Integracion_Cuadratura_Adaptativa : Form
    {
        public Integracion_Cuadratura_Adaptativa()
        {
            InitializeComponent();
        }

        // Aquí pongo la función que quiero integrar
        private double f(double x) => Math.Exp(x * x); // Ejemplo: e^(x^2)

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Jalo los límites y la tolerancia de las cajas
                double a = double.Parse(A_txt.Text);
                double b = double.Parse(B_txt.Text);
                double tol = 0.00001; // Tolerancia por defecto

                // Llamo a la función recursiva de Simpson Adaptativo
                double resultado = SimpsonAdaptativo(a, b, tol, SimpsonRegla(a, b));

                Resultado_txt.Text = resultado.ToString("N8");
            }
            catch { MessageBox.Show("Revisa los números, algo no cuadra."); }
        }

        // Función auxiliar: Regla de Simpson básica para un intervalo
        private double SimpsonRegla(double a, double b)
        {
            double c = (a + b) / 2.0;
            return (Math.Abs(b - a) / 6.0) * (f(a) + 4.0 * f(c) + f(b));
        }

        // Algoritmo de Simpson Adaptativo (Recursivo)
        private double SimpsonAdaptativo(double a, double b, double tol, double S)
        {
            double c = (a + b) / 2.0;
            double S_izq = SimpsonRegla(a, c);
            double S_der = SimpsonRegla(c, b);

            // Si la diferencia es pequeña, ya terminamos ese pedazo
            if (Math.Abs(S_izq + S_der - S) <= 15.0 * tol)
            {
                return S_izq + S_der + (S_izq + S_der - S) / 15.0;
            }

            // Si no, seguimos dividiendo a la mitad
            return SimpsonAdaptativo(a, c, tol / 2.0, S_izq) +
                   SimpsonAdaptativo(c, b, tol / 2.0, S_der);
        }
    }
}