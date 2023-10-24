namespace Escuela002
{
    partial class frmNotas
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
            btnGrabar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            txtMateria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAsignatura = new TextBox();
            label3 = new Label();
            txtTipo = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label5 = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(363, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(12, 415);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(93, 415);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(130, 24);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(227, 23);
            txtMateria.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 6;
            label1.Text = "Matricula alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Asignatura";
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(130, 53);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(227, 23);
            txtAsignatura.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 87);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(130, 84);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(227, 23);
            txtTipo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 118);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(130, 115);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(227, 23);
            txtFecha.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 150);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 14;
            label5.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(130, 147);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(227, 23);
            txtValor.TabIndex = 13;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(txtFecha);
            Controls.Add(label3);
            Controls.Add(txtTipo);
            Controls.Add(label2);
            Controls.Add(txtAsignatura);
            Controls.Add(label1);
            Controls.Add(txtMateria);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(btnBuscar);
            Name = "frmNotas";
            Text = "frmNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnGrabar;
        private Button btnBorrar;
        private Button btnSalir;
        private TextBox txtMateria;
        private Label label1;
        private Label label2;
        private TextBox txtAsignatura;
        private Label label3;
        private TextBox txtTipo;
        private Label label4;
        private TextBox txtFecha;
        private Label label5;
        private TextBox txtValor;
    }
}