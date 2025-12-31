namespace ProyectoMetodos
{
    partial class Formula_Taylor_1
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
            // Definición de Estilos para Segundo Parcial (Azul Profesional)
            System.Drawing.Font fuenteGrande = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fuenteTitulo = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color azul = System.Drawing.Color.MidnightBlue;

            this.btxt = new System.Windows.Forms.TextBox();
            this.incrementotxt = new System.Windows.Forms.TextBox();
            this.xtxt = new System.Windows.Forms.TextBox();
            this.x0txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1 (Título Principal)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = fuenteTitulo;
            this.label1.ForeColor = azul;
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "FÓRMULA DE TAYLOR: ORDEN 1";
            // 
            // btxt
            // 
            this.btxt.Font = fuenteGrande;
            this.btxt.Location = new System.Drawing.Point(520, 120);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(100, 34);
            this.btxt.TabIndex = 50;
            // 
            // incrementotxt
            // 
            this.incrementotxt.Font = fuenteGrande;
            this.incrementotxt.Location = new System.Drawing.Point(520, 75);
            this.incrementotxt.Name = "incrementotxt";
            this.incrementotxt.Size = new System.Drawing.Size(100, 34);
            this.incrementotxt.TabIndex = 49;
            // 
            // xtxt
            // 
            this.xtxt.Font = fuenteGrande;
            this.xtxt.Location = new System.Drawing.Point(100, 120);
            this.xtxt.Name = "xtxt";
            this.xtxt.Size = new System.Drawing.Size(100, 34);
            this.xtxt.TabIndex = 48;
            // 
            // x0txt
            // 
            this.x0txt.Font = fuenteGrande;
            this.x0txt.Location = new System.Drawing.Point(100, 75);
            this.x0txt.Name = "x0txt";
            this.x0txt.Size = new System.Drawing.Size(100, 34);
            this.x0txt.TabIndex = 47;
            // 
            // label6 (Incremento)
            // 
            this.label6.AutoSize = true;
            this.label6.Font = fuenteGrande;
            this.label6.ForeColor = azul;
            this.label6.Location = new System.Drawing.Point(310, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 46;
            this.label6.Text = "Incremento para x:";
            // 
            // label5 (Valor máximo)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = fuenteGrande;
            this.label5.ForeColor = azul;
            this.label5.Location = new System.Drawing.Point(310, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valor máximo para x:";
            // 
            // label2 (X0)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = fuenteGrande;
            this.label2.ForeColor = azul;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "X0 =";
            // 
            // label4 (X)
            // 
            this.label4.AutoSize = true;
            this.label4.Font = fuenteGrande;
            this.label4.ForeColor = azul;
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "x =";
            // 
            // button1 (Calcular)
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = fuenteGrande;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 80);
            this.button1.TabIndex = 44;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(770, 255);
            this.dataGridView1.TabIndex = 45;
            // 
            // Formula_Taylor_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.incrementotxt);
            this.Controls.Add(this.xtxt);
            this.Controls.Add(this.x0txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formula_Taylor_1";
            this.Text = "Taylor Orden 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox btxt;
        private System.Windows.Forms.TextBox incrementotxt;
        private System.Windows.Forms.TextBox xtxt;
        private System.Windows.Forms.TextBox x0txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}