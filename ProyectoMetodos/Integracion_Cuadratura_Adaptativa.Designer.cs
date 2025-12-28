using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    partial class Integracion_Cuadratura_Adaptativa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.A_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.Resultado_txt = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A_txt
            // 
            this.A_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.A_txt.Location = new System.Drawing.Point(250, 70);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(150, 29);
            this.A_txt.TabIndex = 2;
            // 
            // B_txt
            // 
            this.B_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.B_txt.Location = new System.Drawing.Point(250, 120);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(150, 29);
            this.B_txt.TabIndex = 4;
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Resultado_txt.Location = new System.Drawing.Point(30, 280);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.ReadOnly = true;
            this.Resultado_txt.Size = new System.Drawing.Size(370, 29);
            this.Resultado_txt.TabIndex = 7;
            
            this.btnCalcular.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(30, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(370, 50);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Integral";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
           
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblA.Location = new System.Drawing.Point(30, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(163, 23);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Límite inferior (a):";
            
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblB.Location = new System.Drawing.Point(30, 120);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(182, 23);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Límite superior (b):";
            
            this.lblRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRes.Location = new System.Drawing.Point(30, 250);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(100, 23);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Resultado Final:";
            
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuadratura Adaptativa ";
            
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.Resultado_txt);
            this.Name = "Integracion_Cuadratura_Adaptativa";
            this.Text = "Cuadratura adaptiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A_txt, B_txt, Resultado_txt;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblA, lblB, lblRes, lblTitulo;
    }
}