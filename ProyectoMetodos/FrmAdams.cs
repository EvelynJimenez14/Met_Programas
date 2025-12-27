using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmAdams : Form
    {
        public FrmAdams()
        {
            InitializeComponent();
        }

        
        // Ejemplo: dy/dx = y - x^2 + 1
        private double f(double x, double y) => y - (x * x) + 1;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                int n = int.Parse(txtN.Text);

                double[] x = new double[n + 1];
                double[] y = new double[n + 1];

                x[0] = x0;
                y[0] = y0;
                lstPasos.Items.Clear();
                lstPasos.Items.Add($"Paso 0: x={x[0]}, y={y[0]}");

                // 
                for (int i = 0; i < 3 && i < n; i++)
                {
                    double k1 = h * f(x[i], y[i]);
                    double k2 = h * f(x[i] + h / 2, y[i] + k1 / 2);
                    double k3 = h * f(x[i] + h / 2, y[i] + k2 / 2);
                    double k4 = h * f(x[i] + h, y[i] + k3);

                    y[i + 1] = y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    x[i + 1] = x[i] + h;
                    lstPasos.Items.Add($"Paso {i + 1} (RK4): x={Math.Round(x[i + 1], 4)}, y={Math.Round(y[i + 1], 6)}");
                }

               
                for (int i = 3; i < n; i++)
                {
                    
                    double predictor = y[i] + (h / 24.0) * (55 * f(x[i], y[i]) - 59 * f(x[i - 1], y[i - 1]) + 37 * f(x[i - 2], y[i - 2]) - 9 * f(x[i - 3], y[i - 3]));

                    x[i + 1] = x[i] + h;

                   
                    y[i + 1] = y[i] + (h / 24.0) * (9 * f(x[i + 1], predictor) + 19 * f(x[i], y[i]) - 5 * f(x[i - 1], y[i - 1]) + f(x[i - 2], y[i - 2]));

                    lstPasos.Items.Add($"Paso {i + 1} (Adams): x={Math.Round(x[i + 1], 4)}, y={Math.Round(y[i + 1], 6)}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa los datos, algo pusiste mal.");
            }
        }
    }
}