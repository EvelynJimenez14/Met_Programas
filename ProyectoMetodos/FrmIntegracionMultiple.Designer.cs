namespace ProyectoMetodos
{
    partial class FrmIntegracionMultiple
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbTrapecio = new System.Windows.Forms.RadioButton();
            this.rbSimpson = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.txtA.Location = new System.Drawing.Point(30, 50); this.txtA.Size = new System.Drawing.Size(50, 22);
            this.txtB.Location = new System.Drawing.Point(90, 50); this.txtB.Size = new System.Drawing.Size(50, 22);
            this.txtC.Location = new System.Drawing.Point(30, 100); this.txtC.Size = new System.Drawing.Size(50, 22);
            this.txtD.Location = new System.Drawing.Point(90, 100); this.txtD.Size = new System.Drawing.Size(50, 22);
            
            this.txtN.Location = new System.Drawing.Point(160, 50); this.txtN.Size = new System.Drawing.Size(40, 22);
            this.txtM.Location = new System.Drawing.Point(160, 100); this.txtM.Size = new System.Drawing.Size(40, 22);
             
            this.rbTrapecio.Location = new System.Drawing.Point(30, 140); this.rbTrapecio.Text = "Trapecio";
            this.rbSimpson.Location = new System.Drawing.Point(160, 140); this.rbSimpson.Text = "Simpson 1/3 ";
            
            this.btnCalcular.Location = new System.Drawing.Point(30, 180); this.btnCalcular.Size = new System.Drawing.Size(170, 40);
            this.btnCalcular.Text = "Integrar ";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            
            this.lblResultado.Location = new System.Drawing.Point(30, 240);
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Size = new System.Drawing.Size(300, 30);
           
            this.label1.Text = "Límites X (a, b) y n:"; this.label1.Location = new System.Drawing.Point(30, 30);
            this.label2.Text = "Límites Y (c, d) y m:"; this.label2.Location = new System.Drawing.Point(30, 80);
            
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtA, this.txtB, this.txtC, this.txtD, this.txtN, this.txtM, this.btnCalcular, this.rbTrapecio, this.rbSimpson, this.lblResultado, this.label1, this.label2 });
            this.Text = "Integración Múltiple ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtA, txtB, txtC, txtD, txtN, txtM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbTrapecio, rbSimpson;
        private System.Windows.Forms.Label lblResultado, label1, label2;
    }
}