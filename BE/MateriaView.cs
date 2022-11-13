namespace BE
{
    public class MateriaView
    {
        public string ID { get; set; }
        public string nombre { get; set; }

        public MateriaView(string iD, string nombre)
        {
            ID = iD;
            this.nombre = nombre;
        }

        public MateriaView()
        {
        }

        public override string ToString()
        {
            return ID + " - " + nombre;
        }
    }
}
