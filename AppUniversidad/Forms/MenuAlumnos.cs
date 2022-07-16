using System;
using AppUniversidad.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppUniversidad.Forms
{
    public partial class MenuAlumnos : Form
    {
        public DB_Universidad dc { get; set; }
        public Table_Alumno_DB alumno { get; set; }
        public Table_Carreras carreras { get; set; }
        public Table_Materias_DB materias { get; set; }
        public Table_Carrera_Alumno Carrera_Alumno {get; set; }
        public Table_Materia__Alumno materiaAlumno { get; set; }  
        internal string nameAlumno;
        public MenuAlumnos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "|Archivos TXT|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //tatan tatan...
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine();//escribir lo que haga falta            
                }
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionesCarreras inscripciones = new InscripcionesCarreras();
            inscripciones.alumno = this.alumno;
            inscripciones.carreras = this.carreras;
            inscripciones.Carrera_Alumno = this.Carrera_Alumno;
            inscripciones.dc = this.dc;
            inscripciones.ShowDialog();
            actualizarlistas();
        }

        private void MenuAlumnos_Load(object sender, EventArgs e)
        {
            actualizarlistas();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.FirstOrDefault(data=> data.Usuario == nameAlumno);
            alumno = dc.Table_Alumno_DB.FirstOrDefault(data => data.Usuario == nameAlumno);
        }
        private void actualizarlistas()
        {
            table_Carrera_AlumnoBindingSource.DataSource = dc.Table_Carrera_Alumno.ToList();
            table_Materia__AlumnoBindingSource.DataSource = dc.Table_Materia__Alumno.ToList();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InscripcionMaterias inscripcionMaterias = new InscripcionMaterias();
            inscripcionMaterias.alumno = this.alumno;
            inscripcionMaterias.Materia__Alumno = this.materiaAlumno;
            inscripcionMaterias.Materias = this.materias;
            inscripcionMaterias.dc = this.dc;
            inscripcionMaterias.ShowDialog();
            actualizarlistas();
        }
    }
}
