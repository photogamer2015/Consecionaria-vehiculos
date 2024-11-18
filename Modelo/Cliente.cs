using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        private string idCliente;
        private string nombre;
        private string apellido;
        private string cedula;
        private string telefono;
        private string email;

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public Cliente(string idCliente, string nombre, string apellido, string cedula, string telefono, string email)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            Email = email;
        }

        public void registrarCliente()
        {

        }

        public void ActualizarCliente()
        {

        }

        public void AnularCliente()
        {

        }

        public void ReporteCliente()
        {

        }
    }
}
