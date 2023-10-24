namespace Escuela002
{
    partial class frmAlumnosNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblIngreso = new Label();
            lblCP = new Label();
            lblFecNac = new Label();
            lblNotMax = new Label();
            lblNotMin = new Label();
            lblPromedio = new Label();
            dgvNotasAlumno = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotasAlumno).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(276, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(25, 29);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(91, 26);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(179, 23);
            txtMatricula.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(25, 132);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(49, 15);
            lblIngreso.TabIndex = 5;
            lblIngreso.Text = "Ingreso:";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(25, 168);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(84, 15);
            lblCP.TabIndex = 6;
            lblCP.Text = "Codigo Postal:";
            // 
            // lblFecNac
            // 
            lblFecNac.AutoSize = true;
            lblFecNac.Location = new Point(25, 201);
            lblFecNac.Name = "lblFecNac";
            lblFecNac.Size = new Size(122, 15);
            lblFecNac.TabIndex = 7;
            lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // lblNotMax
            // 
            lblNotMax.AutoSize = true;
            lblNotMax.Location = new Point(412, 201);
            lblNotMax.Name = "lblNotMax";
            lblNotMax.Size = new Size(82, 15);
            lblNotMax.TabIndex = 10;
            lblNotMax.Text = "Nota Máxima:";
            // 
            // lblNotMin
            // 
            lblNotMin.AutoSize = true;
            lblNotMin.Location = new Point(412, 168);
            lblNotMin.Name = "lblNotMin";
            lblNotMin.Size = new Size(80, 15);
            lblNotMin.TabIndex = 9;
            lblNotMin.Text = "Nota Mínima:";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(412, 132);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(62, 15);
            lblPromedio.TabIndex = 8;
            lblPromedio.Text = "Promedio:";
            // 
            // dgvNotasAlumno
            // 
            dgvNotasAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotasAlumno.Location = new Point(25, 235);
            dgvNotasAlumno.Name = "dgvNotasAlumno";
            dgvNotasAlumno.RowTemplate.Height = 25;
            dgvNotasAlumno.Size = new Size(763, 176);
            dgvNotasAlumno.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmAlumnosNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(dgvNotasAlumno);
            Controls.Add(lblNotMax);
            Controls.Add(lblNotMin);
            Controls.Add(lblPromedio);
            Controls.Add(lblFecNac);
            Controls.Add(lblCP);
            Controls.Add(lblIngreso);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(btnBuscar);
            Name = "frmAlumnosNotas";
            Text = "Notas de Alumno";
            Load += frmAlumnosNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotasAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label lblMatricula;
        private TextBox txtMatricula;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblIngreso;
        private Label lblCP;
        private Label lblFecNac;
        private Label lblNotMax;
        private Label lblNotMin;
        private Label lblPromedio;
        private DataGridView dgvNotasAlumno;
        private Button btnSalir;
    }
}