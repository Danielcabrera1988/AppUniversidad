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

namespace AppUniversidad.Forms
{
    public partial class InscripcionMaterias : Form
    {
        public DB_Universidad dc { get; set; }
        public Table_Alumno_DB alumno { get; set; }
        public Table_Materias_DB Materias { get; set; }
        public Table_Materia__Alumno Materia__Alumno { get; set; }
        public InscripcionMaterias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Table_Materia__Alumno newMateriaAlumno = new Table_Materia__Alumno();
            alumno.id_Materia = (int) table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
            Materias.id_Alumno = alumno.ID;

            Materia__Alumno.id_Alumnos = alumno.ID;
            Materia__Alumno.id_Materias = (int)table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
            Materia__Alumno.Nombre_Materia = table_Materias_DBDataGridView.CurrentRow.Cells[1].Value.ToString();
            
            newMateriaAlumno = Materia__Alumno;
            dc.Table_Materia__Alumno.Add(newMateriaAlumno);
            dc.SaveChanges();
            this.Close();
        }

        private void InscripcionMaterias_Load(object sender, EventArgs e)
        {
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
        }
    }
}
