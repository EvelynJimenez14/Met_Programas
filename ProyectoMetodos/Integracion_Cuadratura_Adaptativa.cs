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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            if (double.TryParse(A_txt.Text, out double a) &&
                double.TryParse(B_txt.Text, out double b) &&
                double.TryParse(Epsilon_txt.Text, out double eps))
            {
                Integracion motor = new Integracion();

               
                double resultado = motor.MetodoCuadraturaAdaptativa(a, b, eps, 0);

                Resultado_txt.Text = resultado.ToString("N10");

                MessageBox.Show($"Cálculo completado con una tolerancia de: {eps}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}