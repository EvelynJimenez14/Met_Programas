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
            this.labelL = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamano)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.Location = new System.Drawing.Point(30, 125);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(400, 180);
            this.dgvA.TabIndex = 0;
            // 
            // dgvL
            // 
            this.dgvL.Location = new System.Drawing.Point(30, 345);
            this.dgvL.Name = "dgvL";
            this.dgvL.Size = new System.Drawing.Size(280, 180);
            this.dgvL.TabIndex = 1;
            // 
            // dgvU
            // 
            this.dgvU.Location = new System.Drawing.Point(340, 345);
            this.dgvU.Name = "dgvU";
            this.dgvU.Size = new System.Drawing.Size(280, 180);
            this.dgvU.TabIndex = 2;
            // 
            // dgvP
            // 
            this.dgvP.Location = new System.Drawing.Point(650, 345);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(280, 180);
            this.dgvP.TabIndex = 3;
            // 
            // numTamano
            // 
            this.numTamano.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.numTamano.Location = new System.Drawing.Point(30, 60);
            this.numTamano.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTamano.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTamano.Name = "numTamano";
            this.numTamano.Size = new System.Drawing.Size(120, 23);
            this.numTamano.TabIndex = 4;
            this.numTamano.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnAjustar
            // 
            this.btnAjustar.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjustar.Location = new System.Drawing.Point(160, 58);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(160, 30);
            this.btnAjustar.TabIndex = 5;
            this.btnAjustar.Text = "Ajustar Tamaño";
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(340, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR PLU";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(30, 540);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(900, 30);
            this.lblStatus.TabIndex = 7;
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.labelA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelA.Location = new System.Drawing.Point(30, 100);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(100, 23);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "Matriz Original (A):";
            // 
            // labelL
            // 
            this.labelL.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.labelL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelL.Location = new System.Drawing.Point(30, 320);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(280, 23);
            this.labelL.TabIndex = 9;
            this.labelL.Text = "Matriz Inferior (L):";
            // 
            // labelU
            // 
            this.labelU.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.labelU.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelU.Location = new System.Drawing.Point(340, 320);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(280, 23);
            this.labelU.TabIndex = 10;
            this.labelU.Text = "Matriz Superior (U):";
            // 
            // labelP
            // 
            this.labelP.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.labelP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelP.Location = new System.Drawing.Point(650, 320);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(280, 23);
            this.labelP.TabIndex = 11;
            this.labelP.Text = "Matriz Permutación (P):";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(250, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(297, 19);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "FACTORIZACION P A = L U";
            // 
            // FrmPLU
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.dgvL);
            this.Controls.Add(this.dgvU);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.numTamano);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelU);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FrmPLU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorización PLU ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvA, dgvL, dgvU, dgvP;
        private System.Windows.Forms.NumericUpDown numTamano;
        private System.Windows.Forms.Button btnAjustar, btnCalcular;
        private System.Windows.Forms.Label lblStatus, labelA, labelL, labelU, labelP, labelTitulo;
    }
}