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
    public partial class frmNotas : Form
    {

        bool blnNuevo = true;

        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtAsignatura.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la asignatura", "Búsqueda de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFecha.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la fecha", "Búsqueda de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMateria.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la materia", "Búsqueda de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTipo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el tipo de nota", "Búsqueda de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_NOTA";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("MATNOT", txtMateria.Text);
                    cmd.Parameters.AddWithValue("ASINOT", txtAsignatura.Text);
                    cmd.Parameters.AddWithValue("FECNOT", txtFecha.Text);
                    cmd.Parameters.AddWithValue("TIPNOT", txtTipo.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAsignaturas = cmd.ExecuteReader();

                    if (DatosAsignaturas.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAsignaturas.Read())
                        {
                            txtMateria.Text = DatosAsignaturas["MATNOT"].ToString();
                            txtAsignatura.Text = DatosAsignaturas["ASINOT"].ToString();
                            txtTipo.Text = DatosAsignaturas["TIPNOT"].ToString();
                            txtFecha.Text = ((DateTime)DatosAsignaturas["FECNOT"]).ToString("d/MM/yyyy");
                            txtValor.Text = DatosAsignaturas["VALNOT"].ToString();

                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la nota ingresada", "Búsqueda de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (blnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar esta nota?", "Borrar Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            cmd.CommandText = "DEL_NOTA";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("MATNOT", txtMateria.Text);
                            cmd.Parameters.AddWithValue("ASINOT", txtAsignatura.Text);
                            cmd.Parameters.AddWithValue("FECNOT", txtFecha.Text);
                            cmd.Parameters.AddWithValue("TIPNOT", txtTipo.Text);



                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtMateria.Text = "";
                            txtAsignatura.Text = "";
                            txtFecha.Text = "";
                            txtTipo.Text = "";
                            txtValor.Text = "";
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            //Validaciones
            if (txtAsignatura.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la asignatura", "Grabado de notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFecha.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la fecha", "Grabado de notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMateria.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la materia", "Grabado de notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTipo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la tipo", "Grabado de notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el valor", "Grabado de notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_NOTA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATNOT", txtMateria.Text);
                        cmd.Parameters.AddWithValue("ASINOT", txtAsignatura.Text);
                        cmd.Parameters.AddWithValue("FECNOT", txtFecha.Text);
                        cmd.Parameters.AddWithValue("TIPNOT", txtTipo.Text);
                        cmd.Parameters.AddWithValue("VALNOT", txtValor.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtAsignatura.Text = "";
                        txtFecha.Text = "";
                        txtMateria.Text = "";
                        txtTipo.Text = "";
                        txtValor.Text = "";
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
                        cmd.CommandText = "UPD_NOTA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATNOT", txtMateria.Text);
                        cmd.Parameters.AddWithValue("ASINOT", txtAsignatura.Text);
                        cmd.Parameters.AddWithValue("FECNOT", txtFecha.Text);
                        cmd.Parameters.AddWithValue("TIPNOT", txtTipo.Text);
                        cmd.Parameters.AddWithValue("VALNOT", txtValor.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtAsignatura.Text = "";
                        txtFecha.Text = "";
                        txtMateria.Text = "";
                        txtTipo.Text = "";
                        txtValor.Text = "";
                    }
                }
            }

        }



    }
}
