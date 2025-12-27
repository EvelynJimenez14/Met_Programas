namespace ProyectoMetodos
{
    partial class Simpson_Compuesta_Multiple
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
            this.N_x_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.A_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.N_y_txt = new System.Windows.Forms.TextBox();
            this.D_txt = new System.Windows.Forms.TextBox();
            this.C_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(586, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Enabled = false;
            this.Resultado_txt.Location = new System.Drawing.Point(126, 129);
            this.Resultado_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.Size = new System.Drawing.Size(177, 20);
            this.Resultado_txt.TabIndex = 38;
            // 
            // N_x_txt
            // 
            this.N_x_txt.Location = new System.Drawing.Point(126, 105);
            this.N_x_txt.Margin = new System.Windows.Forms.Padding(2);
            this.N_x_txt.Name = "N_x_txt";
            this.N_x_txt.Size = new System.Drawing.Size(68, 20);
            this.N_x_txt.TabIndex = 37;
            // 
            // B_txt
            // 
            this.B_txt.Location = new System.Drawing.Point(207, 78);
            this.B_txt.Margin = new System.Windows.Forms.Padding(2);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(68, 20);
            this.B_txt.TabIndex = 36;
            // 
            // A_txt
            // 
            this.A_txt.Location = new System.Drawing.Point(126, 78);
            this.A_txt.Margin = new System.Windows.Forms.Padding(2);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(68, 20);
            this.A_txt.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "n_x = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Resultado =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Intervalo [a, b] :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "INTEGRACION SIMPSON 1/3 COMPUESTA DOBLE";
            // 
            // N_y_txt
            // 
            this.N_y_txt.Location = new System.Drawing.Point(403, 105);
            this.N_y_txt.Margin = new System.Windows.Forms.Padding(2);
            this.N_y_txt.Name = "N_y_txt";
            this.N_y_txt.Size = new System.Drawing.Size(68, 20);
            this.N_y_txt.TabIndex = 45;
            // 
            // D_txt
            // 
            this.D_txt.Location = new System.Drawing.Point(484, 78);
            this.D_txt.Margin = new System.Windows.Forms.Padding(2);
            this.D_txt.Name = "D_txt";
            this.D_txt.Size = new System.Drawing.Size(68, 20);
            this.D_txt.TabIndex = 44;
            // 
            // C_txt
            // 
            this.C_txt.Location = new System.Drawing.Point(403, 78);
            this.C_txt.Margin = new System.Windows.Forms.Padding(2);
            this.C_txt.Name = "C_txt";
            this.C_txt.Size = new System.Drawing.Size(68, 20);
            this.C_txt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "n_y = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Intervalo [c, d] :";
            // 
            // Simpson_Compuesta_Multiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.N_y_txt);
            this.Controls.Add(this.D_txt);
            this.Controls.Add(this.C_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado_txt);
            this.Controls.Add(this.N_x_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Simpson_Compuesta_Multiple";
            this.Text = "Simpson_Compuesta_Multiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Resultado_txt;
        private System.Windows.Forms.TextBox N_x_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N_y_txt;
        private System.Windows.Forms.TextBox D_txt;
        private System.Windows.Forms.TextBox C_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}