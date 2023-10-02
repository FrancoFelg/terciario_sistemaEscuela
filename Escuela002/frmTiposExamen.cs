﻿using System;
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
    public partial class frmTiposExamen : Form
    {

        bool blnNuevo = true;

        public frmTiposExamen()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el tipo de examen", "Búsqueda de Exámenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_TIPOSEXAMEN";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("CODTIP", txtCodigo.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAsignaturas = cmd.ExecuteReader();

                    if (DatosAsignaturas.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAsignaturas.Read())
                        {
                            txtCodigo.Text = DatosAsignaturas["CODTIP"].ToString();
                            txtNombre.Text = DatosAsignaturas["NOMTIP"].ToString();

                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró el tipo de exámen ingresado", "Búsqueda de Tipos de Exámen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        blnNuevo = true;
                    }

                    DatosAsignaturas.Close();

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea borrar este tipo de exámen?", "Borrar tipo de exámen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                        cmd.CommandText = "DEL_TIPOSEXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                        cmd.Parameters.AddWithValue("CODTIP", txtCodigo.Text);


                        //EJECUTA EL COMANDO
                        cmd.ExecuteNonQuery();

                        txtNombre.Text = "";
                        txtCodigo.Text = "";
                        blnNuevo = true;
                    }
                }

            }

        
            else
            {
                MessageBox.Show("Debe buscar un tipo de exámen para poder borrarlo", "Borrado de tipos de exámenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            //Validaciones
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el codigo del tipo de exámen", "Grabado de tipos de exámenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para nombre", "Grabado de tipos de exámenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_TIPOSEXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtNombre.Text);

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
                        cmd.CommandText = "UPD_TIPOSEXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtNombre.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
