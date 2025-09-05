namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Biblioteca miBiblioteca = new Biblioteca(); 
        Libro miLibro = new Libro();
        Usuario miUsuario = new Usuario();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            miUsuario.ID = int.Parse(txtID.Text);
            miUsuario.Nombre = txtNombre.Text;
            foreach (Control x in groupBox1.Controls) if (x is TextBox)
                    x.Text ="";
            miLibro.Titulo = txtTitulo.Text;
            miLibro.Autor = txtAuto.Text;
            miLibro.ISBN = txtISBN.Text;
            foreach (Control x in groupBox2.Controls) if (x is TextBox)
                    x.Text ="";
            miBiblioteca.Prestamo = DateTime.Today;
            miBiblioteca.Devolucion = dtpFechaDeDevolucion.Value;

            MessageBox.Show("ID del usuario: " + miUsuario.ID.ToString() +
                            "\nNombre del usuario: " + miUsuario.Nombre +
                            "\nTitulo del libro: " + miLibro.Titulo +
                            "\nAutor del libro: " + miLibro.Autor +
                            "\nISBN del libro: " + miLibro.ISBN +
                            "\nFecha que del prestamo: " + miBiblioteca.Prestamo.ToShortDateString() +
                            "\nFecha de devolucion: " + miBiblioteca.Devolucion.ToShortDateString(),"Informacion del prestamo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaDeDevolucion.MinDate = DateTime.Today;
        }
    }
}
