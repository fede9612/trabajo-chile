namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnrq1 = new System.Windows.Forms.Button();
            this.btnrq2 = new System.Windows.Forms.Button();
            this.btnrq3 = new System.Windows.Forms.Button();
            this.btnrq4 = new System.Windows.Forms.Button();
            this.btnrq5 = new System.Windows.Forms.Button();
            this.btnrq6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 250);
            this.textBox1.TabIndex = 0;
            // 
            // btnrq1
            // 
            this.btnrq1.Location = new System.Drawing.Point(12, 12);
            this.btnrq1.Name = "btnrq1";
            this.btnrq1.Size = new System.Drawing.Size(187, 49);
            this.btnrq1.TabIndex = 1;
            this.btnrq1.Text = "Request1";
            this.btnrq1.UseVisualStyleBackColor = true;
            this.btnrq1.Click += new System.EventHandler(this.btnrq1_Click);
            // 
            // btnrq2
            // 
            this.btnrq2.Location = new System.Drawing.Point(12, 67);
            this.btnrq2.Name = "btnrq2";
            this.btnrq2.Size = new System.Drawing.Size(187, 49);
            this.btnrq2.TabIndex = 2;
            this.btnrq2.Text = "Request2";
            this.btnrq2.UseVisualStyleBackColor = true;
            this.btnrq2.Click += new System.EventHandler(this.btnrq2_Click);
            // 
            // btnrq3
            // 
            this.btnrq3.Location = new System.Drawing.Point(12, 122);
            this.btnrq3.Name = "btnrq3";
            this.btnrq3.Size = new System.Drawing.Size(187, 49);
            this.btnrq3.TabIndex = 3;
            this.btnrq3.Text = "Request3";
            this.btnrq3.UseVisualStyleBackColor = true;
            this.btnrq3.Click += new System.EventHandler(this.btnrq3_Click);
            // 
            // btnrq4
            // 
            this.btnrq4.Location = new System.Drawing.Point(12, 177);
            this.btnrq4.Name = "btnrq4";
            this.btnrq4.Size = new System.Drawing.Size(187, 49);
            this.btnrq4.TabIndex = 4;
            this.btnrq4.Text = "Warning";
            this.btnrq4.UseVisualStyleBackColor = true;
            this.btnrq4.Click += new System.EventHandler(this.btnrq4_Click);
            // 
            // btnrq5
            // 
            this.btnrq5.Location = new System.Drawing.Point(12, 232);
            this.btnrq5.Name = "btnrq5";
            this.btnrq5.Size = new System.Drawing.Size(187, 49);
            this.btnrq5.TabIndex = 5;
            this.btnrq5.Text = "WarningAndError";
            this.btnrq5.UseVisualStyleBackColor = true;
            this.btnrq5.Click += new System.EventHandler(this.btnrq5_Click);
            // 
            // btnrq6
            // 
            this.btnrq6.Location = new System.Drawing.Point(12, 287);
            this.btnrq6.Name = "btnrq6";
            this.btnrq6.Size = new System.Drawing.Size(187, 49);
            this.btnrq6.TabIndex = 6;
            this.btnrq6.Text = "Error";
            this.btnrq6.UseVisualStyleBackColor = true;
            this.btnrq6.Click += new System.EventHandler(this.btnrq6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Request";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(735, 250);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrq6);
            this.Controls.Add(this.btnrq5);
            this.Controls.Add(this.btnrq4);
            this.Controls.Add(this.btnrq3);
            this.Controls.Add(this.btnrq2);
            this.Controls.Add(this.btnrq1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnrq1;
        private System.Windows.Forms.Button btnrq2;
        private System.Windows.Forms.Button btnrq3;
        private System.Windows.Forms.Button btnrq4;
        private System.Windows.Forms.Button btnrq5;
        private System.Windows.Forms.Button btnrq6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

