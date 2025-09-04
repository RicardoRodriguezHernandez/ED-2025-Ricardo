namespace ClaseAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto miAuto;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            double Velocidad = double.Parse(txtVelocidad.Text);

            miAuto = new Auto(marca, modelo);
            MessageBox.Show($"Auto " + marca + " y " + modelo + " con una velocidad de " + Velocidad + "km/h a sido creado", "Informacion del auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAcelelar_Click(object sender, EventArgs e)
        {
            if (miAuto != null)
            {
                miAuto.Acelerar(10);
                MessageBox.Show(miAuto.MostrarVelocidad());
            }
            else
            {
                MessageBox.Show("Primero crea el auto");
            }
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            if (miAuto != null)
            {
                miAuto.Frenar(10);
                MessageBox.Show(miAuto.MostrarVelocidad());
            }
            else
            {
                MessageBox.Show("Primero crea el auto");
            }
        }
    }
}
