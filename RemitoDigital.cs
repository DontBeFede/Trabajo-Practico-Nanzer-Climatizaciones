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
    public partial class RemitoDigital : Form
    {
        public RemitoDigital()
        {
            InitializeComponent();
            ControlBox = false;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void RemitoDigital_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT Producto, Especificaciones, Cantidad, PrecioUnitario FROM AñadirArticulosRemitoTemp", Conn);
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
            string QueryStockActual = @"SELECT SUM(Cantidad) from AñadirArticulosRemitoTemp";
            Conn.Open();
            SqlCommand Total = new SqlCommand(QueryStockActual, Conn);
            int ValorNum = Convert.ToInt32(Total.ExecuteScalar());
            label9.Text = ValorNum.ToString();
            Conn.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("DROP TABLE AñadirArticulosRemitoTemp", Conn);
            Consulta.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }

        private void RemitoDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }
    }
}
