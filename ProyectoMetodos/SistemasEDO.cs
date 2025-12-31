using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class SistemasEDO : Form
    {
        public SistemasEDO()
        {
            InitializeComponent();
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            dgvSistemas.Columns.Clear();
            dgvSistemas.Columns.Add("t", "t");
            dgvSistemas.Columns.Add("u", "w1 (u)");
            dgvSistemas.Columns.Add("v", "w2 (v)");
            
            dgvSistemas.Columns.Add("k1u", "k1 u");
            dgvSistemas.Columns.Add("k1v", "k1 v");
            dgvSistemas.Columns.Add("k2u", "k2 u");
            dgvSistemas.Columns.Add("k2v", "k2 v");
            dgvSistemas.Columns.Add("k3u", "k3 u");
            dgvSistemas.Columns.Add("k3v", "k3 v");
            dgvSistemas.Columns.Add("k4u", "k4 u");
            dgvSistemas.Columns.Add("k4v", "k4 v");
        }

        
        private double F1(double t, double u, double v) => v;
        private double F2(double t, double u, double v) => -5 * v * u - (u + 7) * Math.Sin(t);

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(txtT0.Text);
                double u = double.Parse(txtU0.Text);
                double v = double.Parse(txtV0.Text);
                double h = double.Parse(txtH.Text);
                double tMax = double.Parse(txtTMax.Text);

                dgvSistemas.Rows.Clear();

                while (t <= tMax + 0.0001)
                {
               
                    double k11 = h * F1(t, u, v);
                    double k12 = h * F2(t, u, v);

                    double k21 = h * F1(t + h / 2.0, u + k11 / 2.0, v + k12 / 2.0);
                    double k22 = h * F2(t + h / 2.0, u + k11 / 2.0, v + k12 / 2.0);

                    double k31 = h * F1(t + h / 2.0, u + k21 / 2.0, v + k22 / 2.0);
                    double k32 = h * F2(t + h / 2.0, u + k21 / 2.0, v + k22 / 2.0);

                    double k41 = h * F1(t + h, u + k31, v + k32);
                    double k42 = h * F2(t + h, u + k31, v + k32);

                    
                    dgvSistemas.Rows.Add(Math.Round(t, 2), Math.Round(u, 6), Math.Round(v, 6),
                        Math.Round(k11, 5), Math.Round(k12, 5),
                        Math.Round(k21, 5), Math.Round(k22, 5),
                        Math.Round(k31, 5), Math.Round(k32, 5),
                        Math.Round(k41, 5), Math.Round(k42, 5));

                   
                    u += (k11 + 2 * k21 + 2 * k31 + k41) / 6.0;
                    v += (k12 + 2 * k22 + 2 * k32 + k42) / 6.0;
                    t += h;
                }
                MessageBox.Show($"Sistema resuelto.\nFinal en t={tMax}: u={u:F6}, v={v:F6}", "Éxito");
            }
            catch { MessageBox.Show("Revisa que los datos sean números válidos."); }
        }
    }
}