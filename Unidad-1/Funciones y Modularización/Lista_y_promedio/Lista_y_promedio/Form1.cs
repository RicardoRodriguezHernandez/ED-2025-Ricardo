namespace Lista_y_promedio
{
    public partial class Form1 : Form
    {
        double Numero, Promedio;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgreagar_Click(object sender, EventArgs e)
        {
            Numero = Convert.ToDouble(txtNumero.Text);
            ListaDeNumeros.Items.Add(Numero);
            txtNumero.Clear();
        }
        private double CalcularPromedio(List<double> numeros)
        {
            double Suma = 0;
            foreach (double n in numeros)
            {
                Suma += n;
            }
            return Suma / numeros.Count;
        }
        private void btnPromedio_Click(object sender, EventArgs e)
        {
            List<double> numeros = new List<double>();

            foreach (var item in ListaDeNumeros.Items)
            {
                numeros.Add(Convert.ToDouble(item));
            }
            Promedio = CalcularPromedio(numeros);
            MessageBox.Show("Promedio de la lista: "+ Promedio,"Promedio",MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }
    }
}
