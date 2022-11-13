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
    public partial class MateriaForm : Form
    {

        private Materia materiaSelecionada;
        private MateriaBLL bll = new MateriaBLL();



        public MateriaForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("MATERIAS"));


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
                        ListarButon.Enabled = true;
                        break;
                }
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            var materia = new Materia();

            if (materiaSelecionada != null)
            {
                this.materiaSelecionada.Nombre = NombreText.Text;
                materiaSelecionada.Codigo = CodigoText.Text;
                materiaSelecionada.precio = PrecioNumber.Value;

                AgregarButton.Text = "Agregar";
                materiaSelecionada = null;
                return;

            }

            materia.ID = materia.generateID();
            materia.Codigo = this.CodigoText.Text;
            materia.Nombre = this.NombreText.Text;
            materia.precio = this.PrecioNumber.Value;
            bll.SaveMateria(materia);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.materiaSelecionada = (Materia)DataGrid.CurrentRow.DataBoundItem;
            AgregarButton.Text = "Salvar Modificacion";
            this.materiaSelecionada.Nombre = NombreText.Text;
            materiaSelecionada.Codigo = CodigoText.Text;
            materiaSelecionada.precio = PrecioNumber.Value;

            MessageBox.Show("usuari selecionado!");
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            bll.EliminarMateria(materiaSelecionada);
        }

        private void ListarButon_Click(object sender, EventArgs e)
        {
            var usuariList = this.bll.getAllMaterias();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void MateriaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
