﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn7 = new Button();
            txtPantalla = new TextBox();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 75);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 46);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(12, 12);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(266, 47);
            txtPantalla.TabIndex = 1;
            txtPantalla.TextChanged += textBox1_TextChanged;
            // 
            // btn8
            // 
            btn8.Location = new Point(85, 75);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 46);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(158, 75);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 46);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 127);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 46);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(85, 127);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 46);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(158, 127);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 46);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 179);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 46);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(85, 179);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 46);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(158, 179);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 46);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(85, 231);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 46);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(231, 75);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(47, 46);
            btnMas.TabIndex = 11;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(231, 127);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(47, 46);
            btnMenos.TabIndex = 12;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(231, 179);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(47, 46);
            btnMultiplicacion.TabIndex = 13;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(231, 231);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(47, 46);
            btnDivision.TabIndex = 14;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(158, 231);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(67, 46);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 286);
            Controls.Add(btnIgual);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(txtPantalla);
            Controls.Add(btn7);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private TextBox txtPantalla;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnMas;
        private Button btnMenos;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnIgual;
    }
}
