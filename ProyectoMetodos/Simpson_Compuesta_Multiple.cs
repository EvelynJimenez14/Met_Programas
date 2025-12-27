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
    public partial class Simpson_Compuesta_Multiple : Form
    {
        public Simpson_Compuesta_Multiple()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            float c, d;
            int n_x, n_y;
            float resultado;

            Integracion MetIntegracion = new Integracion();

            a = float.Parse(A_txt.Text);
            b = float.Parse(B_txt.Text);
            c = float.Parse(C_txt.Text);
            d = float.Parse(D_txt.Text);
            n_x = int.Parse(N_x_txt.Text);
            n_y = int.Parse(N_y_txt.Text);

            resultado = MetIntegracion.IntegralDoble_Simpson(a, b, c, d, n_x, n_y);
            Resultado_txt.Text = resultado.ToString();
        }
    }
}
