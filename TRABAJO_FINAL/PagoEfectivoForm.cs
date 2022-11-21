using BE;
using BLL;
using Servicios;
using System;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PagoEfectivoForm : Form
    {

        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private CuotaBLL CuotaBLl = new CuotaBLL();
        private PagosBLL pagoBll = new PagosBLL();

        public PagoEfectivoForm(Role role)
        {
            InitializeComponent();
        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            if (DocumentoTextBox.Text == "")
            {
                MessageBox.Show("debe insertar un documento");
            }

            var alumno = alumnoBLL.GetAlumnoPorDni(DocumentoTextBox.Text);

            var newPago = new Pago
            {
                monto = MontoNumber.Value,
                fechaDePago = DateTime.Now,
                AlumnoDocumento = DocumentoTextBox.Text,
            };


            newPago.ID = newPago.generateID();
            pagoBll.GuardarPago(newPago);

            CuotaBLl.pagarCuotasDeAlumno(DocumentoTextBox.Text, MontoNumber.Value, newPago.ID);


        }
    }
}
