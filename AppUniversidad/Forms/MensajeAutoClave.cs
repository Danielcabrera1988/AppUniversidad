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
    public partial class MensajeAutoClave : Form
    {
        public MensajeAutoClave(string mensaje)
        {
            InitializeComponent();
            textBox1.Text = mensaje;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
