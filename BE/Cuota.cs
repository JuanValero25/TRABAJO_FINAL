using System;

namespace BE
{
    public class Cuota : Entidad
    {
        public string Descripcion { get; set; }
        public decimal MontoPagado { get; set; }

        public decimal MontoAPagar { get; set; }

        public string DocumentoID { get; set; }

        public string InscripcionID { get; set; }

        public string PagoID { get; set; }

        public string Estado { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int numeroDeCuota { get; set; }


    }
}
