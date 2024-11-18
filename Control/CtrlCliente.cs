using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class CtrlCliente
    {
        private static List<Cliente> listaClient = new List<Cliente>();

        public static List<Cliente> ListaClient { get => listaClient; set => listaClient = value; }

        public string RegistrarCliente(string id, string nombreCliente, string apellidoCliente, string cedulaCliente, string telefonoCliente, string correoCliente)
        {
            string msj = "";
            Cliente client = null;
            if (nombreCliente != null)
            {
                client = new Cliente(id, nombreCliente, apellidoCliente, cedulaCliente, telefonoCliente, correoCliente);
                listaClient.Add(client);
                msj = client.ToString();
            }
            return msj;
        }
        public string ActulizarCliente(string nombreun, string telefonoCliente, string correoCliente)
        {
            string msj = "Cliente actualizado correctamente";

            Cliente client = listaClient.FirstOrDefault(s => s.Nombre == nombreun);

            if (client != null)
            {
                client.Telefono = telefonoCliente;
                client.Email = correoCliente;
            }
            else
            {
                msj = "No se pudo encontrar cliente";
            }
            return msj;
        }

        public string DardebajaCliente(string cedula, string nombre, string apellido, string telefono, string correo)
        {
            string msj = "Se ha eliminado correctamente";
            Cliente client = listaClient.FirstOrDefault(c => c.Cedula == cedula && c.Nombre == nombre && c.Apellido == apellido &&
            c.Telefono == telefono && c.Email == correo);
            if (client != null)
            {
                listaClient.Remove(client);
            }
            else
            {
                msj = "Cliente no encontrado";
            }
            return msj;
        }
        public int BuscarNombre(String Nombre)
        {
            int i = -1;
            string msj = "Nombre no encontrado";
            Cliente x = listaClient.Find(a => a.Nombre.Contains(Nombre));
            if (x != null)
            {
                i = listaClient.IndexOf(x);
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
            Cliente x = listaClient.Find(a => a.Cedula.Equals(cedula));
            if (x != null)
            {
                i = listaClient.IndexOf(x);
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

        public void LlenarGrid(DataGridView dgvClienteReporte)
        {
            int i = 0;
            dgvClienteReporte.Rows.Clear();//Limpia las filas del datagridview
            foreach (Cliente x in listaClient)
            {
                i = dgvClienteReporte.Rows.Add();
                dgvClienteReporte.Rows[i].Cells["colNombre"].Value = x.Nombre;
                dgvClienteReporte.Rows[i].Cells["colApellido"].Value = x.Apellido;
                dgvClienteReporte.Rows[i].Cells["colCedula"].Value = x.Cedula;
                dgvClienteReporte.Rows[i].Cells["colTelefono"].Value = x.Telefono;
                dgvClienteReporte.Rows[i].Cells["colCorreo"].Value = x.Email;
            }
        }
        public void ActualizarFilaEnGrid(DataGridViewRow fila, string nombre)
        {
            Cliente client = listaClient.FirstOrDefault(s => s.Nombre == nombre);
            if (client != null)
            {
                fila.Cells["colTelefono"].Value = client.Telefono;
                fila.Cells["colCorreo"].Value = client.Email;
            }
        }
    }
}
