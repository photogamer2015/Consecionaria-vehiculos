using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Control
{
    public class CtrlVehiculo
    {
        private static List <Vehiculo> listVehiculo = new List<Vehiculo>();

        public static List<Vehiculo> ListVehiculo { get => listVehiculo; set => listVehiculo = value; }

        //Metodos de Ingreso

        //Ingresar Vehiculo
        public string Ingresar(string id, string marca, string color, string tipoVehiculo, string estado, string tipoCombustible, string kilometraje, string precio)
        {
            string msj = "Se esperaban datos correctos";
            ValidarVehiculo valH = new ValidarVehiculo();

            float skm = valH.ValidarKilometraje(kilometraje) ;
            float spr = valH.ValidarPrecio(precio);

            Vehiculo vh = null;
            if (marca != "" && color != "" && tipoVehiculo != "" && estado != ""  && tipoCombustible != "")
            {
                vh = new Vehiculo(id, marca, color, tipoVehiculo, estado, tipoCombustible, skm, spr);
                listVehiculo.Add(vh);
                msj = vh.ToString();
            }
            return msj;
        }

        //Ingresar Automovil
        public string IngresarAuto(string id, string marca, string color, string tipoVehiculo, string estado, string tipoCombustible, string kilometraje, string precio, string ida,string nPuertas, string tipoTransmision, string tipoAuto)
        {
            string msj = "Se esperaban datos correctos";
            ValidarVehiculo valH = new ValidarVehiculo();

            float skm = valH.ValidarKilometraje(kilometraje);
            float spr = valH.ValidarPrecio(precio);

            Automovil automovil = null;

            if (marca != "" && color != "" && tipoVehiculo != "" && estado != "" && tipoCombustible != "" && nPuertas != "" && tipoTransmision != "" && tipoAuto != "")
            {
                automovil = new Automovil(id, marca, color, tipoVehiculo, estado, tipoCombustible, skm, spr, ida, nPuertas, tipoTransmision, tipoAuto);
                listVehiculo.Add(automovil);
                msj = ("Registro Exitoso");
            }
            return msj;
        }

        //Ingresar Camion
        public string IngresarCamion(string id, string marca, string color, string tipoVehiculo, string estado, string tipoCombustible, string kilometraje, string precio, string idc, string capacidadCarga, string tipoCarga)
        {
            string msj = "Se esperaban datos correctos";
            ValidarVehiculo valH = new ValidarVehiculo();

            float skm = valH.ValidarKilometraje(kilometraje);
            float spr = valH.ValidarPrecio(precio);
            float scpc = valH.ValidarCapacidadCarga(capacidadCarga);

            Camion camion = null;

            if (marca != "" && color != "" && tipoVehiculo != "" && estado != "" && tipoCombustible != "" && capacidadCarga != null && tipoCarga != null)
            {
                camion = new Camion(id, marca, color, tipoVehiculo, estado, tipoCombustible, skm, spr, idc, scpc, tipoCarga);
                listVehiculo.Add(camion);
                msj = ("Registro Exitoso");
            }
            return msj;
        }

        //Ingresar Motocicleta
        public string IngresarMoto(string id, string marca, string color, string tipoVehiculo, string estado, string tipoCombustible, string kilometraje, string precio, string idm, string tipoMoto, string ruedas, string tipoFreno)
        {
            string msj = "Se esperaban datos correctos";
            ValidarVehiculo valH = new ValidarVehiculo();

            float skm = valH.ValidarKilometraje(kilometraje);
            float spr = valH.ValidarPrecio(precio);
            int sruedas = valH.ValidarRuedas(ruedas);

            Motocicleta motocicleta = null;

            if (marca != "" && color != "" && tipoVehiculo != "" && estado != "" && tipoCombustible != "" && tipoMoto != "" &&  tipoFreno != "")
            {
                motocicleta = new Motocicleta(id, marca, color, tipoVehiculo, estado, tipoCombustible, skm, spr, idm, tipoMoto, sruedas, tipoFreno);
                listVehiculo.Add(motocicleta);
                msj = ("Registro Exitoso");
            }
            return msj;
            
        }

        //Limpiar Campos 

        //Limpiar Automovil
        public void LimpiarAuto(TextBox txtMarca, TextBox txtColor, ComboBox cmbTipoVehiculo, ComboBox cmbEstado, TextBox txtCombustible, TextBox txtKilometraje, TextBox txtPrecio, TextBox txtNPuertas, ComboBox cmbTipoTransmision, ComboBox cmbTipoAuto)
        {
            txtMarca.Text = "";
            txtColor.Text = "";
            cmbTipoVehiculo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtCombustible.Text = "";
            txtKilometraje.Text = "";
            txtPrecio.Text = "";
            txtNPuertas.Text = "";
            cmbTipoTransmision.SelectedIndex = -1;
            cmbTipoAuto.SelectedIndex = -1;
        }

        //Limpiar Camion
        public void LimpiarCamion(TextBox txtMarca, TextBox txtColor, ComboBox cmbTipoVehiculo, ComboBox cmbEstado, TextBox txtCombustible, TextBox txtKilometraje, TextBox txtPrecio, TextBox txtCapacidadCarga, ComboBox cmbTipoCarga)
        {
            txtMarca.Text = "";
            txtColor.Text = "";
            cmbTipoVehiculo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtCombustible.Text = "";
            txtKilometraje.Text = "";
            txtPrecio.Text = "";
            txtCapacidadCarga.Text = "";
            cmbTipoCarga.SelectedIndex = -1;
        }

        //Limpiar Motocicleta
        public void LimpiarMoto(TextBox txtMarca, TextBox txtColor, ComboBox cmbTipoVehiculo, ComboBox cmbEstado, TextBox txtCombustible, TextBox txtKilometraje, TextBox txtPrecio, ComboBox cmbTipoMoto, TextBox txtNRuedas, ComboBox cmbTipoFreno)
        {
            txtMarca.Text = "";
            txtColor.Text = "";
            cmbTipoVehiculo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtCombustible.Text = "";
            txtKilometraje.Text = "";
            txtPrecio.Text = "";
            cmbTipoMoto.SelectedIndex = -1;
            txtNRuedas.Text = "";
            cmbTipoFreno.SelectedIndex = -1;
        }

        //Metodo de Reporte
        public void LlenarReporte(DataGridView dgvReporteVehiculo)
        {
            int i = 0;
            dgvReporteVehiculo.Rows.Clear();
            foreach (Vehiculo x in listVehiculo)
            {
                i = dgvReporteVehiculo.Rows.Add();
                dgvReporteVehiculo.Rows[i].Cells[0].Value = x.Marca;
                dgvReporteVehiculo.Rows[i].Cells[1].Value = x.TipoVehiculo;
                dgvReporteVehiculo.Rows[i].Cells[2].Value = x.TipoCombustible;
                dgvReporteVehiculo.Rows[i].Cells[3].Value = x.Color;
                dgvReporteVehiculo.Rows[i].Cells[4].Value = x.Estado;
                dgvReporteVehiculo.Rows[i].Cells[5].Value = x.Precio;
            }
        }

        //Metodo de Retiro
        public string RetirarVehiculo(int index)
        {
            string msj = "Vehículo no encontrado";
            if (index >= 0 && index < listVehiculo.Count)
            {
                listVehiculo.RemoveAt(index);
                msj = "Vehículo eliminado correctamente";
            }
            return msj;
        }
    }

}
