namespace ProyectoMetodos
{
    partial class Rugen_Kutta_4_SEDOS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSistemas = new System.Windows.Forms.DataGridView();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtU0 = new System.Windows.Forms.TextBox();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtTMax = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblT0 = new System.Windows.Forms.Label();
            this.lblU0 = new System.Windows.Forms.Label();
            this.lblV0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblTMax = new System.Windows.Forms.Label();

            // Configuración del Form
            this.Text = "Sistemas EDO - RK4 Profesional";
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Etiquetas (Labels)
            this.lblT0.Text = "t Inicial:"; this.lblT0.Location = new System.Drawing.Point(20, 20);
            this.lblU0.Text = "u(t0):"; this.lblU0.Location = new System.Drawing.Point(110, 20);
            this.lblV0.Text = "v(t0):"; this.lblV0.Location = new System.Drawing.Point(200, 20);
            this.lblH.Text = "Paso h:"; this.lblH.Location = new System.Drawing.Point(290, 20);
            this.lblTMax.Text = "t Máximo:"; this.lblTMax.Location = new System.Drawing.Point(380, 20);

            // Cajas de texto (TextBoxes)
            this.txtT0.Location = new System.Drawing.Point(20, 40); this.txtT0.Size = new System.Drawing.Size(70, 22);
            this.txtU0.Location = new System.Drawing.Point(110, 40); this.txtU0.Size = new System.Drawing.Size(70, 22);
            this.txtV0.Location = new System.Drawing.Point(200, 40); this.txtV0.Size = new System.Drawing.Size(70, 22);
            this.txtH.Location = new System.Drawing.Point(290, 40); this.txtH.Size = new System.Drawing.Size(70, 22);
            this.txtTMax.Location = new System.Drawing.Point(380, 40); this.txtTMax.Size = new System.Drawing.Size(70, 22);

            // Botón
            this.btnCalcular.Text = "Calcular Sistema";
            this.btnCalcular.Location = new System.Drawing.Point(480, 35);
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // DataGridView
            this.dgvSistemas.Location = new System.Drawing.Point(20, 90);
            this.dgvSistemas.Size = new System.Drawing.Size(840, 450);
            this.dgvSistemas.ReadOnly = true;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvSistemas, this.txtT0, this.txtU0, this.txtV0, this.txtH, this.txtTMax,
                this.lblT0, this.lblU0, this.lblV0, this.lblH, this.lblTMax, this.btnCalcular
            });
        }

        private System.Windows.Forms.DataGridView dgvSistemas;
        private System.Windows.Forms.TextBox txtT0, txtU0, txtV0, txtH, txtTMax;
        private System.Windows.Forms.Label lblT0, lblU0, lblV0, lblH, lblTMax;
        private System.Windows.Forms.Button btnCalcular;
    }
}