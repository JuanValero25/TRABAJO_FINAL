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
    public partial class CursosForm : Form
    {
        private CursosBLL cursoBLL = new CursosBLL();
        private ProfesorBLL profesorBLL = new ProfesorBLL();
        private MateriaBLL materiaBLL = new MateriaBLL();

        private Curso cursoSelecionado = new Curso();

        public CursosForm(Role role)
        {
            InitializeComponent();
            InitDates();
            initProfesrList();
            initMaterias();
            renderByRole(role);
        }

        private void InitDates()
        {
            InicioDate.MinDate = DateTime.Now;
            FinalizacionDate.MinDate = DateTime.Now.AddMonths(2);


        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("CURSOS"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {

                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        AgregarButton.Enabled = true;
                        break;
                    case "ELIMINAR":
                        EliminarButton.Enabled = true;
                        break;
                    case "LISTAR":
                        ListarTodoButton.Enabled = true;
                        break;
                }
            }

        }

        public void initProfesrList()
        {
            var profesorList = profesorBLL.getAll().Select(p => p.ToView()).ToList();
            this.ProfesorList.Items.AddRange(profesorList.ToArray());
        }

        public void initMaterias()
        {
            var materiasList = materiaBLL.getAllMaterias().Select(m => m.toView()).ToArray();
            this.MateriaCombo.Items.AddRange(materiasList);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (cursoSelecionado != null)
            {
                cursoSelecionado.Nombre = NombreTextbox.Text;
                cursoSelecionado.MateriaID = ((MateriaView)MateriaCombo.SelectedItem).ID;
                cursoSelecionado.ID = cursoSelecionado.generateID();


                var empEnumerator = ProfesorList.CheckedItems.GetEnumerator();

                if (cursoSelecionado.ProfesoresID == null)
                {
                    cursoSelecionado.ProfesoresID = new List<string>();

                }

                while (empEnumerator.MoveNext())
                {

                    ProfesorView emp = (ProfesorView)empEnumerator.Current;
                    cursoSelecionado.ProfesoresID.Add(emp.ID);
                }


                if (!ValidaFechas(InicioDate.Value, FinalizacionDate.Value))
                {

                    return;
                }

                cursoSelecionado.limiteEstudiantes = LimiteNumber.Value;
                cursoSelecionado.Precio = PrecioNumber.Value;
                cursoSelecionado.fechaInicio = InicioDate.Value;
                cursoSelecionado.fechaFinalizacion = FinalizacionDate.Value;
                cursoBLL.SaveCurso(cursoSelecionado);

                AgregarButton.Text = "Agregar";
                cursoSelecionado = null;
                return;

            }

            Curso newCurso = new Curso();
            newCurso.ID = newCurso.generateID();
            newCurso.Nombre = NombreTextbox.Text;


            var newEnumerator = ProfesorList.CheckedItems.GetEnumerator();

            if (newCurso.ProfesoresID == null) {
                newCurso.ProfesoresID = new List<string>();


            }

            while (newEnumerator.MoveNext())
            {

                ProfesorView emp = (ProfesorView)newEnumerator.Current;
                newCurso.ProfesoresID.Add(emp.ID);
            }



            newCurso.MateriaID = ((MateriaView)MateriaCombo.SelectedItem).ID;
            newCurso.limiteEstudiantes = LimiteNumber.Value;
            newCurso.Precio = PrecioNumber.Value;
            newCurso.fechaInicio = InicioDate.Value;
            newCurso.fechaFinalizacion = FinalizacionDate.Value;

            cursoBLL.SaveCurso(newCurso);
        }

        private bool ValidaFechas(DateTime fechaDeInicio, DateTime fechaDeFinalizacion)
        {

            if (fechaDeInicio == null || fechaDeFinalizacion == null)
            {

                MessageBox.Show("debe selecionar alguna fecha");
                return false;
            }


            if (fechaDeInicio > fechaDeFinalizacion)
            {
                MessageBox.Show("fecha de inicio debe ser menos a la fecha final");
                return false;
            }

            return true;


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarTodoButton_Click(object sender, EventArgs e)
        {
            var usuariList = this.cursoBLL.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (this.cursoSelecionado != null)
            {
                cursoBLL.EliminarCurso(cursoSelecionado);
                cursoSelecionado = null;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.cursoSelecionado = (Curso)DataGrid.CurrentRow.DataBoundItem;
            AgregarButton.Text = "Salvar Modificacion";
            NombreTextbox.Text = this.cursoSelecionado.Nombre;


            if (this.cursoSelecionado.fechaInicio < InicioDate.MinDate ) {
                InicioDate.MinDate = this.cursoSelecionado.fechaInicio.AddDays(-1);


            }

            if (this.cursoSelecionado.fechaFinalizacion < FinalizacionDate.MinDate)
            {
                FinalizacionDate.MinDate = this.cursoSelecionado.fechaFinalizacion.AddDays(-1);


            }


            InicioDate.Value = this.cursoSelecionado.fechaInicio;
            FinalizacionDate.Value = this.cursoSelecionado.fechaFinalizacion;
            MateriaCombo.SelectedItem = materiaBLL.Get(cursoSelecionado.MateriaID);
            LimiteNumber.Value = cursoSelecionado.limiteEstudiantes;
            PrecioNumber.Value = PrecioNumber.Value;



            var empEnumerator = ProfesorList.CheckedItems.GetEnumerator();

            var counter = 0;
            while (empEnumerator.MoveNext())
            {
               
                var emp = (ProfesorView)empEnumerator.Current;
                if (this.cursoSelecionado.ProfesoresID.Select(id => id.Equals(emp.ID)).ToList().Count > 0)
                {
                    ProfesorList.SetItemChecked(counter, true);
                };
                counter++;
            }


        }

        private void CursosForm_Load(object sender, EventArgs e)
        {

        }

        private void MateriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InicioDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
