using BLL;
using Servicios;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PagosForm : Form
    {
        private PagosBLL pagosBLL = new PagosBLL();
        private CuotaBLL cuotaBLL = new CuotaBLL();

        public PagosForm(Role role)
        {
            InitializeComponent();
            renderByRole(role);
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("PAGOS"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {
                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        PagoConTarjeta.Enabled = true;
                        PagoEfectivoButton.Enabled = true;
                        break;
                    case "LISTAR":
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PagoConTarjeta_Click(object sender, EventArgs e)
        {

            var currentRole = RolesManager.getInstance().GetCurrentRole();
            PagoDeTarjetaForm pagoTarjetaForm = new PagoDeTarjetaForm(currentRole);
            pagoTarjetaForm.MdiParent = InitialForm.getCommonInstance(); 
            this.Size = pagoTarjetaForm.Size;
            pagoTarjetaForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DocumentoTextBox.Text == "") {
                MessageBox.Show("debe inserta algun documento");
                return;
            
            }

            var PagoList = this.pagosBLL.GetAll().Where(p=>p.AlumnoDocumento.Equals(DocumentoTextBox.Text));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PagoList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PagoEfectivoButton_Click(object sender, EventArgs e)
        {
            var currentRole = RolesManager.getInstance().GetCurrentRole();
            PagoEfectivoForm pagoEfectivoForm = new PagoEfectivoForm(currentRole);
            pagoEfectivoForm.MdiParent = InitialForm.getCommonInstance(); ;
            this.Size = pagoEfectivoForm.Size;
            pagoEfectivoForm.Show();
        }

        private void ListarCuotas_Click(object sender, EventArgs e)
        {
            if (DocumentoTextBox.Text == "")
            {
                MessageBox.Show("debe inserta algun documento");
                return;

            }

            var PagoList = this.cuotaBLL.GetTodasLasCuotasByDocument(DocumentoTextBox.Text);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PagoList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }
    }
}
