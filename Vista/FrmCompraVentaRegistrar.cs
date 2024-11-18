using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class FrmCompraVentaRegistrar : Form
    {
        CtrlCompraVenta ctrlCV = new CtrlCompraVenta();
        public FrmCompraVentaRegistrar()
        {
            InitializeComponent();
        }

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            string error = "Todos los campos deben tener valores y ser validos.\n Verificar los siguientes campos\n" +
                           " cantidad debe ser entero positivo \n" +
                           " PrecioUnitario debe ser decimal con el siguiente formato 1000,50\n";

            if (!ValidarCompraVenta.ValidarDatosDetalle(dgvDetalle))
            {
                MessageBox.Show(error);
                return;
            }

            ctrlCV.CalcularPrecios(dgvDetalle, txtSubtotal, txtTotal);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string error = "";

            string errorDetalle = "\nTodos los campos deben tener valores y ser validos.\n Verificar los siguientes campos\n" +
                                    " cantidad debe ser entero positivo \n" +
                                    " PrecioUnitario debe ser decimal con el siguiente formato 1000,50\n";

            if (!ValidarCompraVenta.ValidarCedula(txtCedula.Text.Trim()))
                error += "Cedula invalida, debe tener 10 digitos numericos \n";

            if (cmbTipo.Text.Equals(""))
                error += "Se debe escojer un tipo. (compra o venta) \n";


            if (!ValidarCompraVenta.ValidarDatosDetalle(dgvDetalle))
                error += errorDetalle;


            if (error.Length > 0)
            {
                MessageBox.Show("- Registro invalido, Tomar en cuenta que: \n" + error);
                return;
            }

            // El cliente debe ser registrado antes.
            ctrlCV.Registrar(dgvDetalle, txtCedula.Text.Trim(), cmbTipo.Text);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if (!char.IsDigit(n) && n != ' ' && n != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
