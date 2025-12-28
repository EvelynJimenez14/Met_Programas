namespace ProyectoMetodos
{
    partial class FrmFactorizacionLU
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(20, 20);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(50, 22);
            this.txtN.Text = "3";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(80, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvA
            // 
            this.dgvA.Location = new System.Drawing.Point(20, 60);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(220, 150);
            this.dgvA.BackgroundColor = System.Drawing.Color.White;
            // 
            // dgvB
            // 
            this.dgvB.Location = new System.Drawing.Point(250, 60);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(60, 150);
            this.dgvB.BackgroundColor = System.Drawing.Color.LightGray;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.LightGreen;
            this.btnResolver.Location = new System.Drawing.Point(330, 60);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(120, 40);
            this.btnResolver.Text = "Resolver LU";
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // dgvL
            // 
            this.dgvL.Location = new System.Drawing.Point(20, 230);
            this.dgvL.Name = "dgvL";
            this.dgvL.Size = new System.Drawing.Size(220, 130);
            // 
            // dgvU
            // 
            this.dgvU.Location = new System.Drawing.Point(250, 230);
            this.dgvU.Name = "dgvU";
            this.dgvU.Size = new System.Drawing.Size(220, 130);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(20, 380);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Text = "X = []";
            // 
            // FrmFactorizacionLU
            // 
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.dgvU);
            this.Controls.Add(this.dgvL);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtN);
            this.Name = "FrmFactorizacionLU";
            this.Text = "Factorización LU ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvL;
        private System.Windows.Forms.DataGridView dgvU;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Label lblResultado;
    }
}