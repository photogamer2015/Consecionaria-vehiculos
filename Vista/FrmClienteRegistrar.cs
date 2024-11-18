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
    public partial class FrmClienteRegistrar : Form
    {
        public FrmClienteRegistrar()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Num = e.KeyChar;
            if (!char.IsDigit(Num) && Num != ' ' && Num != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Num = e.KeyChar;
            if (!char.IsDigit(Num) && Num != ' ' && Num != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            CtrlCliente client = new CtrlCliente();
            string nombreCliente = txtNombre.Text;
            string apellidoCliente = txtApellido.Text;
            string cedulaCliente = txtCedula.Text;
            string telefonoCliente = txtTelefono.Text;
            string correoCliente = txtCorreo.Text;
            string id = client.generarId();

            if (string.IsNullOrWhiteSpace(nombreCliente))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(apellidoCliente))
            {
                MessageBox.Show("Por favor, ingrese su apellido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cedulaCliente))
            {
                MessageBox.Show("Por favor, ingrese la cédula del cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(telefonoCliente))
            {
                MessageBox.Show("Por favor, ingrese el numero de telefono.");
                return;
            }

            if (string.IsNullOrWhiteSpace(correoCliente))
            {
                MessageBox.Show("Por favor, ingrese el correo del cliente.");
                return;
            }

            if (cedulaCliente != null)
            {
                client.RegistrarCliente(id, nombreCliente, apellidoCliente, cedulaCliente, telefonoCliente, correoCliente);
                MessageBox.Show("Se ha registrado correctamente");
                this.Close();

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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length > 10)
            {
                txtTelefono.Text = txtTelefono.Text.Substring(0, 10);
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
        }
    }
}
