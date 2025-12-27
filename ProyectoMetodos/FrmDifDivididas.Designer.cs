namespace ProyectoMetodos
{
    partial class FrmDifDivididas
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPuntosX = new System.Windows.Forms.TextBox();
            this.txtPuntosY = new System.Windows.Forms.TextBox();
            this.txtValorAInterpolar = new System.Windows.Forms.TextBox();
            this.btnCalcularNewton = new System.Windows.Forms.Button();
            this.dgvTablaDiferencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDiferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPuntosX
            // 
            this.txtPuntosX.Location = new System.Drawing.Point(89, 103);
            this.txtPuntosX.Name = "txtPuntosX";
            this.txtPuntosX.Size = new System.Drawing.Size(100, 20);
            this.txtPuntosX.TabIndex = 0;
            // 
            // txtPuntosY
            // 
            this.txtPuntosY.Location = new System.Drawing.Point(251, 103);
            this.txtPuntosY.Name = "txtPuntosY";
            this.txtPuntosY.Size = new System.Drawing.Size(100, 20);
            this.txtPuntosY.TabIndex = 1;
            // 
            // txtValorAInterpolar
            // 
            this.txtValorAInterpolar.Location = new System.Drawing.Point(466, 102);
            this.txtValorAInterpolar.Name = "txtValorAInterpolar";
            this.txtValorAInterpolar.Size = new System.Drawing.Size(100, 20);
            this.txtValorAInterpolar.TabIndex = 2;
            // 
            // btnCalcularNewton
            // 
            this.btnCalcularNewton.Location = new System.Drawing.Point(55, 161);
            this.btnCalcularNewton.Name = "btnCalcularNewton";
            this.btnCalcularNewton.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularNewton.TabIndex = 3;
            this.btnCalcularNewton.Text = "CALCULAR";
            this.btnCalcularNewton.UseVisualStyleBackColor = true;
            this.btnCalcularNewton.Click += new System.EventHandler(this.btnCalcularNewton_Click_1);
            // 
            // dgvTablaDiferencias
            // 
            this.dgvTablaDiferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaDiferencias.Location = new System.Drawing.Point(89, 215);
            this.dgvTablaDiferencias.Name = "dgvTablaDiferencias";
            this.dgvTablaDiferencias.Size = new System.Drawing.Size(506, 241);
            this.dgvTablaDiferencias.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valores de x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valores de y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor a interpolar";
            // 
            // FrmDifDivididas
            // 
            this.ClientSize = new System.Drawing.Size(641, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTablaDiferencias);
            this.Controls.Add(this.btnCalcularNewton);
            this.Controls.Add(this.txtValorAInterpolar);
            this.Controls.Add(this.txtPuntosY);
            this.Controls.Add(this.txtPuntosX);
            this.Name = "FrmDifDivididas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDiferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuntosX;
        private System.Windows.Forms.TextBox txtPuntosY;
        private System.Windows.Forms.TextBox txtValorAInterpolar;
        private System.Windows.Forms.Button btnCalcularNewton;
        private System.Windows.Forms.DataGridView dgvTablaDiferencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}