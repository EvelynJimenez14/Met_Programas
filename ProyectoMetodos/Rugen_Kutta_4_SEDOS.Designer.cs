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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSistemas
            // 
            this.dgvSistemas.Location = new System.Drawing.Point(20, 90);
            this.dgvSistemas.Name = "dgvSistemas";
            this.dgvSistemas.ReadOnly = true;
            this.dgvSistemas.Size = new System.Drawing.Size(840, 450);
            this.dgvSistemas.TabIndex = 0;
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(20, 40);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(70, 20);
            this.txtT0.TabIndex = 1;
            // 
            // txtU0
            // 
            this.txtU0.Location = new System.Drawing.Point(110, 40);
            this.txtU0.Name = "txtU0";
            this.txtU0.Size = new System.Drawing.Size(70, 20);
            this.txtU0.TabIndex = 2;
            // 
            // txtV0
            // 
            this.txtV0.Location = new System.Drawing.Point(200, 40);
            this.txtV0.Name = "txtV0";
            this.txtV0.Size = new System.Drawing.Size(70, 20);
            this.txtV0.TabIndex = 3;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(290, 40);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(70, 20);
            this.txtH.TabIndex = 4;
            // 
            // txtTMax
            // 
            this.txtTMax.Location = new System.Drawing.Point(380, 40);
            this.txtTMax.Name = "txtTMax";
            this.txtTMax.Size = new System.Drawing.Size(70, 20);
            this.txtTMax.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(480, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular Sistema";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblT0
            // 
            this.lblT0.Location = new System.Drawing.Point(20, 20);
            this.lblT0.Name = "lblT0";
            this.lblT0.Size = new System.Drawing.Size(56, 23);
            this.lblT0.TabIndex = 6;
            this.lblT0.Text = "t Inicial:";
            // 
            // lblU0
            // 
            this.lblU0.Location = new System.Drawing.Point(110, 20);
            this.lblU0.Name = "lblU0";
            this.lblU0.Size = new System.Drawing.Size(70, 23);
            this.lblU0.TabIndex = 7;
            this.lblU0.Text = "u(t0):";
            // 
            // lblV0
            // 
            this.lblV0.Location = new System.Drawing.Point(200, 20);
            this.lblV0.Name = "lblV0";
            this.lblV0.Size = new System.Drawing.Size(51, 23);
            this.lblV0.TabIndex = 8;
            this.lblV0.Text = "v(t0):";
            // 
            // lblH
            // 
            this.lblH.Location = new System.Drawing.Point(290, 20);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(100, 23);
            this.lblH.TabIndex = 9;
            this.lblH.Text = "Paso h:";
            // 
            // lblTMax
            // 
            this.lblTMax.Location = new System.Drawing.Point(380, 20);
            this.lblTMax.Name = "lblTMax";
            this.lblTMax.Size = new System.Drawing.Size(100, 23);
            this.lblTMax.TabIndex = 10;
            this.lblTMax.Text = "t Máximo:";
            // 
            // Rugen_Kutta_4_SEDOS
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvSistemas);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.txtU0);
            this.Controls.Add(this.txtV0);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtTMax);
            this.Controls.Add(this.lblT0);
            this.Controls.Add(this.lblU0);
            this.Controls.Add(this.lblV0);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblTMax);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Rugen_Kutta_4_SEDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas EDO - RK4 ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvSistemas;
        private System.Windows.Forms.TextBox txtT0, txtU0, txtV0, txtH, txtTMax;
        private System.Windows.Forms.Label lblT0, lblU0, lblV0, lblH, lblTMax;
        private System.Windows.Forms.Button btnCalcular;
    }
}