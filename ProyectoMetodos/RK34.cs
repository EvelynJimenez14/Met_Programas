using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmRK : Form
    {
        public FrmRK()
        {
            InitializeComponent();
        }

        // Definición de la función f(x,y) = dy/dx
        // Ejemplo por aplicación: y' = x + y
        public double f(double x, double y) => x + y;

        public class FilaRK
        {
            public int Iteracion { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public string Valores_K { get; set; }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX0.Text);
                double y = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                double xMax = double.Parse(txtXMax.Text);

                List<FilaRK> lista = new List<FilaRK>();
                int i = 0;

                while (x <= xMax + 0.0001)
                {
                    double k1, k2, k3, k4 = 0, ySig;
                    string ks;

                    k1 = h * f(x, y);

                    if (rbRK3.Checked) // Método de Runge-Kutta de 3er Orden
                    {
                        k2 = h * f(x + h / 2, y + k1 / 2);
                        k3 = h * f(x + h, y - k1 + 2 * k2);
                        ySig = y + (k1 + 4 * k2 + k3) / 6.0;
                        ks = $"k1:{k1:F4}, k2:{k2:F4}, k3:{k3:F4}";
                    }
                    else // Método de Runge-Kutta de 4to Orden (RK4)
                    {
                        k2 = h * f(x + h / 2, y + k1 / 2);
                        k3 = h * f(x + h / 2, y + k2 / 2);
                        k4 = h * f(x + h, y + k3);
                        ySig = y + (k1 + 2 * k2 + 2 * k3 + k4) / 6.0;
                        ks = $"k1:{k1:F4}, k2:{k2:F4}, k3:{k3:F4}, k4:{k4:F4}";
                    }

                    lista.Add(new FilaRK { Iteracion = i, X = x, Y = y, Valores_K = ks });

                    y = ySig;
                    x += h;
                    i++;
                }
                dgvResultados.DataSource = lista;
                double resultadoFinal = lista[lista.Count - 1].Y;
               
                MessageBox.Show($"La aproximación final en x = {xMax} es y = {resultadoFinal:F6}",
                                "Resultado RK",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Error en los datos de entrada."); }
        }
    }
}