namespace ProyectoMetodos
{
    partial class FrmPLU
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
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.numTamano = new System.Windows.Forms.NumericUpDown();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();

            // Form principal
            this.Text = "Factorización PLU - ESCOM Ciencia de Datos";
            this.Size = new System.Drawing.Size(1000, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Controles de Configuración superiores
            this.numTamano.Location = new System.Drawing.Point(30, 20);
            this.numTamano.Value = 3;
            this.btnAjustar.Text = "Ajustar Tamaño";
            this.btnAjustar.Location = new System.Drawing.Point(150, 18);
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);

            this.btnCalcular.Text = "CALCULAR PLU";
            this.btnCalcular.Location = new System.Drawing.Point(300, 15);
            this.btnCalcular.Size = new System.Drawing.Size(150, 35);
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // Matriz A (Entrada)
            this.labelA.Text = "Matriz A:"; this.labelA.Location = new System.Drawing.Point(30, 70);
            this.dgvA.Location = new System.Drawing.Point(30, 90);
            this.dgvA.Size = new System.Drawing.Size(400, 200);

            // Matriz L
            this.dgvL.Location = new System.Drawing.Point(30, 350);
            this.dgvL.Size = new System.Drawing.Size(280, 200);

            // Matriz U
            this.dgvU.Location = new System.Drawing.Point(340, 350);
            this.dgvU.Size = new System.Drawing.Size(280, 200);

            // Matriz P
            this.dgvP.Location = new System.Drawing.Point(650, 350);
            this.dgvP.Size = new System.Drawing.Size(280, 200);

            this.lblStatus.Location = new System.Drawing.Point(30, 580);
            this.lblStatus.Size = new System.Drawing.Size(500, 30);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvA, this.dgvL, this.dgvU, this.dgvP,
                this.numTamano, this.btnAjustar, this.btnCalcular, this.lblStatus, this.labelA
            });
        }

        private System.Windows.Forms.DataGridView dgvA, dgvL, dgvU, dgvP;
        private System.Windows.Forms.NumericUpDown numTamano;
        private System.Windows.Forms.Button btnAjustar, btnCalcular;
        private System.Windows.Forms.Label lblStatus, labelA;
    }
}