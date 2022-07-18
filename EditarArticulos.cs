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
    public partial class EditarArticulos : Form
    {
        public EditarArticulos()
        {
            InitializeComponent();
            CantidadTxt.MaxLength = 4;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void EditarArticulos_Load(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (String.IsNullOrEmpty(CantidadTxt.Text))
            {
                CantidadTxt.Focus();
                MessageBox.Show("Debe ingresar la cantidad");
            }
            else if (!int.TryParse(CantidadTxt.Text, out parsedValue))
            {
                CantidadTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else
            {
                string Codigo = CodigoETxt.Text;
                Conn.Open();
                SqlCommand ConsultaEditar = new SqlCommand("UPDATE Articulo SET Cantidad = @Cantidad WHERE Codigo = '" + Codigo + "'", Conn);
                ConsultaEditar.Parameters.AddWithValue("@Cantidad", int.Parse(CantidadTxt.Text));
                ConsultaEditar.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Se editó con éxito!");
                this.Close();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
