namespace ProyectoMetodos
{
    partial class Integracion_Simpson_1_3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Resultado_txt = new System.Windows.Forms.TextBox();
            this.N_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.A_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(425, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Enabled = false;
            this.Resultado_txt.Location = new System.Drawing.Point(134, 108);
            this.Resultado_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.Size = new System.Drawing.Size(68, 20);
            this.Resultado_txt.TabIndex = 29;
            this.Resultado_txt.TextChanged += new System.EventHandler(this.Resultado_txt_TextChanged);
            // 
            // N_txt
            // 
            this.N_txt.Location = new System.Drawing.Point(134, 84);
            this.N_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.N_txt.Name = "N_txt";
            this.N_txt.Size = new System.Drawing.Size(68, 20);
            this.N_txt.TabIndex = 28;
            this.N_txt.TextChanged += new System.EventHandler(this.N_txt_TextChanged);
            // 
            // B_txt
            // 
            this.B_txt.Location = new System.Drawing.Point(215, 57);
            this.B_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(68, 20);
            this.B_txt.TabIndex = 27;
            this.B_txt.TextChanged += new System.EventHandler(this.B_txt_TextChanged);
            // 
            // A_txt
            // 
            this.A_txt.Location = new System.Drawing.Point(134, 57);
            this.A_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(68, 20);
            this.A_txt.TabIndex = 26;
            this.A_txt.TextChanged += new System.EventHandler(this.A_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "n = ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Resultado =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Intervalo [a, b] :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "INTEGRACION SIMPSON 1/3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Integracion_Simpson_1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado_txt);
            this.Controls.Add(this.N_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Integracion_Simpson_1_3";
            this.Text = "Integracion_Simpson_1_3";
            this.Load += new System.EventHandler(this.Integracion_Simpson_1_3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Resultado_txt;
        private System.Windows.Forms.TextBox N_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}