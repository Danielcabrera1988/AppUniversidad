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
    
    public partial class Table_Alumno_DB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Alumno_DB()
        {
            this.Table_Materia__Alumno = new HashSet<Table_Materia__Alumno>();
            this.Table_Profesor_Alumno = new HashSet<Table_Profesor_Alumno>();
            this.Table_Carrera_Alumno = new HashSet<Table_Carrera_Alumno>();
            this.Table_Carrera_Alumno1 = new HashSet<Table_Carrera_Alumno>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Pswd { get; set; }
        public string email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> Notas { get; set; }
        public Nullable<int> Faltas { get; set; }
        public Nullable<int> id_Materia { get; set; }
        public Nullable<int> id_Profesor { get; set; }
        public Nullable<int> id_Carrera { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Materia__Alumno> Table_Materia__Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Profesor_Alumno> Table_Profesor_Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Carrera_Alumno> Table_Carrera_Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Carrera_Alumno> Table_Carrera_Alumno1 { get; set; }
    }
}
