using BE;
using MPP;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class PagosBLL
    {
        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private PagoXMLMPP pagosMapper = new PagoXMLMPP();



        public void GuardarPago(Pago pago)
        {

            var Alumno = alumnoBLL.GetAlumnoPorDni(pago.AlumnoDocumento);

            if (Alumno == null)
            {
                MessageBox.Show("el DNI que inserto no esta asociado a ningun Alumno");
                return;
            }

            pagosMapper.Save(pago);
        }

        public List<Pago> GetAll() {
            return pagosMapper.GetAll();


        }

    }
}
