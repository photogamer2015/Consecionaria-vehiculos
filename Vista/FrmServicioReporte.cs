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
    public partial class FrmServicioReporte : Form
    {
        CtrlServicios ctrlser = new CtrlServicios();
        public FrmServicioReporte()
        {
            InitializeComponent();
            ctrlser.LlenarGrid(dgvServicios);
        }
        public void ActualizarDataGridView()
        {
            ctrlser.LlenarGrid(dgvServicios);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvServicios.SelectedRows[0];
                string cedula = filaSeleccionada.Cells["colCedula"].Value.ToString();
                string tipodeVehiculo = filaSeleccionada.Cells["colTipodeVehiculo"].Value.ToString();
                string servicio = filaSeleccionada.Cells["colServicio"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["colFecha"].Value);
                float costo = float.Parse(filaSeleccionada.Cells["colCosto"].Value.ToString());

                FrmServicioActualizar formActualizar = new FrmServicioActualizar();
                formActualizar.SetDatos(cedula, tipodeVehiculo, servicio, fecha, costo);

                if (formActualizar.ShowDialog() == DialogResult.OK)
                {
                    var datosActualizados = formActualizar.GetDatosActualizados();
                    ctrlser.ModificarServicio(datosActualizados.Item3, datosActualizados.Item1, datosActualizados.Item2, datosActualizados.Item4, datosActualizados.Item5);
                    ActualizarFila(cedula);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar");
            }
        }

        private void ActualizarFila(string cedula)
        {
            foreach (DataGridViewRow fila in dgvServicios.Rows)
            {
                if (fila.Cells["colCedula"].Value.ToString() == cedula)
                {
                    ctrlser.ActualizarFilaEnGrid(fila, cedula);
                    break;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvServicios.SelectedRows[0];
                string cedula = filaSeleccionada.Cells["colCedula"].Value.ToString();
                string servicio = filaSeleccionada.Cells["colServicio"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["colFecha"].Value);

                CtrlServicios ser = new CtrlServicios();
                string mensaje = ser.EliminarServicio(cedula, servicio, fecha);

                if (mensaje.Contains("correctamente"))
                {
                    dgvServicios.Rows.RemoveAt(filaSeleccionada.Index);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el servicio");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar");
            }
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                string cedB = txtCedula.Text.Trim();
                foreach (DataGridViewRow row in dgvServicios.Rows)
                {
                    if (row.Cells["colCedula"].Value != null && row.Cells["colCedula"].Value.ToString().Contains(cedB))
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtCedula.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servselect = cmbServicio.SelectedItem.ToString();
            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                if (row.Cells["colServicio"].Value != null && row.Cells["colServicio"].Value.ToString() == servselect)
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

}
