using AppUniversidad.Forms;
using AppUniversidad.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace AppUniversidad
{
    public partial class Login : Form
    {
        public DB_Universidad dc = new DB_Universidad();

        private SqlConnection connection = new SqlConnection(@"server = DANIEL\SQLEXPRESS; database = DB_Entity_Universidad; INTEGRATED SECURITY = true;");
        public Login()
        {
            InitializeComponent();
        }

        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "USUARIO")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "USUARIO";
                txtBoxUser.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "CONTRASEÑA")
            {
                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.Black;
                txtBoxPass.UseSystemPasswordChar = true;
            }
        }
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "")
            {
                txtBoxPass.Text = "CONTRASEÑA";
                txtBoxPass.ForeColor = Color.Gainsboro;
                txtBoxPass.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioNuevo nuevo = new UsuarioNuevo();
            nuevo.Show();
            nuevo.dc = this.dc;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Consulta para los ADM
            SqlCommand cmadm = new SqlCommand("SELECT USUARIO, PSWD FROM Table_Adm WHERE Usuario = @vusuario AND Pswd = @vpswd",connection);
            cmadm.Parameters.AddWithValue("@vusuario",txtBoxUser.Text);
            cmadm.Parameters.AddWithValue("@vpswd", GetMD5(txtBoxPass.Text));
            SqlDataReader reader = cmadm.ExecuteReader();
            if (reader.Read())
            {
                MenuUserAdm menuAdm = new MenuUserAdm();
                menuAdm.Show();
                connection.Close();
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
                return;
            }
            reader.Close();
            //Consulta para los Alumnos
            SqlCommand cmalumno = new SqlCommand("SELECT USUARIO, PSWD FROM Table_Alumno_DB WHERE Usuario = @vusuario AND Pswd = @vpswd", connection);
            cmalumno.Parameters.AddWithValue("@vusuario", txtBoxUser.Text);
            cmalumno.Parameters.AddWithValue("@vpswd", GetMD5(txtBoxPass.Text));
            reader = cmalumno.ExecuteReader();
            if (reader.Read())
            {
                MenuAlumnos menuAlumnos = new MenuAlumnos();
                menuAlumnos.Show();
                connection.Close();
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
                return;
            }
            reader.Close();
            //Consulta para los Profesores
            SqlCommand cmprofe = new SqlCommand("SELECT USUARIO, PSWD FROM Table_Profesor_DB WHERE Usuario = @vusuario AND Pswd = @vpswd", connection);
            cmprofe.Parameters.AddWithValue("@vusuario", txtBoxUser.Text);
            cmprofe.Parameters.AddWithValue("@vpswd", GetMD5(txtBoxPass.Text));
            reader = cmprofe.ExecuteReader();
            if (reader.Read())
            {
                MenuProfesor menuProfesor = new MenuProfesor();
                menuProfesor.Show();
                connection.Close();
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
                return;
            }
            else MessageBox.Show("Usuario o Contraseña invalidos", "DATOS INCORRECTOS");
            reader.Close();
            connection.Close();
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
