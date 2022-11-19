using BLL;
using Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TRABAJO_FINAL
{
    public partial class PagoDeTarjetaForm : Form
    {

        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private TarjetaMockService tarjetaService = new TarjetaMockService();
        private CuotaBLL CuotaBLl = new CuotaBLL();
        private PagosBLL pagoBll = new PagosBLL();

        public PagoDeTarjetaForm(Role role)
        {
            InitializeComponent();
        }

        private void renderByRole(Role role)
        {
            var Accessos = role.ObtenerHijos().Where(h => h.name.Equals("PAGO_TARJETA"));


            foreach (Permiso p in Accessos.First().ObtenerHijos())
            {
                switch (p.name)
                {
                    case "AGREGAR_MODIFICAR":
                        PagoButton.Enabled = true;
                        break;
                }
            }
        }

        private bool validaCampos() {

            return
               DocumentoTarjeta.Text != "" &&
               NombreEnTarjetaText.Text != "" &&
               CodigoDeSeguridad.Text != "" &&
               DniAlumno.Text != "" &&
               NumeroTarjeta.Text!= "" &&
               NumeroTarjeta.Text.Length >= 16 &&
               NumeroTarjeta.Text.Length < 19 &&
               FechaDeVencimiento.Value > DateTime.Now;
                ;

        
            
        }


        private void PagoButton_Click(object sender, System.EventArgs e)
        {

            if (!validaCampos()) {
                MessageBox.Show("Alguno de los Campos pueden estar vacios o mal escrito porfavor verifique");
                return;
                
            }

            var DNIDeEstudiante = DniAlumno.Text;

            var alumno = alumnoBLL.GetAlumnoPorDni(DNIDeEstudiante);

            if (alumno.ID == null)
            {
                MessageBox.Show("Alumno no existe");
                return;
            }

            var tInfo = new TarjetaInfo
            {
                CodigoDeverificacion = CodigoDeSeguridad.Text,
                Documento = DocumentoTarjeta.Text,
                Nombre = NombreEnTarjetaText.Text,
                FechaDeVencimiento = FechaDeVencimiento.Value,
                NumeroDeTarjeta = NumeroTarjeta.Text
            };

            var pago = tarjetaService.PagarNow(tInfo, MontoApagar.Value);

            if (pago == null)
            {
                return;
            }

            pago.AlumnoDocumento = DniAlumno.Text;

            pagoBll.GuardarPago(pago);

            CuotaBLl.pagarCuotasDeAlumno(DNIDeEstudiante, MontoApagar.Value, pago.ID);



        }
    }
}
