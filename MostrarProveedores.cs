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
    public partial class MostrarProveedores : Form
    {
        public MostrarProveedores()
        {
            InitializeComponent();           
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");
        private void MostrarProveedores_Load(object sender, EventArgs e)
        {
                try
            {
                Conn.Open();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM Proveedores", Conn);
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
            ComboRazonSocial();
            DisplayDGVRazonSocial();
            ComboCiudad();
            DisplayDGVCiudad();
            ComboProvincia();
            DisplayDGVProvincia();
            cboRazonSocial.Text = "Seleccione Razón Social";
            CboProvincia.Text = "Seleccione Provincia";
            cboCiudad.Text = "Seleccione Ciudad";
        }
        private void cboRazonSocial_Click(object sender, EventArgs e)
        {
        }

        private void CboProvincia_Click(object sender, EventArgs e)
        {
        }
        private void ComboRazonSocial()
        {
            String Query1 = "SELECT DISTINCT RazonSocial FROM Proveedores";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query1, Conn);
            Conn.Open();
            DataSet DT = new DataSet();
            Adaptador.Fill(DT, "RazonSocial");
            cboRazonSocial.DisplayMember = "RazonSocial";
            cboRazonSocial.ValueMember = "RazonSocial";
            cboRazonSocial.DataSource = DT.Tables["RazonSocial"];
            Conn.Close();
            if (cboRazonSocial.Items.Count > 1)
            {
                cboRazonSocial.SelectedIndex = -1;
            }
        }
        private void DisplayDGVRazonSocial()
        {
            SqlCommand Query2 = new SqlCommand("SELECT * FROM Proveedores WHERE RazonSocial LIKE '%" + cboRazonSocial.Text + "'", Conn);
            SqlDataAdapter Adaptador2 = new SqlDataAdapter();
            DataTable Tabla2 = new DataTable();
            Adaptador2.SelectCommand = Query2;
            Tabla2.Clear();
            Adaptador2.Fill(Tabla2);
            DgvDatos.DataSource = null;
            DgvDatos.DataSource = Tabla2;
        }
        private void ComboCiudad()
        {
            String Query1 = "SELECT DISTINCT Ciudad FROM Proveedores";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query1, Conn);
            Conn.Open();
            DataSet DT = new DataSet();
            Adaptador.Fill(DT, "Ciudad");
            cboCiudad.DisplayMember = "Ciudad";
            cboCiudad.ValueMember = "Ciudad";
            cboCiudad.DataSource = DT.Tables["Ciudad"];
            Conn.Close();
            if (cboCiudad.Items.Count > 1)
            {
                cboCiudad.SelectedIndex = -1;
            }
        }
        private void DisplayDGVCiudad()
        {
            SqlCommand Query2 = new SqlCommand("SELECT * FROM Proveedores WHERE Ciudad LIKE '%" + cboCiudad.Text + "'", Conn);
            SqlDataAdapter Adaptador2 = new SqlDataAdapter();
            DataTable Tabla2 = new DataTable();
            Adaptador2.SelectCommand = Query2;
            Tabla2.Clear();
            Adaptador2.Fill(Tabla2);
            DgvDatos.DataSource = null;
            DgvDatos.DataSource = Tabla2;
        }
        private void ComboProvincia()
        {
            String Query1 = "SELECT DISTINCT Provincia FROM Proveedores";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query1, Conn);
            Conn.Open();
            DataSet DT = new DataSet();
            Adaptador.Fill(DT, "Provincia");
            CboProvincia.DisplayMember = "Provincia";
            CboProvincia.ValueMember = "Provincia";
            CboProvincia.DataSource = DT.Tables["Provincia"];
            Conn.Close();
            if (CboProvincia.Items.Count > 1)
            {
                CboProvincia.SelectedIndex = -1;
            }
        }
        private void DisplayDGVProvincia()
        {
            SqlCommand Query2 = new SqlCommand("SELECT * FROM Proveedores WHERE Provincia LIKE '%" + CboProvincia.Text + "'", Conn);
            SqlDataAdapter Adaptador2 = new SqlDataAdapter();
            DataTable Tabla2 = new DataTable();
            Adaptador2.SelectCommand = Query2;
            Tabla2.Clear();
            Adaptador2.Fill(Tabla2);
            DgvDatos.DataSource = null;
            DgvDatos.DataSource = Tabla2;
        }
        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedIndex >= 0)
            {
                CboProvincia.SelectedIndex = -1;
                CboProvincia.Text = "Seleccione Provincia";
                cboRazonSocial.SelectedIndex = -1;
                cboRazonSocial.Text = "Seleccione Razón Social";
                DisplayDGVCiudad();
                
                
            }
        }
        private void cboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboRazonSocial.SelectedIndex >= 0)
            {
                cboCiudad.SelectedIndex = -1;
                cboCiudad.Text = "Seleccione Ciudad";
                CboProvincia.SelectedIndex = -1;
                CboProvincia.Text = "Seleccione Provincia";
                DisplayDGVRazonSocial();
            }
        }

        private void CboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProvincia.SelectedIndex >= 0)
            {
                cboCiudad.SelectedIndex = -1;
                cboCiudad.Text = "Seleccione Ciudad";
                cboRazonSocial.SelectedIndex = -1;
                cboRazonSocial.Text = "Seleccione Razón Social";
                DisplayDGVProvincia();

            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro desea borrar los datos del Proveedor?", "Nanzer Climatizacion Integral", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = DgvDatos.CurrentRow.Cells[0].Value.ToString();
                Conn.Open();
                SqlCommand ConsultaBorrar = new SqlCommand("DELETE FROM Proveedores WHERE ID = '" + ID + "'", Conn);
                ConsultaBorrar.ExecuteNonQuery();
                SqlCommand Consulta = new SqlCommand("SELECT * FROM Proveedores", Conn);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                DgvDatos.DataSource = null;
                DgvDatos.DataSource = Tabla;
                DgvDatos.Refresh();
                DgvDatos.Update();
                Conn.Close();
                cboRazonSocial.SelectedIndex = -1;
                CboProvincia.SelectedIndex = -1;
                cboCiudad.SelectedIndex = -1;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarProveedores Edicion = new EditarProveedores();
            Edicion.IDProvTxt.Text = this.DgvDatos.CurrentRow.Cells[0].Value.ToString();
            Edicion.CuitCuilTxt.Text = this.DgvDatos.CurrentRow.Cells[1].Value.ToString();
            Edicion.RazonSocialTxt.Text = this.DgvDatos.CurrentRow.Cells[2].Value.ToString();
            Edicion.DireccionTxt.Text = this.DgvDatos.CurrentRow.Cells[3].Value.ToString();
            Edicion.CiudadTxt.Text = this.DgvDatos.CurrentRow.Cells[4].Value.ToString();
            Edicion.cboProvincia.Text = this.DgvDatos.CurrentRow.Cells[5].Value.ToString();
            Edicion.RepresentanteTxt.Text = this.DgvDatos.CurrentRow.Cells[6].Value.ToString();
            Edicion.TelefonoTxt.Text = this.DgvDatos.CurrentRow.Cells[7].Value.ToString();
            Edicion.EmailTxt.Text = this.DgvDatos.CurrentRow.Cells[8].Value.ToString();
            Edicion.ShowDialog();
            Refrescar();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refrescar()
        {
            Conn.Open();
            SqlCommand Consulta = new SqlCommand("SELECT * FROM Proveedores", Conn);
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
    }
}
