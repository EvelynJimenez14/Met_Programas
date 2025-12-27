using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmRichardson : Form
    {
        private TextBox txtX;
        private TextBox txtH;
        private Label lblResultado;

        public FrmRichardson()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        private void ConfigurarVentana()
        {
            this.Text = "Extrapolación de Richardson";
            this.Size = new Size(350, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label l1 = new Label { Text = "Valor de X (donde derivar):", Location = new Point(30, 30), AutoSize = true };
            txtX = new TextBox { Text = "1.0", Location = new Point(30, 55) };

            Label l2 = new Label { Text = "Paso inicial (h):", Location = new Point(30, 90), AutoSize = true };
            txtH = new TextBox { Text = "0.5", Location = new Point(30, 115) };

            Button btn = new Button { Text = "Calcular Derivada", Location = new Point(30, 160), Width = 150, Height = 40, BackColor = Color.LightGreen };
            btn.Click += Btn_Click;

            lblResultado = new Label { Text = "Resultado: --", Location = new Point(30, 220), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };

            this.Controls.Add(l1); this.Controls.Add(txtX);
            this.Controls.Add(l2); this.Controls.Add(txtH);
            this.Controls.Add(btn); this.Controls.Add(lblResultado);
        }

        private double Funcion(double x)
        {
            return Math.Sin(x); // Puedes cambiar la función aquí
        }

        private double DerivadaCentral(double x, double h)
        {
            return (Funcion(x + h) - Funcion(x - h)) / (2 * h);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double h = double.Parse(txtH.Text);

                double D1 = DerivadaCentral(x, h);
                double D2 = DerivadaCentral(x, h / 2.0);
                double mejorada = D2 + (D2 - D1) / 3.0;

                lblResultado.Text = $"Derivada Aprox: {mejorada:F6}";
            }
            catch
            {
                MessageBox.Show("Error: Revisa los números.");
            }
        }

       
        private void FrmRichardson_Load(object sender, EventArgs e)
        {
        }
    }
}