﻿using Control;
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
    public partial class FrmClienteActualizar : Form
    {
        CtrlCliente ctrlcliente = new CtrlCliente();
        private string nombreun;
        public FrmClienteActualizar()
        {
            InitializeComponent();
        }

        public void SetDatos(string nombre, string telefono, string correo)
        {
            nombreun = nombre;
            txtTelefono.Text = telefono.ToString();
            txtCorreo.Text = correo.ToString();
        }

        public (string, string, string) GetDatosActualizados()
        {
            return (
                nombreun,
                txtTelefono.Text,
                txtCorreo.Text
            );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            ctrlcliente.ActulizarCliente(nombreun, telefono, correo);
            MessageBox.Show("Se ha actualizado correctamente");
            this.DialogResult = DialogResult.OK;
            this.Close(); ;
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
