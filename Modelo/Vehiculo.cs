using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vehiculo
    {
        private string idVehiculo;
        private string marca;
        private string tipoVehiculo;
        private string tipoCombustible;
        private string color;
        private string estado;
        private float kilometraje;
        private float precio;

        public string IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string TipoCombustible { get => tipoCombustible; set => tipoCombustible = value; }
        public string Color { get => color; set => color = value; }
        public float Kilometraje { get => kilometraje; set => kilometraje = value; }
        public float Precio { get => precio; set => precio = value; }

        public Vehiculo(string idVehiculo, string marca, string tipoVehiculo, string tipoCombustible, string color, string estado, float kilometraje, float precio)
        {
            IdVehiculo = idVehiculo;
            Marca = marca;
            TipoVehiculo = tipoVehiculo;
            TipoCombustible = tipoCombustible;
            Color = color;
            Estado = estado;
            Kilometraje = kilometraje;
            Precio = precio;
        }

        public void RegistarVehiculo()
        {

        }

        public void ReporteVehiculo()
        {

        }

        public Boolean RetirarVehiculo()
        {
            return true;
        }

        public override string ToString()
        {
            return "Id: " + IdVehiculo + "\nMarca: " + Marca + "\nTipo de Vehiculo: " + TipoVehiculo + "\nTipo de Combustible: " + TipoCombustible + "\nColor: " + Color + "\nEstado: " + Estado + "\nKilometraje: " + Kilometraje + "\nPrecio: " + Precio;
        }
    }
}
