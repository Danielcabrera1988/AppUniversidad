using AppUniversidad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUniversidad.Forms
{
    public partial class altaAlumno : Form
    {
        public DB_Universidad dc { get; set; }
        public Table_Alumno_DB newAlumno { get; set; }
        public altaAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            newAlumno.Pswd = GetMD5(pswdTextBox.Text);
            dc.Table_Alumno_DB.Add(newAlumno);
            dc.SaveChanges();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            this.Close();
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

        private void altaAlumno_Load(object sender, EventArgs e)
        {
            if (newAlumno == null)
            {
                newAlumno = new Table_Alumno_DB();
            }
            table_Alumno_DBBindingSource.DataSource = newAlumno;
        }
    }
}
