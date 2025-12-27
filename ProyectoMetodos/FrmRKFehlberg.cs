using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmRKFehlberg : Form
    {
        private TextBox txtX0, txtY0, txtH, txtTol;
        private DataGridView dgvTabla;
        private Button btnCalcular;

        public FrmRKFehlberg()
        {
            // Quitamos InitializeComponent si te da errores visuales 
            // o asegúrate de que el diseño esté vacío.
            InitializeComponent();
            this.Controls.Clear(); // Limpiamos cualquier control encimado del diseño
            RK_ConstruirInterfaz();
        }

        private void RK_ConstruirInterfaz()
        {
            this.Text = "Método RK-Fehlberg (Paso Variable)";
            this.Size = new Size(650, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Etiquetas e Inputs
            Label l1 = new Label { Text = "X0:", Location = new Point(20, 20), Width = 30 };
            txtX0 = new TextBox { Text = "0", Location = new Point(55, 20), Width = 60 };
            Label l2 = new Label { Text = "Y0:", Location = new Point(130, 20), Width = 30 };
            txtY0 = new TextBox { Text = "1", Location = new Point(165, 20), Width = 60 };
            Label l3 = new Label { Text = "h:", Location = new Point(240, 20), Width = 20 };
            txtH = new TextBox { Text = "0.5", Location = new Point(265, 20), Width = 60 };
            Label l4 = new Label { Text = "Tol:", Location = new Point(340, 20), Width = 30 };
            txtTol = new TextBox { Text = "0.0001", Location = new Point(375, 20), Width = 70 };

            btnCalcular = new Button { Text = "CALCULAR RK", Location = new Point(470, 15), Width = 120, Height = 35, BackColor = Color.LightGreen };
            btnCalcular.Click += btnCalcularRK_Click;

            dgvTabla = new DataGridView
            {
                Location = new Point(20, 70),
                Width = 590,
                Height = 360,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvTabla.Columns.Add("it", "Iter");
            dgvTabla.Columns.Add("x", "X");
            dgvTabla.Columns.Add("y", "Y (RK)");
            dgvTabla.Columns.Add("h", "Paso h");
            dgvTabla.Columns.Add("err", "Error");

            this.Controls.Add(l1); this.Controls.Add(txtX0);
            this.Controls.Add(l2); this.Controls.Add(txtY0);
            this.Controls.Add(l3); this.Controls.Add(txtH);
            this.Controls.Add(l4); this.Controls.Add(txtTol);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(dgvTabla);
        }

        private double RK_Funcion(double x, double y) => y - (x * x) + 1;

        private void btnCalcularRK_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX0.Text);
                double y = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                double tol = double.Parse(txtTol.Text);
                dgvTabla.Rows.Clear();
                dgvTabla.Rows.Add(0, x, y, h, "---");
                int iter = 0;
                while (x < 5 && iter < 50)
                {
                    double rk1 = h * RK_Funcion(x, y);
                    double rk2 = h * RK_Funcion(x + h / 4.0, y + rk1 / 4.0);
                    double rk3 = h * RK_Funcion(x + 3.0 * h / 8.0, y + 3.0 * rk1 / 32.0 + 9.0 * rk2 / 32.0);
                    double rk4 = h * RK_Funcion(x + 12.0 * h / 13.0, y + 1932.0 * rk1 / 2197.0 - 7200.0 * rk2 / 2197.0 + 7296.0 * rk3 / 2197.0);
                    double rk5 = h * RK_Funcion(x + h, y + 439.0 * rk1 / 216.0 - 8.0 * rk2 + 3680.0 * rk3 / 513.0 - 845.0 * rk4 / 4104.0);
                    double rk6 = h * RK_Funcion(x + h / 2.0, y - 8.0 * rk1 / 27.0 + 2.0 * rk2 - 3544.0 * rk3 / 2565.0 + 1859.0 * rk4 / 4104.0 - 11.0 * rk5 / 40.0);
                    double error = Math.Abs((rk1 / 360.0 - 128.0 * rk3 / 4275.0 - 2197.0 * rk4 / 75240.0 + rk5 / 50.0 + 2.0 * rk6 / 55.0) / h);
                    if (error <= tol)
                    {
                        x += h;
                        y += (25.0 * rk1 / 216.0 + 1408.0 * rk3 / 2565.0 + 2197.0 * rk4 / 4104.0 - rk5 / 5.0);
                        iter++;
                        dgvTabla.Rows.Add(iter, Math.Round(x, 4), Math.Round(y, 6), Math.Round(h, 6), error.ToString("E2"));
                    }
                    h *= 0.84 * Math.Pow((tol / (error + 1e-10)), 0.25);
                    if (h > 1.0) h = 1.0;
                }
            }
            catch { MessageBox.Show("Error en datos"); }
        }
    }
}