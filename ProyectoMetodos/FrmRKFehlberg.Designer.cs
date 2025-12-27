namespace ProyectoMetodos
{
    partial class FrmRKFehlberg
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularRK = new System.Windows.Forms.Button();
            this.txtX0RK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtY0RK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHRK = new System.Windows.Forms.TextBox();
            this.dgvTablaRK = new System.Windows.Forms.DataGridView();
            this.IterRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X0RK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y0RK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRK)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X0";
            // 
            // btnCalcularRK
            // 
            this.btnCalcularRK.Location = new System.Drawing.Point(94, 109);
            this.btnCalcularRK.Name = "btnCalcularRK";
            this.btnCalcularRK.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularRK.TabIndex = 1;
            this.btnCalcularRK.Text = "CALCULAR";
            this.btnCalcularRK.UseVisualStyleBackColor = true;
            this.btnCalcularRK.Click += new System.EventHandler(this.btnCalcularRK_Click);
            // 
            // txtX0RK
            // 
            this.txtX0RK.Location = new System.Drawing.Point(32, 40);
            this.txtX0RK.Name = "txtX0RK";
            this.txtX0RK.Size = new System.Drawing.Size(100, 20);
            this.txtX0RK.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y0";
            // 
            // txtY0RK
            // 
            this.txtY0RK.Location = new System.Drawing.Point(190, 40);
            this.txtY0RK.Name = "txtY0RK";
            this.txtY0RK.Size = new System.Drawing.Size(100, 20);
            this.txtY0RK.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "h";
            // 
            // txtHRK
            // 
            this.txtHRK.Location = new System.Drawing.Point(330, 40);
            this.txtHRK.Name = "txtHRK";
            this.txtHRK.Size = new System.Drawing.Size(100, 20);
            this.txtHRK.TabIndex = 6;
            // 
            // dgvTablaRK
            // 
            this.dgvTablaRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaRK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IterRK,
            this.X0RK,
            this.Y0RK,
            this.hRK,
            this.ErrorRK});
            this.dgvTablaRK.Location = new System.Drawing.Point(63, 164);
            this.dgvTablaRK.Name = "dgvTablaRK";
            this.dgvTablaRK.Size = new System.Drawing.Size(542, 256);
            this.dgvTablaRK.TabIndex = 7;
            // 
            // IterRK
            // 
            this.IterRK.HeaderText = "Iter";
            this.IterRK.Name = "IterRK";
            // 
            // X0RK
            // 
            this.X0RK.HeaderText = "X0";
            this.X0RK.Name = "X0RK";
            // 
            // Y0RK
            // 
            this.Y0RK.HeaderText = "Y0";
            this.Y0RK.Name = "Y0RK";
            // 
            // hRK
            // 
            this.hRK.HeaderText = "h";
            this.hRK.Name = "hRK";
            // 
            // ErrorRK
            // 
            this.ErrorRK.HeaderText = "Error";
            this.ErrorRK.Name = "ErrorRK";
            // 
            // FrmRKFehlberg
            // 
            this.ClientSize = new System.Drawing.Size(710, 481);
            this.Controls.Add(this.dgvTablaRK);
            this.Controls.Add(this.txtHRK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtY0RK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX0RK);
            this.Controls.Add(this.btnCalcularRK);
            this.Controls.Add(this.label3);
            this.Name = "FrmRKFehlberg";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularRK;
        private System.Windows.Forms.TextBox txtX0RK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY0RK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHRK;
        private System.Windows.Forms.DataGridView dgvTablaRK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IterRK;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0RK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y0RK;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorRK;
    }
}