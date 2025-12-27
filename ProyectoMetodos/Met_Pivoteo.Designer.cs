namespace ProyectoMetodos
{
    partial class Met_Pivoteo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.cmbTipoPivoteo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblOrden = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();

            this.labelN.Text = "Tamaño (n):";
            this.labelN.Location = new System.Drawing.Point(20, 20);
            this.labelN.AutoSize = true;

            this.txtN.Location = new System.Drawing.Point(100, 18);
            this.txtN.Size = new System.Drawing.Size(50, 25);
            this.txtN.Text = "3";

            this.btnGenerar.Text = "Generar Matriz";
            this.btnGenerar.Location = new System.Drawing.Point(160, 16);
            this.btnGenerar.Size = new System.Drawing.Size(120, 30);
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            this.dgvMatriz.Location = new System.Drawing.Point(20, 60);
            this.dgvMatriz.Size = new System.Drawing.Size(450, 150);
            this.dgvMatriz.AllowUserToAddRows = false;

            this.cmbTipoPivoteo.Location = new System.Drawing.Point(480, 60);
            this.cmbTipoPivoteo.Size = new System.Drawing.Size(150, 25);
            this.cmbTipoPivoteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnCalcular.Text = "Aplicar Pivoteo";
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.Location = new System.Drawing.Point(480, 100);
            this.btnCalcular.Size = new System.Drawing.Size(150, 35);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.dgvResultado.Location = new System.Drawing.Point(20, 230);
            this.dgvResultado.Size = new System.Drawing.Size(450, 150);
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.ReadOnly = true;

            this.lblOrden.Location = new System.Drawing.Point(20, 400);
            
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Text = " Pivoteo";
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.cmbTipoPivoteo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.lblOrden);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnGenerar, btnCalcular;
        private System.Windows.Forms.DataGridView dgvMatriz, dgvResultado;
        private System.Windows.Forms.ComboBox cmbTipoPivoteo;
        private System.Windows.Forms.Label lblOrden, labelN;
    }
}