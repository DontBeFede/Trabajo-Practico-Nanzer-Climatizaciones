using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalNanzerClima
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura oAgregar = new Factura();
            oAgregar.ShowDialog();
        }

        private void cargarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_Proveedores oAgregar = new Cargar_Proveedores();
            oAgregar.ShowDialog();
        }

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProveedores oAgregar = new MostrarProveedores();
            oAgregar.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void listarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockArticulos oAgregar = new StockArticulos();
            oAgregar.ShowDialog();
        }

        private void remitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remito oAgregar = new Remito();
            oAgregar.ShowDialog();
        }

        private void órdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenDeCompra oAgregar = new OrdenDeCompra();
            oAgregar.ShowDialog();
        }

        private void consultarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDocumentos oAgregar = new ConsultaDocumentos();
            oAgregar.ShowDialog();
        }

        private void listarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInsumo oAgregar = new StockInsumo();
            oAgregar.ShowDialog();
        }

        private void léemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leeme oAgregar = new Leeme();
            oAgregar.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Seguro que quieres salir?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
