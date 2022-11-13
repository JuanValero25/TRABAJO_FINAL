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
    public partial class AlumnoForm : Form
    {

        AlumnoBLL bll = new AlumnoBLL();
        private Alumno AlumnoSelecionado;


        public AlumnoForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("ALUMNOS"));


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
                        ListarTodo.Enabled = true;
                        break;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (AlumnoSelecionado != null)
            {
                AlumnoSelecionado.Nombre = NombreTextBox.Text;
                AlumnoSelecionado.Apellido = ApellidoTextBox.Text;
                AlumnoSelecionado.DNI = DNITextBox.Text;
                AlumnoSelecionado.Telefono = TelefonoTextBox.Text;
                AlumnoSelecionado.Email = EmailTextBox.Text;
                AlumnoSelecionado.Estado = this.EstadoTextBox.SelectedItem.ToString();
                bll.AgregarAlumno(AlumnoSelecionado);
                AgregarButton.Text = "Agregar";
                AlumnoSelecionado = null;
                return;

            }


            var newAlumno = new Alumno();
            newAlumno.ID = newAlumno.generateID();
            newAlumno.DNI = this.DNITextBox.Text;
            newAlumno.Nombre = this.NombreTextBox.Text;
            newAlumno.Apellido = this.ApellidoTextBox.Text;
            newAlumno.Email = this.EmailTextBox.Text;
            newAlumno.Telefono = this.TelefonoTextBox.Text;
            newAlumno.Estado = this.EstadoTextBox.SelectedItem.ToString();

            bll.AgregarAlumno(newAlumno);

        }


        private void ListarTodo_Click(object sender, EventArgs e)
        {
            var usuariList = this.bll.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            if (AlumnoSelecionado != null)
            {

                this.bll.borrarAlumno(AlumnoSelecionado);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.AlumnoSelecionado = (Alumno)DataGrid.CurrentRow.DataBoundItem;
            AgregarButton.Text = "Salvar Modificacion";
            this.NombreTextBox.Text = AlumnoSelecionado.Nombre;
            this.ApellidoTextBox.Text = AlumnoSelecionado.Apellido;
            this.DNITextBox.Text = AlumnoSelecionado.DNI;
            this.EmailTextBox.Text = AlumnoSelecionado.Email;
            this.EstadoTextBox.SelectedItem = AlumnoSelecionado.Estado;
            this.TelefonoTextBox.Text = AlumnoSelecionado.Telefono;


            MessageBox.Show("Alumno selecionado!");
        }
    }
}
