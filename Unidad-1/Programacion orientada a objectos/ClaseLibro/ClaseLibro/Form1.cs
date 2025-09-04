namespace ClaseLibro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Libro miLibro = new Libro();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            miLibro.Titulo = txtTitulo.Text;
            miLibro.Autor = txtAutor.Text; 
            MessageBox.Show("El libro a sido creado","Libro nuevo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtTitulo.Clear();
            txtAutor.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miLibro.ToString(), "Informacion del libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
