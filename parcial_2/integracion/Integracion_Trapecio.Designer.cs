namespace ProyectoMetodos
{
    partial class Integracion_Trapecio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.N_txt = new System.Windows.Forms.TextBox();
            this.Resultado_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "INTEGRACION TRAPECIO COMPUESTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Intervalo [a, b] :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "n = ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // A_txt
            // 
            this.A_txt.Location = new System.Drawing.Point(193, 106);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(100, 26);
            this.A_txt.TabIndex = 16;
            this.A_txt.TextChanged += new System.EventHandler(this.A_txt_TextChanged);
            // 
            // B_txt
            // 
            this.B_txt.Location = new System.Drawing.Point(314, 106);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(100, 26);
            this.B_txt.TabIndex = 17;
            this.B_txt.TextChanged += new System.EventHandler(this.B_txt_TextChanged);
            // 
            // N_txt
            // 
            this.N_txt.Location = new System.Drawing.Point(193, 147);
            this.N_txt.Name = "N_txt";
            this.N_txt.Size = new System.Drawing.Size(100, 26);
            this.N_txt.TabIndex = 18;
            this.N_txt.TextChanged += new System.EventHandler(this.N_txt_TextChanged);
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Location = new System.Drawing.Point(193, 184);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.Size = new System.Drawing.Size(100, 26);
            this.Resultado_txt.TabIndex = 19;
            this.Resultado_txt.TextChanged += new System.EventHandler(this.Resultado_txt_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Integracion_Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado_txt);
            this.Controls.Add(this.N_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Integracion_Trapecio";
            this.Text = "Integracion_Trapecio_Compuesto";
            this.Load += new System.EventHandler(this.Integracion_Trapecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox N_txt;
        private System.Windows.Forms.TextBox Resultado_txt;
        private System.Windows.Forms.Button button1;
    }
}