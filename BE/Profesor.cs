namespace BE
{
    public class Profesor : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ProfesorView ToView()
        {
            return new ProfesorView(ID, Nombre + " " + Apellido);
        }

    }

}
