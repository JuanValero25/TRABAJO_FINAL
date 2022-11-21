using Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class InitialForm : Form
    {
        private static InitialForm CommonInstance = null;

        public InitialForm()
        {
            InitializeComponent();
            initLogin();
            CommonInstance = this;
        }

        public void EnableMenuToolTips()
        {
            alumnosToolStripMenuItem.Enabled = true;
            cursosToolStripMenuItem.Enabled = true;
            profesoresToolStripMenuItem.Enabled = true;
            materiaToolStripMenuItem.Enabled = true;
            RenderTooltops();
        }

        public static InitialForm getCommonInstance()
        {
            return CommonInstance;
        }

        public void RenderTooltops()
        {

            RolesManager roleManager = RolesManager.getInstance();
            var currentRole = roleManager.GetCurrentRole();
            //INSCRIPCION
            var AccessosCursos = currentRole.ObtenerHijos().Where(h => h.name.Equals("CURSOS"));
            var AccessosInscripcion = currentRole.ObtenerHijos().Where(h => h.name.Equals("INSCRIPCION"));
            var AccessosPermisos = currentRole.ObtenerHijos().Where(h => h.name.Equals("PAGOS"));
            var AccessosPagos = currentRole.ObtenerHijos().Where(h => h.name.Equals("PERMISOS"));
            var AccessosBackup = currentRole.ObtenerHijos().Where(h => h.name.Equals("PACKUP_AND_RESTORE"));
            var AccessosCuentas = currentRole.ObtenerHijos().Where(h => h.name.Equals("CUENTAS"));
            var FinalesCuentas = currentRole.ObtenerHijos().Where(h => h.name.Equals("FINALES"));
            var SubirCuentas = currentRole.ObtenerHijos().Where(h => h.name.Equals("SUBIR_NOTAS"));

            if (SubirCuentas.Count() > 0)
            {
                SubirNotaToolTip.Enabled = true;

            }

            if (AccessosCursos.Count() > 0)
            {
                administracionDeCursosToolStripMenuItem.Enabled = true;

            }
            if (FinalesCuentas.Count() > 0)
            {
                finalesToolStripMenuItem.Enabled = true;

            }

            if (AccessosInscripcion.Count() > 0)
            {

                inscripcionCursoToolStripMenuItem.Enabled = true;
            }

            if (AccessosPermisos.Count() > 0)
            {
                pagosToolStripMenuItem.Enabled = true;

            }

            if (AccessosPagos.Count() > 0)
            {

                permisosToolStripMenuItem.Enabled = true;
            }

            if (AccessosBackup.Count() > 0)
            {

                backupAndRestoreToolStripMenuItem.Enabled = true;
            }

            if (AccessosCuentas.Count() > 0)
            {

                cuentasToolStripMenuItem.Enabled = true;
            }

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

        private void inscripcionCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            InscripcionForm cursosForm = new InscripcionForm(currentRole);
            cursosForm.MdiParent = this;
            this.Size = cursosForm.Size;
            cursosForm.Show();

        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            PermisosForm cursosForm = new PermisosForm();
            cursosForm.MdiParent = this;
            this.Size = cursosForm.Size;
            cursosForm.Show();
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            PagosForm cursosForm = new PagosForm(currentRole);
            cursosForm.MdiParent = this;
            this.Size = cursosForm.Size;
            cursosForm.Show();
        }

        private void backupAndRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var currentRole = RolesManager.getInstance().GetCurrentRole();
            BackUpForm BackUpForm = new BackUpForm(currentRole);
            BackUpForm.MdiParent = this;
            this.Size = BackUpForm.Size;
            BackUpForm.Show();

        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            CuentasForm CuentasForm = new CuentasForm(currentRole);
            CuentasForm.MdiParent = this;
            this.Size = CuentasForm.Size;
            CuentasForm.Show();
        }

        private void finalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            FinalForm finalForm = new FinalForm(currentRole);
            finalForm.MdiParent = this;
            this.Size = finalForm.Size;
            finalForm.Show();
        }

        private void ponerNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            SubirNotasForm subirNotasForm = new SubirNotasForm(currentRole);
            subirNotasForm.MdiParent = this;
            this.Size = subirNotasForm.Size;
            subirNotasForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesManager.getInstance().ResetSession();
            disableUI();
            initLogin();
        }

        private void disableUI() {
            alumnosToolStripMenuItem.Enabled = false;
            cursosToolStripMenuItem.Enabled = false;
            profesoresToolStripMenuItem.Enabled = false;
            materiaToolStripMenuItem.Enabled = false;
            pagosToolStripMenuItem.Enabled = false;
            permisosToolStripMenuItem.Enabled = false;
            finalesToolStripMenuItem.Enabled = false;
            cuentasToolStripMenuItem.Enabled = false;
            backupAndRestoreToolStripMenuItem.Enabled = false;
            administracionDeCursosToolStripMenuItem.Enabled = false;
            inscripcionCursoToolStripMenuItem.Enabled = false;
            SubirNotaToolTip.Enabled = false;
        
        }
    }
}

