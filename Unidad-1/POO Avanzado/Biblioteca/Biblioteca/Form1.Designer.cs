namespace Biblioteca
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
            dtpFechaDeDevolucion = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtISBN = new TextBox();
            label5 = new Label();
            txtAuto = new TextBox();
            label4 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            BtnAgregar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaDeDevolucion
            // 
            dtpFechaDeDevolucion.Location = new Point(250, 46);
            dtpFechaDeDevolucion.Name = "dtpFechaDeDevolucion";
            dtpFechaDeDevolucion.Size = new Size(290, 27);
            dtpFechaDeDevolucion.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 106);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtID
            // 
            txtID.Location = new Point(49, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtISBN);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAuto);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpFechaDeDevolucion);
            groupBox2.Location = new Point(12, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 133);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Libro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 23);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 10;
            label6.Text = "Fecha de devolucion:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(66, 92);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(131, 27);
            txtISBN.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 95);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 8;
            label5.Text = "ISBN:";
            // 
            // txtAuto
            // 
            txtAuto.Location = new Point(72, 59);
            txtAuto.Name = "txtAuto";
            txtAuto.Size = new Size(125, 27);
            txtAuto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 62);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Autor:";
            label4.Click += label4_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(72, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Titulo:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(262, 26);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 57);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Crear prestamo";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 268);
            Controls.Add(BtnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Biblioteca";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFechaDeDevolucion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtAuto;
        private Label label4;
        private TextBox txtTitulo;
        private Label label3;
        private Label label6;
        private TextBox txtISBN;
        private Label label5;
        private Button BtnAgregar;
    }
}
