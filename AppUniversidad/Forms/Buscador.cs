using AppUniversidad.Class;
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
    public partial class Buscador : Form
    {
        public DB_Universidad dc { get; set; }
        Profesor profe = new Profesor();
        public Buscador()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //enlazar segun EL FILTRO NOMBRE Y APELLIDO al datagrid del menu profesor
        }
    }
}
