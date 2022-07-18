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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");
        private void ComboRazonSocial()
        {
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Proveedores";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RazonSocialCbo.Items.Add(dr["RazonSocial"].ToString());
            }
            Conn.Close();
        }
        private void CargarArticulosBtn_Click(object sender, EventArgs e)
        {
            AñadirArticulosFactura oAgregar = new AñadirArticulosFactura();
            oAgregar.ShowDialog();
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select * from ArticulosFactura", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatos.DataSource = null;
                DgvDatos.DataSource = Tabla;
                DgvDatos.Refresh();
                DgvDatos.Update();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }          
                StockTotalActual();
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (String.IsNullOrEmpty(NumeroTxt.Text))
            {
                NumeroTxt.Focus();
                MessageBox.Show("Debe ingresar el número de la factura");
            }
            else if (!int.TryParse(NumeroTxt.Text, out parsedValue))
            {
                NumeroTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;               
            }
            else if (DgvDatos.Rows.Count == 0){
                MessageBox.Show("Debe ingresar al menos un producto para guardar la factura");
            } 
            else if (TipoCbo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Tipo de Factura");
            }
            else if (String.IsNullOrEmpty(DireccionTxt.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos");                
            } else
            {                
                string Documento = "Factura";
                for (int i = 0; i < DgvDatos.Rows.Count; i++)
                {
                    Conn.Open();
                    SqlCommand GuardarArticulosFactura = new SqlCommand("INSERT INTO Factura (Documento, Numero, Tipo, Fecha, RazonSocial, Direccion, Ciudad, Provincia, Producto, Especificaciones, Cantidad, PrecioUnitario, Subtotal) VALUES (@Documento, @Numero, @Tipo, @Fecha, @RazonSocial, @Direccion, @Ciudad, @Provincia, '" + DgvDatos.Rows[i].Cells[1].Value + "', '" + DgvDatos.Rows[i].Cells[2].Value + "', '" + DgvDatos.Rows[i].Cells[3].Value + "', '" + DgvDatos.Rows[i].Cells[4].Value + "', '" + DgvDatos.Rows[i].Cells[5].Value + "')", Conn);
                    GuardarArticulosFactura.Parameters.AddWithValue("@Documento", Documento);
                    GuardarArticulosFactura.Parameters.AddWithValue("@Numero", NumeroTxt.Text);
                    GuardarArticulosFactura.Parameters.AddWithValue("@Tipo", TipoCbo.SelectedItem.ToString());
                    GuardarArticulosFactura.Parameters.AddWithValue("@Fecha", FechaDate.Value.ToString());
                    GuardarArticulosFactura.Parameters.AddWithValue("@RazonSocial", RazonSocialCbo.SelectedItem.ToString());
                    GuardarArticulosFactura.Parameters.AddWithValue("@Direccion", DireccionTxt.Text);
                    GuardarArticulosFactura.Parameters.AddWithValue("@Ciudad", CiudadTxt.Text);
                    GuardarArticulosFactura.Parameters.AddWithValue("@Provincia", ProvinciaTxt.Text);
                    GuardarArticulosFactura.ExecuteNonQuery();
                    SqlCommand BorrarDup = new SqlCommand("DELETE FROM Factura WHERE PrecioUnitario LIKE 0", Conn);
                    BorrarDup.ExecuteNonQuery();
                    SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosFactura", Conn);
                    Borrar.ExecuteNonQuery();
                    Conn.Close();
                }
                MessageBox.Show("Se guardó la Factura!");
                this.Close();
            }
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosFactura", Conn);
            Borrar.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }
        private void RazonSocialCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Proveedores WHERE RazonSocial = '" + RazonSocialCbo.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CiudadTxt.Text = dr["Ciudad"].ToString();
                DireccionTxt.Text = dr["Direccion"].ToString();
                ProvinciaTxt.Text = dr["Provincia"].ToString();
            }
            Conn.Close();
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            ComboRazonSocial();
            NumeroTxt.MaxLength = 9;
        }
        private void StockTotalActual()
        {                       
            string QueryStockActual = @"SELECT ISNULL(SUM(Subtotal), 0) from ArticulosFactura";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);                     
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            TotalLbl.Text = "$" + ValorNum.ToString();           
            Conn.Close();           
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el artículo de la Factura?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = DgvDatos.CurrentRow.Cells[2].Value.ToString();
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM ArticulosFactura WHERE Especificaciones = '" + ID + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM ArticulosFactura", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatos.DataSource = null;
                DgvDatos.DataSource = Tabla;
                DgvDatos.Refresh();
                DgvDatos.Update();
                Conn.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
