using AppUniversidad.Model;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppUniversidad.Forms
{
    public partial class MenuProfesor : Form
    {
        public DB_Universidad dc = new DB_Universidad();
        public Table_Alumno_DB alumno { get; set; }
        public MenuProfesor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.Where(a => a.Nombre == txtBoxBuscador.Text || a.Apellido == txtBoxBuscador.Text).ToList();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modifica la nota y las faltas del alumno seleccionado
            ModificarAlumno modificar = new ModificarAlumno();
            modificar.dc = this.dc;
            modificar.alumno = (Table_Alumno_DB)table_Alumno_DBBindingSource.Current;
            dc.SaveChanges();
            modificar.ShowDialog();
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
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
                        //Formato ==> Alumno: Fulano Merengue Nota: ? Faltas: ?
                        writer.WriteLine("Alumno: " + data.Cells[0].Value + " " + data.Cells[1].Value + " Nota: " + data.Cells[2].Value + " Faltas: " + data.Cells[3].Value);
                    }
                }
            }
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
            if (alumno == null)
            {
                alumno = new Table_Alumno_DB();
            }
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            table_Alumno_DBBindingSource.DataSource = dc.Table_Alumno_DB.ToList();
            txtBoxBuscador.Text = String.Empty;
        }
    }
}
