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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            
            System.Drawing.Font fuenteEtiquetas = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fuenteTitulo = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);

            
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
            this.lblTitulo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();

            
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fuenteTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(220, 15);
            this.lblTitulo.Text = "METODOS DE RUNGE-KUTTA";

            
            this.lblX0.Text = "X inicial (x0):";
            this.lblX0.Font = fuenteEtiquetas;
            this.lblX0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblX0.Location = new System.Drawing.Point(30, 60);
            this.txtX0.Location = new System.Drawing.Point(30, 80);
            this.txtX0.Size = new System.Drawing.Size(90, 25);

            
            this.lblY0.Text = "Y inicial (y0):";
            this.lblY0.Font = fuenteEtiquetas;
            this.lblY0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblY0.Location = new System.Drawing.Point(140, 60);
            this.txtY0.Location = new System.Drawing.Point(140, 80);
            this.txtY0.Size = new System.Drawing.Size(90, 25);

            
            this.lblH.Text = "Paso (h):";
            this.lblH.Font = fuenteEtiquetas;
            this.lblH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblH.Location = new System.Drawing.Point(250, 60);
            this.txtH.Location = new System.Drawing.Point(250, 80);
            this.txtH.Size = new System.Drawing.Size(90, 25);

           
            this.lblXMax.Text = "X final:";
            this.lblXMax.Font = fuenteEtiquetas;
            this.lblXMax.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblXMax.Location = new System.Drawing.Point(360, 60);
            this.txtXMax.Location = new System.Drawing.Point(360, 80);
            this.txtXMax.Size = new System.Drawing.Size(90, 25);

            
            this.rbRK3.Text = "Orden 3";
            this.rbRK3.Font = fuenteEtiquetas;
            this.rbRK3.Location = new System.Drawing.Point(480, 65);
            this.rbRK4.Text = "Orden 4";
            this.rbRK4.Font = fuenteEtiquetas;
            this.rbRK4.Location = new System.Drawing.Point(480, 85);
            this.rbRK4.Checked = true;

            
            this.btnCalcular.Text = "RESOLVER";
            this.btnCalcular.Font = fuenteEtiquetas;
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(620, 65);
            this.btnCalcular.Size = new System.Drawing.Size(150, 45);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvResultados.Location = new System.Drawing.Point(30, 130);
            this.dgvResultados.Size = new System.Drawing.Size(770, 400);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResultados.EnableHeadersVisualStyles = false;

            
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.BackColor = System.Drawing.Color.Snow;
            this.Text = "Runge-Kutta 3 y 4 ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvResultados, this.txtX0, this.txtY0, this.txtH, this.txtXMax,
                this.lblX0, this.lblY0, this.lblH, this.lblXMax, this.btnCalcular,
                this.rbRK3, this.rbRK4, this.lblTitulo
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtX0, txtY0, txtH, txtXMax;
        private System.Windows.Forms.Label lblX0, lblY0, lblH, lblXMax, lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbRK3, rbRK4;
    }
}