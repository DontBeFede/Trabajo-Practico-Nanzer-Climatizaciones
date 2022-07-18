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
    public partial class StockArticulos : Form
    {
        public StockArticulos()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void ComboArticulos()
        {
            String Query1 = "SELECT DISTINCT Producto FROM Articulo";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query1, Conn);
            Conn.Open();
            DataSet DT = new DataSet();
            Adaptador.Fill(DT, "Producto");
            CbFiltrarProducto.DisplayMember = "Producto";
            CbFiltrarProducto.ValueMember = "Producto";
            CbFiltrarProducto.DataSource = DT.Tables["Producto"];
            Conn.Close();
            if (CbFiltrarProducto.Items.Count > 1)
            {
                CbFiltrarProducto.SelectedIndex = -1;
            }
        }

        private void DisplayDGVRazonSocial()
        {
            SqlCommand Query2 = new SqlCommand("SELECT Codigo, Producto, Especificacion, Cantidad FROM Articulo WHERE Producto LIKE '%" + CbFiltrarProducto.Text + "'", Conn);
            SqlDataAdapter Adaptador2 = new SqlDataAdapter();
            DataTable Tabla2 = new DataTable();
            Adaptador2.SelectCommand = Query2;
            Tabla2.Clear();
            Adaptador2.Fill(Tabla2);
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = Tabla2;
        }

        private void CbFiltrarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFiltrarProducto.SelectedIndex >= 0)
            {
                DisplayDGVRazonSocial();
            }
            SumaDeBusqueda();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Codigo, Producto, Especificacion, Cantidad FROM Articulo WHERE Producto LIKE '%" + TxtBuscar.Text + "%' OR Especificacion LIKE '%" + TxtBuscar.Text + "%' OR Codigo LIKE '%" + TxtBuscar.Text + "%' OR Cantidad LIKE '%" + TxtBuscar.Text + "%'", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable DT3 = new DataTable();
                Adaptador.Fill(DT3);
                Conn.Close();
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = DT3;
                dgvArticulos.Refresh();
                SumaDeBusqueda();
                Clear();
            }
        }

        private void Clear()
        {
            TxtBuscar.Text = string.Empty;
            CbFiltrarProducto.Text = string.Empty;
        }

        private void StockTotalActual()
        {
            string QueryStockActual = @"SELECT SUM(Cantidad) from Articulo";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            TotalesLbl.Text = ValorNum.ToString();
            Conn.Close();
        }

        private void SumaDeBusqueda()
        {
            int sum = 0;
            for (int i = 0; i < dgvArticulos.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvArticulos.Rows[i].Cells[3].Value);
            }
            TxtTotales.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Codigo, Producto, Especificacion, Cantidad FROM Articulo ORDER BY Codigo DESC", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = Tabla;
                dgvArticulos.Refresh();
                dgvArticulos.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }

            ComboArticulos();
            DisplayDGVRazonSocial();
            StockTotalActual();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el Artículo?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string Codigo = CodigoTxt.Text;
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM Articulo WHERE Codigo = '" + Codigo + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                SqlCommand Consulta = new SqlCommand("SELECT Codigo, Producto, Especificacion, Cantidad FROM Articulo", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = Tabla;
                dgvArticulos.Refresh();
                dgvArticulos.Update();
                Conn.Close();
                CbFiltrarProducto.SelectedIndex = -1;
                TxtBuscar.Text = string.Empty;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            CodigoTxt.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarArticulos Edicion = new EditarArticulos();
            Edicion.CodigoETxt.Text = this.dgvArticulos.CurrentRow.Cells[0].Value.ToString();
            Edicion.ProductoETxt.Text = this.dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            Edicion.EspecifETxt.Text = this.dgvArticulos.CurrentRow.Cells[2].Value.ToString();          
            Edicion.ShowDialog();
            Refrescar();
        }

        private void Refrescar()
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("SELECT Codigo, Producto, Especificacion, Cantidad FROM Articulo", Conn);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = Consulta;
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = Tabla;
            dgvArticulos.Refresh();
            dgvArticulos.Update();
            Conn.Close();
            CbFiltrarProducto.SelectedIndex = -1;
            TxtBuscar.Text = string.Empty;
        }
    }
}
