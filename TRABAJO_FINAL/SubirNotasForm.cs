using BE;
using BLL;
using Servicios;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class SubirNotasForm : Form
    {

        private InscripcionBLL inscripcionBLL = new InscripcionBLL();
        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private CursosBLL cursoBLL = new CursosBLL();
        private ProfesorBLL profesorBLL = new ProfesorBLL();
        private MateriaBLL materiaBLL = new MateriaBLL();

        private Inscripcion inscripcionSelecionada;

        public SubirNotasForm(Role role)
        {
            InitializeComponent();
            initMaterias();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("SUBIR_NOTAS"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {

                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        GuardarNotasButton.Enabled = true;
                        break;

                }
            }

        }

        public void initMaterias()
        {
            var materiasList = materiaBLL.getAllMaterias().Select(m => m.toView()).ToArray();
            this.MateriaCombo.Items.AddRange(materiasList);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            var inscripcion = (Inscripcion)DataGrid.CurrentRow.DataBoundItem;
            inscripcionSelecionada = inscripcion;
            NotaAlumno.Value = inscripcion.notaCursada;

            var alumno = alumnoBLL.getAlumno(inscripcion.AlumnoID);

            NombreAlumnoText.Text = alumno.Nombre;
            DniALumnoText.Text = alumno.DNI;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CursoSelected = (Curso)CursoCombo.SelectedItem;

            var inscripciones = inscripcionBLL.GetInscripcionPorCurso(CursoSelected.ID);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = inscripciones;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;


        }

        private void MateriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DniProfesorText.Text != "")
            {
                var materiaSelected = (MateriaView)MateriaCombo.SelectedItem;
                var cursos = cursoBLL.GetAllByProfesorIDAndMateria(DniProfesorText.Text, materiaSelected.ID);


                CursoCombo.Items.Clear();
                CursoCombo.Items.AddRange(cursos.ToArray());


            }


        }

        private void SubirNotasForm_Load(object sender, EventArgs e)
        {

        }

        private void DniProfesorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inscripcionSelecionada != null)
            {
                inscripcionBLL.Eliminar(inscripcionSelecionada);
                inscripcionSelecionada.notaCursada = Decimal.ToInt32(NotaAlumno.Value);

                if (NotaAlumno.Value >= 4)
                {
                    inscripcionSelecionada.cursadaEstado = "A_FINAL";
                    MessageBox.Show("Inscripcion guardada con estado A_FINAL");
                }
                else
                {
                    inscripcionSelecionada.cursadaEstado = "A_REPARAR";
                    MessageBox.Show("Inscripcion guardada con estado A_REPARAR");
                }

                inscripcionBLL.save(inscripcionSelecionada);

            }



        }
    }
}
