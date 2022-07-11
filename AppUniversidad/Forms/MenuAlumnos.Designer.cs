namespace AppUniversidad.Forms
{
    partial class MenuAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadoExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Materia__AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgMateriasAlumnos = new System.Windows.Forms.DataGridView();
            this.tableMateriaAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriasAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMateriaAlumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.inscripcionesToolStripMenuItem,
            this.faltasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Solicitudes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examenToolStripMenuItem,
            this.certificadoExamenToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.altaToolStripMenuItem.Text = "Alta / Baja";
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.examenToolStripMenuItem.Text = "Examen";
            // 
            // certificadoExamenToolStripMenuItem
            // 
            this.certificadoExamenToolStripMenuItem.Name = "certificadoExamenToolStripMenuItem";
            this.certificadoExamenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.certificadoExamenToolStripMenuItem.Text = "Certificado Examen";
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrerasToolStripMenuItem,
            this.licenciaturasToolStripMenuItem,
            this.tecnicaturasToolStripMenuItem});
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // licenciaturasToolStripMenuItem
            // 
            this.licenciaturasToolStripMenuItem.Name = "licenciaturasToolStripMenuItem";
            this.licenciaturasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.licenciaturasToolStripMenuItem.Text = "Licenciaturas";
            // 
            // tecnicaturasToolStripMenuItem
            // 
            this.tecnicaturasToolStripMenuItem.Name = "tecnicaturasToolStripMenuItem";
            this.tecnicaturasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tecnicaturasToolStripMenuItem.Text = "Tecnicaturas";
            // 
            // faltasToolStripMenuItem
            // 
            this.faltasToolStripMenuItem.Name = "faltasToolStripMenuItem";
            this.faltasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.faltasToolStripMenuItem.Text = "Faltas";
            this.faltasToolStripMenuItem.Click += new System.EventHandler(this.faltasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
            // 
            // table_Materia__AlumnoBindingSource
            // 
            this.table_Materia__AlumnoBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materia__Alumno);
            // 
            // dgMateriasAlumnos
            // 
            this.dgMateriasAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriasAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materias,
            this.Nota,
            this.Faltas,
            this.Profesor});
            this.dgMateriasAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMateriasAlumnos.Location = new System.Drawing.Point(0, 24);
            this.dgMateriasAlumnos.Name = "dgMateriasAlumnos";
            this.dgMateriasAlumnos.ReadOnly = true;
            this.dgMateriasAlumnos.Size = new System.Drawing.Size(442, 327);
            this.dgMateriasAlumnos.TabIndex = 3;
            // 
            // tableMateriaAlumnoBindingSource
            // 
            this.tableMateriaAlumnoBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materia__Alumno);
            // 
            // Materias
            // 
            this.Materias.HeaderText = "Materias";
            this.Materias.Name = "Materias";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // Faltas
            // 
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            // 
            // MenuAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 351);
            this.Controls.Add(this.dgMateriasAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAlumnos";
            this.Text = "Menu Alumnos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriasAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMateriaAlumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadoExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicaturasToolStripMenuItem;
        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Materia__AlumnoBindingSource;
        private System.Windows.Forms.DataGridView dgMateriasAlumnos;
        private System.Windows.Forms.BindingSource tableMateriaAlumnoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
    }
}