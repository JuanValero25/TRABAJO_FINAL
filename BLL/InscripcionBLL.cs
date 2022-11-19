using BE;
using MPP;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class InscripcionBLL
    {
        private InscriptionXMLMPP mpp = new InscriptionXMLMPP();
        private CursosBLL CursosBLL = new CursosBLL();


        public void InscribirEnCurso(Inscripcion ca)
        {


            var inscripcion = mpp.Get(ca.AlumnoID + "-" + ca.CursoID);


            if (inscripcion.ID == null)
            {
                ca.ID = ca.AlumnoID + "-" + ca.CursoID;
                mpp.Save(ca);

                var curso = CursosBLL.Get(ca.CursoID);
                curso.estudiantesInscritos += 1;

                CursosBLL.EliminarCurso(curso);
                CursosBLL.SaveCurso(curso);


                return;
            }

            MessageBox.Show("ya esta inscrito en este curso");

        }

        public List<Inscripcion> GetAll()
        {

            return mpp.GetAll();
        }

        public void Eliminar(Inscripcion ca)
        {
            mpp.Delete(ca);
        }

        public Inscripcion GetInscripcionByDocumento(string documento)
        {
            return mpp.GetAll().Find(i => i.AlumnoID.Equals(documento));
        }



    }
}
