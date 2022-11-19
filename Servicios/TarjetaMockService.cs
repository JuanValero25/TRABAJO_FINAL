using BE;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Servicios
{
    public class TarjetaMockService : CardPaymentService
    {
        Random rnd = new Random();
        const string chars = "0123456789";
        public Pago PagarNow(TarjetaInfo tarjeta, decimal monto)
        {

            var OkReq = rnd.Next(100);

            var pagoRef = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());

            var finalCard = tarjeta.NumeroDeTarjeta.Substring(tarjeta.NumeroDeTarjeta.Length - 5, 5);
            var pagoTarjetaMock = new Pago
            {
                ID = pagoRef,
                fechaDePago = DateTime.Now,
                monto = monto,
                tarjetaObsfuscated = tarjeta.NumeroDeTarjeta.Substring(0, 5) + "********" + finalCard,
                estadoPagoTarjeta = OkReq > 5 ? "OK" : "ERROR",
            };

            if (pagoTarjetaMock.estadoPagoTarjeta.Equals("ERROR"))
            {
                MessageBox.Show("error usando la tarjeta vuelva a intentar");
                return null;
            }


            return pagoTarjetaMock;
        }
    }
}
