using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CursosBLL
    {

        private CursosXMLMPP mpp = new CursosXMLMPP();

        public void SaveCurso(Curso curso) {
            mpp.Save(curso);
        }

        public List<Curso> GetAll() {
            return mpp.GetAll();
        }

        public Curso Get(string ID) {
           return mpp.Get(ID);


        }

        public void EliminarCurso(Curso curso) {

            mpp.Delete(curso);
        }



    }
}
