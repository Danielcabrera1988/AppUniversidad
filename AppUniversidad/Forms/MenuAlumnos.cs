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
    public partial class MenuAlumnos : Form
    {
        public MenuAlumnos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
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

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cread grid de materias con relacion de faltas
        }
    }
}
