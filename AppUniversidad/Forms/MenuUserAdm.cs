﻿using AppUniversidad.Model;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppUniversidad.Forms
{
    public partial class MenuUserAdm : Form
    {
        public DB_Universidad dc = new DB_Universidad();
        public Table_Profesor_DB profe { get; set; }
        public Table_Alumno_DB alumno { get; set; }
        public Table_Materias_DB materia { get; set; }
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
            //inner join de profes y materias
            AsociacionMaterias_Profes asociacion = new AsociacionMaterias_Profes();
            asociacion.dc = this.dc;
            dc.SaveChanges();
            asociacion.ShowDialog();          
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
        }

        private void altaProfesor_Click(object sender, EventArgs e)
        {
            //crecion de profe en bd
            altaProfesor newProfe = new altaProfesor();
            newProfe.dc = this.dc;
            dc.SaveChanges();
            newProfe.ShowDialog();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
        }
        private void altasAlumnos(object sender, EventArgs e)
        {
            //creacion de alumnos en bd
            altaAlumno altaAlumno = new altaAlumno();
            altaAlumno.dc = this.dc;
            dc.SaveChanges();
            altaAlumno.ShowDialog();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
        }
        private void altaMateria(object sender, EventArgs e)
        {
            altaMaterias alta = new altaMaterias();
            alta.dc = this.dc;
            dc.SaveChanges();
            alta.ShowDialog();
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
        }
        private void bajasProfesor(object sender, EventArgs e)
        {
            //elimnacion de profe seleccionado y en bd
            Table_Profesor_DB profeEliminado = (Table_Profesor_DB) table_Profesor_DBBindingSource.Current;
            if (profeEliminado != null)
            {
                dc.Table_Profesor_DB.Remove(profeEliminado);
                dc.SaveChanges();
                table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            }
            else MessageBox.Show("Debe seleccionar un Profesor", "Error de Selección");
            
        }
        private void bajasAlumno(object sender, EventArgs e)
        {
            //eliminacion de alumno seleccionado y en bd
            Table_Alumno_DB alumnoEliminado = (Table_Alumno_DB) table_Alumno_DBBindingSource.Current;
            if (alumnoEliminado != null)
            {
                dc.Table_Alumno_DB.Remove(alumnoEliminado);
                dc.SaveChanges();
                table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
            }
            else MessageBox.Show("Debe seleccionar un Alumno", "Error de Selección");
        }
        private void bajaMaterias_Click(object sender, EventArgs e)
        {
            //eliminacion de materia seleccionada y en bd
            Table_Materias_DB materiaElimiada = (Table_Materias_DB) table_Materias_DBBindingSource.Current;
            if (materiaElimiada != null)
            {
                dc.Table_Materias_DB.Remove(materiaElimiada);
                dc.SaveChanges();
                table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            }
            else MessageBox.Show("Debe seleccionar una Materia", "Error de Selección");
        }
        private void MenuUserAdm_Load(object sender, EventArgs e)
        {
            //carga todos los alumnos, profes y materias de la bd en cada una de sus columnas
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
        }
        private void guardarArchivo(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos TXT|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //tatan tatan...
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine("Tabla de Alumnos");
                    foreach (DataGridViewRow data in table_Alumno_DBDataGridView.Rows)
                    {
                        //Formato ==> Alumno: Fulano Merengue
                        writer.WriteLine("Alumno: " + data.Cells[0].Value + " " + data.Cells[1].Value);
                    }
                    writer.WriteLine("Tabla de Profesores");
                    foreach (DataGridViewRow data in table_Profesor_DBDataGridView.Rows)
                    {
                        //Formato ==> Profesor: Fulano Merengue
                        writer.WriteLine("Profesor: " + data.Cells[0].Value + " " + data.Cells[1].Value);
                    }
                    writer.WriteLine("Tabla de Materias");
                    foreach (DataGridViewRow data in table_Materias_DBDataGridView.Rows)
                    {
                        //Formato ==> Alumno: Fulano Merengue Nota: ? Faltas: ?
                        writer.WriteLine("Materia: " + data.Cells[0].Value);
                    }
                }
            }
        }
    }
}
