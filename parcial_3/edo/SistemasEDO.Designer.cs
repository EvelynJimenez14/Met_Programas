namespace ProyectoMetodos
{
    partial class SistemasEDO
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(50, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1100, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMAS DE ECUACIONES DIFERENCIALES (RK4)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSistemas
            // 
            this.dgvSistemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSistemas.BackgroundColor = System.Drawing.Color.White;
            this.dgvSistemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvSistemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSistemas.EnableHeadersVisualStyles = false;
            this.dgvSistemas.Location = new System.Drawing.Point(30, 130);
            this.dgvSistemas.Name = "dgvSistemas";
            this.dgvSistemas.RowHeadersVisible = false;
            this.dgvSistemas.Size = new System.Drawing.Size(1140, 480);
            this.dgvSistemas.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(850, 60);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 50);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "EJECUTAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtT0
            // 
            this.txtT0.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtT0.Location = new System.Drawing.Point(50, 80);
            this.txtT0.Size = new System.Drawing.Size(70, 27);
            // 
            // lblT0
            // 
            this.lblT0.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblT0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblT0.Location = new System.Drawing.Point(50, 55);
            this.lblT0.Text = "t0";
            // 
            // txtU0
            // 
            this.txtU0.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtU0.Location = new System.Drawing.Point(140, 80);
            this.txtU0.Size = new System.Drawing.Size(70, 27);
            // 
            // lblU0
            // 
            this.lblU0.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblU0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblU0.Location = new System.Drawing.Point(140, 55);
            this.lblU0.Text = "u0";
            // 
            // txtV0
            // 
            this.txtV0.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtV0.Location = new System.Drawing.Point(230, 80);
            this.txtV0.Size = new System.Drawing.Size(70, 27);
            // 
            // lblV0
            // 
            this.lblV0.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblV0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblV0.Location = new System.Drawing.Point(230, 55);
            this.lblV0.Text = "v0";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtH.Location = new System.Drawing.Point(320, 80);
            this.txtH.Size = new System.Drawing.Size(70, 27);
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblH.Location = new System.Drawing.Point(320, 55);
            this.lblH.Text = "h";
            // 
            // txtTMax
            // 
            this.txtTMax.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtTMax.Location = new System.Drawing.Point(410, 80);
            this.txtTMax.Size = new System.Drawing.Size(70, 27);
            // 
            // lblTMax
            // 
            this.lblTMax.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblTMax.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTMax.Location = new System.Drawing.Point(410, 55);
            this.lblTMax.Text = "t Final";
           
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvSistemas);
            this.Controls.Add(this.txtTMax);
            this.Controls.Add(this.lblTMax);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtV0);
            this.Controls.Add(this.lblV0);
            this.Controls.Add(this.txtU0);
            this.Controls.Add(this.lblU0);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.lblT0);
            this.Name = "Rugen_Kutta_4_SEDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas EDO ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }



        private System.Windows.Forms.DataGridView dgvSistemas;
        private System.Windows.Forms.TextBox txtT0, txtU0, txtV0, txtH, txtTMax;
        private System.Windows.Forms.Label lblT0, lblU0, lblV0, lblH, lblTMax, lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
    }
}