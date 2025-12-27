using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmIntegracionMultiple : Form
    {
        public FrmIntegracionMultiple()
        {
            InitializeComponent();
        }

        
        private double f(double x, double y) => (x * x) + (y * y);

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                int n = int.Parse(txtN.Text); 

                
                double c = double.Parse(txtC.Text);
                double d = double.Parse(txtD.Text);
                int m = int.Parse(txtM.Text); 

                double resultado = 0;

                if (rbTrapecio.Checked)
                {
                    resultado = IntegracionDobleTrapecio(a, b, n, c, d, m);
                    lblResultado.Text = "Resultado (Trapecio): " + Math.Round(resultado, 6);
                }
                else
                {
                    
                    if (n % 2 != 0 || m % 2 != 0)
                    {
                        MessageBox.Show("Para Simpson, los pasos (n, m) deben ser pares.");
                        return;
                    }
                    resultado = IntegracionDobleSimpson(a, b, n, c, d, m);
                    lblResultado.Text = "Resultado (Simpson): " + Math.Round(resultado, 6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checa que los límites y pasos sean números válidos.");
            }
        }

        
        private double IntegracionDobleTrapecio(double a, double b, int n, double c, double d, int m)
        {
            double hx = (b - a) / n;
            double hy = (d - c) / m;
            double suma = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    
                    double peso = 1;
                    if ((i == 0 || i == n) && (j == 0 || j == m)) peso = 1;
                    else if (i == 0 || i == n || j == 0 || j == m) peso = 2;
                    else peso = 4;

                    suma += peso * f(a + i * hx, c + j * hy);
                }
            }
            return (hx * hy / 4.0) * suma;
        }

        
        private double IntegracionDobleSimpson(double a, double b, int n, double c, double d, int m)
        {
            double hx = (b - a) / n;
            double hy = (d - c) / m;
            double suma = 0;

            for (int i = 0; i <= n; i++)
            {
                double pesoX = (i == 0 || i == n) ? 1 : (i % 2 == 0 ? 2 : 4);
                for (int j = 0; j <= m; j++)
                {
                    double pesoY = (j == 0 || j == m) ? 1 : (j % 2 == 0 ? 2 : 4);
                    suma += (pesoX * pesoY) * f(a + i * hx, c + j * hy);
                }
            }
            return (hx * hy / 9.0) * suma;
        }
    }
}