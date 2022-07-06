using AppUniversidad.Forms;
using AppUniversidad.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppUniversidad
{
    public partial class Login : Form
    {
        public DB_Universidad dc = new DB_Universidad();
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
            nuevo.dc = this.dc;
            nuevo.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //realizar la conexion a la base de datos y comprobar si el usario existe
            // y si las credenciales son correctas
            MenuUserAdm adm = new MenuUserAdm();
            adm.ShowDialog();
        }
    }
}
