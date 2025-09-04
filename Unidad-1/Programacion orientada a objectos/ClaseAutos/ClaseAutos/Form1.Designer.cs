namespace ClaseAutos
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
            label1 = new Label();
            txtMarca = new TextBox();
            btnCrear = new Button();
            groupBox1 = new GroupBox();
            btnFrenar = new Button();
            btnAcelelar = new Button();
            label3 = new Label();
            txtVelocidad = new TextBox();
            label2 = new Label();
            txtModelo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(75, 37);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(206, 37);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(111, 37);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Auto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFrenar);
            groupBox1.Controls.Add(btnAcelelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtVelocidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 242);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnFrenar
            // 
            btnFrenar.Location = new Point(6, 189);
            btnFrenar.Name = "btnFrenar";
            btnFrenar.Size = new Size(111, 37);
            btnFrenar.TabIndex = 8;
            btnFrenar.Text = "Frenar";
            btnFrenar.UseVisualStyleBackColor = true;
            btnFrenar.Click += btnFrenar_Click;
            // 
            // btnAcelelar
            // 
            btnAcelelar.Location = new Point(6, 146);
            btnAcelelar.Name = "btnAcelelar";
            btnAcelelar.Size = new Size(111, 37);
            btnAcelelar.TabIndex = 7;
            btnAcelelar.Text = "Acelelar";
            btnAcelelar.UseVisualStyleBackColor = true;
            btnAcelelar.Click += btnAcelelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 106);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Velocidad:";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(89, 103);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(111, 27);
            txtVelocidad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(89, 70);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(111, 27);
            txtModelo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 269);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMarca;
        private Button btnCrear;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtModelo;
        private Button btnFrenar;
        private Button btnAcelelar;
        private Label label3;
        private TextBox txtVelocidad;
    }
}
