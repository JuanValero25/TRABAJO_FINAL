using BE;
using BLL;
using Servicios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class InscripcionForm : Form
    {

        private InscripcionBLL bll = new InscripcionBLL();
        private AlumnoBLL alumnoBll = new AlumnoBLL();
        private CursosBLL cursoBll = new CursosBLL();
        private MateriaBLL materiaBLL = new MateriaBLL();
        private CuotaBLL cuotaBLL = new CuotaBLL();
        private Inscripcion InscripcionSelecionado;

        public InscripcionForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
            InitCursos();
        }


        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("INSCRIPCION"));
            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {
                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        InscribirSeButton.Enabled = true;
                        break;
                    case "ELIMINAR":
                        EliminarButton.Enabled = true;
                        break;
                    case "LISTAR":
                        BurcarPorDNIButton.Enabled = true;
                        break;
                }
            }

        }

        private void InitCursos()
        {

            var cursos = cursoBll.GetAll();
            CursoCombo.Items.AddRange(cursos.ToArray());


        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                var inscripcion = new Inscripcion();

                var alumno = alumnoBll.getAlumno(DniTextBox.Text);

                if (alumno.DNI == null)
                {
                    MessageBox.Show("Alumno no existe");
                    return;

                }
                //ca.AlumnoID + "-" + ca.CursoID
                inscripcion.cursadaEstado = "ACTIVA";
                inscripcion.FechaDeInscripcion = DateTime.Now;
                inscripcion.FechaCaducidad = DateTime.Now.AddYears(3);
                inscripcion.AlumnoID = alumno.DNI;
                inscripcion.CursoID = ((Curso)CursoCombo.SelectedItem).ID;
                bll.InscribirEnCurso(inscripcion);

                cuotaBLL.GenerarCuotas(alumno.DNI, alumno.DNI + "-" + inscripcion.CursoID);
            }
            catch (Exception ex) {

                MessageBox.Show("ya esta inscrito en este curso");
            }

        }

        private void CursoCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var cursoSelecionado = (Curso)CursoCombo.SelectedItem;
            var materia = materiaBLL.Get(cursoSelecionado.MateriaID);

            NombreMateriaText.Text = materia.Nombre;

            FechaDeInicioText.Text = cursoSelecionado.fechaInicio.ToString();
            CuposDisponiblesNumber.Value = (cursoSelecionado.limiteEstudiantes - cursoSelecionado.estudiantesInscritos);
            PrecioNumber.Value = cursoSelecionado.Precio;


        }

        private void BurcarPorDNIButton_Click(object sender, System.EventArgs e)
        {
            var cursoAlumnoList = this.bll.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cursoAlumnoList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.InscripcionSelecionado = (Inscripcion)DataGrid.CurrentRow.DataBoundItem;

            this.CursoCombo.SelectedItem = cursoBll.Get(InscripcionSelecionado.ID);
            this.DniTextBox.Text = InscripcionSelecionado.AlumnoID;


            MessageBox.Show("Curso selecionado!");
        }

        private void EliminarButton_Click(object sender, System.EventArgs e)
        {
            if (InscripcionSelecionado != null)
            {

            }

        }

        private void FechaDeInicioText_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void CuposDisponiblesNumber_ValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
