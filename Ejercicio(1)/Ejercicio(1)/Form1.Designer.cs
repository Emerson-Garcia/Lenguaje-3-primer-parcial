﻿
namespace Ejercicio_1_
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
            this.calcular_button = new System.Windows.Forms.Button();
            this.numero2_textBox = new System.Windows.Forms.TextBox();
            this.numero1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcular_button
            // 
            this.calcular_button.Location = new System.Drawing.Point(187, 127);
            this.calcular_button.Name = "calcular_button";
            this.calcular_button.Size = new System.Drawing.Size(120, 51);
            this.calcular_button.TabIndex = 9;
            this.calcular_button.Text = "Calcular";
            this.calcular_button.UseVisualStyleBackColor = true;
            this.calcular_button.Click += new System.EventHandler(this.calcular_button_Click);
            // 
            // numero2_textBox
            // 
            this.numero2_textBox.Location = new System.Drawing.Point(187, 80);
            this.numero2_textBox.Name = "numero2_textBox";
            this.numero2_textBox.Size = new System.Drawing.Size(142, 20);
            this.numero2_textBox.TabIndex = 8;
            // 
            // numero1_textBox
            // 
            this.numero1_textBox.Location = new System.Drawing.Point(187, 30);
            this.numero1_textBox.Name = "numero1_textBox";
            this.numero1_textBox.Size = new System.Drawing.Size(142, 20);
            this.numero1_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero 1 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcular_button);
            this.Controls.Add(this.numero2_textBox);
            this.Controls.Add(this.numero1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular_button;
        private System.Windows.Forms.TextBox numero2_textBox;
        private System.Windows.Forms.TextBox numero1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

