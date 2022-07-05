using AppUniversidad.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUniversidad.Forms
{
    public partial class UsuarioNuevo : Form
    {
        public UsuarioNuevo()
        {
            InitializeComponent();
        }
        //private List<UserAdm> users = new List<UserAdm>();//Ejemplo de lista de solo Administradores
        private List<Profesor> ListProfes = new List<Profesor>();
        private List<Alumno> ListAlumnos = new List<Alumno>();

        private void txtBoxPswd1_TextChanged(object sender, EventArgs e)
        {
            txtBoxPswd1.UseSystemPasswordChar = true;
        }

        private void txtBoxPswd2_TextChanged(object sender, EventArgs e)
        {
            txtBoxPswd2.UseSystemPasswordChar = true;
        }
        private void makePassword()
        {
            string letrasYNumeros = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string caracteresEspeciales = "!@#$%^&*()_-+=[{]};:<>|./?";
            char caracter;
            string password = "";
            int longPswd = 16;
            int option;
            Random rnd = new Random();
            while (longPswd > 0)
            {
                option = rnd.Next(0, 10);
                if (option < 5)
                {
                    caracter = letrasYNumeros[rnd.Next(letrasYNumeros.Length)];
                    password += caracter.ToString();
                }
                else
                {
                    caracter = letrasYNumeros[rnd.Next(caracteresEspeciales.Length)];
                    password += caracter.ToString();
                }
                longPswd--;
            }
            txtBoxPswd1.Text = password;
            txtBoxPswd2.Text = password;
            MessageBox.Show($"Contraseña generada << {password} >>\n ¡Guardela antes de cerrar el cuadro de dialogo!", "AUTOGEN PSWD");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtBoxName.Text != "" && txtBoxApellido.Text != "" && txtBoxNewUser.Text != "" && txtBoxPswd1.Text != "" && txtBoxPswd2.Text != "" && txtBoxEmail.Text != "" && RBtnAlumno.Checked)
                || (txtBoxName.Text != "" && txtBoxApellido.Text != "" && txtBoxNewUser.Text != "" && txtBoxPswd1.Text != "" && txtBoxPswd2.Text != "" && txtBoxEmail.Text != "" && RBtnProfesor.Checked))
            {
                if (RBtnAlumno.Checked)
                {
                    Alumno alumno = new Alumno(txtBoxName.Text, txtBoxApellido.Text, txtBoxNewUser.Text, txtBoxPswd1.Text, txtBoxEmail.Text);
                    ListAlumnos.Add(alumno);
                    MessageBox.Show("Alumno creado con éxito", "Creación de Alumno");
                }
                else if (RBtnProfesor.Checked)
                {
                    Profesor profesor = new Profesor();
                    ListProfes.Add(profesor);
                    MessageBox.Show("Profesor creado con éxito", "Creación de Profesor");
                }
                //UserAdm user = new UserAdm(txtBoxName.Text, txtBoxApellido.Text, txtBoxNewUser.Text, txtBoxPswd1.Text, txtEmail.Text);
                //users.Add(user);
                //MessageBox.Show("Usuario Creado con éxito", "Nuevo Usuario");
                Close();
            }
            else
            {
                lblMsgError.Text = "Error, Uno o mas campos incompletos";
                lblMsgError.Visible = true;
            }
        }

        private void btnAutoPswd_Click(object sender, EventArgs e)
        {
            makePassword();
        }
    }
}
