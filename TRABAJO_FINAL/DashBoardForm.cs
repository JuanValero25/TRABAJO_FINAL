using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class DashBoardForm : Form
    {

        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private MateriaBLL MateriaBLL = new MateriaBLL();
        private ProfesorBLL ProfesorBLL = new ProfesorBLL();
        private InscripcionBLL inscripcionBLL = new InscripcionBLL();

        public DashBoardForm()
        {
            InitializeComponent();
            initDashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void initDashboard() {

           var nroAlumnos= alumnoBLL.GetAll().Count();
            var nroMateria = MateriaBLL.getAllMaterias().Count();
            var nroProfesor = ProfesorBLL.getAll().Count();
            var nroInscripcion = inscripcionBLL.GetAll().Count();

            NroDeAlumnos.Text = nroAlumnos.ToString();
            NroDeMaterias.Text = nroMateria.ToString();
            NroDeProfesores.Text = nroProfesor.ToString();
            NroDeInscriptos.Text = nroInscripcion.ToString();

            InscriptosPorMes();

        }

        public void InscriptosPorMes() {


            var inscription = inscripcionBLL.inscriptionPerMonth();
            DataTable dataTable = ConvertToDataTable(inscription.ToArray());

            chart1.DataSource = dataTable;

            chart1.Series["Series1"].XValueMember = "month";
            chart1.Series["Series1"].YValueMembers = "inscriptions";

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private DataTable ConvertToDataTable(Object[] array)
        {
            PropertyInfo[] properties = array.GetType().GetElementType().GetProperties();
            DataTable dt = CreateDataTable(properties);
            if (array.Length != 0)
            {
                foreach (object o in array)
                    FillData(properties, dt, o);
            }
            return dt;
        }

        private DataTable CreateDataTable(PropertyInfo[] properties)

        {
            DataTable dt = new DataTable();
            DataColumn dc = null;
            foreach (PropertyInfo pi in properties)
            {
                dc = new DataColumn();
                dc.ColumnName = pi.Name;
                dc.DataType = pi.PropertyType;
                dt.Columns.Add(dc);
            }
            return dt;
        }

        private void FillData(PropertyInfo[] properties, DataTable dt, Object o)
        {
            DataRow dr = dt.NewRow();
            foreach (PropertyInfo pi in properties)
            {
                dr[pi.Name] = pi.GetValue(o, null);
            }
            dt.Rows.Add(dr);
        }
    }
}
