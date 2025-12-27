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
    public partial class Formulario_Taylor_4 : Form
    {
        public Formulario_Taylor_4()
        {
            InitializeComponent();
        }

        private void xtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void incrementotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x0, x, b, incremento;
            Taylor formulatay = new Taylor();
            float Result;

            x0 = float.Parse(x0txt.Text);
            x = float.Parse(xtxt.Text);
            b = float.Parse(btxt.Text);
            incremento = float.Parse(incrementotxt.Text);

            Result = formulatay.FormulaTaylor4(x0, x, b, incremento, this.DataGridView2);
        }
    }
}
