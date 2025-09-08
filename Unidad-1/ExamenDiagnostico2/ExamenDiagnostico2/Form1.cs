namespace ExamenDiagnostico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangulo miRectangulo;
        Cuadrado miCuadrado;
        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            miRectangulo = new Rectangulo(double.Parse(txtAncho.Text));
            miCuadrado = new Cuadrado(double.Parse(txtAncho.Text));
            miRectangulo.Alto = double.Parse(txtAlto.Text);
            MessageBox.Show("Area: " + miRectangulo.CalcularArea().ToString() +
                            "\nPerimetro: " + miRectangulo.CalcularPerimetro().ToString() +
                            "\n\nCuadrado" +
                            "\nArea: " + miCuadrado.CalcularArea().ToString() +
                            "\nPerimetro: " + miCuadrado.CalcularPerimetro().ToString(), "Rectangulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
