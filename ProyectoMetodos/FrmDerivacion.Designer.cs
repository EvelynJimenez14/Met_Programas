namespace ProyectoMetodos
{
    partial class Derivacion
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
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Location = new System.Drawing.Point(30, 30);
            this.cmbMetodo.Size = new System.Drawing.Size(250, 24);
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);

            
            this.lblX0.Text = "Punto x0:"; this.lblX0.Location = new System.Drawing.Point(30, 70);
            this.txtX0.Location = new System.Drawing.Point(30, 90); this.txtX0.Size = new System.Drawing.Size(80, 22);

            this.lblH.Text = "Paso (h):"; this.lblH.Location = new System.Drawing.Point(130, 70);
            this.txtH.Location = new System.Drawing.Point(130, 90); this.txtH.Size = new System.Drawing.Size(80, 22);

            
            this.lblY0.Text = "y0:"; this.lblY0.Location = new System.Drawing.Point(130, 70); this.lblY0.Visible = false;
            this.txtY0.Location = new System.Drawing.Point(130, 90); this.txtY0.Size = new System.Drawing.Size(80, 22); this.txtY0.Visible = false;

            this.lblX1.Text = "x1:"; this.lblX1.Location = new System.Drawing.Point(30, 130); this.lblX1.Visible = false;
            this.txtX1.Location = new System.Drawing.Point(30, 150); this.txtX1.Size = new System.Drawing.Size(80, 22); this.txtX1.Visible = false;

            this.lblY1.Text = "y1:"; this.lblY1.Location = new System.Drawing.Point(130, 130); this.lblY1.Visible = false;
            this.txtY1.Location = new System.Drawing.Point(130, 150); this.txtY1.Size = new System.Drawing.Size(80, 22); this.txtY1.Visible = false;

            
            this.btnCalcular.Text = "Calcular Derivada";
            this.btnCalcular.Location = new System.Drawing.Point(30, 200);
            this.btnCalcular.Size = new System.Drawing.Size(180, 35);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            
            this.lblResultado.Text = "Resultado: ";
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(30, 250);
            this.lblResultado.Size = new System.Drawing.Size(300, 30);

            
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.cmbMetodo, this.txtX0, this.txtH, this.txtY0, this.txtX1, this.txtY1,
                this.lblX0, this.lblH, this.lblY0, this.lblX1, this.lblY1, this.btnCalcular, this.lblResultado
            });
            this.Name = "Derivacion";
            this.Text = "Cálculo de Derivadas Numéricas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.TextBox txtX0, txtH, txtY0, txtX1, txtY1;
        private System.Windows.Forms.Label lblX0, lblH, lblY0, lblX1, lblY1, lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}