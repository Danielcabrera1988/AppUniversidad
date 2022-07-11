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
    public partial class ModificarAlumno : Form
    {
        public DB_Universidad dc { get; set; }
        internal Table_Alumno_DB alumno { get; set; }
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Actualizar datos del alumno
            int nota, falta;
            if (int.TryParse(faltasTextBox.Text, out falta) && int.TryParse(notasTextBox.Text, out nota))
            {
                alumno.Faltas = falta;
                alumno.Notas = nota;
                dc.SaveChanges();
                this.Close();
                table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
            }
            else MessageBox.Show("Valores ingresados incorrectos", "ALERTA");            
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            lblNombre.Text = alumno.Nombre;
            lblApellido.Text = alumno.Apellido;
        }
    }
}
