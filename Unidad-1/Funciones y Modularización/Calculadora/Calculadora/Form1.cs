namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1, Numero2, Resultado;
        string Operaciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(txtPantalla.Text);
            Operaciones = "+";
            txtPantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(txtPantalla.Text);
            Operaciones = "-";
            txtPantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(txtPantalla.Text);
            Operaciones = "*";
            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Numero1 = double.Parse(txtPantalla.Text);
            Operaciones = "/";
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = double.Parse(txtPantalla.Text);

            switch (Operaciones)
            {
                case ("+"):
                    {
                        Resultado = Numero1 + Numero2;
                        break;
                    }
                case ("-"):
                    {
                        Resultado = Numero1 - Numero2;
                        break;
                    }
                case ("*"):
                    {
                        Resultado = Numero1 * Numero2;
                        break;
                    }
                case ("/"):
                    {
                        if (Numero2 != 0)
                        {
                            Resultado = Numero1 / Numero2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir con 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
            }
            txtPantalla.Text = Resultado.ToString();
        }
    }
}
