
namespace Ejercicio_1_
{
    partial class Ejercicio2
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
            this.calcular_button = new System.Windows.Forms.Button();
            this.numero2_textBox = new System.Windows.Forms.TextBox();
            this.numero1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Operaciones_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calcular_button
            // 
            this.calcular_button.Location = new System.Drawing.Point(161, 183);
            this.calcular_button.Name = "calcular_button";
            this.calcular_button.Size = new System.Drawing.Size(120, 51);
            this.calcular_button.TabIndex = 14;
            this.calcular_button.Text = "Calcular";
            this.calcular_button.UseVisualStyleBackColor = true;
            // 
            // numero2_textBox
            // 
            this.numero2_textBox.Location = new System.Drawing.Point(161, 79);
            this.numero2_textBox.Name = "numero2_textBox";
            this.numero2_textBox.Size = new System.Drawing.Size(142, 20);
            this.numero2_textBox.TabIndex = 13;
            // 
            // numero1_textBox
            // 
            this.numero1_textBox.Location = new System.Drawing.Point(161, 29);
            this.numero1_textBox.Name = "numero1_textBox";
            this.numero1_textBox.Size = new System.Drawing.Size(142, 20);
            this.numero1_textBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero 1 :";
            // 
            // Operaciones_comboBox
            // 
            this.Operaciones_comboBox.FormattingEnabled = true;
            this.Operaciones_comboBox.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.Operaciones_comboBox.Location = new System.Drawing.Point(160, 123);
            this.Operaciones_comboBox.Name = "Operaciones_comboBox";
            this.Operaciones_comboBox.Size = new System.Drawing.Size(184, 21);
            this.Operaciones_comboBox.TabIndex = 15;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Operaciones_comboBox);
            this.Controls.Add(this.calcular_button);
            this.Controls.Add(this.numero2_textBox);
            this.Controls.Add(this.numero1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular_button;
        private System.Windows.Forms.TextBox numero2_textBox;
        private System.Windows.Forms.TextBox numero1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Operaciones_comboBox;
    }
}