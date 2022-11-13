using Servicios;
using System;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            initLogin();
        }

        public void EnableMenuToolTips()
        {
            alumnosToolStripMenuItem.Enabled = true;
            cursosToolStripMenuItem.Enabled = true;
            profesoresToolStripMenuItem.Enabled = true;
            materiaToolStripMenuItem.Enabled = true;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            AlumnoForm userForm = new AlumnoForm(currentRole);
            userForm.MdiParent = this;
            this.Size = userForm.Size;
            userForm.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            ProfesoresForm profesorForm = new ProfesoresForm(currentRole);
            profesorForm.MdiParent = this;
            this.Size = profesorForm.Size;
            profesorForm.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            MateriaForm materiaForm = new MateriaForm(currentRole);
            materiaForm.MdiParent = this;
            this.Size = materiaForm.Size;
            materiaForm.Show();
        }

        private void initLogin()
        {

            LoginForm loginForm = new LoginForm(this);
            loginForm.MdiParent = this;
            this.Size = loginForm.Size;
            loginForm.Show();
        }

        private void administracionDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            CursosForm cursosForm = new CursosForm(currentRole);
            cursosForm.MdiParent = this;
            this.Size = cursosForm.Size;
            cursosForm.Show();
        }
    }
}
