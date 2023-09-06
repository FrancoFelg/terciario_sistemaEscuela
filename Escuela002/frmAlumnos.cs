using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace Escuela002
{
    public partial class frmAlumnos : Form
    {

        bool blnNuevo = true;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            //Validaciones
            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Apellido", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Nombre", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCP.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Código Postal", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFecNac.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Fecha de Nacimiento", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (blnNuevo)//Si es un booleano no es necesario poner la asignación
            {
                // Conexión a la BDD
                //Declaro variable con tipo nombre = new..
                using (SqlConnection con = new SqlConnection())
                {
                    //Abrir conexión
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INS_ALUMNO";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);
                        cmd.Parameters.AddWithValue("APEALU", txtApellido.Text);
                        cmd.Parameters.AddWithValue("NOMALU", txtNombre.Text);
                        cmd.Parameters.AddWithValue("INGALU", txtIngreso.Text);

                        cmd.Parameters.AddWithValue("POSALU", txtCP.Text);
                        cmd.Parameters.AddWithValue("FNAALU", txtFecNac.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMatricula.Text = "";
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        txtIngreso.Text = "";
                        txtCP.Text = "";
                        txtFecNac.Text = "";

                    }
                }
            }
            else
            {
                //EDITAR REGISTRO
                // Conexión a la BDD
                //Declaro variable con tipo nombre = new..
                using (SqlConnection con = new SqlConnection())
                {
                    //Abrir conexión
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UPD_ALUMNO";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);
                        cmd.Parameters.AddWithValue("APEALU", txtApellido.Text);
                        cmd.Parameters.AddWithValue("NOMALU", txtNombre.Text);
                        cmd.Parameters.AddWithValue("INGALU", txtIngreso.Text);

                        cmd.Parameters.AddWithValue("POSALU", txtCP.Text);
                        cmd.Parameters.AddWithValue("FNAALU", txtFecNac.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMatricula.Text = "";
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        txtIngreso.Text = "";
                        txtCP.Text = "";
                        txtFecNac.Text = "";

                    }
                }
            }


        }
    }
}
