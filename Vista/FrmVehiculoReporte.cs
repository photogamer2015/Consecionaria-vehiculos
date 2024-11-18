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
    public partial class FrmVehiculoReporte : Form
    {
        CtrlVehiculo Ctrlvh = new CtrlVehiculo();

        public FrmVehiculoReporte()
        {
            InitializeComponent();
            Ctrlvh.LlenarReporte(dgvReporteVehiculo);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (dgvReporteVehiculo.SelectedRows.Count > 0)
            {
                int rowIndex = dgvReporteVehiculo.SelectedRows[0].Index;
                string msj = Ctrlvh.RetirarVehiculo(rowIndex);

                if (msj.Contains("correctamente"))
                {
                    dgvReporteVehiculo.Rows.RemoveAt(rowIndex);
                    MessageBox.Show(msj);
                }
                else
                {
                    MessageBox.Show(msj);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = cmbFiltro.SelectedItem.ToString();
            foreach (DataGridViewRow row in dgvReporteVehiculo.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == estadoSeleccionado)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string marcaBuscada = txtMarca.Text.Trim().ToUpper();
                foreach (DataGridViewRow row in dgvReporteVehiculo.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToUpper().Contains(marcaBuscada))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                txtMarca.Clear();
            }
        }
    }
}
