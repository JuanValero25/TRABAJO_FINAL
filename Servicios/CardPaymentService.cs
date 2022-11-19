using BE;

namespace Servicios
{
    public interface CardPaymentService
    {

        Pago PagarNow(TarjetaInfo tarjeta, decimal monto);

    }
}
