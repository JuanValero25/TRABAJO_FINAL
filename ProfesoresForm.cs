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
using BE;

namespace TRABAJO_FINAL
{
    public partial class ProfesoresForm : Form
    {

        ProfesorBLL bll = new ProfesorBLL();
        private Profesor ProfesorSelecionado;

        public ProfesoresForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ProfesorSelecionado != null)
            {
                ProfesorSelecionado.Nombre = this.NombreText.Text;
                ProfesorSelecionado.Apellido = ApellidoText.Text;
                ProfesorSelecionado.DNI = DniTextBox.Text;
                ProfesorSelecionado.Telefono = TelefonoTextBox.Text;
                ProfesorSelecionado.Email = EmailTextBox.Text;

                bll.saveProfesor(ProfesorSelecionado);
                AgregarButton.Text = "Agregar";
                ProfesorSelecionado = null;
                return;

            }


            var newProfesor = new Profesor();
            newProfesor.ID = newProfesor.generateID();
            newProfesor.DNI = this.DniTextBox.Text;
            newProfesor.Nombre = this.NombreText.Text;
            newProfesor.Apellido = this.ApellidoText.Text;
            newProfesor.Email = this.EmailTextBox.Text;
            newProfesor.Telefono = this.TelefonoTextBox.Text;
          

            bll.saveProfesor(newProfesor);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (this.ProfesorSelecionado != null) {
                this.bll.EliminarProf(ProfesorSelecionado);
            
            }
        }

        private void ListarTodoButton_Click(object sender, EventArgs e)
        {
            var usuariList = this.bll.getAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }
    }
}
