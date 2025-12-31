namespace ProyectoMetodos
{
    partial class FrmDerivadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle styleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvDerivadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(80, 20);
            this.lblTitulo.Text = "DERIVACION NUMERICA";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblX0.Location = new System.Drawing.Point(30, 75);
            this.lblX0.Text = "x inicial:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblH.Location = new System.Drawing.Point(160, 75);
            this.lblH.Text = "paso (h):";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblN.Location = new System.Drawing.Point(290, 75);
            this.lblN.Text = "iteraciones (n):";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(30, 95);
            this.txtX0.Size = new System.Drawing.Size(100, 20);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(160, 95);
            this.txtH.Size = new System.Drawing.Size(100, 20);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(290, 95);
            this.txtN.Size = new System.Drawing.Size(100, 20);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(420, 75);
            this.btnCalcular.Size = new System.Drawing.Size(120, 50);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvDerivadas
            // 
            this.dgvDerivadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDerivadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            styleHeader.BackColor = System.Drawing.Color.MidnightBlue;
            styleHeader.ForeColor = System.Drawing.Color.White;
            styleHeader.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDerivadas.ColumnHeadersDefaultCellStyle = styleHeader;
            this.dgvDerivadas.EnableHeadersVisualStyles = false;
            this.dgvDerivadas.Location = new System.Drawing.Point(30, 150);
            this.dgvDerivadas.Size = new System.Drawing.Size(700, 300);
            this.dgvDerivadas.RowHeadersVisible = false;
            this.dgvDerivadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDerivadas.Columns.Add("xi", "xi");
            this.dgvDerivadas.Columns.Add("fi", "f(xi)");
            this.dgvDerivadas.Columns.Add("d2", "Derivada 2 pts");
            this.dgvDerivadas.Columns.Add("d3", "Derivada 3 pts");
            this.dgvDerivadas.Columns.Add("d5", "Derivada 5 pts");
            this.dgvDerivadas.Columns.Add("dExacta", "Derivada Exacta");
            // 
            // FrmDerivadas
            // 
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvDerivadas);
            this.Name = "FrmDerivadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derivación Numérica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo, lblX0, lblH, lblN;
        private System.Windows.Forms.TextBox txtX0, txtH, txtN;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvDerivadas;
    }
}
