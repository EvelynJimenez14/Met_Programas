using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmInterpolacion : Form
    {
        public FrmInterpolacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                double[] x = txtX.Text.Split(',').Select(double.Parse).ToArray();
                double[] y = txtY.Text.Split(',').Select(double.Parse).ToArray();
                double valor = double.Parse(txtValor.Text);

                
                if (x.Length != y.Length)
                {
                    MessageBox.Show("Debes tener la misma cantidad de números en X y en Y.", "Error de Datos");
                    return;
                }

                
                Interpolacion interpo = new Interpolacion(); 
                double resultado = 0;

                if (rbNewton.Checked)
                {
                    
                    resultado = interpo.InterpolacionNewton(x, y, valor, dgvTabla);
                    lblResultado.Text = $"Resultado (Newton): {resultado:F6}";
                }
                else if (rbNeville.Checked)
                {
                   
                    resultado = interpo.MetodoNeville(x, y, valor, dgvTabla);
                    lblResultado.Text = $"Resultado (Neville): {resultado:F6}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos.\nasegúrate de usar COMAS para separar los números (ej: 1, 2, 3).\n\nDetalle: " + ex.Message, "Error");
            }
        }
    }
}