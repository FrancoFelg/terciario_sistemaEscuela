namespace Escuela002
{
    partial class frmAlumnosLista
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
            btnSalir = new Button();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.GridColor = SystemColors.ButtonHighlight;
            dgvAlumnos.Location = new Point(12, 12);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(776, 397);
            dgvAlumnos.TabIndex = 1;
            // 
            // frmAlumnosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnSalir);
            Name = "frmAlumnosLista";
            Text = "Listado de Alumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private DataGridView dgvAlumnos;
    }
}