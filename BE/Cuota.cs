namespace BE
{
    public class Cuota : Entidad
    {
        public string Descripcion { get; set; }
        public decimal MontoPagado { get; set; }

        public decimal MontoAPagar { get; set; }

        public string AlumnoID { get; set; }
        public string InscripcionID { get; set; }
    }
}
