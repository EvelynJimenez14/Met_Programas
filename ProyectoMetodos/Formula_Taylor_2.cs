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
    public partial class Formula_Taylor_2 : Form
    {
        public Formula_Taylor_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

            Result = formulatay.FormulaTaylor2(x0, x, b, incremento, this.DataGridView2);
        }

        private void Formula_Taylor_3_Load(object sender, EventArgs e)
        {

        }
    }
}
