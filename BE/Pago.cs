using System;

namespace BE
{
    public class Pago : Entidad
    {

        public DateTime fechaDePago { get; set; }
        public string AlumnoDocumento { get; set; }
        public string tarjetaObsfuscated { get; set; }
        public string estadoPagoTarjeta { get; set; }
        public decimal monto { get; set; }
    }
}
