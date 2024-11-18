using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class ValidarCompraVenta
    {
        public static bool ValidarDatosDetalle(DataGridView grid)
        {
            bool esValido = true;
            int i = 0;

            if (grid.RowCount == 1)
                return !esValido;

            foreach (DataGridViewRow row in grid.Rows)
            {
                decimal Cantidad = ValidarCompraVenta.aDecimal(row.Cells["colCantidad"].Value.ToString());

                if (row.Cells["colCantidad"].Value == null || row.Cells["colDescripcion"].Value == null || row.Cells["colPrecioUnitario"].Value == null)
                    return !esValido;

                if (row.Cells["colCantidad"].Value.ToString().Contains(".") ||
                    row.Cells["colPrecioUnitario"].Value.ToString().Contains("."))
                    return !esValido;

                if (Cantidad <= 0)
                    return !esValido;

                if (++i == grid.RowCount - 1) break;
            }
            return esValido;
        }

        public static bool ValidarCedula(string cedula)
        {
            bool esValido = true;

            if (cedula.Length != 10 || String.IsNullOrEmpty(cedula))
                return !esValido;

            foreach (char letra in cedula)
            {
                if (Char.IsLetter(letra))
                {
                    esValido = false;
                    break;
                }
            }

            return esValido;
        }

        public static decimal aDecimal(string valor)
        {
            try
            {
                return Decimal.Parse(valor);
            }
            catch
            {
                return -1;
            }
        }

        public static int aEntero(string valor)
        {
            try
            {
                return Convert.ToInt32(valor.Trim());
            }
            catch
            {
                return -1;
            }
        }
    }
}
