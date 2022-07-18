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
    public partial class StockInsumo : Form
    {
        public StockInsumo()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void StockInsumo_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Codigo, Tipo, Especificacion, Cantidad FROM Insumo", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = Tabla;
                dgvInsumos.Refresh();
                dgvInsumos.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
            ComboInsumo();
            DisplayDGVInsumo();
            StockTotalActual();
        }

        private void ComboInsumo()
        {
            String Query1 = "SELECT DISTINCT Tipo FROM Insumo";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query1, Conn);
            Conn.Open();
            DataSet DT = new DataSet();
            Adaptador.Fill(DT, "Tipo");
            CbFiltrarInsumo.DisplayMember = "Tipo";
            CbFiltrarInsumo.ValueMember = "Tipo";
            CbFiltrarInsumo.DataSource = DT.Tables["Tipo"];
            Conn.Close();
            if (CbFiltrarInsumo.Items.Count > 1)
            {
                CbFiltrarInsumo.SelectedIndex = -1;
            }
        }
        private void DisplayDGVInsumo()
        {
            SqlCommand Query2 = new SqlCommand("SELECT * FROM Insumo WHERE Tipo LIKE '%" + CbFiltrarInsumo.Text + "'", Conn);
            SqlDataAdapter Adaptador2 = new SqlDataAdapter();
            DataTable Tabla2 = new DataTable();
            Adaptador2.SelectCommand = Query2;
            Tabla2.Clear();
            Adaptador2.Fill(Tabla2);
            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = Tabla2;
        }

        private void SumaDeBusqueda()
        {
            int sum = 0;
            for (int i = 0; i < dgvInsumos.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvInsumos.Rows[i].Cells[3].Value);
            }
            TxtTotales.Text = sum.ToString();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Codigo, Tipo, Especificacion, Cantidad FROM Insumo WHERE Tipo LIKE '%" + TxtBuscar.Text + "%' OR Especificacion LIKE '%" + TxtBuscar.Text + "%' OR Codigo LIKE '%" + TxtBuscar.Text + "%' OR Cantidad LIKE '%" + TxtBuscar.Text + "%'", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable DT3 = new DataTable();
                Adaptador.Fill(DT3);
                Conn.Close();
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = DT3;
                dgvInsumos.Refresh();
                Clear();
            }
            SumaDeBusqueda();
        }

        private void Clear()
        {
            TxtBuscar.Text = string.Empty;
            CbFiltrarInsumo.Text = string.Empty;
        }

        private void StockTotalActual()
        {
            string QueryStockActual = @"SELECT SUM(Cantidad) from Insumo";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            lblStock.Text = ValorNum.ToString();
            Conn.Close();
        }

        private void CbFiltrarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFiltrarInsumo.SelectedIndex >= 0)
            {
                DisplayDGVInsumo();
                SumaDeBusqueda();
            }
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarInsumos Edicion = new EditarInsumos();
            Edicion.CodigoEITxt.Text = this.dgvInsumos.CurrentRow.Cells[0].Value.ToString();
            Edicion.ProductoEITxt.Text = this.dgvInsumos.CurrentRow.Cells[1].Value.ToString();
            Edicion.EspecifEITxt.Text = this.dgvInsumos.CurrentRow.Cells[2].Value.ToString();
            Edicion.ShowDialog();
            Refrescar();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el Insumo?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string Codigo = CodigoTxt.Text;
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM Insumo WHERE Codigo = '" + Codigo + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                Conn.Close();
                Refrescar();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dgvInsumos_SelectionChanged(object sender, EventArgs e)
        {
            CodigoTxt.Text = dgvInsumos.CurrentRow.Cells[0].Value.ToString();
        }

        private void Refrescar()
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("SELECT Codigo, Tipo, Especificacion, Cantidad FROM Insumo", Conn);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = Consulta;
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = Tabla;
            dgvInsumos.Refresh();
            dgvInsumos.Update();
            Conn.Close();
            CbFiltrarInsumo.SelectedIndex = -1;
            TxtBuscar.Text = string.Empty;
        }
    }
}
