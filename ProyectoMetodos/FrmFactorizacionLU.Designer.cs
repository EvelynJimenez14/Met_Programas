namespace ProyectoMetodos
{
    partial class FrmFactorizacionLU
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvL = new System.Windows.Forms.DataGridView();
            this.dgvU = new System.Windows.Forms.DataGridView();
            this.btnResolver = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtN.Location = new System.Drawing.Point(20, 20); this.txtN.Size = new System.Drawing.Size(50, 25); this.txtN.Text = "3";
            this.btnGenerar.Text = "Generar"; this.btnGenerar.Location = new System.Drawing.Point(80, 18); this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            this.dgvA.Location = new System.Drawing.Point(20, 60); this.dgvA.Size = new System.Drawing.Size(250, 150);
            this.dgvB.Location = new System.Drawing.Point(280, 60); this.dgvB.Size = new System.Drawing.Size(60, 150);

            this.btnResolver.Text = "Resolver Ax=B (LU)"; this.btnResolver.Location = new System.Drawing.Point(360, 60); this.btnResolver.Size = new System.Drawing.Size(120, 40); this.btnResolver.BackColor = System.Drawing.Color.LightGreen; this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);

            this.dgvL.Location = new System.Drawing.Point(20, 230); this.dgvL.Size = new System.Drawing.Size(220, 130);
            this.dgvU.Location = new System.Drawing.Point(260, 230); this.dgvU.Size = new System.Drawing.Size(220, 130);

            this.lblResultado.Location = new System.Drawing.Point(20, 380); this.lblResultado.AutoSize = true; this.lblResultado.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Text = "Factorización LU - Ax = B";
            this.Controls.AddRange(new System.Windows.Forms.Control[] { txtN, btnGenerar, dgvA, dgvB, btnResolver, dgvL, dgvU, lblResultado });
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnGenerar, btnResolver;
        private System.Windows.Forms.DataGridView dgvA, dgvB, dgvL, dgvU;
        private System.Windows.Forms.Label lblResultado;
    }
}