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
    public partial class EditarProveedores : Form
    {
        public EditarProveedores()
        {
            InitializeComponent();
            TelefonoTxt.MaxLength = 10;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");        

        private void EditarProveedores_Load(object sender, EventArgs e)
        {
            
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //Int64 parsedValue;
            if (String.IsNullOrEmpty(CuitCuilTxt.Text))
            {
                CuitCuilTxt.Focus();
                MessageBox.Show("Debe ingresar el Cuit o Cuil");
            }
            else if (String.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                RazonSocialTxt.Focus();
                MessageBox.Show("Debe ingresar la Razón Social");
            }
            else if (String.IsNullOrEmpty(DireccionTxt.Text))
            {
                DireccionTxt.Focus();
                MessageBox.Show("Debe ingresar la Dirección");
            }
            else if (String.IsNullOrEmpty(CiudadTxt.Text))
            {
                CiudadTxt.Focus();
                MessageBox.Show("Debe ingresar la Ciudad");
            }
            else if (cboProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar la Provincia");
            }
            else if (String.IsNullOrEmpty(RepresentanteTxt.Text))
            {
                RepresentanteTxt.Focus();
                MessageBox.Show("Debe ingresar el Representante");
            }
            else if (String.IsNullOrEmpty(TelefonoTxt.Text))
            {
                TelefonoTxt.Focus();
                MessageBox.Show("Debe ingresar el Número de Teléfono");
            }
            else if (!Int64.TryParse(TelefonoTxt.Text, out parsedValue))
            {
                TelefonoTxt.Focus();
                MessageBox.Show("Por favor ingrese solo números");
                return;
            }
            else if (String.IsNullOrEmpty(EmailTxt.Text))
            {
                EmailTxt.Focus();
                MessageBox.Show("Debe ingresar el e-Mail");
            }            
            else { 
            string Codigo = IDProvTxt.Text;
            Conn.Open();
            SqlCommand ConsultaEditar = new SqlCommand("UPDATE Proveedores SET CuitCuil = @CuitCuil, RazonSocial = @RazonSocial, Direccion = @Direccion, Ciudad = @Ciudad, Provincia = @Provincia, Representante = @Representante, Telefono = @Telefono, Email = @Email WHERE ID = '" + Codigo + "'", Conn);
            ConsultaEditar.Parameters.AddWithValue("@CuitCuil", CuitCuilTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@RazonSocial", RazonSocialTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@Direccion", DireccionTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@Ciudad", CiudadTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@Provincia", cboProvincia.SelectedItem.ToString());
            ConsultaEditar.Parameters.AddWithValue("@Representante", RepresentanteTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@Telefono", TelefonoTxt.Text);
            ConsultaEditar.Parameters.AddWithValue("@Email", EmailTxt.Text);
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

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
