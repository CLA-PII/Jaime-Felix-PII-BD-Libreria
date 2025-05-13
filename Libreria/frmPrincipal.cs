using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Preguntar si desea salir
            DialogResult salir = MessageBox.Show("¿Deseas salir de la aplicación?",
                "El Libro Leído", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (salir == DialogResult.No)
                e.Cancel = true;
        }

        private void mnuCatSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAyuAcercaDe_Click(object sender, EventArgs e)
        {
            // Mostrar la información del sistema
            String mensaje = "El Libro Leído\n" +
                            "Autor: PROPORCIONAR NOMBRE DEL AUTOR";
            MessageBox.Show(mensaje, "Libreria");
        }

        private void mnuCatLecturas_Click(object sender, EventArgs e)
        {
            // Mostrar el catálogo de lecturas
            Lecturas frmLecturas = new Lecturas();
            frmLecturas.ShowDialog();
        }

        private void mnuCatVendedores_Click(object sender, EventArgs e)
        {
            // Mostrar el catálogo de vendedores
            Vendedores frmVendedores = new Vendedores();
            frmVendedores.ShowDialog();
        }

        private void mnuProVentas_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de ventas
            Ventas frmVentas = new Ventas();
            frmVentas.ShowDialog();
        }
    }
}
