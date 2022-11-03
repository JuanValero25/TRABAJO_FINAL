using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
