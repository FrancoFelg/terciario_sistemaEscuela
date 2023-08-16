namespace Escuela002
{
    partial class frmAlumnos
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMatricula = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtPostal = new TextBox();
            txtIngreso = new TextBox();
            txtFechaNacimiento = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido/s:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre/s:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "Año Ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "Código Postal:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(131, 6);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(234, 23);
            txtMatricula.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(131, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(234, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(131, 176);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(234, 23);
            txtPostal.TabIndex = 11;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(131, 143);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(234, 23);
            txtIngreso.TabIndex = 10;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(131, 112);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(234, 23);
            txtFechaNacimiento.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPostal);
            Controls.Add(txtIngreso);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMatricula);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlumnos";
            Text = "Gestion de Alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMatricula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtPostal;
        private TextBox txtIngreso;
        private TextBox txtFechaNacimiento;
        private Button button1;
    }
}