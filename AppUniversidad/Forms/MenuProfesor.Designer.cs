﻿namespace AppUniversidad.Forms
{
    partial class MenuProfesor
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
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_Materia__AlumnoDataGridView = new System.Windows.Forms.DataGridView();
            this.columnaMateria_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAlumno_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMateria_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_Alumno_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Materia__AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Profesor_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UniversidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.btnModificar);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table_Materia__AlumnoDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(684, 386);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(3, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(3, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppUniversidad.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // table_Materia__AlumnoDataGridView
            // 
            this.table_Materia__AlumnoDataGridView.AutoGenerateColumns = false;
            this.table_Materia__AlumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Materia__AlumnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaMateria_1,
            this.columnaAlumno_2,
            this.nombreMateria_3,
            this.nombre_Alumno_4,
            this.Nota_5});
            this.table_Materia__AlumnoDataGridView.DataSource = this.table_Materia__AlumnoBindingSource;
            this.table_Materia__AlumnoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Materia__AlumnoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.table_Materia__AlumnoDataGridView.Name = "table_Materia__AlumnoDataGridView";
            this.table_Materia__AlumnoDataGridView.Size = new System.Drawing.Size(542, 386);
            this.table_Materia__AlumnoDataGridView.TabIndex = 0;
            // 
            // columnaMateria_1
            // 
            this.columnaMateria_1.DataPropertyName = "id_Materias";
            this.columnaMateria_1.HeaderText = "id_Materias";
            this.columnaMateria_1.Name = "columnaMateria_1";
            // 
            // columnaAlumno_2
            // 
            this.columnaAlumno_2.DataPropertyName = "id_Alumnos";
            this.columnaAlumno_2.HeaderText = "id_Alumnos";
            this.columnaAlumno_2.Name = "columnaAlumno_2";
            // 
            // nombreMateria_3
            // 
            this.nombreMateria_3.DataPropertyName = "Nombre_Materia";
            this.nombreMateria_3.HeaderText = "Nombre_Materia";
            this.nombreMateria_3.Name = "nombreMateria_3";
            // 
            // nombre_Alumno_4
            // 
            this.nombre_Alumno_4.DataPropertyName = "Nombre_Alumno";
            this.nombre_Alumno_4.HeaderText = "Nombre_Alumno";
            this.nombre_Alumno_4.Name = "nombre_Alumno_4";
            // 
            // Nota_5
            // 
            this.Nota_5.HeaderText = "Nota";
            this.Nota_5.Name = "Nota_5";
            // 
            // table_Materia__AlumnoBindingSource
            // 
            this.table_Materia__AlumnoBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materia__Alumno);
            // 
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
            // 
            // table_Profesor_DBBindingSource
            // 
            this.table_Profesor_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Profesor_DB);
            // 
            // dB_UniversidadBindingSource
            // 
            this.dB_UniversidadBindingSource.DataSource = typeof(AppUniversidad.Model.DB_Universidad);
            // 
            // MenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Profesor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materia__AlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UniversidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource table_Profesor_DBBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Materia__AlumnoBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.BindingSource dB_UniversidadBindingSource;
        private System.Windows.Forms.DataGridView table_Materia__AlumnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMateria_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAlumno_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMateria_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_Alumno_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_5;
    }
}