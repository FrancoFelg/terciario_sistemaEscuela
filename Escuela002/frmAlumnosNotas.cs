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
    public partial class frmAlumnosNotas : Form
    {
        BindingSource BindingSourceNotas = new BindingSource();
        public frmAlumnosNotas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlumnosNotas_Load(object sender, EventArgs e)
        {
            dgvNotasAlumno.DataSource = BindingSourceNotas;

            lblApellido.Text = "";
            lblNombre.Text = "";
            lblIngreso.Text = "";
            lblCP.Text = "";
            lblFecNac.Text = "";
            lblNotMin.Text = "";
            lblNotMax.Text = "";
            lblPromedio.Text = "";

            dgvNotasAlumno.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /// botón buscar

            dgvNotasAlumno.Visible = false;


            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true";

                con.Open();



                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ALUMNO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;



                    cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);



                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows)
                    {

                        while (DatosAlumno.Read())
                        {
                            lblApellido.Text = "Apellido: "+DatosAlumno["APEALU"].ToString();//Asignación de campo de un data reader a una caja de texto
                            lblNombre.Text = "Nombre: "+DatosAlumno["NOMALU"].ToString();
                            lblIngreso.Text = "Fecha de Ingreso: "+DatosAlumno["INGALU"].ToString();
                            lblCP.Text = "Código postal: "+DatosAlumno["POSALU"].ToString();//BD: 2000 >  "2000"
                            lblFecNac.Text = "Fecha de Nacimiento: " + ((DateTime)DatosAlumno["FNAALU"]).ToString("dd/MM/yyyy");

                            GetNotas("SEL_ALUMNO_NOTAS");//Original: SEL_ALUMNO_NOTAS

                            dgvNotasAlumno.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                            dgvNotasAlumno.Columns[0].HeaderText = "Fecha";
                            dgvNotasAlumno.Columns[1].HeaderText = "Asignatura";
                            dgvNotasAlumno.Columns[2].HeaderText = "Tipo Examen";
                            dgvNotasAlumno.Columns[3].HeaderText = "Nota";



                            dgvNotasAlumno.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvNotasAlumno.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



                            //Antes de sacar el promedio, me fijo si traje notas
                            if (dgvNotasAlumno.Visible)
                            {
                                Promedio();
                            }

                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    DatosAlumno.Close();

                }
            }


        }


        private void Promedio()
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true";

                con.Open();


                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ALUMNO_PROMEDIO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("MATNOT", txtMatricula.Text);

                    SqlDataReader NotasAlumno = cmd.ExecuteReader();

                    if (NotasAlumno.HasRows)
                    {
                        while (NotasAlumno.Read())
                        {
                            lblPromedio.Text = "Promedio: "+NotasAlumno["PROMEDIO"].ToString();
                            lblNotMin.Text = "Nota más baja: "+NotasAlumno["MINIMO"].ToString();
                            lblNotMax.Text = "Nota más alta:"+NotasAlumno["MAXIMO"].ToString();
                        }

                    }

                }

            }
        }

        ///PROCEDIMIENTO/FUNCION APARTE

        private void GetNotas(string SPnombre)
        {
            //Procedimiento porque no devuelve ningún valor
            //Void en este contexto es null/nada
            //SPnombre es el nombre del procedimiento almacenado que llega como parámetro de ESTE procedimiento

            try
            {

                SqlConnection cn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Escuela; Integrated Security = true");
                //Se ejecuta completo en tanto no haya errores


                SqlCommand cmd = new SqlCommand();
                //Creo una datatable (matriz) - no permite modificar/solo mostrar
                DataTable dtNotas = new DataTable();

                //Instancio un obj de clase dataadapter (nueva variable)
                SqlDataAdapter daNotas = new SqlDataAdapter();


                cmd.CommandText = "SEL_ALUMNO_NOTAS";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MATNOT", txtMatricula.Text);
                cmd.Connection.Open();

                daNotas.SelectCommand = cmd;

                //Conecta a la bdd y llena la datatable
                daNotas.Fill(dtNotas);

                //Me fijo si mi tabla tiene filas, si tiene muestro la grilla cambiando el boolean a true
                if (dtNotas.Rows.Count > 0)
                {
                    dgvNotasAlumno.Visible = true;
                }
                else
                {
                    lblPromedio.Text = "Sin notas";
                    lblNotMin.Text = "Sin notas";
                    lblNotMax.Text = "Sin notas";

                    //Otra opción: agregar un message box
                }

                //Le asigno al bindign mi datatable llena y así se muestran finalmente
                BindingSourceNotas.DataSource = dtNotas;

                cmd.Connection.Close();
                cmd.Dispose();
                daNotas.Dispose();
                dtNotas.Dispose();
                cn.Close();
                cn.Dispose();

            }
            catch (SqlException exc)
            {
                //Sólo se ejecuta en caso de error dentro del bloque try
                MessageBox.Show(exc.Message.ToString());

            }
            finally
            {
                //Con error o sin error se ejecuta
            }


        }

    }

}
