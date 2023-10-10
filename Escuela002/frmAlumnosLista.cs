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
    public partial class frmAlumnosLista : Form
    {


        //Objeto que me permite linkear los datos con la grilla
        BindingSource BindingSourceAlumnos = new BindingSource();

        public frmAlumnosLista()
        {
            InitializeComponent();
        }

        private void frmAlumnosLista_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de datoS, la variable que creé en la clase

            dgvAlumnos.DataSource = BindingSourceAlumnos;

            //clsAlumnos clsAlumnos = new clsAlumnos(); // instanciamos la clase

            BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");

            SetAlumnos();
        }


        //PEGAR TODO ESTE CODIGO DEBAJO DE LA LLAVE QUE CIERRA frmAlumnosLista_Load

        private void SetAlumnos()
        {
            dgvAlumnos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAlumnos.Columns[0].HeaderText = "Matrícula";
            dgvAlumnos.Columns[1].HeaderText = "Apellido";
            dgvAlumnos.Columns[2].HeaderText = "Nombre";
            dgvAlumnos.Columns[3].HeaderText = "DNI";
            dgvAlumnos.Columns[4].HeaderText = "Código Postal";
            dgvAlumnos.Columns[5].HeaderText = "Fecha de Nacimiento";
            dgvAlumnos.Columns[6].HeaderText = "Fecha carga";
            dgvAlumnos.Columns[7].HeaderText = "Usuario";

            //Números y fechas van por defecto a la derecha
            dgvAlumnos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgvAlumnos.Columns[6].Visible = false;
            dgvAlumnos.Columns[7].Visible = false;
        }

        private DataTable GetAlumnos(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtAlumnos = new DataTable();

            try
            {
                //se ejecuta completo en tanto no haya ningún error

                // definimos un dataadapter llamado daAlumnos
                SqlDataAdapter daAlumnos = new SqlDataAdapter();



                daAlumnos = new SqlDataAdapter(SPNombre, "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EscuelaLeti; Integrated Security = true");

                SqlCommandBuilder cbAlumnos = new SqlCommandBuilder(daAlumnos);
                //
                daAlumnos.Fill(dtAlumnos);

                //

                return dtAlumnos;

            }

            catch (SqlException exc)

            {

                //sólo se ejecuta si se produjo algún error dentro del bloque try
                MessageBox.Show("No se pudo recuperar los datos del alumno", exc.Message.ToString());


            }
            finally
            {

                //Con error o sin error se ejecuta


            }

            return dtAlumnos;
        }

        private void frmAlumnosLista_Load_1(object sender, EventArgs e)
        {
            //Asigno a mi fuente de datoS, la variable que creé en la clase

            dgvAlumnos.DataSource = BindingSourceAlumnos;

            //clsAlumnos clsAlumnos = new clsAlumnos(); // instanciamos la clase

            BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");

            SetAlumnos();
        }
    }
}
