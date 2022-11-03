using BLL;
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
    public partial class CursosForm : Form
    {
        private CursosBLL cursoBLL = new CursosBLL();
        private ProfesorBLL profesorBLL = new ProfesorBLL();
        private MateriaBLL materiaBLL = new MateriaBLL();

        public CursosForm()
        {
            InitializeComponent();
            initProfesrList();
            initMaterias();
        }

        public void initProfesrList() {
            var profesorList = profesorBLL.getAll().Select(p => p.ToView()).ToList();
            this.ProfesorList.Items.AddRange(profesorList.ToArray());
        }

        public void initMaterias() {
            var materiasList = materiaBLL.getAllMaterias().Select(m=>m.toView()).ToArray();
            this.MateriaCombo.Items.AddRange(materiasList);
        
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
