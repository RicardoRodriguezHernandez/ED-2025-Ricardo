namespace ExamenDiagnostico2
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
            txtAncho = new TextBox();
            txtAlto = new TextBox();
            label2 = new Label();
            btnCalcularArea = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Ancho:";
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(75, 37);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(86, 27);
            txtAncho.TabIndex = 1;
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(75, 80);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(86, 27);
            txtAlto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Alto:";
            // 
            // btnCalcularArea
            // 
            btnCalcularArea.Location = new Point(187, 37);
            btnCalcularArea.Name = "btnCalcularArea";
            btnCalcularArea.Size = new Size(163, 63);
            btnCalcularArea.TabIndex = 4;
            btnCalcularArea.Text = "Calcular  y mostar dimensiones ";
            btnCalcularArea.UseVisualStyleBackColor = true;
            btnCalcularArea.Click += btnCalcularArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 210);
            Controls.Add(btnCalcularArea);
            Controls.Add(txtAlto);
            Controls.Add(label2);
            Controls.Add(txtAncho);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAncho;
        private TextBox txtAlto;
        private Label label2;
        private Button btnCalcularArea;
    }
}
