namespace BE
{
    public class ProfesorView
    {
        public string ID { get; set; }
        public string nombre_apellido { get; set; }

        public ProfesorView(string iD, string nombre_apellido)
        {
            ID = iD;
            this.nombre_apellido = nombre_apellido;
        }

        public ProfesorView()
        {
        }

        public override string ToString()
        {
            return ID + " - " + nombre_apellido;
        }
    }
}
