using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class AlumnoBLL
    {

        AlumnoXMLMPP alumnoXMLMPP = new AlumnoXMLMPP();



        public void AgregarAlumno(Alumno alumno)
        {

            alumnoXMLMPP.Save(alumno);

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
