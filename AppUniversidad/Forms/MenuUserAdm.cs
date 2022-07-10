using AppUniversidad.Model;
using System;
using System.IO;
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void asignarMateriasProfes(object sender, EventArgs e)
        {
            //inner join de profes a materias
        }

        private void altaProfesor_Click(object sender, EventArgs e)
        {
            //crecion de profe en bd
        }

        private void altasAlumnos(object sender, EventArgs e)
        {
            //creacion de alumnos en bd
        }

        private void bajasProfesor(object sender, EventArgs e)
        {
            //elimnacion de profe seleccionado y en bd
        }

        private void bajasAlumno(object sender, EventArgs e)
        {
            //eliminacion de alumno seleccionado y en bd
        }
        private void bajaMaterias_Click(object sender, EventArgs e)
        {
            //eliminacion de materia seleccionada y en bd
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine();//escribir lo que haga falta            
                }
            }
        }
        private void altaMateria(object sender, EventArgs e)
        {
            altaMaterias alta = new altaMaterias();
            alta.Show();
            //instruccion SQL para crear nueva materia en bd
        }

        private void MenuUserAdm_Load(object sender, EventArgs e)
        {
            //cargar todos los alumnos, profes y materias de la bd
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
        }
    }
}
