using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrabajoFinalNanzerClima
{
    public partial class ConsultaDocumentos : Form
    {
        public ConsultaDocumentos()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void ConsultaDocumentos_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT DISTINCT R.Documento, R.Numero, R.Fecha, R.RazonSocial, R.Direccion, R.Ciudad, R.Provincia FROM Remito as R UNION Select DISTINCT O.Documento, O.Numero, O.Fecha, O.RazonSocial, O.Direccion, O.Ciudad, O.Provincia From OrdenCompra as O UNION SELECT DISTINCT F.Documento, F.Numero, F.Fecha, F.RazonSocial, F.Direccion, F.Ciudad, F.Provincia from Factura as F", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = Tabla;
                DgvDatosDoc.Refresh();
                DgvDatosDoc.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }           
        }

        private void TipoDocumentoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrbControles.Enabled = true;

            if (TipoDocumentoCbo.SelectedIndex >= 0)
            {
                EligioFactura();
                ControlesHabilitados(true);
            }
            if (TipoDocumentoCbo.SelectedIndex >= 1)
            {
                EligioOrdenCompra();
                ControlesHabilitados(true);
            }
            if (TipoDocumentoCbo.SelectedIndex >= 2)
            {
                EligioRemito();
                ControlesHabilitados(true);
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EligioFactura()
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select DISTINCT Documento, Numero, Tipo, Fecha, RazonSocial, Direccion, Ciudad, Provincia from Factura", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = Tabla;
                DgvDatosDoc.Refresh();
                DgvDatosDoc.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        private void EligioOrdenCompra()
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia, Representante, Telefono, Email from OrdenCompra", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = Tabla;
                DgvDatosDoc.Refresh();
                DgvDatosDoc.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        private void EligioRemito()
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia from Remito", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = Tabla;
                DgvDatosDoc.Refresh();
                DgvDatosDoc.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        private void NumeroTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            DgvDatosDoc.DataSource = null;
            GrbControles.Enabled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Busqueda = NumeroTxt.Text;
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia FROM Remito WHERE Numero like '" + Busqueda + "'" + " UNION Select DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia From OrdenCompra WHERE Numero like '" + Busqueda + "'" + " UNION SELECT DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia FROM Factura WHERE Numero like '" + Busqueda + "'", Conn);
                SqlDataReader resultado = Consulta.ExecuteReader();
                DataTable DT3 = new DataTable();
                DT3.Load(resultado);
                Conn.Close();
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = DT3;
                DgvDatosDoc.Update();
                DgvDatosDoc.Refresh();
                Clear();
            }
            TipoDocumentoCbo.SelectedIndex = -1;
            Borrar(true);
        }

        private void Clear()
        {
            NumeroTxt.Text = string.Empty;
            FechaTxt.Text = string.Empty;
        }

        private void FechaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            DgvDatosDoc.DataSource = null;
            GrbControles.Enabled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Busqueda = FechaTxt.Text;
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia FROM Remito WHERE Fecha like '%" + Busqueda + "%'" + " UNION Select DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia From OrdenCompra WHERE Fecha like '%" + Busqueda + "%'" + " UNION SELECT DISTINCT Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia FROM Factura WHERE Fecha like '%" + Busqueda + "%'", Conn);
                SqlDataReader resultado = Consulta.ExecuteReader();
                DataTable DT3 = new DataTable();
                DT3.Load(resultado);
                Conn.Close();
                DgvDatosDoc.DataSource = null;
                DgvDatosDoc.DataSource = DT3;
                DgvDatosDoc.Update();
                DgvDatosDoc.Refresh();
                Clear();
            }
            TipoDocumentoCbo.SelectedIndex = -1;
            Borrar(true);
        }

        private void DgvDatosDoc_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionTxt.Text = DgvDatosDoc.CurrentRow.Cells[0].Value.ToString();
            NumeroSeleccionTxt.Text = DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            string FilaDgv = DgvDatosDoc.CurrentRow.Cells[0].Value.ToString();
            string NumeroSeleccionado = DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();

            if (FilaDgv == "Factura" && DgvDatosDoc.CurrentRow.Cells[1].Value.ToString() == NumeroSeleccionado)
            {
                FacturaDigital Factura = new FacturaDigital();
                Factura.textBox1.Text = this.DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();
                Factura.textBox2.Text = this.DgvDatosDoc.CurrentRow.Cells[2].Value.ToString();
                Factura.textBox3.Text = this.DgvDatosDoc.CurrentRow.Cells[3].Value.ToString();
                Factura.textBox4.Text = this.DgvDatosDoc.CurrentRow.Cells[4].Value.ToString();
                Factura.textBox5.Text = this.DgvDatosDoc.CurrentRow.Cells[5].Value.ToString();
                Factura.textBox6.Text = this.DgvDatosDoc.CurrentRow.Cells[6].Value.ToString();
                Factura.textBox7.Text = this.DgvDatosDoc.CurrentRow.Cells[7].Value.ToString();
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Producto, Cantidad, PrecioUnitario, Subtotal INTO AñadirArticulosFacturaTemp FROM Factura WHERE Numero = '" + NumeroSeleccionado + "'", Conn);
                Consulta.ExecuteNonQuery();
                Conn.Close();
                Factura.ShowDialog();
            }

            if (FilaDgv == "Remito")
            {
                RemitoDigital Remito = new RemitoDigital();
                Remito.textBox1.Text = this.DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();
                Remito.textBox3.Text = this.DgvDatosDoc.CurrentRow.Cells[2].Value.ToString();
                Remito.textBox4.Text = this.DgvDatosDoc.CurrentRow.Cells[3].Value.ToString();
                Remito.textBox5.Text = this.DgvDatosDoc.CurrentRow.Cells[4].Value.ToString();
                Remito.textBox6.Text = this.DgvDatosDoc.CurrentRow.Cells[5].Value.ToString();
                Remito.textBox7.Text = this.DgvDatosDoc.CurrentRow.Cells[6].Value.ToString();
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Producto, Especificaciones, Cantidad, PrecioUnitario INTO AñadirArticulosRemitoTemp FROM Remito WHERE Numero = '" + this.DgvDatosDoc.CurrentRow.Cells[1].Value.ToString() + "'", Conn);
                Consulta.ExecuteNonQuery();
                Conn.Close();
                Remito.ShowDialog();
            }

            if (FilaDgv == "Orden De Compra")
            {
                OrdenCompraDigital Orden = new OrdenCompraDigital();
                Orden.textBox1.Text = this.DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();
                Orden.textBox3.Text = this.DgvDatosDoc.CurrentRow.Cells[2].Value.ToString();
                Orden.textBox4.Text = this.DgvDatosDoc.CurrentRow.Cells[3].Value.ToString();
                Orden.textBox5.Text = this.DgvDatosDoc.CurrentRow.Cells[4].Value.ToString();
                Orden.textBox6.Text = this.DgvDatosDoc.CurrentRow.Cells[5].Value.ToString();
                Orden.textBox7.Text = this.DgvDatosDoc.CurrentRow.Cells[6].Value.ToString();
                Orden.textBox8.Text = this.DgvDatosDoc.CurrentRow.Cells[7].Value.ToString();
                Orden.textBox2.Text = this.DgvDatosDoc.CurrentRow.Cells[8].Value.ToString();
                Orden.textBox9.Text = this.DgvDatosDoc.CurrentRow.Cells[9].Value.ToString();
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Producto, Cantidad, PrecioUnitario, Subtotal INTO AñadirArticulosOrdenTemp FROM OrdenCompra WHERE Numero = '" + this.DgvDatosDoc.CurrentRow.Cells[1].Value.ToString() + "'", Conn);
                Consulta.ExecuteNonQuery();
                Conn.Close();
                Orden.ShowDialog();
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el Documento?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string FilaDgv = DgvDatosDoc.CurrentRow.Cells[0].Value.ToString();
                string NumeroSeleccionado = DgvDatosDoc.CurrentRow.Cells[1].Value.ToString();

                if (FilaDgv == "Factura")
                {
                    Conn.Open();
                    SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM Factura WHERE Numero = '" + NumeroSeleccionado + "'", Conn);
                    ConsultaBorrar.ExecuteNonQuery();
                    SqlCommand Consulta = new SqlCommand("SELECT DISTINCT R.Documento, R.Numero, R.Fecha, R.RazonSocial, R.Direccion, R.Ciudad, R.Provincia FROM Remito as R UNION Select DISTINCT O.Documento, O.Numero, O.Fecha, O.RazonSocial, O.Direccion, O.Ciudad, O.Provincia From OrdenCompra as O UNION SELECT DISTINCT F.Documento, F.Numero, F.Fecha, F.RazonSocial, F.Direccion, F.Ciudad, F.Provincia from Factura as F", Conn);
                    SqlDataAdapter Adaptador = new SqlDataAdapter();
                    Adaptador.SelectCommand = Consulta;
                    DataTable Tabla = new DataTable();
                    Adaptador.Fill(Tabla);
                    DgvDatosDoc.DataSource = null;
                    DgvDatosDoc.DataSource = Tabla;
                    DgvDatosDoc.Refresh();
                    DgvDatosDoc.Update();
                    Conn.Close();
                    TipoDocumentoCbo.SelectedIndex = -1;
                }

                if (FilaDgv == "Orden De Compra")
                {
                    Conn.Open();
                    SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM OrdenCompra WHERE Numero = '" + NumeroSeleccionado + "'", Conn);
                    ConsultaBorrar.ExecuteNonQuery();
                    SqlCommand Consulta = new SqlCommand("SELECT DISTINCT R.Documento, R.Numero, R.Fecha, R.RazonSocial, R.Direccion, R.Ciudad, R.Provincia FROM Remito as R UNION Select DISTINCT O.Documento, O.Numero, O.Fecha, O.RazonSocial, O.Direccion, O.Ciudad, O.Provincia From OrdenCompra as O UNION SELECT DISTINCT F.Documento, F.Numero, F.Fecha, F.RazonSocial, F.Direccion, F.Ciudad, F.Provincia from Factura as F", Conn);
                    SqlDataAdapter Adaptador = new SqlDataAdapter();
                    Adaptador.SelectCommand = Consulta;
                    DataTable Tabla = new DataTable();
                    Adaptador.Fill(Tabla);
                    DgvDatosDoc.DataSource = null;
                    DgvDatosDoc.DataSource = Tabla;
                    DgvDatosDoc.Refresh();
                    DgvDatosDoc.Update();
                    Conn.Close();
                    TipoDocumentoCbo.SelectedIndex = -1;
                }

                if (FilaDgv == "Remito")
                {
                    Conn.Open();
                    SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM Remito WHERE Numero = '" + NumeroSeleccionado + "'", Conn);
                    ConsultaBorrar.ExecuteNonQuery();
                    SqlCommand Consulta = new SqlCommand("SELECT DISTINCT R.Documento, R.Numero, R.Fecha, R.RazonSocial, R.Direccion, R.Ciudad, R.Provincia FROM Remito as R UNION Select DISTINCT O.Documento, O.Numero, O.Fecha, O.RazonSocial, O.Direccion, O.Ciudad, O.Provincia From OrdenCompra as O UNION SELECT DISTINCT F.Documento, F.Numero, F.Fecha, F.RazonSocial, F.Direccion, F.Ciudad, F.Provincia from Factura as F", Conn);
                    SqlDataAdapter Adaptador = new SqlDataAdapter();
                    Adaptador.SelectCommand = Consulta;
                    DataTable Tabla = new DataTable();
                    Adaptador.Fill(Tabla);
                    DgvDatosDoc.DataSource = null;
                    DgvDatosDoc.DataSource = Tabla;
                    DgvDatosDoc.Refresh();
                    DgvDatosDoc.Update();
                    Conn.Close();
                    TipoDocumentoCbo.SelectedIndex = -1;
                }

                GrbControles.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Borrar(bool est)
        {
            BorrarBtn.Enabled = est;          
            ConsultarBtn.Enabled = !est;
        }

        private void ControlesHabilitados(bool est)
        {
            BorrarBtn.Enabled = est;            
            ConsultarBtn.Enabled = est;
        }
    }   
}
