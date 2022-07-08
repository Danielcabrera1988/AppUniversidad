using AppUniversidad.Class;
using AppUniversidad.Forms;
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
    public partial class MenuProfesor : Form
    {
        public MenuProfesor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador buscador = new Buscador();
            buscador.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarAlumno modificar = new ModificarAlumno();
            modificar.Show();
        }
    }
}
