using System;
using AppUniversidad.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AppUniversidad.Forms
{
    public partial class altaProfesor : Form
    {
        public DB_Universidad dc { get ; set; }
        public Table_Profesor_DB newProfe { get; set; }
        public altaProfesor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            newProfe.Pswd = GetMD5(pswdTextBox.Text);
            dc.Table_Profesor_DB.Add(newProfe);            
            dc.SaveChanges();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
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

        private void ctnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaProfesor_Load(object sender, EventArgs e)
        {
            table_Profesor_DBBindingSource.DataSource = newProfe;
        }
    }
}
