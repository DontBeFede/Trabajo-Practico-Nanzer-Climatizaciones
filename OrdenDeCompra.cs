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
    public partial class OrdenDeCompra : Form
    {
        public OrdenDeCompra()
        {
            InitializeComponent();
            NumeroTxt.MaxLength = 9;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {
            ComboRazonSocial();
        }

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
            AgregarArticulosOrdenDeCompra oAgregar = new AgregarArticulosOrdenDeCompra();
            oAgregar.ShowDialog();
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select * from ArticulosOrdenDeCompra", Conn);
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

        private void StockTotalActual()
        {
            string QueryStockActual = @"SELECT ISNULL (SUM(Subtotal), 0) from ArticulosOrdenDeCompra";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            TotalLbl.Text = "$" + ValorNum.ToString();
            Conn.Close();
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
                RepresentanteTxt.Text = dr["Representante"].ToString();
                TelefonoTxt.Text = dr["Telefono"].ToString();
                EmailTxt.Text = dr["Email"].ToString();
            }
            Conn.Close();
        }


        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (String.IsNullOrEmpty(NumeroTxt.Text))
            {
                NumeroTxt.Focus();
                MessageBox.Show("debe ingresar el número de la orden");
            }
            else if (!int.TryParse(NumeroTxt.Text, out parsedValue))
            {
                NumeroTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else if (DgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto para guardar la orden");
            }
            else if (String.IsNullOrEmpty(DireccionTxt.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                for (int i = 0; i < DgvDatos.Rows.Count; i++)
                {
                    string Documento = "Orden De Compra";
                    Conn.Open();
                    SqlCommand GuardarArticulosOrdenDeCompra = new SqlCommand("INSERT INTO OrdenCompra (Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia, Representante, Telefono, Email, Producto, Especificaciones, Cantidad, PrecioUnitario, Subtotal) VALUES (@Documento, @Numero, @Fecha, @RazonSocial, @Direccion, @Ciudad, @Provincia, @Representante, @Telefono, @Email, '" + DgvDatos.Rows[i].Cells[0].Value + "', '" + DgvDatos.Rows[i].Cells[1].Value + "', '" + DgvDatos.Rows[i].Cells[3].Value + "', '" + DgvDatos.Rows[i].Cells[2].Value + "', '" + DgvDatos.Rows[i].Cells[4].Value + "')", Conn);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Documento", Documento);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Numero", NumeroTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Fecha", FechaDate.Value.ToString());
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@RazonSocial", RazonSocialCbo.SelectedItem.ToString());
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Direccion", DireccionTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Ciudad", CiudadTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Provincia", ProvinciaTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Representante", RepresentanteTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Telefono", TelefonoTxt.Text);
                    GuardarArticulosOrdenDeCompra.Parameters.AddWithValue("@Email", EmailTxt.Text);
                    GuardarArticulosOrdenDeCompra.ExecuteNonQuery();
                    SqlCommand BorrarDup = new SqlCommand("DELETE FROM OrdenCompra WHERE PrecioUnitario LIKE 0", Conn);
                    BorrarDup.ExecuteNonQuery();
                    SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosOrdenDeCompra", Conn);
                    Borrar.ExecuteNonQuery();
                    Conn.Close();                    
                }
                MessageBox.Show("Se guardó la Orden De Compra!");
                this.Close();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosOrdenDeCompra", Conn);
            Borrar.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }

        private void BorrarArticulosBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el artículo de la Orden de Compra?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = DgvDatos.CurrentRow.Cells[1].Value.ToString();
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM ArticulosOrdenDeCompra WHERE Especificaciones = '" + ID + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM ArticulosOrdenDeCompra", Conn);
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
