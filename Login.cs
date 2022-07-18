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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ControlBox = false;
        }

        SqlConnection Conn = new SqlConnection("workstation id=TrabajoFinalNanzerClima.mssql.somee.com;packet size=4096;user id=agusD_SQLLogin_1;pwd=zn9i9o78g7;data source=TrabajoFinalNanzerClima.mssql.somee.com;persist security info=False;initial catalog=TrabajoFinalNanzerClima");
        private void Clear()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Conn.Open();

            SqlCommand Consulta = new SqlCommand("SELECT Usuario, Contrasena FROM Login WHERE Usuario = @vUsu AND Contrasena = @vContra", Conn);

            Consulta.Parameters.AddWithValue("@vUsu", txtUsuario.Text);
            Consulta.Parameters.AddWithValue("@vContra", txtContraseña.Text);

            SqlDataReader resultado = Consulta.ExecuteReader();

            if (resultado.Read())
            {
                Conn.Close();

                Clear();

                MessageBox.Show("Bienvenido");

                Menu home = new Menu();
                home.Show();

                this.Close();
            }
            else
            {
                Conn.Close();
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                Clear();
                txtUsuario.Focus();
            }
        }

       

            private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Conn.Open();

                SqlCommand Consulta = new SqlCommand("SELECT Usuario, Contrasena FROM Login WHERE Usuario = @vUsu AND Contrasena = @vContra", Conn);

                Consulta.Parameters.AddWithValue("@vUsu", txtUsuario.Text);
                Consulta.Parameters.AddWithValue("@vContra", txtContraseña.Text);

                SqlDataReader resultado = Consulta.ExecuteReader();

                if (resultado.Read())
                {
                    Conn.Close();
                    Clear();
                    MessageBox.Show("Bienvenido!");

                    Menu home = new Menu();
                    home.Show();

                    this.Close();
                }
                else
                {
                    Conn.Close();
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario por defecto es 'admin' y la contraseña es 'admin'");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }    
}
