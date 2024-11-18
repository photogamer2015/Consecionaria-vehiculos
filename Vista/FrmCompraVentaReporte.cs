using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCompraVentaReporte : Form
    {
        CtrlCompraVenta ctrlCV = new CtrlCompraVenta();
        public FrmCompraVentaReporte()
        {
            InitializeComponent();
            ctrlCV.LlenarGrid(dgvReporteCompraVenta);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string error = "";

            if (!ValidarCompraVenta.ValidarCedula(txtCedula.Text.Trim()))
                error += "Cedula invalida, debe tener 10 digitos numericos \n";

            if (cmbTipo.Text.Equals(""))
                error += "Se debe escojer un tipo. (Compra o Venta) \n";

            if (error.Length > 0)
            {
                MessageBox.Show("- Registro invalido, Tomar en cuenta que: \n" + error);
                return;
            }

            ctrlCV.Reporte(dgvReporteCompraVenta, txtCedula.Text.Trim(), cmbTipo.Text);

            txtCedula.Text = "";
            cmbTipo.SelectedItem = null;
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
