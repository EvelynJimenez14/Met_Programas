namespace ProyectoMetodos
{
    partial class FrmNeville
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

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvNeville = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeville)).BeginInit();
            this.SuspendLayout();

            // Texto de las etiquetas
            this.label1.Text = "Valores de X (separados por comas):";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;

            this.label2.Text = "Valores de Y (f(x)):";
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.AutoSize = true;

            this.label3.Text = "Punto a evaluar (x):";
            this.label3.Location = new System.Drawing.Point(250, 115);
            this.label3.AutoSize = true;

            // Cajas de texto
            this.txtX.Location = new System.Drawing.Point(20, 40);
            this.txtX.Size = new System.Drawing.Size(300, 22);

            this.txtY.Location = new System.Drawing.Point(20, 90);
            this.txtY.Size = new System.Drawing.Size(300, 22);

            this.txtTarget.Location = new System.Drawing.Point(360, 112);
            this.txtTarget.Size = new System.Drawing.Size(60, 22);

            // Botón de calcular
            this.btnCalcular.Location = new System.Drawing.Point(20, 130);
            this.btnCalcular.Size = new System.Drawing.Size(100, 35);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // Tabla y texto de respuesta
            this.dgvNeville.Location = new System.Drawing.Point(20, 180);
            this.dgvNeville.Size = new System.Drawing.Size(500, 200);
            this.dgvNeville.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.lblResultado.Location = new System.Drawing.Point(140, 140);
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblResultado.AutoSize = true;

            // Configuración general del Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvNeville);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FrmNeville";
            this.Text = "Interpolación de Neville";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeville)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvNeville;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}