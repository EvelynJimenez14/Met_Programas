namespace ProyectoMetodos
{
    partial class FrmNeville
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPuntosX = new System.Windows.Forms.TextBox();
            this.txtPuntosY = new System.Windows.Forms.TextBox();
            this.txtValorAInterpolar = new System.Windows.Forms.TextBox();
            this.btnCalcularNeville = new System.Windows.Forms.Button();
            this.dgvNeville = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeville)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(80, 20);
            this.lblTitulo.Text = "INTERPOLACION NEVILLE";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lblX.ForeColor = System.Drawing.Color.Black;
            this.lblX.Location = new System.Drawing.Point(30, 75);
            this.lblX.Text = "Puntos X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lblY.ForeColor = System.Drawing.Color.Black;
            this.lblY.Location = new System.Drawing.Point(30, 115);
            this.lblY.Text = "Puntos Y:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(30, 155);
            this.lblValor.Text = "Valor a interpolar:";
            // 
            // txtPuntosX
            // 
            this.txtPuntosX.Location = new System.Drawing.Point(150, 72);
            this.txtPuntosX.Size = new System.Drawing.Size(200, 20);
            // 
            // txtPuntosY
            // 
            this.txtPuntosY.Location = new System.Drawing.Point(150, 112);
            this.txtPuntosY.Size = new System.Drawing.Size(200, 20);
            // 
            // txtValorAInterpolar
            // 
            this.txtValorAInterpolar.Location = new System.Drawing.Point(150, 152);
            this.txtValorAInterpolar.Size = new System.Drawing.Size(200, 20);
            // 
            // btnCalcularNeville
            // 
            this.btnCalcularNeville.BackColor = System.Drawing.Color.Black;
            this.btnCalcularNeville.ForeColor = System.Drawing.Color.White;
            this.btnCalcularNeville.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalcularNeville.Location = new System.Drawing.Point(380, 100);
            this.btnCalcularNeville.Size = new System.Drawing.Size(120, 50);
            this.btnCalcularNeville.Text = "Calcular";
            this.btnCalcularNeville.UseVisualStyleBackColor = false;
            this.btnCalcularNeville.Click += new System.EventHandler(this.btnCalcularNeville_Click);
            // 
            // dgvNeville
            // 
            this.dgvNeville.BackgroundColor = System.Drawing.Color.White;
            this.dgvNeville.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            styleHeader.BackColor = System.Drawing.Color.Black;
            styleHeader.ForeColor = System.Drawing.Color.White;
            styleHeader.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.dgvNeville.ColumnHeadersDefaultCellStyle = styleHeader;
            this.dgvNeville.EnableHeadersVisualStyles = false;
            this.dgvNeville.Location = new System.Drawing.Point(30, 200);
            this.dgvNeville.Size = new System.Drawing.Size(600, 250);
            this.dgvNeville.RowHeadersVisible = false;
            this.dgvNeville.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // FrmNeville
            // 
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtPuntosX);
            this.Controls.Add(this.txtPuntosY);
            this.Controls.Add(this.txtValorAInterpolar);
            this.Controls.Add(this.btnCalcularNeville);
            this.Controls.Add(this.dgvNeville);
            this.Name = "FrmNeville";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neville";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeville)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtPuntosX;
        private System.Windows.Forms.TextBox txtPuntosY;
        private System.Windows.Forms.TextBox txtValorAInterpolar;
        private System.Windows.Forms.Button btnCalcularNeville;
        private System.Windows.Forms.DataGridView dgvNeville;
    }
}
