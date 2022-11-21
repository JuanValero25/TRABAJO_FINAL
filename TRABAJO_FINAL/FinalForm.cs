using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class FinalForm : Form
    {
        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private InscripcionBLL inscripcionbll = new InscripcionBLL();
        private CursosBLL CursosBLL = new CursosBLL();

        private Inscripcion inscripcionSelecionada;


        public FinalForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("FINALES"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {

                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        InscribirButton.Enabled = true;
                        break;
                    case "ELIMINAR":
                        EliminarButton.Enabled = true;
                        break;
                    case "LISTAR":
                        ListarButton.Enabled = true;
                        break;
                }
            }

        }

        private void CursosPorDNIButton_Click(object sender, EventArgs e)
        {
            if (DocumentoTextBox.Text == "")
            {
                MessageBox.Show("Debe escribir algun DNI");
                return;

            }

            var estudiante = alumnoBLL.GetAlumnoPorDni(DocumentoTextBox.Text);

            if (estudiante == null)
            {
                MessageBox.Show("El estudiante no existe");
                return;
            }

            var allInscription = inscripcionbll.GetAll();

            if (allInscription.Count() == 0)
            {
                MessageBox.Show("no tinene ninguna inscripcion");
                return;
            }


            var inscripciones = inscripcionbll.GetAll().FindAll(i => (i.AlumnoID.Equals(estudiante.DNI) && i.cursadaEstado.Equals("A_FINAL")));

            var CursoList = new List<InscripcionCursoView>();
            CursoComboBox.Items.Clear();

            foreach (var i in inscripciones)
            {

                var curso = CursosBLL.Get(i.CursoID);

                if (curso.ID != null)
                {
                    CursoList.Add(new InscripcionCursoView
                    {
                        cursoID = curso.ID,
                        InscripcionID = i.ID,
                        NombreCurso = curso.Nombre
                    });
                }

            }

            CursoComboBox.Items.AddRange(CursoList.ToArray());

        }

        private void Inscribir_Click(object sender, EventArgs e)
        {
            var cursoView = ((InscripcionCursoView)CursoComboBox.SelectedItem);

            var inscripcion = inscripcionbll.Get(cursoView.InscripcionID);

            if (inscripcion.ID == null)
            {
                return;
            }

            inscripcionbll.Eliminar(inscripcion);
            inscripcion.cursadaEstado = "INSCRITO_EN_FINAL";
            inscripcionbll.save(inscripcion);


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (inscripcionSelecionada != null)
            {

                inscripcionSelecionada.cursadaEstado = "A_FINAL";
                inscripcionbll.Eliminar(inscripcionSelecionada);
                inscripcionbll.InscribirEnCurso(inscripcionSelecionada);

                inscripcionSelecionada = null;
            }


        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            var usuariList = this.inscripcionbll.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.inscripcionSelecionada = (Inscripcion)DataGrid.CurrentRow.DataBoundItem;
        }

        private void CursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
