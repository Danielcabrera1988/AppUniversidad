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
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if ((nombreTextBox.Text != "" && apellidoTextBox.Text != "" && usuarioTextBox.Text != "" && pswdTextBox.Text != "" && txtBoxPswd2.Text != "" && emailTextBox.Text != "" && RBtnAlumno.Checked)
                || (nombreTextBox.Text != "" && apellidoTextBox.Text != "" && apellidoTextBox.Text != "" && pswdTextBox.Text != "" && txtBoxPswd2.Text != "" && emailTextBox.Text != "" && RBtnProfesor.Checked))
            {
                if (RBtnAlumno.Checked)
                {
                    if (verificarPswd())
                    {
                        pswdTextBox.Text = GetSHA256(txtBoxPswd2.Text);
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
        private void pswdTextBox_TextChanged(object sender, EventArgs e)
        {
            pswdTextBox.UseSystemPasswordChar = true;
        }
        private void txtBoxPswd2_TextChanged(object sender, EventArgs e)
        {
            txtBoxPswd2.UseSystemPasswordChar = true;
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
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
            MessageBox.Show($"Contraseña generada << {password} >>\n ¡Guardela antes de cerrar el cuadro de dialogo!", "AUTOGEN PSWD");
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
    }
}
