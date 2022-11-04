﻿using BE;
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

        private Curso cursoSelecionado = new Curso();

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

            if (cursoSelecionado != null)
            {
                cursoSelecionado.Nombre = NombreTextbox.Text;
                cursoSelecionado.MateriaID = ((MateriaView)MateriaCombo.SelectedItem).ID;



                using (IEnumerator<ProfesorView> empEnumerator = (IEnumerator<ProfesorView>)ProfesorList.CheckedItems.GetEnumerator())
                {
                    if (cursoSelecionado.ProfesoresID == null) {
                        cursoSelecionado.ProfesoresID = new List<string>();

                    }

                    while (empEnumerator.MoveNext())
                    {
                        
                        ProfesorView emp = empEnumerator.Current;
                        cursoSelecionado.ProfesoresID.Add(emp.ID);
                    }
                }


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


            using (IEnumerator<ProfesorView> empEnumerator = (IEnumerator<ProfesorView>)ProfesorList.CheckedItems.GetEnumerator())
            {
                if (cursoSelecionado.ProfesoresID == null)
                {
                    newCurso.ProfesoresID = new List<string>();

                }

                while (empEnumerator.MoveNext())
                {

                    ProfesorView emp = empEnumerator.Current;
                    newCurso.ProfesoresID.Add(emp.ID);
                }
            }


            newCurso.MateriaID = ((MateriaView)MateriaCombo.SelectedItem).ID;

            newCurso.fechaInicio = InicioDate.Value;
            newCurso.fechaFinalizacion = FinalizacionDate.Value;

            cursoBLL.SaveCurso(newCurso);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarTodoButton_Click(object sender, EventArgs e)
        {
            var usuariList = this.cursoBLL.GetAll() ;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuariList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DataGrid = (DataGridView)sender;
            this.cursoSelecionado = (Curso)DataGrid.CurrentRow.DataBoundItem;
            AgregarButton.Text = "Salvar Modificacion";
            NombreTextbox.Text = this.cursoSelecionado.Nombre;
            InicioDate.Value = this.cursoSelecionado.fechaInicio;
            FinalizacionDate.Value = this.cursoSelecionado.fechaFinalizacion;
            MateriaCombo.SelectedItem = materiaBLL.Get(cursoSelecionado.MateriaID);


            using (IEnumerator<ProfesorView> empEnumerator = (IEnumerator<ProfesorView>)ProfesorList.CheckedItems.GetEnumerator())
            {
                var counter = 0;
                while (empEnumerator.MoveNext())
                {
                    counter++;
                    ProfesorView emp = empEnumerator.Current;
                    if (this.cursoSelecionado.ProfesoresID.Select(id => id.Equals(emp.ID)).ToList().Count>0) {
                        ProfesorList.SetItemChecked(counter, true);
                    } ;
                }
            }


        }
    }
}
