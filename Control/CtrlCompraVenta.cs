using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class CtrlCompraVenta
    {
        private static List<CompraVenta> listCompraVenta = new List<CompraVenta>();

        public static List<CompraVenta> ListCompraVenta { get => listCompraVenta; set => listCompraVenta = value; }

        public void CalcularPrecios(DataGridView dgvDetalle, TextBox txtSubtotal, TextBox txtTotal)
        {
            decimal subtotal = 0m, total = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                int Cantidad = ValidarCompraVenta.aEntero(row.Cells["colCantidad"].Value.ToString());
                decimal precioUnitario = ValidarCompraVenta.aDecimal(row.Cells["colPrecioUnitario"].Value.ToString());

                subtotal += (Cantidad * precioUnitario);

                if (++i == dgvDetalle.RowCount - 1) break;// Ignora el ultimo registro en blanco de la grilla
            }
            txtSubtotal.Text = subtotal.ToString();
            total = subtotal + Decimal.Truncate(subtotal * 0.15m);
            txtTotal.Text = total.ToString();
        }

        public void LlenarGrid(DataGridView dgvReporteCompraVenta)
        {
            int i = 0;
            dgvReporteCompraVenta.Rows.Clear();//Limpia las filas del datagridview
            foreach (CompraVenta compraVenta in listCompraVenta)
            {
                // Detalle de la venta del cliente
                compraVenta.Detalles.ForEach((detalle) =>
                {
                    i = dgvReporteCompraVenta.Rows.Add();
                    dgvReporteCompraVenta.Rows[i].Cells["colNombre"].Value = compraVenta.Cliente.Nombre;
                    dgvReporteCompraVenta.Rows[i].Cells["colTipo"].Value = compraVenta.TipoCV;
                    dgvReporteCompraVenta.Rows[i].Cells["colCantidad"].Value = detalle.Cantidad;
                    dgvReporteCompraVenta.Rows[i].Cells["colPrecioUnitario"].Value = detalle.PrecioUnitario;
                });
            }

        }

        public void Registrar(DataGridView grid, string cedula, string tipo)
        {
            CompraVenta compraVenta = new CompraVenta();
            Cliente client = CtrlCliente.ListaClient.Find(x => x.Cedula == cedula);
            if(client == null)
            {
                MessageBox.Show("El cliente debe ser registrado!");
                return;
            }

            MessageBox.Show("Registro exitoso!");

            compraVenta.Cliente = client;
            compraVenta.Detalles = LlenarDetalle(grid);
            compraVenta.TipoCV = tipo;
            compraVenta.Subtotal = compraVenta.CalcularSubtotal();
            compraVenta.Total = compraVenta.Calculartotal();

            listCompraVenta.Add(compraVenta);
        }

        public void Reporte(DataGridView grid, string cedula, string tipo)
        {
            List<CompraVenta> listaFiltrada = listCompraVenta.FindAll(x => (x.Cliente.Cedula == cedula && x.TipoCV == tipo));
            int i = 0;
            grid.Rows.Clear();//Limpia las filas del datagridview
            if (listaFiltrada.Count > 0)
            {
                listaFiltrada.ForEach((venta) =>
                {
                    // Detalle de la venta del cliente
                    venta.Detalles.ForEach((detalle) =>
                    {
                        i = grid.Rows.Add();
                        grid.Rows[i].Cells["colNombre"].Value = venta.Cliente.Nombre;
                        grid.Rows[i].Cells["colTipo"].Value = tipo;
                        grid.Rows[i].Cells["colCantidad"].Value = detalle.Cantidad;
                        grid.Rows[i].Cells["colPrecioUnitario"].Value = detalle.PrecioUnitario;
                    });
                });
            }
            else
            {
                MessageBox.Show("No hay registros!");
            }
        }

        private List<Detalle> LlenarDetalle(DataGridView grid)
        {
            decimal subtotal = 0m;
            int i = 0;

            List<Detalle> detalles = new List<Detalle>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                int Cantidad = ValidarCompraVenta.aEntero(row.Cells["colCantidad"].Value.ToString());
                decimal precioUnitario = ValidarCompraVenta.aDecimal(row.Cells["colPrecioUnitario"].Value.ToString());

                subtotal += (Cantidad * precioUnitario);

                detalles.Add(new Detalle(Cantidad, precioUnitario));
                if (++i == grid.RowCount - 1) break;// Ignora el ultimo registro en blanco de la grilla
            }
            return detalles;
        }
    }
}
