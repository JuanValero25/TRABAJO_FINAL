using BE;
using MPP;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class AlumnoBLL
    {

        AlumnoXMLMPP alumnoXMLMPP = new AlumnoXMLMPP();



        public void AgregarAlumno(Alumno alumno)
        {

            var AlumnoExistente = this.GetAll().Find(a => a.DNI.Equals(alumno.DNI));

            if (AlumnoExistente != null)
            {

                MessageBox.Show("el alumno ya existe");
                return;

            }

            alumnoXMLMPP.Save(alumno);

        }

        public void ModificarAlumno(Alumno alumno)
        {
            var AlumnoExistente = this.GetAll().Find(a => a.DNI.Equals(alumno.DNI));


            if (AlumnoExistente == null)
            {

                MessageBox.Show("el alumno no ya existe");
                return;

            }

            alumnoXMLMPP.Delete(alumno);
            alumnoXMLMPP.Save(alumno);

        }

        public Alumno GetAlumnoPorDni(string DNI)
        {

            return this.GetAll().Find(a => a.DNI.Equals(DNI));
        }

        public Alumno getAlumno(string ID)
        {
            return alumnoXMLMPP.Get(ID);
        }

        public void borrarAlumno(Alumno alumno)
        {
            alumnoXMLMPP.Delete(alumno);
        }

        public List<Alumno> GetAll()
        {

            return this.alumnoXMLMPP.GetAll();
        }



    }
}
