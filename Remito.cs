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
    public partial class Remito : Form
    {
        public Remito()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");

        private void Remito_Load(object sender, EventArgs e)
        {
            ComboRazonSocial();
            NumeroTxt.MaxLength = 9;
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
        private void ArticulosBtn_Click(object sender, EventArgs e)
        {
            AñadirArticulosRemito oAgregar = new AñadirArticulosRemito();
            oAgregar.ShowDialog();
            try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("select * from ArticulosRemito", Conn);
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
        private void GuardarBtn_Click_1(object sender, EventArgs e)
        {
            int parsedValue;
            if (String.IsNullOrEmpty(NumeroTxt.Text))
            {
                NumeroTxt.Focus();
                MessageBox.Show("Debe ingresar el número del remito");
            }
            else if (!int.TryParse(NumeroTxt.Text, out parsedValue))
            {
                NumeroTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else if (DgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto para guardar el remito");
            }
            else if (String.IsNullOrEmpty(DireccionTxt.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                NumeroTxt.Focus();
                string Documento = "Remito";
                for (int i = 0; i < DgvDatos.Rows.Count; i++)
                {
                    Conn.Open();
                    SqlCommand GuardarArticulosRemito = new SqlCommand("INSERT INTO Remito (Documento, Numero, Fecha, RazonSocial, Direccion, Ciudad, Provincia, Producto, Especificaciones, Cantidad, PrecioUnitario) VALUES (@Documento, @Numero, @Fecha, @RazonSocial, @Direccion, @Ciudad, @Provincia, '" + DgvDatos.Rows[i].Cells[1].Value + "', '" + DgvDatos.Rows[i].Cells[2].Value + "', '" + DgvDatos.Rows[i].Cells[3].Value + "', '" + DgvDatos.Rows[i].Cells[4].Value + "')", Conn);
                    GuardarArticulosRemito.Parameters.AddWithValue("@Documento", Documento);
                    GuardarArticulosRemito.Parameters.AddWithValue("@Numero", NumeroTxt.Text);
                    GuardarArticulosRemito.Parameters.AddWithValue("@Fecha", FechaDate.Value.ToString());
                    GuardarArticulosRemito.Parameters.AddWithValue("@RazonSocial", RazonSocialCbo.SelectedItem.ToString());
                    GuardarArticulosRemito.Parameters.AddWithValue("@Direccion", DireccionTxt.Text);
                    GuardarArticulosRemito.Parameters.AddWithValue("@Ciudad", CiudadTxt.Text);
                    GuardarArticulosRemito.Parameters.AddWithValue("@Provincia", ProvinciaTxt.Text);
                    GuardarArticulosRemito.ExecuteNonQuery();
                    SqlCommand BorrarDup = new SqlCommand("DELETE FROM Remito WHERE PrecioUnitario LIKE 0", Conn);
                    BorrarDup.ExecuteNonQuery();
                    SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosRemito", Conn);
                    Borrar.ExecuteNonQuery();
                    Conn.Close();
                }
                MessageBox.Show("Se guardó el Remito!");
                this.Close();
            }
            
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Borrar = new SqlCommand("DELETE FROM ArticulosRemito", Conn);
            Borrar.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar el artículo del Remito?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = DgvDatos.CurrentRow.Cells[2].Value.ToString();
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM ArticulosRemito WHERE Especificaciones = '" + ID + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM ArticulosRemito", Conn);
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
