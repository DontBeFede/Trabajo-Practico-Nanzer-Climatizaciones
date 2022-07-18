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
    
    public partial class AñadirArticulosRemito : Form
    {       
        public AñadirArticulosRemito()
        {
            InitializeComponent();
            CantidadTxt.MaxLength = 4;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");
        
        private void AñadirArticulosRemito_Load(object sender, EventArgs e)
        {
            CargarDatos();
            EspecificacionesCbo.Text = "Seleccione Especificaciones";          
        }

        private void Limpiar()
        {
            CantidadTxt.Clear();
            PrecioUnitarioTxt.Clear();
        }    

        public void AgregarBtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (ProducntoCbo.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar el producto");
            }
            else if (EspecificacionesCbo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar las especificaciones");
            }
            else if (String.IsNullOrEmpty(CantidadTxt.Text))
                {
                CantidadTxt.Focus();
                MessageBox.Show("Por favor ingrese la cantidad");
                }
            else if (!int.TryParse(CantidadTxt.Text, out parsedValue))
            {
                CantidadTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else {
                Conn.Open();
                SqlCommand query = new SqlCommand("INSERT INTO ArticulosRemito (Producto, Especificaciones, Cantidad, PrecioUnitario) values (@Producto, @Especificaciones, @Cantidad, @PrecioUnitario)", Conn);
                query.Parameters.AddWithValue("@Producto", ProducntoCbo.SelectedValue.ToString());
                query.Parameters.AddWithValue("@Especificaciones", EspecificacionesCbo.SelectedItem.ToString());
                query.Parameters.AddWithValue("@Cantidad", int.Parse(CantidadTxt.Text));
                query.Parameters.AddWithValue("@PrecioUnitario", Convert.ToInt64(PrecioUnitarioTxt.Text));
                query.ExecuteNonQuery();
                Conn.Close();

                string TipoProducto = textBox1.Text.ToString();
                if (TipoProducto == "Equipo")
                {
                    Conn.Open();
                    SqlCommand AgregarStockRemito = new SqlCommand("UPDATE Articulo SET Cantidad = Cantidad + @Cantidad WHERE Especificacion = @Especificacion", Conn);
                    AgregarStockRemito.Parameters.AddWithValue("@Especificacion", EspecificacionesCbo.SelectedItem.ToString());
                    AgregarStockRemito.Parameters.AddWithValue("@Cantidad", int.Parse(CantidadTxt.Text));
                    AgregarStockRemito.ExecuteNonQuery();
                    Conn.Close();
                    Limpiar();
                    this.Close();
                }

                if (TipoProducto == "Insumo")
                {
                    Conn.Open();
                    SqlCommand AgregarStockRemito = new SqlCommand("UPDATE Insumo SET Cantidad = Cantidad + @Cantidad WHERE Especificacion = @Especificacion", Conn);
                    AgregarStockRemito.Parameters.AddWithValue("@Especificacion", EspecificacionesCbo.SelectedItem.ToString());
                    AgregarStockRemito.Parameters.AddWithValue("@Cantidad", int.Parse(CantidadTxt.Text));
                    AgregarStockRemito.ExecuteNonQuery();
                    Conn.Close();
                    Limpiar();
                    this.Close();
                }
            }
        }

        private void Tipo()
        {
            Conn.Open();
            SqlCommand SeleccionTipo = new SqlCommand("SELECT * FROM ListaDePrecios WHERE Especificaciones = '" + EspecificacionesCbo.SelectedItem.ToString() + "'", Conn);
            SeleccionTipo.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SeleccionTipo);
            da.Fill(dt);
            Conn.Close();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                textBox1.Text = row["Tipo"].ToString();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        public void CargarDatos()
        {
            Conn.Open(); 
            SqlCommand ComboProd = new SqlCommand("SELECT DISTINCT Producto FROM ListaDePrecios", Conn);
            SqlDataAdapter DaProd = new SqlDataAdapter(ComboProd);
            DataTable DTProd = new DataTable();
            DaProd.Fill(DTProd);
            Conn.Close();

            DataRow Fila = DTProd.NewRow();
            Fila["Producto"] = "Seleccione un Producto";
            DTProd.Rows.InsertAt(Fila, 0);

            ProducntoCbo.ValueMember = "Producto";
            ProducntoCbo.DisplayMember = "Producto";
            ProducntoCbo.DataSource = DTProd;
        }

        public void ComboEspecificacion(string Prod)
        {
            Conn.Open();
            SqlCommand cmd2 = Conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Especificaciones FROM ListaDePrecios WHERE Producto = @Producto";
            cmd2.Parameters.AddWithValue("Producto", Prod);
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            Conn.Close();

            EspecificacionesCbo.Items.Clear();
            foreach (DataRow dr2 in dt2.Rows)
            {                
                EspecificacionesCbo.Items.Add(dr2["Especificaciones"].ToString());
            }
        }

        public void ProducntoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecificacionesCbo.SelectedIndex = -1; 

            if (ProducntoCbo.SelectedValue.ToString() != null)
            {
                string Prod = ProducntoCbo.SelectedValue.ToString();
                ComboEspecificacion(Prod);
            }
        }
        
        private void EspecificacionesCbo_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (EspecificacionesCbo.SelectedIndex > -1)
            {               
                Conn.Open();
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT PrecioUnitario FROM ListaDePrecios WHERE Especificaciones = '" + EspecificacionesCbo.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Conn.Close();

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    PrecioUnitarioTxt.Text = row["PrecioUnitario"].ToString();
                }

                Tipo();
            }
        }

        private void EspecificacionesCbo_TextChanged(object sender, EventArgs e)
        {         
                if (EspecificacionesCbo.SelectedIndex < 0)
                {
                EspecificacionesCbo.Text = "Seleccione Especificaciones";
                }
                else
                {
                EspecificacionesCbo.Text = EspecificacionesCbo.SelectedText;
                }
        }
    }
}