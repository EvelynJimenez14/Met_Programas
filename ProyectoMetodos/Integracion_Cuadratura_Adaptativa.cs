using System;
using System.Drawing;
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
                double.TryParse(B_txt.Text, out double b))
            {
                double tol = 0.00001; 

                Integracion motor = new Integracion();
                double resultado = motor.MetodoCuadraturaAdaptativa(a, b, tol, 0);

                Resultado_txt.Text = resultado.ToString("N10");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los límites.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}