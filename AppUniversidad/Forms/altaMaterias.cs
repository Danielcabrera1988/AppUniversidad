using AppUniversidad.Model;
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
    public partial class altaMaterias : Form
    {
        public DB_Universidad dc { get; set; }
        public Table_Materias_DB materia { get; set; }
        public altaMaterias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dc.Table_Materias_DB.Add(materia);
            dc.SaveChanges();
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            this.Close();
        }

        private void altaMaterias_Load(object sender, EventArgs e)
        {
            if (materia == null)
            {
                materia = new Table_Materias_DB();
            }
            table_Materias_DBBindingSource.DataSource = materia;
        }
    }
}
