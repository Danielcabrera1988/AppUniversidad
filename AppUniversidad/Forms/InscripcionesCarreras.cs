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
using System.Data.SqlClient;

namespace AppUniversidad.Forms
{
    public partial class InscripcionesCarreras : Form
    {
        public DB_Universidad dc { get; set; }
        public Table_Alumno_DB alumno { get; set; }

        public Table_Carrera_Alumno Carrera_Alumno { get; set; }
        public InscripcionesCarreras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno.id_Carrera = (int)table_CarrerasDataGridView.CurrentRow.Cells[0].Value;
            Carrera_Alumno.id_Alumno = alumno.ID;
            Carrera_Alumno.id_Carrera = (int)table_CarrerasDataGridView.CurrentRow.Cells[0].Value;
            dc.Table_Carrera_Alumno.Add(Carrera_Alumno);
            dc.SaveChanges();
            MessageBox.Show("Inscripcion a la carrera correctamente", "Inscrpcion");
            
            this.Close();
        }

        private void InscripcionesCarreras_Load(object sender, EventArgs e)
        {
            table_CarrerasBindingSource.DataSource = dc.Table_Carreras.ToList();
        }
    }
}
