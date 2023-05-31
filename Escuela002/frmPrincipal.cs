namespace Escuela002
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestionarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se instancia un objeto de tipo frmAlumnos
            frmAlumnos Alumnos = new frmAlumnos();
            //Se muestra el formulario            
            Alumnos.ShowDialog();
        }
    }
}