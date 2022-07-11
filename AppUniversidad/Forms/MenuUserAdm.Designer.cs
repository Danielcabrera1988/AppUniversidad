namespace AppUniversidad.Forms
{
    partial class MenuUserAdm
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
            this.altasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.altasAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.altasMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.table_Materias_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Materias_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Alumno_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Profesor_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Profesor_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UniversidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasMenuItem,
            this.bajasToolStripMenuItem,
            this.asignarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altasMenuItem
            // 
            this.altasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProfesor,
            this.altasAlumno,
            this.altasMateria});
            this.altasMenuItem.Name = "altasMenuItem";
            this.altasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altasMenuItem.Text = "Altas";
            // 
            // altaProfesor
            // 
            this.altaProfesor.Name = "altaProfesor";
            this.altaProfesor.Size = new System.Drawing.Size(180, 22);
            this.altaProfesor.Text = "Profesor";
            this.altaProfesor.Click += new System.EventHandler(this.altaProfesor_Click);
            // 
            // altasAlumno
            // 
            this.altasAlumno.Name = "altasAlumno";
            this.altasAlumno.Size = new System.Drawing.Size(180, 22);
            this.altasAlumno.Text = "Alumnos";
            this.altasAlumno.Click += new System.EventHandler(this.altasAlumnos);
            // 
            // altasMateria
            // 
            this.altasMateria.Name = "altasMateria";
            this.altasMateria.Size = new System.Drawing.Size(180, 22);
            this.altasMateria.Text = "Materia";
            this.altasMateria.Click += new System.EventHandler(this.altaMateria);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaProfesor,
            this.bajaAlumno,
            this.bajaMaterias});
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            // 
            // bajaProfesor
            // 
            this.bajaProfesor.Name = "bajaProfesor";
            this.bajaProfesor.Size = new System.Drawing.Size(122, 22);
            this.bajaProfesor.Text = "Profesor";
            this.bajaProfesor.Click += new System.EventHandler(this.bajasProfesor);
            // 
            // bajaAlumno
            // 
            this.bajaAlumno.Name = "bajaAlumno";
            this.bajaAlumno.Size = new System.Drawing.Size(122, 22);
            this.bajaAlumno.Text = "Alumnos";
            this.bajaAlumno.Click += new System.EventHandler(this.bajasAlumno);
            // 
            // bajaMaterias
            // 
            this.bajaMaterias.Name = "bajaMaterias";
            this.bajaMaterias.Size = new System.Drawing.Size(122, 22);
            this.bajaMaterias.Text = "Materia";
            this.bajaMaterias.Click += new System.EventHandler(this.bajaMaterias_Click);
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asignarToolStripMenuItem.Text = "Asignar";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarMateriasProfes);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardarTXT,
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // btnGuardarTXT
            // 
            this.btnGuardarTXT.Name = "btnGuardarTXT";
            this.btnGuardarTXT.Size = new System.Drawing.Size(102, 22);
            this.btnGuardarTXT.Text = "TXT";
            this.btnGuardarTXT.Click += new System.EventHandler(this.btnGuardarTXT_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(781, 419);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CopyRight 2022 Lab 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::AppUniversidad.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.table_Materias_DBDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Alumno_DBDataGridView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Profesor_DBDataGridView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 419);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // table_Materias_DBDataGridView
            // 
            this.table_Materias_DBDataGridView.AutoGenerateColumns = false;
            this.table_Materias_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Materias_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.table_Materias_DBDataGridView.DataSource = this.table_Materias_DBBindingSource;
            this.table_Materias_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Materias_DBDataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_Materias_DBDataGridView.Name = "table_Materias_DBDataGridView";
            this.table_Materias_DBDataGridView.Size = new System.Drawing.Size(180, 413);
            this.table_Materias_DBDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_Profesor";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_Profesor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // table_Materias_DBBindingSource
            // 
            this.table_Materias_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materias_DB);
            // 
            // table_Alumno_DBDataGridView
            // 
            this.table_Alumno_DBDataGridView.AutoGenerateColumns = false;
            this.table_Alumno_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Alumno_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.table_Alumno_DBDataGridView.DataSource = this.table_Alumno_DBBindingSource;
            this.table_Alumno_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Alumno_DBDataGridView.Location = new System.Drawing.Point(375, 3);
            this.table_Alumno_DBDataGridView.Name = "table_Alumno_DBDataGridView";
            this.table_Alumno_DBDataGridView.Size = new System.Drawing.Size(182, 413);
            this.table_Alumno_DBDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn19.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn20.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn21.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn23.HeaderText = "email";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn24.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn25.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn26.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
            // 
            // table_Profesor_DBDataGridView
            // 
            this.table_Profesor_DBDataGridView.AutoGenerateColumns = false;
            this.table_Profesor_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Profesor_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.table_Profesor_DBDataGridView.DataSource = this.table_Profesor_DBBindingSource;
            this.table_Profesor_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Profesor_DBDataGridView.Location = new System.Drawing.Point(189, 3);
            this.table_Profesor_DBDataGridView.Name = "table_Profesor_DBDataGridView";
            this.table_Profesor_DBDataGridView.Size = new System.Drawing.Size(180, 413);
            this.table_Profesor_DBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn8.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn11.HeaderText = "email";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn13.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn14.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // table_Profesor_DBBindingSource
            // 
            this.table_Profesor_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Profesor_DB);
            // 
            // dB_UniversidadBindingSource
            // 
            this.dB_UniversidadBindingSource.DataSource = typeof(AppUniversidad.Model.DB_Universidad);
            // 
            // MenuUserAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuUserAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador - Alumnado";
            this.Load += new System.EventHandler(this.MenuUserAdm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UniversidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.BindingSource dB_UniversidadBindingSource;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasAlumno;
        private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaProfesor;
        private System.Windows.Forms.ToolStripMenuItem bajaAlumno;
        private System.Windows.Forms.ToolStripMenuItem altaProfesor;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarTXT;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasMateria;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem bajaMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource table_Materias_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Profesor_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
        private System.Windows.Forms.DataGridView table_Alumno_DBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridView table_Profesor_DBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView table_Materias_DBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}