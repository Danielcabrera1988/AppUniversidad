using AppUniversidad.Model;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace AppUniversidad.Forms
{
    public partial class UsuarioNuevo : Form
    {
        public DB_Universidad dc { get; set; }
        private Table_Alumno_DB AlumnoFicha { get; set; }
        private Table_Profesor_DB ProfesorFicha { get; set; }
        
        public UsuarioNuevo()
        {
            InitializeComponent();
        }
        //creacion del alumno o profesor
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //corregir el databinging de alumno y profesor
            if ((nombreTextBox.Text != "" && apellidoTextBox.Text != "" && usuarioTextBox.Text != "" && pswdTextBox.Text != "" && txtBoxPswd2.Text != "" && emailTextBox.Text != "" && RBtnAlumno.Checked)
                || (nombreTextBox.Text != "" && apellidoTextBox.Text != "" && apellidoTextBox.Text != "" && pswdTextBox.Text != "" && txtBoxPswd2.Text != "" && emailTextBox.Text != "" && RBtnProfesor.Checked))
            {
                if (RBtnAlumno.Checked)
                {
                    if (verificarPswd())
                    {
                        AlumnoFicha.Apellido = apellidoTextBox.Text;
                        AlumnoFicha.Nombre = nombreTextBox.Text;
                        AlumnoFicha.email = emailTextBox.Text;
                        AlumnoFicha.Usuario = usuarioTextBox.Text;
                        AlumnoFicha.Pswd = GetMD5(pswdTextBox.Text);
                        dc.Table_Alumno_DB.Add(AlumnoFicha);
                        dc.SaveChanges();
                        MessageBox.Show("Alumno creado con éxito", "Creación de Alumno");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben coincidir", "CONTRASEÑAS");
                        pswdTextBox.Text = "";
                        txtBoxPswd2.Text = "";
                    }
                }
                else if (RBtnProfesor.Checked)
                {
                    if (verificarPswd())
                    {
                        ProfesorFicha.Apellido = usuarioTextBox.Text;
                        ProfesorFicha.Nombre = nombreTextBox.Text;
                        ProfesorFicha.email = emailTextBox.Text;
                        ProfesorFicha.Usuario = usuarioTextBox.Text;
                        ProfesorFicha.Pswd = GetMD5(pswdTextBox.Text);
                        dc.Table_Profesor_DB.Add(ProfesorFicha);
                        dc.SaveChanges();
                        MessageBox.Show("Profesor creado con éxito", "Creación de Profesor");
                        this.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben coincidir", "CONTRASEÑAS");
                        pswdTextBox.Text = "";
                        txtBoxPswd2.Text = "";
                    }
                }
            }
            else
            {
                lblMsgError.Visible = true;
                lblMsgError.Text = "Error, Uno o mas campos incompletos";
            }
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
        private void makePassword()
        {
            string letrasYNumeros = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string caracteresEspeciales = "!@#$%^&*()_-+=[{]};:<>|./?";
            string password = "";
            char caracter;
            int longPswd = 16;
            int option;
            Random rnd = new Random();
            while (longPswd > 0)
            {
                option = rnd.Next(1, 5);
                if (option % 2 == 0)
                {
                    caracter = letrasYNumeros[rnd.Next(letrasYNumeros.Length)];
                    password += caracter.ToString();
                }
                else
                {
                    caracter = caracteresEspeciales[rnd.Next(caracteresEspeciales.Length)];
                    password += caracter.ToString();
                }
                longPswd--;
            }
            txtBoxPswd2.Text = password;
            pswdTextBox.Text = password;
            MensajeAutoClave mensajebox = new MensajeAutoClave($"Contraseña generada:\r\n\r\n{password}\r\n\r\n¡Guardela antes de cerrar el cuadro de dialogo!");
            mensajebox.ShowDialog();
        }
        private void btnAutoPswd_Click(object sender, EventArgs e)
        {
            makePassword();
        }
        private bool verificarPswd()
        {
            if (pswdTextBox.Text != txtBoxPswd2.Text)
            {
                return false;
            }
            else return true;
        }
        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {
            if (ProfesorFicha == null || AlumnoFicha == null)
            {
                AlumnoFicha = new Table_Alumno_DB();
                ProfesorFicha = new Table_Profesor_DB();
                table_Alumno_DBBindingSource.DataSource = AlumnoFicha;
                table_Profesor_DBBindingSource.DataSource = ProfesorFicha;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
