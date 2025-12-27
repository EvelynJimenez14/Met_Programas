namespace ProyectoMetodos
{
    partial class FrmRK
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblXMax = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbRK3 = new System.Windows.Forms.RadioButton();
            this.rbRK4 = new System.Windows.Forms.RadioButton();

            this.Text = "Runge-Kutta 3 y 4 ";
            this.Size = new System.Drawing.Size(850, 600);

            
            this.lblX0.Text = "X inicial (x0):"; this.lblX0.Location = new System.Drawing.Point(30, 20);
            this.txtX0.Location = new System.Drawing.Point(30, 40); this.txtX0.Size = new System.Drawing.Size(80, 25);

            this.lblY0.Text = "Y inicial (y0):"; this.lblY0.Location = new System.Drawing.Point(130, 20);
            this.txtY0.Location = new System.Drawing.Point(130, 40); this.txtY0.Size = new System.Drawing.Size(80, 25);

            this.lblH.Text = "Paso (h):"; this.lblH.Location = new System.Drawing.Point(230, 20);
            this.txtH.Location = new System.Drawing.Point(230, 40); this.txtH.Size = new System.Drawing.Size(80, 25);

            this.lblXMax.Text = "X final (Límite):"; this.lblXMax.Location = new System.Drawing.Point(330, 20);
            this.txtXMax.Location = new System.Drawing.Point(330, 40); this.txtXMax.Size = new System.Drawing.Size(80, 25);

            
            this.rbRK3.Text = "Runge-Kutta 3"; this.rbRK3.Location = new System.Drawing.Point(450, 20);
            this.rbRK4.Text = "Runge-Kutta 4"; this.rbRK4.Location = new System.Drawing.Point(450, 45); this.rbRK4.Checked = true;

            this.btnCalcular.Text = "Calcular"; this.btnCalcular.Location = new System.Drawing.Point(600, 30);
            this.btnCalcular.Size = new System.Drawing.Size(120, 40);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.dgvResultados.Location = new System.Drawing.Point(30, 100);
            this.dgvResultados.Size = new System.Drawing.Size(770, 430);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvResultados, this.txtX0, this.txtY0, this.txtH, this.txtXMax,
                this.lblX0, this.lblY0, this.lblH, this.lblXMax, this.btnCalcular, this.rbRK3, this.rbRK4
            });
        }

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtX0, txtY0, txtH, txtXMax;
        private System.Windows.Forms.Label lblX0, lblY0, lblH, lblXMax;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbRK3, rbRK4;
    }
}