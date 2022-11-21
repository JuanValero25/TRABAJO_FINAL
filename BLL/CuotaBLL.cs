using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class CuotaBLL
    {
        private CuotaXMLMPP cuotaMPP = new CuotaXMLMPP();
        private AlumnoBLL alumnoBLL = new AlumnoBLL();
        private InscripcionBLL inscripcionBLL = new InscripcionBLL();
        private CursosBLL cursosBLL = new CursosBLL();


        public void pagarCuotasDeAlumno(string DNI, decimal monto, string pagoID)
        {


            var cuotas = GetTodasLasCuotasByDocument(DNI).FindAll(c => !c.Estado.Equals("PAGADO"));
            cuotas.Sort();

            var CuotasPagadas = new List<Cuota>();
            foreach (Cuota c in cuotas)
            {

                if (monto > c.MontoAPagar)
                {
                    c.MontoPagado += c.MontoAPagar;
                    c.MontoAPagar = 0;
                    monto -= c.MontoPagado;
                    c.PagoID = pagoID;
                    c.Estado = "PAGADO";
                }
                else
                {
                    c.MontoPagado += monto;
                    c.MontoAPagar -= monto;
                    c.Estado = "PARCIAL";
                    c.PagoID = pagoID;
                    monto = 0;
                }
                CuotasPagadas.Add(c);

                if (monto == 0)
                {
                    break;
                }

            }

            foreach (Cuota c in CuotasPagadas)
            {
                cuotaMPP.Delete(c);
                cuotaMPP.Save(c);
            }





        }

        public void GenerarCuotas(string DNI, string inscripcionID)
        {

            var Alumno = alumnoBLL.GetAlumnoPorDni(DNI);
            var Inscripcion = inscripcionBLL.GetInscripcionByDocumento(DNI);
            var cuotas = cuotaMPP.GetAll().FindAll(c => c.InscripcionID.Equals(inscripcionID));

            if (cuotas.Count() > 0)
            {
                MessageBox.Show("cuotas generadas");
                return;
            }

            var Curso = cursosBLL.Get(Inscripcion.CursoID);

            var Months = Curso.fechaFinalizacion.Subtract(Curso.fechaInicio).Days / (365.25 / 12);
            var cuotasInt = Math.Ceiling(Months);

            for (int i = 0; i < cuotasInt; i++)
            {
                var curso = cursosBLL.Get(Inscripcion.CursoID);

                var newCuota = new Cuota
                {
                    Descripcion = curso.Nombre + " - mes " + (curso.fechaInicio.Month + i),
                    Estado = "PENDIENTE",
                    DocumentoID = DNI,
                    FechaVencimiento = curso.fechaFinalizacion.AddMonths(i).AddDays(15),
                    InscripcionID = inscripcionID,
                    MontoAPagar = curso.Precio,
                    MontoPagado = 0,
                    numeroDeCuota = i,

                };

                newCuota.ID = newCuota.generateID();
                cuotaMPP.Save(newCuota);

            }


        }


        public List<Cuota> GetTodasLasCuotasByDocument(string document)
        {
            return cuotaMPP.GetAll().FindAll(c => c.DocumentoID.Equals(document));
        }

    }
}
