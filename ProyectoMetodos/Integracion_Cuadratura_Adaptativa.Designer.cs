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
            this.Resultado_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A_txt
            // 
            this.A_txt.Location = new System.Drawing.Point(50, 50);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(100, 20);
            this.A_txt.TabIndex = 6;
            // 
            // B_txt
            // 
            this.B_txt.Location = new System.Drawing.Point(370, 50);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(100, 20);
            this.B_txt.TabIndex = 5;
            // 
            // Resultado_txt
            // 
            this.Resultado_txt.Location = new System.Drawing.Point(412, 100);
            this.Resultado_txt.Name = "Resultado_txt";
            this.Resultado_txt.ReadOnly = true;
            this.Resultado_txt.Size = new System.Drawing.Size(154, 20);
            this.Resultado_txt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular Adaptativo";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Límite a:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(392, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Límite b:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(345, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado:";
            // 
            // Integracion_Cuadratura_Adaptativa
            // 
            this.ClientSize = new System.Drawing.Size(611, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Name = "Integracion_Cuadratura_Adaptativa";
            this.Text = "Cuadratura Adaptativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox Resultado_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}