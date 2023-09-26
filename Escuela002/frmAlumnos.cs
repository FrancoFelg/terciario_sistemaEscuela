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

        private void button1_Click(object sender, EventArgs e)//btnSalir
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//BtnBorrar
        {
            if (blnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar este alumno?", "Borrar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            cmd.CommandText = "DEL_ALUMNO";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtMatricula.Text = "";
                            txtApellido.Text = "";
                            txtNombre.Text = "";
                            txtIngreso.Text = "";
                            txtCP.Text = "";
                            txtFecNac.Text = "";

                            blnNuevo = true;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe buscar un alumno para poder borrarlo", "Borrado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_ALUMNO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtApellido.Text = DatosAlumno["APEALU"].ToString();
                            txtNombre.Text = DatosAlumno["NOMALU"].ToString();
                            txtIngreso.Text = DatosAlumno["INGALU"].ToString();
                            txtCP.Text = DatosAlumno["POSALU"].ToString();
                            //txtFecNac.Text = DatosAlumno["FNAALU"].ToString().Substring(0, 10);//Original
                            //txtFecNac.Text = DatosAlumno["FNAALU"].ToString().Substring(0, 9);//Mejorado
                            txtFecNac.Text = ((DateTime)DatosAlumno["FNAALU"]).ToString("dd/MM/yyyy");

                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        blnNuevo = true;
                    }

                    DatosAlumno.Close();

                }
            }

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
