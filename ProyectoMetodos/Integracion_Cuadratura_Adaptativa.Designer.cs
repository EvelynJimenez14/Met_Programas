namespace ProyectoMetodos
{
    partial class Integracion_Cuadratura_Adaptativa
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
            this.A_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.Epsilon_txt = new System.Windows.Forms.TextBox();
            this.Resultado_txt = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(120, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(430, 22);
            this.lblTitulo.Text = "CUADRATURA ADAPTATIVA";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblA.Location = new System.Drawing.Point(50, 80);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(130, 17);
            this.lblA.Text = "Intervalo [a, b] :";
            // 
            // A_txt
            // 
            this.A_txt.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.A_txt.Location = new System.Drawing.Point(200, 77);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(80, 23);
            // 
            // B_txt
            // 
            this.B_txt.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.B_txt.Location = new System.Drawing.Point(290, 77);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(80, 23);
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEps.Location = new System.Drawing.Point(50, 115);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(115, 17);
            this.lblEps.Text = "Epsilon (eps):";
            // 
            // Epsilon_txt
            // 
            this.Epsilon_txt.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.Epsilon_txt.Location = new System.Drawing.Point(200, 112);
            this.Epsilon_txt.Name = "Epsilon_txt";
            this.Epsilon_txt.Size = new System.Drawing.Size(170, 23);
            this.Epsilon_txt.Text = "0.00001";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(450, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 60);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblRes.Location = new System.Drawing.Point(50, 160);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(102, 17);
            this.lblRes.Text = "Resultado =";
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.BackColor = System.Drawing.Color.White;
            this.Resultado_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultado_txt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.Resultado_txt.Location = new System.Drawing.Point(200, 157);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.ReadOnly = true;
            this.Resultado_txt.Size = new System.Drawing.Size(250, 23);
            // 
            // Integracion_Cuadratura_Adaptativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(650, 230);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.lblEps);
            this.Controls.Add(this.Epsilon_txt);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.Resultado_txt);
            this.Name = "Integracion_Cuadratura_Adaptativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadratura Adaptativa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox A_txt, B_txt, Epsilon_txt, Resultado_txt;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblA, lblEps, lblRes, lblTitulo;
    }
}
