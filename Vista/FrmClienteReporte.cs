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
    public partial class FrmClienteReporte : Form
    {
        CtrlCliente client = new CtrlCliente();
        public FrmClienteReporte()
        {
            InitializeComponent();
            client.LlenarGrid(dgvClienteReporte);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClienteReporte.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvClienteReporte.SelectedRows[0];
                string nombre = filaSeleccionada.Cells["colNombre"].Value.ToString();
                string telefono = filaSeleccionada.Cells["colTelefono"].Value.ToString();
                string correo = filaSeleccionada.Cells["colCorreo"].Value.ToString();

                FrmClienteActualizar frmClienteAct = new FrmClienteActualizar();
                frmClienteAct.SetDatos(nombre, telefono, correo);

                if (frmClienteAct.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar");
            }
        }

        private void ActualizarFila(string nombre)
        {
            foreach (DataGridViewRow fila in dgvClienteReporte.Rows)
            {
                if (fila.Cells["colNombre"].Value.ToString() == nombre)
                {
                    client.ActualizarFilaEnGrid(fila, nombre);
                    break;
                }
            }
        }
        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                string cedBusq = txtCedula.Text.Trim();
                foreach (DataGridViewRow row in dgvClienteReporte.Rows)
                {
                    if (row.Cells["colCedula"].Value != null && row.Cells["colCedula"].Value.ToString().Contains(cedBusq))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length > 10)
            {
                txtCedula.Text = txtCedula.Text.Substring(0, 10);
                txtCedula.SelectionStart = txtCedula.Text.Length;
            }
        }


        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string busqNom = txtNombre.Text.Trim().ToUpper();
                foreach (DataGridViewRow row in dgvClienteReporte.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToUpper().Contains(busqNom))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvClienteReporte.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvClienteReporte.SelectedRows[0];
                string nombre = filaSeleccionada.Cells["colNombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["colApellido"].Value.ToString();
                string cedula = filaSeleccionada.Cells["colCedula"].Value.ToString();
                string telefono = filaSeleccionada.Cells["colTelefono"].Value.ToString();
                string correo = filaSeleccionada.Cells["colCorreo"].Value.ToString();

                CtrlCliente ser = new CtrlCliente();
                string mensaje = ser.DardebajaCliente(cedula, nombre, apellido, telefono, correo);

                if (mensaje.Contains("Se ha dado de baja con éxito"))
                {
                    dgvClienteReporte.Rows.RemoveAt(filaSeleccionada.Index);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Error al dar de baja a cliente");
                }
            }
            else
            {
                MessageBox.Show("seleccione fila a dar de baja");
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            client.LlenarGrid(dgvClienteReporte);
        }
    }
}
