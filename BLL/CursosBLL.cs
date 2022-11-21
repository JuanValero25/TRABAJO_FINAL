﻿using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class CursosBLL
    {

        private CursosXMLMPP mpp = new CursosXMLMPP();

        public void SaveCurso(Curso curso)
        {
            mpp.Save(curso);
        }

        public List<Curso> GetAll()
        {
            return mpp.GetAll();
        }

        public Curso Get(string ID)
        {
            return mpp.Get(ID);


        }

        public void EliminarCurso(Curso curso)
        {

            mpp.Delete(curso);
        }

        public List<Curso> GetAllByProfesorIDAndMateria(string ID, string materiaID)
        {
            return mpp.GetAll().FindAll(c=>c.ProfesoresID.Contains(ID) && c.MateriaID.Equals(materiaID) );
        }




    }
}
