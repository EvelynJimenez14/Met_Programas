namespace ProyectoMetodos
{
    partial class Formula_Taylor_3
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
            this.btxt = new System.Windows.Forms.TextBox();
            this.incrementotxt = new System.Windows.Forms.TextBox();
            this.xtxt = new System.Windows.Forms.TextBox();
            this.x0txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btxt
            // 
            this.btxt.Location = new System.Drawing.Point(518, 123);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(100, 26);
            this.btxt.TabIndex = 74;
            this.btxt.TextChanged += new System.EventHandler(this.btxt_TextChanged);
            // 
            // incrementotxt
            // 
            this.incrementotxt.Location = new System.Drawing.Point(506, 80);
            this.incrementotxt.Name = "incrementotxt";
            this.incrementotxt.Size = new System.Drawing.Size(100, 26);
            this.incrementotxt.TabIndex = 73;
            this.incrementotxt.TextChanged += new System.EventHandler(this.incrementotxt_TextChanged);
            // 
            // xtxt
            // 
            this.xtxt.Location = new System.Drawing.Point(88, 75);
            this.xtxt.Name = "xtxt";
            this.xtxt.Size = new System.Drawing.Size(100, 26);
            this.xtxt.TabIndex = 72;
            this.xtxt.TextChanged += new System.EventHandler(this.xtxt_TextChanged);
            // 
            // x0txt
            // 
            this.x0txt.Location = new System.Drawing.Point(88, 119);
            this.x0txt.Name = "x0txt";
            this.x0txt.Size = new System.Drawing.Size(100, 26);
            this.x0txt.TabIndex = 71;
            this.x0txt.TextChanged += new System.EventHandler(this.x0txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 70;
            this.label6.Text = "Incremento para x:";
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(16, 171);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersWidth = 62;
            this.DataGridView2.RowTemplate.Height = 28;
            this.DataGridView2.Size = new System.Drawing.Size(772, 263);
            this.DataGridView2.TabIndex = 69;
            this.DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(673, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 56);
            this.button1.TabIndex = 68;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Valor maximo para x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "x =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "X0 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(199, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "FORMULA TAYLOR 3";
            // 
            // Formula_Taylor_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.incrementotxt);
            this.Controls.Add(this.xtxt);
            this.Controls.Add(this.x0txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formula_Taylor_3";
            this.Text = "Formula_Taylor_3";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btxt;
        private System.Windows.Forms.TextBox incrementotxt;
        private System.Windows.Forms.TextBox xtxt;
        private System.Windows.Forms.TextBox x0txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}