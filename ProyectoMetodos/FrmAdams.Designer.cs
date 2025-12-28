namespace ProyectoMetodos
{
    partial class FrmAdams
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.grpMetodo = new System.Windows.Forms.GroupBox();
            this.rbMoulton = new System.Windows.Forms.RadioButton();
            this.rbBashforth = new System.Windows.Forms.RadioButton();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.grpMetodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1000, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "METODO MULTIPASO DE ADAMS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtX0
            // 
            this.txtX0.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtX0.Location = new System.Drawing.Point(50, 110);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(80, 27);
            this.txtX0.TabIndex = 1;
            // 
            // txtY0
            // 
            this.txtY0.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtY0.Location = new System.Drawing.Point(150, 110);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(80, 27);
            this.txtY0.TabIndex = 2;
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtH.Location = new System.Drawing.Point(250, 110);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(80, 27);
            this.txtH.TabIndex = 3;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.txtN.Location = new System.Drawing.Point(350, 110);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(80, 27);
            this.txtN.TabIndex = 4;
            // 
            // grpMetodo
            // 
            this.grpMetodo.Controls.Add(this.rbMoulton);
            this.grpMetodo.Controls.Add(this.rbBashforth);
            this.grpMetodo.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.grpMetodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpMetodo.Location = new System.Drawing.Point(460, 75);
            this.grpMetodo.Name = "grpMetodo";
            this.grpMetodo.Size = new System.Drawing.Size(300, 80);
            this.grpMetodo.TabIndex = 5;
            this.grpMetodo.TabStop = false;
            this.grpMetodo.Text = "Selección de Adams";
            // 
            // rbMoulton
            // 
            this.rbMoulton.Location = new System.Drawing.Point(150, 30);
            this.rbMoulton.Name = "rbMoulton";
            this.rbMoulton.Size = new System.Drawing.Size(120, 24);
            this.rbMoulton.TabIndex = 1;
            this.rbMoulton.Text = "Adams M";
            // 
            // rbBashforth
            // 
            this.rbBashforth.Checked = true;
            this.rbBashforth.Location = new System.Drawing.Point(20, 30);
            this.rbBashforth.Name = "rbBashforth";
            this.rbBashforth.Size = new System.Drawing.Size(120, 24);
            this.rbBashforth.TabIndex = 0;
            this.rbBashforth.TabStop = true;
            this.rbBashforth.Text = "Adams B";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(820, 85);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(230, 60);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeight = 35;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Location = new System.Drawing.Point(50, 180);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.Size = new System.Drawing.Size(1000, 450);
            this.dgvResultados.TabIndex = 7;
            // 
            // lblX0
            // 
            this.lblX0.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblX0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblX0.Location = new System.Drawing.Point(50, 85);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(80, 23);
            this.lblX0.TabIndex = 8;
            this.lblX0.Text = "x0";
            // 
            // lblY0
            // 
            this.lblY0.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblY0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblY0.Location = new System.Drawing.Point(150, 85);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(80, 23);
            this.lblY0.TabIndex = 9;
            this.lblY0.Text = "y0";
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblH.Location = new System.Drawing.Point(250, 85);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(80, 23);
            this.lblH.TabIndex = 10;
            this.lblH.Text = "h";
            // 
            // lblN
            // 
            this.lblN.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblN.Location = new System.Drawing.Point(350, 85);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(80, 23);
            this.lblN.TabIndex = 11;
            this.lblN.Text = "Pasos";
            // 
            // FrmAdams
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.lblY0);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpMetodo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Name = "FrmAdams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adams B/M ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.grpMetodo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtX0, txtY0, txtH, txtN;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox grpMetodo;
        private System.Windows.Forms.RadioButton rbMoulton, rbBashforth;
        private System.Windows.Forms.Label lblX0, lblY0, lblH, lblN, lblTitulo;
    }
}