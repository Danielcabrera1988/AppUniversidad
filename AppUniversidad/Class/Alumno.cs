using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUniversidad.Class
{
    internal class Alumno
    {
        private string name { get; set; }
        private string apellido { get; set; }
        private int id { get; set; }
        private string[] materia { get; set; }
        private int [] faltasXMaterias { get; set; }
        private int[] notasXMaterias { get; set; }
    }
}
