using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CompraVenta
    {
        private Cliente cliente;
        private List<Detalle> detalles;
        private string tipoCV;
        private DateTime fecha;
        private decimal subtotal;
        private decimal total;

        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string TipoCV { get => tipoCV; set => tipoCV = value; }
        public List<Detalle> Detalles { get => detalles; set => detalles = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public CompraVenta(Cliente cliente, List<Detalle> detalles, string tipoCV, DateTime fecha, decimal subtotal, decimal total)
        {
            Cliente = cliente;
            Detalles = detalles;
            TipoCV = tipoCV;
            Fecha = fecha;
            Subtotal = subtotal;
            Total = total;
        }
        public override string ToString()
        {
            return $"{Cliente?.Cedula}  {TipoCV}  {Total}  {Subtotal} ";
        }
        public decimal CalcularSubtotal()
        {
            decimal subtotal = 0m;
            foreach (var detalle in detalles)
            {
                subtotal += (detalle.Cantidad * detalle.PrecioUnitario);
            }
            Subtotal = subtotal;
            return Subtotal;
        }
        public decimal Calculartotal()
        {
            if (Subtotal != 0)
                Total = Subtotal + Decimal.Truncate(Subtotal * 0.15m);

            return Total;
        }
    }
}

