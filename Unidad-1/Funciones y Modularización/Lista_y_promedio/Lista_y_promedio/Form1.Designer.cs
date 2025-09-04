namespace Lista_y_promedio
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
            txtNumero = new TextBox();
            label1 = new Label();
            ListaDeNumeros = new ListBox();
            label2 = new Label();
            btnAgreagar = new Button();
            btnPromedio = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(84, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(77, 27);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero:";
            // 
            // ListaDeNumeros
            // 
            ListaDeNumeros.FormattingEnabled = true;
            ListaDeNumeros.ItemHeight = 20;
            ListaDeNumeros.Location = new Point(167, 12);
            ListaDeNumeros.Name = "ListaDeNumeros";
            ListaDeNumeros.Size = new Size(137, 184);
            ListaDeNumeros.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "Agrega un numero";
            // 
            // btnAgreagar
            // 
            btnAgreagar.Location = new Point(28, 82);
            btnAgreagar.Name = "btnAgreagar";
            btnAgreagar.Size = new Size(124, 53);
            btnAgreagar.TabIndex = 4;
            btnAgreagar.Text = "Agregar Numero";
            btnAgreagar.UseVisualStyleBackColor = true;
            btnAgreagar.Click += btnAgreagar_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(28, 141);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(124, 55);
            btnPromedio.TabIndex = 5;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 216);
            Controls.Add(btnPromedio);
            Controls.Add(btnAgreagar);
            Controls.Add(label2);
            Controls.Add(ListaDeNumeros);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private ListBox ListaDeNumeros;
        private Label label2;
        private Button btnAgreagar;
        private Button btnPromedio;
    }
}
