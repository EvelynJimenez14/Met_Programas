namespace ProyectoMetodos
{
    partial class Integracion_Cuadratura_Gaussiana
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
            this.button1.Location = new System.Drawing.Point(635, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 48;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Enabled = false;
            this.Resultado_txt.Location = new System.Drawing.Point(247, 180);
            this.Resultado_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.Size = new System.Drawing.Size(89, 22);
            this.Resultado_txt.TabIndex = 47;
            // 
            // N_txt
            // 
            this.N_txt.Location = new System.Drawing.Point(247, 150);
            this.N_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N_txt.Name = "N_txt";
            this.N_txt.Size = new System.Drawing.Size(89, 22);
            this.N_txt.TabIndex = 46;
            // 
            // B_txt
            // 
            this.B_txt.Location = new System.Drawing.Point(355, 117);
            this.B_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(89, 22);
            this.B_txt.TabIndex = 45;
            // 
            // A_txt
            // 
            this.A_txt.Location = new System.Drawing.Point(247, 117);
            this.A_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(89, 22);
            this.A_txt.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "n = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Resultado =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Intervalo [a, b] :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cuadratura Gaussiana";
            // 
            // Integracion_Cuadratura_Gaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "Integracion_Cuadratura_Gaussiana";
            this.Text = "Integracion_Cuadratura_Gaussiana";
            this.Load += new System.EventHandler(this.Integracion_Cuadratura_Gaussiana_Load);
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