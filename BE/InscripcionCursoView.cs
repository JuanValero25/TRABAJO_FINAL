namespace BE
{
    public class InscripcionCursoView
    {
        public string cursoID { get; set; }
        public string InscripcionID { get; set; }
        public string NombreCurso { get; set; }


        public override string ToString()
        {
            return NombreCurso;
        }

    }


}
