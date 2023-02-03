namespace Primer_Parcial
{
    partial class Tarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngreseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Determine si es un  numero par o Impar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un numero:";
            // 
            // IngreseTextBox
            // 
            this.IngreseTextBox.Location = new System.Drawing.Point(275, 71);
            this.IngreseTextBox.Name = "IngreseTextBox";
            this.IngreseTextBox.Size = new System.Drawing.Size(217, 20);
            this.IngreseTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado:";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(275, 120);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(217, 20);
            this.ResultadoTextBox.TabIndex = 4;
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(332, 170);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton1.TabIndex = 5;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // Tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IngreseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarea1";
            this.Text = "Tarea1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngreseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Button CalcularButton1;
    }
}