namespace Escuela002
{
    partial class frmAsignaturas
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
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            btnSalir = new Button();
            btnGrabar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Asignatura";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Asignatura";
            label2.Click += label2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(282, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(129, 15);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(147, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(699, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(12, 415);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(89, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += button3_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(107, 415);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(89, 23);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // frmAsignaturas
            // 
            AcceptButton = btnGrabar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(btnSalir);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAsignaturas";
            Text = "Gestión de Asignaturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Button btnSalir;
        private Button btnGrabar;
        private Button btnBorrar;
    }
}