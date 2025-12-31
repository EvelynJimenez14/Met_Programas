using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            MenuStrip ms = new MenuStrip();
            ms.BackColor = Color.WhiteSmoke;

            
            ToolStripMenuItem m1 = new ToolStripMenuItem("Primer Parcial");
            m1.BackColor = Color.LightSkyBlue;
            m1.DropDownItems.Add("Bisección", null, (s, e) => new Metodo_Biseccion().Show());
            m1.DropDownItems.Add("Falsa Posición", null, (s, e) => new Metodo_Falsa_Posicion().Show());
            m1.DropDownItems.Add("Punto Fijo", null, (s, e) => new Metodo_Punto_Fijo().Show());
            m1.DropDownItems.Add("Newton-Raphson", null, (s, e) => new Metodo_Newton().Show());
            m1.DropDownItems.Add("Secante", null, (s, e) => new Metodo_Secante().Show());
            m1.DropDownItems.Add("Müller", null, (s, e) => new Metodo_Muller().Show());
           
            
            ToolStripMenuItem m2 = new ToolStripMenuItem("Segundo Parcial");
            m2.BackColor = Color.LightGreen;

            
            var subDeriv = new ToolStripMenuItem("Derivación");
            subDeriv.DropDownItems.Add("2, 3, 5 puntos ", null, (s, e) => new FrmDerivadas().Show());
            subDeriv.DropDownItems.Add("Puntos con dif. h",null,(s,e) => new FrmDerivadasHVariable().Show());
            subDeriv.DropDownItems.Add("Extrapolación (Richardson)", null, (s, e) => new FrmRichardson().Show());

            
            var subInteg = new ToolStripMenuItem("Integración Compuesta");
            subInteg.DropDownItems.Add("Trapecio", null, (s, e) => new Integracion_Trapecio().Show());
            subInteg.DropDownItems.Add("Simpson 1/3 ", null, (s, e) => new Integracion_Simpson_1_3().Show());
            subInteg.DropDownItems.Add("Simpson 3/8", null, (s, e) => new Integracion_Simpson_3_8().Show());
            subInteg.DropDownItems.Add("Cuadratura Adaptativa", null, (s, e) => new Integracion_Cuadratura_Adaptativa().Show());
            subInteg.DropDownItems.Add("Cuadratura Gaussiana", null, (s, e) => new Integracion_Cuadratura_Gaussiana().Show());

            
            var subMult = new ToolStripMenuItem("Integración Múltiple");
            subMult.DropDownItems.Add("Trapecio-Simpson", null, (s, e) => new FrmIntegracionMultiple().Show());
;

            
            var subInterp = new ToolStripMenuItem("Interpolación");
            subInterp.DropDownItems.Add("Diferencias Divididas (Adelante/Atrás)", null, (s, e) => new FrmDifDivididas().Show());
            subInterp.DropDownItems.Add("Neville", null, (s, e) => new FrmNeville().Show());
            subInterp.DropDownItems.Add("Lagrange (Puntos dif. h)", null, (s, e) => new FormLagrange().Show());

            m2.DropDownItems.AddRange(new ToolStripItem[] { subDeriv, subInteg, subMult, subInterp });

             
            ToolStripMenuItem m3 = new ToolStripMenuItem("Tercer Parcial");
            m3.BackColor = Color.LightSalmon;

            
            var subSistemas = new ToolStripMenuItem("Sistemas de Ecuaciones");
            subSistemas.DropDownItems.Add("Eliminación Gaussiana", null, (s, e) => new Eliminacion_Gaussiana().Show());
            subSistemas.DropDownItems.Add("Estrategias de Pivoteo (P/E/T)", null, (s, e) => new Met_Pivoteo().Show());
            subSistemas.DropDownItems.Add("PLU", null, (s, e) => new FrmPLU().Show());
            subSistemas.DropDownItems.Add("LU",null,(s,e) => new FrmFactorizacionLU().Show());
            subSistemas.DropDownItems.Add("Factorización LU (Ax=B)", null, (s, e) => new FrmFactorizacionLU().Show());
            
            var subEDO = new ToolStripMenuItem("Ecuaciones Diferenciales");
            subEDO.DropDownItems.Add("Euler (Taylor 1)", null, (s, e) => new Formula_Taylor_1().Show());

            
            var subTaylor = new ToolStripMenuItem("Series de Taylor ");
            subTaylor.DropDownItems.Add("Orden 2", null, (s, e) => new Formula_Taylor_2().Show());
            subTaylor.DropDownItems.Add("Orden 3", null, (s, e) => new Formula_Taylor_3().Show());
            subTaylor.DropDownItems.Add("Orden 4", null, (s, e) => new Formulario_Taylor_4().Show());
            subTaylor.DropDownItems.Add("Orden 5", null, (s, e) => new Formula_Taylor_5().Show());
            subEDO.DropDownItems.Add(subTaylor);

            subEDO.DropDownItems.Add("Runge-Kutta 3-4", null, (s, e) => new FrmRK().Show());
            subEDO.DropDownItems.Add("RK-Fehlberg (4-5)", null, (s, e) => new FrmRKFehlberg().Show());
            subEDO.DropDownItems.Add("Adams Bashforth / Moulton", null, (s, e) => new FrmAdams().Show());
            subEDO.DropDownItems.Add("Sistemas de EDO RK-4", null, (s, e) => new SistemasEDO().Show());

            m3.DropDownItems.AddRange(new ToolStripItem[] { subSistemas, subEDO });

            ms.Items.AddRange(new ToolStripItem[] { m1, m2, m3 });
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);
        }
    }
}