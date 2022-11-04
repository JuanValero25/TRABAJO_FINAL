using System;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoForm userForm = new AlumnoForm();
            userForm.MdiParent = this;
            this.Size = userForm.Size;
            userForm.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesoresForm profesorForm = new ProfesoresForm();
            profesorForm.MdiParent = this;
            this.Size = profesorForm.Size;
            profesorForm.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursosForm cursosForm = new CursosForm();
            cursosForm.MdiParent = this;
            this.Size = cursosForm.Size;
            cursosForm.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MateriaForm materiaForm = new MateriaForm();
            materiaForm.MdiParent = this;
            this.Size = materiaForm.Size;
            materiaForm.Show();
        }
    }
}
