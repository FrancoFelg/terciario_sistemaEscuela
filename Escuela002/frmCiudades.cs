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
    public partial class frmCiudades : Form
    {
        bool blnNuevo = true;

        public frmCiudades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//BUSCAR
        {
            if (txtCodigoPostal.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Búsqueda de Ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_CIUDAD";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("POSCIU", txtCodigoPostal.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosCiudad = cmd.ExecuteReader();

                    if (DatosCiudad.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosCiudad.Read())
                        {
                            txtCodigoPostal.Text = DatosCiudad["POSCIU"].ToString();
                            txtNombre.Text = DatosCiudad["NOMCIU"].ToString();                            

                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de Ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        blnNuevo = true;
                    }

                    DatosCiudad.Close();

                }
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}
