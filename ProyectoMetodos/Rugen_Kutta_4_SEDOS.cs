using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Rugen_Kutta_4_SEDOS : Form
    {
        public Rugen_Kutta_4_SEDOS()
        {
            InitializeComponent();
        }

        // Clase para estructurar la tabla como en tus Excel
        public class FilaSEDOS
        {
            public double t { get; set; }
            public double w1 { get; set; } // Variable U
            public double w2 { get; set; } // Variable V
            public string Detalles_K { get; set; } // Muestra k1 a k4
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar datos de los TextBox (Nombres validados para el Designer)
                double t = double.Parse(txtT0.Text);
                double u = double.Parse(txtU0.Text);
                double v = double.Parse(txtV0.Text);
                double h = double.Parse(txtH.Text);
                double tMax = double.Parse(txtTMax.Text);

                List<FilaSEDOS> listaResultados = new List<FilaSEDOS>();

                while (t <= tMax + 0.0001)
                {
                    // Ejemplo de aplicación: u' = v | v' = -u
                    double k11 = h * v;
                    double k12 = h * (-u);

                    double k21 = h * (v + 0.5 * k12);
                    double k22 = h * (-(u + 0.5 * k11));

                    double k31 = h * (v + 0.5 * k22);
                    double k32 = h * (-(u + 0.5 * k21));

                    double k41 = h * (v + k32);
                    double k42 = h * (-(u + k31));

                    listaResultados.Add(new FilaSEDOS
                    {
                        t = Math.Round(t, 4),
                        w1 = Math.Round(u, 6),
                        w2 = Math.Round(v, 6),
                        Detalles_K = $"k1:{k11:F4} | k4:{k41:F4}"
                    });

                    // Actualización del sistema
                    u += (k11 + 2 * k21 + 2 * k31 + k41) / 6.0;
                    v += (k12 + 2 * k22 + 2 * k32 + k42) / 6.0;
                    t += h;
                }

                dgvSistemas.DataSource = listaResultados;
                dgvSistemas.Columns["Detalles_K"].Width = 180;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la entrada de datos: " + ex.Message);
            }
        }
    }
}