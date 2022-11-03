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

        private CursosXMLMPP bll = new CursosXMLMPP();

        public void SaveCurso(Curso curso) {
            bll.Save(curso);
        }

        public List<Curso> GetAll() {
            return bll.GetAll();
        }

        public Curso Get(string ID) {
           return bll.Get(ID);


        }

        public void EliminarCurso(Curso curso) {

            bll.Delete(curso);
        }



    }
}
