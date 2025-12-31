using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmAdams : Form
    {
        public FrmAdams()
        {
            InitializeComponent();
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            dgvResultados.Columns.Clear();
            dgvResultados.Columns.Add("i", "i");
            dgvResultados.Columns.Add("x", "x");
            dgvResultados.Columns.Add("y", "y (Resultado)");
            dgvResultados.Columns.Add("k1", "k1");
            dgvResultados.Columns.Add("k2", "k2");
            dgvResultados.Columns.Add("k3", "k3");
            dgvResultados.Columns.Add("k4", "k4");
        }

        private double f(double x, double y) => y - (x * x) + 1;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                int n = int.Parse(txtN.Text);

                if (n < 4) { MessageBox.Show("Adams requiere al menos 4 pasos."); return; }

                double[] x = new double[n + 1];
                double[] y = new double[n + 1];
                x[0] = x0; y[0] = y0;

                dgvResultados.Rows.Clear();
                dgvResultados.Rows.Add(0, x[0], y[0], "-", "-", "-", "-");

                for (int i = 0; i < 3; i++)
                {
                    double k1 = h * f(x[i], y[i]);
                    double k2 = h * f(x[i] + h / 2, y[i] + k1 / 2);
                    double k3 = h * f(x[i] + h / 2, y[i] + k2 / 2);
                    double k4 = h * f(x[i] + h, y[i] + k3);

                    y[i + 1] = y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    x[i + 1] = x[i] + h;

                    dgvResultados.Rows.Add(i + 1, Math.Round(x[i + 1], 4), Math.Round(y[i + 1], 8),
                        Math.Round(k1, 6), Math.Round(k2, 6), Math.Round(k3, 6), Math.Round(k4, 6));
                }

                for (int i = 3; i < n; i++)
                {
                    x[i + 1] = x[i] + h;
                    double f0 = f(x[i], y[i]);
                    double f1 = f(x[i - 1], y[i - 1]);
                    double f2 = f(x[i - 2], y[i - 2]);
                    double f3 = f(x[i - 3], y[i - 3]);

                    if (rbBashforth.Checked)
                    {
                        y[i + 1] = y[i] + (h / 24.0) * (55 * f0 - 59 * f1 + 37 * f2 - 9 * f3);
                    }
                    else
                    {
                        double y_p = y[i] + (h / 24.0) * (55 * f0 - 59 * f1 + 37 * f2 - 9 * f3);
                        y[i + 1] = y[i] + (h / 24.0) * (9 * f(x[i + 1], y_p) + 19 * f0 - 5 * f1 + f2);
                    }
                    dgvResultados.Rows.Add(i + 1, Math.Round(x[i + 1], 4), Math.Round(y[i + 1], 8), "", "", "", "");
                }
            }
            catch { MessageBox.Show("Error en los datos."); }
        }
    }
}