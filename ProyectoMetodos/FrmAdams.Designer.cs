namespace ProyectoMetodos
{
    partial class FrmAdams
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstPasos = new System.Windows.Forms.ListBox();
            this.grpMetodo = new System.Windows.Forms.GroupBox();
            this.rbMoulton = new System.Windows.Forms.RadioButton();
            this.rbBashforth = new System.Windows.Forms.RadioButton();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.grpMetodo.SuspendLayout();
            this.SuspendLayout();
            
            this.txtX0.Location = new System.Drawing.Point(30, 40);
            this.txtY0.Location = new System.Drawing.Point(90, 40);
            this.txtH.Location = new System.Drawing.Point(150, 40);
            this.txtN.Location = new System.Drawing.Point(210, 40);
            
            this.grpMetodo.Controls.Add(this.rbMoulton);
            this.grpMetodo.Controls.Add(this.rbBashforth);
            this.grpMetodo.Location = new System.Drawing.Point(30, 80);
            this.grpMetodo.Size = new System.Drawing.Size(320, 60);
            this.grpMetodo.Text = "Seleccione la variante de Adams";
             
            this.rbBashforth.Location = new System.Drawing.Point(15, 25);
            this.rbBashforth.Text = "Adams-Bashforth (B)";
            this.rbBashforth.Checked = true;
             
            this.rbMoulton.Location = new System.Drawing.Point(170, 25);
            this.rbMoulton.Text = "Adams-Moulton (M)";
            
            this.btnCalcular.Location = new System.Drawing.Point(30, 150);
            this.btnCalcular.Size = new System.Drawing.Size(320, 35);
            this.btnCalcular.Text = "Ejecutar Método de Adams";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            
            this.lstPasos.Location = new System.Drawing.Point(30, 200);
            this.lstPasos.Size = new System.Drawing.Size(320, 180);
             
            this.lblX0.Text = "x0"; this.lblX0.Location = new System.Drawing.Point(30, 20);
            this.lblY0.Text = "y0"; this.lblY0.Location = new System.Drawing.Point(90, 20);
            this.lblH.Text = "h"; this.lblH.Location = new System.Drawing.Point(150, 20);
            this.lblN.Text = "Pasos"; this.lblN.Location = new System.Drawing.Point(210, 20);
            
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.lblX0); this.Controls.Add(this.lblY0);
            this.Controls.Add(this.lblH); this.Controls.Add(this.lblN);
            this.Controls.Add(this.lstPasos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpMetodo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Name = "FrmAdams";
            this.Text = "Adams B/M";
            this.grpMetodo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtX0, txtY0, txtH, txtN;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstPasos;
        private System.Windows.Forms.GroupBox grpMetodo;
        private System.Windows.Forms.RadioButton rbMoulton, rbBashforth;
        private System.Windows.Forms.Label lblX0, lblY0, lblH, lblN;
    }
}