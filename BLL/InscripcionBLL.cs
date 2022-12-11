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
            
       
            throw new System.Exception("ya esta inscrito");

        }

        public void save(Inscripcion ca)
        {
            mpp.Save(ca);
        }

        public List<Inscripcion> GetAll()
        {

            return mpp.GetAll();
        }

        public void Eliminar(Inscripcion ca)
        {
            mpp.Delete(ca);
        }

        public Inscripcion Get(string ID)
        {

            return mpp.Get(ID);

        }


        public List<Inscripcion> GetInscripcionPorCurso(string CursoID)
        {
            return mpp.GetAll().FindAll(i => i.CursoID.Equals(CursoID));


        }


        public Inscripcion GetInscripcionByDocumento(string documento)
        {
            return mpp.GetAll().Find(i => i.AlumnoID.Equals(documento));
        }

        public List<InscripcionPorMes> inscriptionPerMonth() {
            var inscriptionList = new List<InscripcionPorMes>();
            var allInscriptions = GetAll();

            Dictionary<string, int> InscriptionPerMonth = new Dictionary<string, int>();

           

            allInscriptions.ForEach(i => {
                var month = MonthByNumber(i.FechaDeInscripcion.Month);
                if (InscriptionPerMonth.ContainsKey(month)) {
                    InscriptionPerMonth[month] += 1;
                } else {
                    InscriptionPerMonth.Add(month, 1);
                }

               
            });

            foreach (var item in InscriptionPerMonth){
                inscriptionList.Add(new InscripcionPorMes
                {
                    month = item.Key,
                    inscriptions = item.Value
                    
                }); ;

            }


            return inscriptionList;
        }

        public string MonthByNumber(int month) {
            Dictionary<int, string> InscriptionPerMonth = new Dictionary<int, string>();

            if (month < 1 && month > 12) {
                return "";
            }


            InscriptionPerMonth.Add(1, "enero");
            InscriptionPerMonth.Add(2, "febrero");
            InscriptionPerMonth.Add(3, "marzo");
            InscriptionPerMonth.Add(4, "abril");
            InscriptionPerMonth.Add(5, "mayo");
            InscriptionPerMonth.Add(6, "junio");
            InscriptionPerMonth.Add(7, "julio");
            InscriptionPerMonth.Add(8, "agosto");
            InscriptionPerMonth.Add(9, "septiembre");
            InscriptionPerMonth.Add(10, "octubre");
            InscriptionPerMonth.Add(11, "noviembre");
            InscriptionPerMonth.Add(12, "diciembre");
            return InscriptionPerMonth[month];
        }



    }
}
