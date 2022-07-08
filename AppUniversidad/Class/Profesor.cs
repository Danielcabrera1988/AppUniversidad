using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUniversidad.Class
{
    internal class Profesor
    {
        private string name { get; set; }
        private string apellido { get; set; }
        private int id { get; set; }

        private List<Materias> materias = new List<Materias>();
        internal List<Materias> Materias { get => materias; set => materias = value; }

    }
}
