namespace Escuela002
{
    partial class frmTiposExamen
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
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(340, 19);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(106, 19);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(228, 23);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 23);
            txtNombre.TabIndex = 7;
            // 
            // frmTiposExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(btnBuscar);
            Name = "frmTiposExamen";
            Text = "Gestión de Tipos de Examen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnGrabar;
        private Button btnBorrar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private TextBox txtNombre;
    }
}