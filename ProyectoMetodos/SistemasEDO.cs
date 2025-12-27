using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class SistemasEDO : Form
    {
        public SistemasEDO()
        {
            InitializeComponent();
        }

        public class FilaSistema
        {
            public double T { get; set; }
            public double U { get; set; }
            public double V { get; set; }
            public string Pasos_K_U { get; set; } // Muestra k1, k2, k3, k4 para U
            public string Pasos_K_V { get; set; } // Muestra k1, k2, k3, k4 para V
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(txtT0.Text);
                double u = double.Parse(txtU0.Text);
                double v = double.Parse(txtV0.Text);
                double h = double.Parse(txtH.Text);
                double tMax = double.Parse(txtTMax.Text);

                List<FilaSistema> lista = new List<FilaSistema>();

                while (t <= tMax + 0.0001)
                {
                    // Ejemplo de aplicación: Sistema de oscilador
                    // du/dt = v
                    // dv/dt = -u
                    double ku1 = v;
                    double kv1 = -u;

                    double ku2 = v + (h / 2) * kv1;
                    double kv2 = -(u + (h / 2) * ku1);

                    double ku3 = v + (h / 2) * kv2;
                    double kv3 = -(u + (h / 2) * ku2);

                    double ku4 = v + h * kv3;
                    double kv4 = -(u + h * ku3);

                    lista.Add(new FilaSistema
                    {
                        T = t,
                        U = u,
                        V = v,
                        Pasos_K_U = $"k1:{ku1:F3}, k2:{ku2:F3}, k3:{ku3:F3}, k4:{ku4:F3}",
                        Pasos_K_V = $"k1:{kv1:F3}, k2:{kv2:F3}, k3:{kv3:F3}, k4:{kv4:F3}"
                    });

                    u += (h / 6.0) * (ku1 + 2 * ku2 + 2 * ku3 + ku4);
                    v += (h / 6.0) * (kv1 + 2 * kv2 + 2 * kv3 + kv4);
                    t += h;
                }
                dgvSistemas.DataSource = lista;
                // Ajustamos el ancho de las columnas para que se vean bien los k
                dgvSistemas.Columns["Pasos_K_U"].Width = 200;
                dgvSistemas.Columns["Pasos_K_V"].Width = 200;
            }
            catch { MessageBox.Show("Verifica que todos los campos tengan números válidos."); }
        }
    }
}