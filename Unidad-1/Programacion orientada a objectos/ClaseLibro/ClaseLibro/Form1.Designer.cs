namespace ClaseLibro
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            btnCrear = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(79, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(79, 60);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 27);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(39, 108);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(153, 54);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Agregar libro";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(39, 180);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(153, 54);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar informacion de libro";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 255);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label label2;
        private Button btnCrear;
        private Button btnMostrar;
    }
}
