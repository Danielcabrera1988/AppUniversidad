//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUniversidad.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Materia__Alumno
    {
        public int ID { get; set; }
        public Nullable<int> id_Materias { get; set; }
        public Nullable<int> id_Alumnos { get; set; }
        public string Nombre_Materia { get; set; }
        public string Nombre_Alumno { get; set; }
        public string Nota { get; set; }
    
        public virtual Table_Alumno_DB Table_Alumno_DB { get; set; }
        public virtual Table_Materias_DB Table_Materias_DB { get; set; }
    }
}
