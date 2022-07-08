using AppUniversidad.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppUniversidad.Forms
{
    public partial class MenuUserAdm : Form
    {
        DB_Universidad dc = new DB_Universidad();
        public MenuUserAdm()
        {
            InitializeComponent();
        }

        private void MenuUserAdm_Load(object sender, EventArgs e)
        {
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
