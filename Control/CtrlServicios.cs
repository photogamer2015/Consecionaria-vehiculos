using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Control
{
    public class CtrlServicios
    {
        private static List<Servicio> listaServ = new List<Servicio>();

        public static List<Servicio> ListaServ { get => listaServ; set => listaServ = value; }


        public string RegistrarServicio(string idServicio, string tipoVehiculo, string cedula, string servicios, DateTime fecha, string descripServicio, float costo)
        {

            string msj = "";
            Servicio serv = null;
            if (tipoVehiculo != null)
            {
                serv = new Servicio(idServicio, tipoVehiculo, cedula, servicios, fecha, descripServicio, costo);
                listaServ.Add(serv);
                msj = serv.ToString();
            }
            return msj;
        }

        public string ModificarServicio(string cedulaOriginal, string newTipoVehiculo, string newServicio, DateTime newFecha, float newCosto)
        {
            string msj = "Servicio modificado exitosamente";

            Servicio serv = listaServ.FirstOrDefault(s => s.Cedula == cedulaOriginal);

            if (serv != null)
            {
                serv.TipoVehiculo = newTipoVehiculo;
                serv.Servicios = newServicio;
                serv.Fecha = newFecha;
                serv.Costo = newCosto;
            }
            else
            {
                msj = "No se pudo encontrar el servicio";
            }
            return msj;
        }

        public string EliminarServicio(string cedula, string servicio, DateTime fecha)
        {
            string msj = "Se ha eliminado correctamente";
            Servicio serv = listaServ.FirstOrDefault(s => s.Cedula == cedula && s.Servicios == servicio && s.Fecha == fecha);
            if (serv != null)
            {
                listaServ.Remove(serv);
            }
            else
            {
                msj = "Servicio no encontrado";
            }
            return msj;
        }
        public int BuscarServi(String servicios)
        {
            int i = -1;
            string msj = "Servicio no encontrado";
            Servicio x = listaServ.Find(a => a.Servicios.Contains(servicios));
            if (x != null)
            {
                i = listaServ.IndexOf(x);
                Console.WriteLine("\n" + x.ToString());
            }
            else
            {
                Console.WriteLine(msj);
            }
            return i;

        }
        public int BuscarCedula(string cedula)
        {
            int i = -1;
            string msj = "Cedula del cliente no encontrada";
            Servicio x = listaServ.Find(a => a.Cedula.Equals(cedula));
            if (x != null)
            {
                i = listaServ.IndexOf(x);
                Console.WriteLine("\n" + x.ToString() + "\n");
            }
            else
            {
                Console.WriteLine(msj);
            }
            return i;
        }

        public string generarId()
        {
            string id = "";
            Random r = new Random();
            id = r.Next(1, 1000).ToString();
            return id;
        }

        public void LlenarGrid(DataGridView dgvServicios)
        {
            int i = 0;
            dgvServicios.Rows.Clear();//Limpia las filas del datagridview
            foreach (Servicio x in listaServ)
            {
                i = dgvServicios.Rows.Add();
                dgvServicios.Rows[i].Cells["colCedula"].Value = x.Cedula;
                dgvServicios.Rows[i].Cells["colTipodeVehiculo"].Value = x.TipoVehiculo;
                dgvServicios.Rows[i].Cells["colServicio"].Value = x.Servicios;
                dgvServicios.Rows[i].Cells["colFecha"].Value = x.Fecha;
                dgvServicios.Rows[i].Cells["colCosto"].Value = x.Costo;
            }
        }

        public void ActualizarFilaEnGrid(DataGridViewRow fila, string cedula)
        {
            Servicio serv = listaServ.FirstOrDefault(s => s.Cedula == cedula);
            if (serv != null)
            {
                fila.Cells["colTipodeVehiculo"].Value = serv.TipoVehiculo;
                fila.Cells["colServicio"].Value = serv.Servicios;
                fila.Cells["colFecha"].Value = serv.Fecha;
                fila.Cells["colCosto"].Value = serv.Costo;
            }
        }

    }
}
