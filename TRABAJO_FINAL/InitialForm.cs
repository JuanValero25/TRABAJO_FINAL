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

        public static InitialForm getCommonInstance() {
            return CommonInstance;
        } 

        public void RenderTooltops() {

            RolesManager roleManager = RolesManager.getInstance();
          var currentRole =  roleManager.GetCurrentRole();
            //INSCRIPCION
            var AccessosCursos = currentRole.ObtenerHijos().Where(h => h.name.Equals("CURSOS"));
            var AccessosInscripcion = currentRole.ObtenerHijos().Where(h => h.name.Equals("INSCRIPCION"));
            var AccessosPermisos = currentRole.ObtenerHijos().Where(h => h.name.Equals("PAGOS"));
            var AccessosPagos = currentRole.ObtenerHijos().Where(h => h.name.Equals("PERMISOS"));

            if (AccessosCursos.Count() > 0) {
                administracionDeCursosToolStripMenuItem.Enabled = true;
                
            }

            if (AccessosInscripcion.Count() > 0) {

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
    }
    }

