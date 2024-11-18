namespace Vista
{
    partial class FrmMainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCompraVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.compraVentaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(745, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.reporteClientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVehiculoToolStripMenuItem,
            this.reporteVehiculoToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // registroVehiculoToolStripMenuItem
            // 
            this.registroVehiculoToolStripMenuItem.Name = "registroVehiculoToolStripMenuItem";
            this.registroVehiculoToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.registroVehiculoToolStripMenuItem.Text = "Registro Vehiculo";
            this.registroVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroVehiculoToolStripMenuItem_Click);
            // 
            // reporteVehiculoToolStripMenuItem
            // 
            this.reporteVehiculoToolStripMenuItem.Name = "reporteVehiculoToolStripMenuItem";
            this.reporteVehiculoToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.reporteVehiculoToolStripMenuItem.Text = "Reporte Vehiculo";
            this.reporteVehiculoToolStripMenuItem.Click += new System.EventHandler(this.reporteVehiculoToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarServicioToolStripMenuItem,
            this.reporteServicioToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // registrarServicioToolStripMenuItem
            // 
            this.registrarServicioToolStripMenuItem.Name = "registrarServicioToolStripMenuItem";
            this.registrarServicioToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.registrarServicioToolStripMenuItem.Text = "Registrar Servicio";
            this.registrarServicioToolStripMenuItem.Click += new System.EventHandler(this.registrarServicioToolStripMenuItem_Click);
            // 
            // reporteServicioToolStripMenuItem
            // 
            this.reporteServicioToolStripMenuItem.Name = "reporteServicioToolStripMenuItem";
            this.reporteServicioToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.reporteServicioToolStripMenuItem.Text = "Reporte Servicio";
            this.reporteServicioToolStripMenuItem.Click += new System.EventHandler(this.reporteServicioToolStripMenuItem_Click);
            // 
            // compraVentaToolStripMenuItem
            // 
            this.compraVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraVentaToolStripMenuItem,
            this.reporteCompraVentaToolStripMenuItem});
            this.compraVentaToolStripMenuItem.Name = "compraVentaToolStripMenuItem";
            this.compraVentaToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.compraVentaToolStripMenuItem.Text = "Compra/Venta";
            // 
            // registrarCompraVentaToolStripMenuItem
            // 
            this.registrarCompraVentaToolStripMenuItem.Name = "registrarCompraVentaToolStripMenuItem";
            this.registrarCompraVentaToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.registrarCompraVentaToolStripMenuItem.Text = "Registrar Compra Venta";
            this.registrarCompraVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraVentaToolStripMenuItem_Click);
            // 
            // reporteCompraVentaToolStripMenuItem
            // 
            this.reporteCompraVentaToolStripMenuItem.Name = "reporteCompraVentaToolStripMenuItem";
            this.reporteCompraVentaToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.reporteCompraVentaToolStripMenuItem.Text = "Reporte Compra Venta";
            this.reporteCompraVentaToolStripMenuItem.Click += new System.EventHandler(this.reporteCompraVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Consecionaria Vehiculos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVehiculoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCompraVentaToolStripMenuItem;
    }
}

