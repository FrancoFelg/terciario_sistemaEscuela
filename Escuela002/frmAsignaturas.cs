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
    public partial class frmAsignaturas : Form
    {

        bool blnNuevo = true;

        public frmAsignaturas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//Grabar
        {

            //Validaciones
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el codigo de la asignatura", "Grabado de asignaturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para nombre", "Grabado de asignaturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_ASIGNATURA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODASI", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("NOMASI", txtNombre.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCodigo.Text = "";
                        txtNombre.Text = "";
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
                        cmd.CommandText = "UPD_ASIGNATURA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODASI", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("NOMASI", txtNombre.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                    }
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la asignatura", "Búsqueda de Asignaturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Busca la mat especificada y si la encuentra blnNuevo pasa a false.
            //Si no la encuentra debe permanecer en true.
            using (SqlConnection con = new SqlConnection())
            {
                //Abrir conexión
                // cadena de conexión o connection string: donde se tiene q conectar mi programa
                // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true"; //copiar cadena del botón Grabar
                //Abro conexión
                con.Open();


                //Representa el objeto que utiliza el SP para ejecutarse
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ASIGNATURA";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("CODASI", txtCodigo.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAsignaturas = cmd.ExecuteReader();

                    if (DatosAsignaturas.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAsignaturas.Read())
                        {
                            txtCodigo.Text = DatosAsignaturas["CODASI"].ToString();
                            txtNombre.Text = DatosAsignaturas["NOMASI"].ToString();

                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la asignatura ingresada", "Búsqueda de Asignaturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        blnNuevo = true;
                    }

                    DatosAsignaturas.Close();

                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (blnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar esta asignatura?", "Borrar Asignatura", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes) //Si presionó el botón SI
                {
                    //Borro registro
                    using (SqlConnection con = new SqlConnection())
                    {
                        //Abrir conexión
                        // cadena de conexión o connect string: donde se tiene q conectar mi programa
                        // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                        con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true";
                        //Conecto 
                        con.Open();

                        //Defino el comando que apunta a del_alumno
                        //Representa el objeto q vos queres usar en la BDD
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "DEL_ASIGNATURA";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("CODASI", txtCodigo.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtNombre.Text = "";
                            txtCodigo.Text = "";
                            blnNuevo = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe buscar una asignatura para poder borrarla", "Borrado de asignaturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
