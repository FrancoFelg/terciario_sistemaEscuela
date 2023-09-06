namespace Escuela002
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeAlumnosToolStripMenuItem = new ToolStripMenuItem();
            gestionarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeNotasToolStripMenuItem = new ToolStripMenuItem();
            gestionarNotasToolStripMenuItem1 = new ToolStripMenuItem();
            notasDeAlumnoToolStripMenuItem1 = new ToolStripMenuItem();
            listadoDeNotasToolStripMenuItem1 = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            asignaturasToolStripMenuItem = new ToolStripMenuItem();
            ciudadesToolStripMenuItem = new ToolStripMenuItem();
            tiposDeExámenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, gestiónDeAlumnosToolStripMenuItem, gestiónDeNotasToolStripMenuItem, configuraciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // gestiónDeAlumnosToolStripMenuItem
            // 
            gestiónDeAlumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarAlumnosToolStripMenuItem });
            gestiónDeAlumnosToolStripMenuItem.Name = "gestiónDeAlumnosToolStripMenuItem";
            gestiónDeAlumnosToolStripMenuItem.Size = new Size(121, 20);
            gestiónDeAlumnosToolStripMenuItem.Text = "Gestión de Alumno";
            gestiónDeAlumnosToolStripMenuItem.Click += gestiónDeAlumnosToolStripMenuItem_Click;
            // 
            // gestionarAlumnosToolStripMenuItem
            // 
            gestionarAlumnosToolStripMenuItem.Name = "gestionarAlumnosToolStripMenuItem";
            gestionarAlumnosToolStripMenuItem.Size = new Size(175, 22);
            gestionarAlumnosToolStripMenuItem.Text = "Gestionar Alumnos";
            gestionarAlumnosToolStripMenuItem.Click += gestionarAlumnosToolStripMenuItem_Click;
            // 
            // gestiónDeNotasToolStripMenuItem
            // 
            gestiónDeNotasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarNotasToolStripMenuItem1, notasDeAlumnoToolStripMenuItem1, listadoDeNotasToolStripMenuItem1 });
            gestiónDeNotasToolStripMenuItem.Name = "gestiónDeNotasToolStripMenuItem";
            gestiónDeNotasToolStripMenuItem.Size = new Size(109, 20);
            gestiónDeNotasToolStripMenuItem.Text = "Gestión de Notas";
            // 
            // gestionarNotasToolStripMenuItem1
            // 
            gestionarNotasToolStripMenuItem1.Name = "gestionarNotasToolStripMenuItem1";
            gestionarNotasToolStripMenuItem1.Size = new Size(167, 22);
            gestionarNotasToolStripMenuItem1.Text = "Gestionar Notas";
            // 
            // notasDeAlumnoToolStripMenuItem1
            // 
            notasDeAlumnoToolStripMenuItem1.Name = "notasDeAlumnoToolStripMenuItem1";
            notasDeAlumnoToolStripMenuItem1.Size = new Size(167, 22);
            notasDeAlumnoToolStripMenuItem1.Text = "Notas de Alumno";
            // 
            // listadoDeNotasToolStripMenuItem1
            // 
            listadoDeNotasToolStripMenuItem1.Name = "listadoDeNotasToolStripMenuItem1";
            listadoDeNotasToolStripMenuItem1.Size = new Size(167, 22);
            listadoDeNotasToolStripMenuItem1.Text = "Listado de Notas";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asignaturasToolStripMenuItem, ciudadesToolStripMenuItem, tiposDeExámenToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // asignaturasToolStripMenuItem
            // 
            asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            asignaturasToolStripMenuItem.Size = new Size(163, 22);
            asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // ciudadesToolStripMenuItem
            // 
            ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            ciudadesToolStripMenuItem.Size = new Size(163, 22);
            ciudadesToolStripMenuItem.Text = "Ciudades";
            // 
            // tiposDeExámenToolStripMenuItem
            // 
            tiposDeExámenToolStripMenuItem.Name = "tiposDeExámenToolStripMenuItem";
            tiposDeExámenToolStripMenuItem.Size = new Size(163, 22);
            tiposDeExámenToolStripMenuItem.Text = "Tipos de Exámen";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Sistema de Alumnado";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestiónDeAlumnosToolStripMenuItem;
        private ToolStripMenuItem gestiónDeNotasToolStripMenuItem;
        private ToolStripMenuItem gestionarNotasToolStripMenuItem1;
        private ToolStripMenuItem notasDeAlumnoToolStripMenuItem1;
        private ToolStripMenuItem listadoDeNotasToolStripMenuItem1;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem asignaturasToolStripMenuItem;
        private ToolStripMenuItem ciudadesToolStripMenuItem;
        private ToolStripMenuItem tiposDeExámenToolStripMenuItem;
        private ToolStripMenuItem gestionarAlumnosToolStripMenuItem;
    }
}