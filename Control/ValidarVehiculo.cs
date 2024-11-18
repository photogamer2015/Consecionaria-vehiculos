using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ValidarVehiculo
    {
        public float ValidarKilometraje(string kilometraje)
        {
            float km = -1;
            try
            {
                km = float.Parse(kilometraje);
            }
            catch (Exception)
            {
                Console.WriteLine("Error en el kilometraje");
            }
            return km;
        }

        public float ValidarPrecio(string precio)
        {
            float pr = -1;
            try
            {
                pr = float.Parse(precio);
            }
            catch (Exception)
            {
                Console.WriteLine("Error en el precio");
            }
            return pr;
        }

        public int ValidarRuedas(string ruedas)
        {
            int ru = -1;
            try
            {
                ru = int.Parse(ruedas);
            }
            catch (Exception)
            {
                Console.WriteLine("Error en el numero de ruedas");
            }
            return ru;
        }

        public float ValidarCapacidadCarga(string capacidadCarga)
        {
            float cc = -1;
            try
            {
                cc = float.Parse(capacidadCarga);
            }
            catch (Exception)
            {
                Console.WriteLine("Error en la capacidad de carga");
            }
            return cc;
            
        }

        public string GenerarId()
        {
            string id = "";
            Random r = new Random();
            id = r.Next(1, 1000).ToString();
            return id;
        }
    }
}
