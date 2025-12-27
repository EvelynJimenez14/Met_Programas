namespace ProyectoMetodos
{
    partial class FrmLU
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvL = new System.Windows.Forms.DataGridView();
            this.dgvU = new System.Windows.Forms.DataGridView();
            this.numTamano = new System.Windows.Forms.NumericUpDown();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            // Configuración del Formulario Principal
            this.Text = "Factorización LU Simple - ESCOM";
            this.Size = new System.Drawing.Size(950, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Panel Superior: Configuración de tamaño
            this.numTamano.Location = new System.Drawing.Point(30, 25);
            this.numTamano.Minimum = 2;
            this.numTamano.Value = 3;

            this.btnAjustar.Text = "Cambiar Tamaño";
            this.btnAjustar.Location = new System.Drawing.Point(150, 22);
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);

            this.btnCalcular.Text = "CALCULAR LU";
            this.btnCalcular.Location = new System.Drawing.Point(300, 20);
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // Matriz A (Entrada) - Posición Superior
            this.dgvA.Location = new System.Drawing.Point(30, 80);
            this.dgvA.Size = new System.Drawing.Size(450, 220);

            // Matriz L (Resultado) - Posición Inferior Izquierda
            this.dgvL.Location = new System.Drawing.Point(30, 350);
            this.dgvL.Size = new System.Drawing.Size(430, 220);

            // Matriz U (Resultado) - Posición Inferior Derecha
            this.dgvU.Location = new System.Drawing.Point(480, 350);
            this.dgvU.Size = new System.Drawing.Size(430, 220);

            this.lblStatus.Location = new System.Drawing.Point(30, 580);
            this.lblStatus.Size = new System.Drawing.Size(400, 20);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvA, this.dgvL, this.dgvU, this.numTamano, this.btnAjustar, this.btnCalcular, this.lblStatus
            });
        }

        private System.Windows.Forms.DataGridView dgvA, dgvL, dgvU;
        private System.Windows.Forms.NumericUpDown numTamano;
        private System.Windows.Forms.Button btnAjustar, btnCalcular;
        private System.Windows.Forms.Label lblStatus;
    }
}