namespace ProyectoMetodos
{
    partial class FrmIntegracionMultiple
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbTrapecio = new System.Windows.Forms.RadioButton();
            this.rbSimpson = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(30, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(50, 22);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(90, 50);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(50, 22);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(30, 100);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(50, 22);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(90, 100);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(50, 22);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(160, 50);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(40, 22);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(160, 100);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(40, 22);
            // 
            // rbTrapecio
            // 
            this.rbTrapecio.Location = new System.Drawing.Point(30, 140);
            this.rbTrapecio.Name = "rbTrapecio";
            this.rbTrapecio.Size = new System.Drawing.Size(104, 24);
            this.rbTrapecio.TabIndex = 0;
            this.rbTrapecio.Text = "Trapecio";
            this.rbTrapecio.Checked = true;
            // 
            // rbSimpson
            // 
            this.rbSimpson.Location = new System.Drawing.Point(160, 140);
            this.rbSimpson.Name = "rbSimpson";
            this.rbSimpson.Size = new System.Drawing.Size(120, 24);
            this.rbSimpson.Text = "Simpson 1/3";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(30, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(170, 40);
            this.btnCalcular.Text = "Integrar";
            this.btnCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(30, 240);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(300, 30);
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Text = "Resultado: --";
            // 
            // label1
            // 
            this.label1.Text = "Límites X (a, b) y n:";
            this.label1.Location = new System.Drawing.Point(30, 30);
            // 
            // label2
            // 
            this.label2.Text = "Límites Y (c, d) y m:";
            this.label2.Location = new System.Drawing.Point(30, 80);
            // 
            // FrmIntegracionMultiple
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtA, this.txtB, this.txtC, this.txtD, this.txtN, this.txtM,
                this.btnCalcular, this.rbTrapecio, this.rbSimpson, this.lblResultado,
                this.label1, this.label2
            });
            this.Text = "Integración Múltiple ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtA, txtB, txtC, txtD, txtN, txtM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbTrapecio, rbSimpson;
        private System.Windows.Forms.Label lblResultado, label1, label2;
    }
}