using System;
using AppUniversidad.Model;
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
    public partial class AsociacionMaterias_Profes : Form
    {
        public DB_Universidad dc { get; set; }

        public Table_Materias_Profe table_Materias_Profe { get; set; }
        public Table_Materias_DB materia = new Table_Materias_DB(); 
        public Table_Profesor_DB profe = new Table_Profesor_DB();
        public AsociacionMaterias_Profes()
        {
            InitializeComponent();
        }

        private void AsociacionMaterias_Profes_Load(object sender, EventArgs e)
        {
            table_Materias_DBBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            table_Materias_ProfeBindingSource.DataSource = dc.Table_Materias_Profe.ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (table_Materias_Profe == null)
            {
                table_Materias_Profe = new Table_Materias_Profe();
                //Asignacion de valores a la nueva relacion Profe <==> Materia
                table_Materias_Profe.id_Materia = (int)table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
                table_Materias_Profe.id_Profesor = (int)table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
                table_Materias_Profe.Nombre_Materia = table_Materias_DBDataGridView.CurrentRow.Cells[2].Value.ToString();
                table_Materias_Profe.Nombre_Profesor = table_Profesor_DBDataGridView.CurrentRow.Cells[2].Value.ToString();

                //asignacion de la relacion de los id de materia y profesor
                materia.id_Profesor = (int)table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
                profe.id_Materia = table_Materias_DBDataGridView.CurrentRow.Cells[0].Value.ToString();

                //asignacion de id del profe a la materia
                table_Materias_DBDataGridView.CurrentRow.Cells[1].Value = table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
                //Asignacion de id de la materia al profe
                table_Profesor_DBDataGridView.CurrentRow.Cells[1].Value = table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
                //se agrega el nuevo elemento a la tabla de relacion
                dc.Table_Materias_Profe.Add(table_Materias_Profe);
                dc.SaveChanges();
            }           
            actualizarListas();
        }
        private void actualizarListas()
        {
            table_Materias_ProfeBindingSource.DataSource = dc.Table_Materias_DB.ToList();
            table_Profesor_DBBindingSource.DataSource = dc.Table_Profesor_DB.ToList();
            table_Materias_ProfeBindingSource.DataSource = dc.Table_Materias_Profe.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminacion de materia_profe seleccionada y en bd
            Table_Materias_Profe relacionAEliminar = (Table_Materias_Profe)table_Materias_ProfeBindingSource.Current;
            if (relacionAEliminar.id_Materia == null || relacionAEliminar.id_Profesor == null)
            {
                dc.Table_Materias_Profe.Remove(relacionAEliminar);
                dc.SaveChanges();
                table_Materias_ProfeBindingSource.DataSource = dc.Table_Materias_Profe.ToList();
            }
            else MessageBox.Show("Debe seleccionar una Relación", "Error de Selección");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Asignacion de valores a la nueva relacion Profe <==> Materia
            table_Materias_Profe.id_Materia = (int)table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
            table_Materias_Profe.id_Profesor = (int)table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
            table_Materias_Profe.Nombre_Materia = table_Materias_DBDataGridView.CurrentRow.Cells[2].Value.ToString();
            table_Materias_Profe.Nombre_Profesor = table_Profesor_DBDataGridView.CurrentRow.Cells[2].Value.ToString();

            //asignacion de la relacion de los id de materia y profesor
            materia.id_Profesor = (int)table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
            profe.id_Materia = table_Materias_DBDataGridView.CurrentRow.Cells[0].Value.ToString();

            //asignacion de id del profe a la materia
            table_Materias_DBDataGridView.CurrentRow.Cells[1].Value = table_Profesor_DBDataGridView.CurrentRow.Cells[0].Value;
            //Asignacion de id de la materia al profe
            table_Profesor_DBDataGridView.CurrentRow.Cells[1].Value = table_Materias_DBDataGridView.CurrentRow.Cells[0].Value;
            dc.SaveChanges();
        }
    }
}
