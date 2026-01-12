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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(80, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 22);
            this.lblTitulo.Text = "INTEGRACION MULTIPLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.Text = "Límites X [a, b] y n:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(185, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(60, 20);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(255, 67);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(60, 20);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(325, 67);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(40, 20);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.Text = "Límites Y [c, d] y m:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(185, 102);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(60, 20);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(255, 102);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(60, 20);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(325, 102);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(40, 20);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(390, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 60);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.Text = "Método:";
            // 
            // rbTrapecio
            // 
            this.rbTrapecio.AutoSize = true;
            this.rbTrapecio.Checked = true;
            this.rbTrapecio.Font = new System.Drawing.Font("Lucida Sans", 8F);
            this.rbTrapecio.Location = new System.Drawing.Point(100, 143);
            this.rbTrapecio.Name = "rbTrapecio";
            this.rbTrapecio.Size = new System.Drawing.Size(71, 18);
            this.rbTrapecio.Text = "Trapecio";
            this.rbTrapecio.UseVisualStyleBackColor = true;
            // 
            // rbSimpson
            // 
            this.rbSimpson.AutoSize = true;
            this.rbSimpson.Font = new System.Drawing.Font("Lucida Sans", 8F);
            this.rbSimpson.Location = new System.Drawing.Point(200, 143);
            this.rbSimpson.Name = "rbSimpson";
            this.rbSimpson.Size = new System.Drawing.Size(92, 18);
            this.rbSimpson.Text = "Simpson 1/3";
            this.rbSimpson.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(20, 180);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(102, 16);
            this.lblResultado.Text = "Resultado =";
            // 
            // FrmIntegracionMultiple
            // 
            this.ClientSize = new System.Drawing.Size(520, 230);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbTrapecio);
            this.Controls.Add(this.rbSimpson);
            this.Controls.Add(this.lblResultado);
            this.Name = "FrmIntegracionMultiple";
            this.Text = "Integración Doble";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtA, txtB, txtC, txtD, txtN, txtM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbTrapecio, rbSimpson;
        private System.Windows.Forms.Label lblResultado, label1, label2, label3, lblTitulo;
    }
}
