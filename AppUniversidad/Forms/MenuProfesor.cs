using AppUniversidad.Class;
using AppUniversidad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Modificar el alumno seleccionado
            ModificarAlumno modificar = new ModificarAlumno();
            modificar.Show();
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
    }
}
