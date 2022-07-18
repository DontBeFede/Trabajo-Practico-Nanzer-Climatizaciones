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
    public partial class OrdenCompraDigital : Form
    {
        public OrdenCompraDigital()
        {
            InitializeComponent();
            ControlBox = false;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("DROP TABLE AñadirArticulosOrdenTemp", Conn);
            Consulta.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }

        private void OrdenCompraDigital_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Producto, Cantidad, PrecioUnitario, Subtotal FROM AñadirArticulosOrdenTemp", Conn);
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
            string QueryStockActual = @"SELECT SUM(Subtotal) from AñadirArticulosOrdenTemp";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            label10.Text = "$" + ValorNum.ToString();
            Conn.Close();
        }

        private void OrdenCompraDigital_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }   
}
