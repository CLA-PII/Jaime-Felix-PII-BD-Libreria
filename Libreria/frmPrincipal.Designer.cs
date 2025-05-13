namespace Libreria
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatLecturas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCatSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogos,
            this.mnuProcesos,
            this.mnuAyuda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCatalogos
            // 
            this.mnuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatLecturas,
            this.mnuCatVendedores,
            this.toolStripMenuItem1,
            this.mnuCatSalir});
            this.mnuCatalogos.Name = "mnuCatalogos";
            this.mnuCatalogos.Size = new System.Drawing.Size(72, 20);
            this.mnuCatalogos.Text = "&Catálogos";
            // 
            // mnuCatLecturas
            // 
            this.mnuCatLecturas.Name = "mnuCatLecturas";
            this.mnuCatLecturas.Size = new System.Drawing.Size(180, 22);
            this.mnuCatLecturas.Text = "&Lecturas";
            this.mnuCatLecturas.Click += new System.EventHandler(this.mnuCatLecturas_Click);
            // 
            // mnuCatVendedores
            // 
            this.mnuCatVendedores.Name = "mnuCatVendedores";
            this.mnuCatVendedores.Size = new System.Drawing.Size(180, 22);
            this.mnuCatVendedores.Text = "&Vendedores";
            this.mnuCatVendedores.Click += new System.EventHandler(this.mnuCatVendedores_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuCatSalir
            // 
            this.mnuCatSalir.Name = "mnuCatSalir";
            this.mnuCatSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuCatSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuCatSalir.Text = "&Salir";
            this.mnuCatSalir.Click += new System.EventHandler(this.mnuCatSalir_Click);
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProVentas});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(66, 20);
            this.mnuProcesos.Text = "&Procesos";
            // 
            // mnuProVentas
            // 
            this.mnuProVentas.Name = "mnuProVentas";
            this.mnuProVentas.Size = new System.Drawing.Size(180, 22);
            this.mnuProVentas.Text = "&Ventas";
            this.mnuProVentas.Click += new System.EventHandler(this.mnuProVentas_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAyuAcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnuAyuda.Text = "Ay&uda";
            // 
            // mnuAyuAcercaDe
            // 
            this.mnuAyuAcercaDe.Name = "mnuAyuAcercaDe";
            this.mnuAyuAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.mnuAyuAcercaDe.Text = "Ac&erca de ...";
            this.mnuAyuAcercaDe.Click += new System.EventHandler(this.mnuAyuAcercaDe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "El Libro Leído";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem mnuCatLecturas;
        private System.Windows.Forms.ToolStripMenuItem mnuCatVendedores;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCatSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuProVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuAcercaDe;
    }
}

