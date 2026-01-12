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
    public partial class Metodo_Runge_Kuta4 : Form
    {
        public Metodo_Runge_Kuta4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tMax, y0, h;
            EcuaDif ec = new EcuaDif();  // Crear una instancia de la clase EcuaDif
            int resultado;

            try
            {
                tMax = float.Parse(tMaxtxt.Text);  
                y0 = float.Parse(y0txt.Text);      
                h = float.Parse(htxt.Text);     

                resultado = ec.RungeKuta4(tMax, y0, h, this.dataGridView1);

                if (resultado == -1)
                {
                    MessageBox.Show("Hubo un error en los cálculos con el Método de Euler.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
