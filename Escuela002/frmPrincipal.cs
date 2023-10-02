using System.Security.Cryptography.Xml;

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

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se instancia un objeto de tipo frmAsignaturas
            frmAsignaturas Asignaturas = new frmAsignaturas();
            //Se muestra el formulario            
            Asignaturas.ShowDialog();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades Ciudades = new frmCiudades();
            Ciudades.ShowDialog();
        }

        private void gestionarNotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNotas Notas = new frmNotas();
            Notas.ShowDialog();
        }

        private void tiposDeExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposExamen TiposExamen = new frmTiposExamen();
            TiposExamen.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}