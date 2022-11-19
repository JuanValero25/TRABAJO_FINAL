
namespace TRABAJO_FINAL
{
    partial class InitialForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Enabled = false;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionDeCursosToolStripMenuItem,
            this.inscripcionCursoToolStripMenuItem});
            this.cursosToolStripMenuItem.Enabled = false;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // administracionDeCursosToolStripMenuItem
            // 
            this.administracionDeCursosToolStripMenuItem.Enabled = false;
            this.administracionDeCursosToolStripMenuItem.Name = "administracionDeCursosToolStripMenuItem";
            this.administracionDeCursosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.administracionDeCursosToolStripMenuItem.Text = "Administracion de cursos";
            this.administracionDeCursosToolStripMenuItem.Click += new System.EventHandler(this.administracionDeCursosToolStripMenuItem_Click);
            // 
            // inscripcionCursoToolStripMenuItem
            // 
            this.inscripcionCursoToolStripMenuItem.Enabled = false;
            this.inscripcionCursoToolStripMenuItem.Name = "inscripcionCursoToolStripMenuItem";
            this.inscripcionCursoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inscripcionCursoToolStripMenuItem.Text = "Inscripcion curso";
            this.inscripcionCursoToolStripMenuItem.Click += new System.EventHandler(this.inscripcionCursoToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Enabled = false;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Enabled = false;
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Enabled = false;
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Enabled = false;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InitialForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
    }
}

