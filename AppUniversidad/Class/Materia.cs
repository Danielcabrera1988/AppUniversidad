using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUniversidad.Class
{
    internal class Materia
    {
        private string nombre;
        private List<Profesor> profesorList;
        private List<Alumno> alumnoList;

        public Materia()
        {
            nombre = "";
            profesorList = new List<Profesor>();
            alumnoList = new List<Alumno>();
        }

        public Materia(string name, List<Profesor> Profes, List<Alumno> Alumnos)
        {
            nombre = name;
            profesorList = Profes;
            alumnoList = Alumnos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Profesor> ProfesorList { get => profesorList; }
        internal List<Alumno> AlumnoList { get => alumnoList; }
    }
}
