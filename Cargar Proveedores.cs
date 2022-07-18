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
    public partial class Cargar_Proveedores : Form
    {
        public Cargar_Proveedores()
        {
            InitializeComponent();
            TelefonoTxt.MaxLength = 10;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");
        private void Cargar_Proveedores_Load(object sender, EventArgs e)
        {
            DgvDatos.DataSource = null;
        }

        private void Limpiar()
        {
            CuitCuilTxt.Clear();
            RazonSocialTxt.Clear();
            DireccionTxt.Clear();
            CiudadTxt.Clear();
            RepresentanteTxt.Clear();
            TelefonoTxt.Clear();
            EmailTxt.Clear();
            cboProvincia.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int parsedValue;           
            if (String.IsNullOrEmpty(CuitCuilTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                CuitCuilTxt.Focus();
                MessageBox.Show("Debe ingresar el Cuit o Cuil");
            }
            else if (String.IsNullOrEmpty(RazonSocialTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                RazonSocialTxt.Focus();
                MessageBox.Show("Debe ingresar la Razón Social");
            }
            else if (String.IsNullOrEmpty(DireccionTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                DireccionTxt.Focus();
                MessageBox.Show("Debe ingresar la Dirección");
            }
            else if (String.IsNullOrEmpty(CiudadTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                CiudadTxt.Focus();
                MessageBox.Show("Debe ingresar la Ciudad");
            }
            else if (cboProvincia.SelectedIndex == -1 && DgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar la Provincia");
            }
            else if (String.IsNullOrEmpty(RepresentanteTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                RepresentanteTxt.Focus();
                MessageBox.Show("Debe ingresar el Representante");
            }
            else if (String.IsNullOrEmpty(TelefonoTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                TelefonoTxt.Focus();
                MessageBox.Show("Debe ingresar el Número de Teléfono");
            }
            else if (!int.TryParse(TelefonoTxt.Text, out parsedValue) && DgvDatos.Rows.Count == 0)
            {
                TelefonoTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else if (String.IsNullOrEmpty(EmailTxt.Text) && DgvDatos.Rows.Count == 0)
            {
                EmailTxt.Focus();
                MessageBox.Show("Debe ingresar el e-Mail");
            }
            else if (DgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto para guardar la factura");
            }
            else
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM AñadirProveedores", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                Conn.Close();
                if (Tabla.Rows == null)
                {
                    MessageBox.Show("Select a non null row");
                }

                else
                {
                    for (int i = 0; i < DgvDatos.Rows.Count; i++)
                    {
                        Conn.Open();
                        SqlCommand Insertar = new SqlCommand(" INSERT INTO Proveedores (CuitCuil, RazonSocial, Direccion, Ciudad, Provincia, Representante, Telefono, Email) VALUES ('" + DgvDatos.Rows[i].Cells[0].Value + "', '" + DgvDatos.Rows[i].Cells[1].Value + "', '" + DgvDatos.Rows[i].Cells[2].Value + "', '" + DgvDatos.Rows[i].Cells[3].Value + "', '" + DgvDatos.Rows[i].Cells[4].Value + "', '" + DgvDatos.Rows[i].Cells[5].Value + "', '" + DgvDatos.Rows[i].Cells[6].Value + "', '" + DgvDatos.Rows[i].Cells[7].Value + "')", Conn);
                        Insertar.ExecuteNonQuery();
                        SqlCommand Borrar = new SqlCommand("DELETE FROM AñadirProveedores", Conn);
                        Borrar.ExecuteNonQuery();
                        Conn.Close();
                    }
                    MessageBox.Show("Se guardaron los datos!");
                    this.Close();
                }                         
            }
        }

        public void btnAñadir_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand AñadirProveedores = new SqlCommand("INSERT INTO AñadirProveedores (CuitCuil, RazonSocial, Direccion, Ciudad, Provincia, Representante, Telefono, Email) VALUES (@CuitCuil, @RazonSocial, @Direccion, @Ciudad, @Provincia, @Representante, @Telefono, @Email)", Conn);
            AñadirProveedores.Parameters.AddWithValue("@CuitCuil", CuitCuilTxt.Text);
            AñadirProveedores.Parameters.AddWithValue("@RazonSocial", RazonSocialTxt.Text);
            AñadirProveedores.Parameters.AddWithValue("@Direccion", DireccionTxt.Text);
            AñadirProveedores.Parameters.AddWithValue("@Ciudad", CiudadTxt.Text);
            AñadirProveedores.Parameters.AddWithValue("@Provincia", cboProvincia.SelectedItem.ToString());
            AñadirProveedores.Parameters.AddWithValue("@Representante", RepresentanteTxt.Text);
            AñadirProveedores.Parameters.AddWithValue("@Telefono", Convert.ToInt64(TelefonoTxt.Text));
            AñadirProveedores.Parameters.AddWithValue("@Email", EmailTxt.Text);
            AñadirProveedores.ExecuteNonQuery();
            Conn.Close();
            MostrarAñadidos();
        }

        private void MostrarAñadidos()
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("SELECT * FROM AñadirProveedores", Conn);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = Consulta;
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            DgvDatos.DataSource = null;
            DgvDatos.DataSource = Tabla;
            DgvDatos.Refresh();
            DgvDatos.Update();
            Conn.Close();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Borrar = new SqlCommand("DELETE FROM AñadirProveedores", Conn);
            Borrar.ExecuteNonQuery();
            Conn.Close();
            Limpiar();
            this.Close();
        }
    }
}
