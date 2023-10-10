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
            button1 = new Button();
            lblMatricula = new Label();
            textBox1 = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblIngreso = new Label();
            lblCodigoPostal = new Label();
            lblFechaNac = new Label();
            lblNotaMax = new Label();
            lblNotaMin = new Label();
            lblPromedio = new Label();
            dgvNotasAlumno = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotasAlumno).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(91, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 2;
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
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(25, 168);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 6;
            lblCodigoPostal.Text = "Codigo Postal:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(25, 201);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(122, 15);
            lblFechaNac.TabIndex = 7;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblNotaMax
            // 
            lblNotaMax.AutoSize = true;
            lblNotaMax.Location = new Point(412, 201);
            lblNotaMax.Name = "lblNotaMax";
            lblNotaMax.Size = new Size(82, 15);
            lblNotaMax.TabIndex = 10;
            lblNotaMax.Text = "Nota Máxima:";
            // 
            // lblNotaMin
            // 
            lblNotaMin.AutoSize = true;
            lblNotaMin.Location = new Point(412, 168);
            lblNotaMin.Name = "lblNotaMin";
            lblNotaMin.Size = new Size(80, 15);
            lblNotaMin.TabIndex = 9;
            lblNotaMin.Text = "Nota Mínima:";
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
            Controls.Add(lblNotaMax);
            Controls.Add(lblNotaMin);
            Controls.Add(lblPromedio);
            Controls.Add(lblFechaNac);
            Controls.Add(lblCodigoPostal);
            Controls.Add(lblIngreso);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(textBox1);
            Controls.Add(lblMatricula);
            Controls.Add(button1);
            Name = "frmAlumnosNotas";
            Text = "Notas de Alumno";
            ((System.ComponentModel.ISupportInitialize)dgvNotasAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblMatricula;
        private TextBox textBox1;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblIngreso;
        private Label lblCodigoPostal;
        private Label lblFechaNac;
        private Label lblNotaMax;
        private Label lblNotaMin;
        private Label lblPromedio;
        private DataGridView dgvNotasAlumno;
        private Button btnSalir;
    }
}