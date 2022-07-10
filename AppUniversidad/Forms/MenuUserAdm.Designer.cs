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
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.table_Alumno_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.table_Profesor_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.table_Materias_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pswd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Profesor_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Materias_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).BeginInit();
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
            this.altasMenuItem.Size = new System.Drawing.Size(114, 22);
            this.altasMenuItem.Text = "Altas";
            // 
            // altaProfesor
            // 
            this.altaProfesor.Name = "altaProfesor";
            this.altaProfesor.Size = new System.Drawing.Size(122, 22);
            this.altaProfesor.Text = "Profesor";
            this.altaProfesor.Click += new System.EventHandler(this.altaProfesor_Click);
            // 
            // altasAlumno
            // 
            this.altasAlumno.Name = "altasAlumno";
            this.altasAlumno.Size = new System.Drawing.Size(122, 22);
            this.altasAlumno.Text = "Alumnos";
            this.altasAlumno.Click += new System.EventHandler(this.altasAlumnos);
            // 
            // altasMateria
            // 
            this.altasMateria.Name = "altasMateria";
            this.altasMateria.Size = new System.Drawing.Size(122, 22);
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
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.asignarToolStripMenuItem.Text = "Asignar";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarMateriasProfes);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.tXTToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
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
            this.splitContainer1.Enabled = false;
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.table_Alumno_DBDataGridView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Profesor_DBDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Materias_DBDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 419);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // table_Alumno_DBDataGridView
            // 
            this.table_Alumno_DBDataGridView.AutoGenerateColumns = false;
            this.table_Alumno_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Alumno_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Direccion,
            this.dataGridViewTextBoxColumn6});
            this.table_Alumno_DBDataGridView.DataSource = this.table_Alumno_DBBindingSource;
            this.table_Alumno_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Alumno_DBDataGridView.Location = new System.Drawing.Point(375, 3);
            this.table_Alumno_DBDataGridView.Name = "table_Alumno_DBDataGridView";
            this.table_Alumno_DBDataGridView.Size = new System.Drawing.Size(182, 413);
            this.table_Alumno_DBDataGridView.TabIndex = 2;
            // 
            // table_Profesor_DBDataGridView
            // 
            this.table_Profesor_DBDataGridView.AutoGenerateColumns = false;
            this.table_Profesor_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Profesor_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Usuario,
            this.Pswd,
            this.email,
            this.Telefono,
            this.FechaNacimiento});
            this.table_Profesor_DBDataGridView.DataSource = this.table_Profesor_DBBindingSource;
            this.table_Profesor_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Profesor_DBDataGridView.Location = new System.Drawing.Point(189, 3);
            this.table_Profesor_DBDataGridView.Name = "table_Profesor_DBDataGridView";
            this.table_Profesor_DBDataGridView.Size = new System.Drawing.Size(180, 413);
            this.table_Profesor_DBDataGridView.TabIndex = 1;
            // 
            // table_Materias_DBDataGridView
            // 
            this.table_Materias_DBDataGridView.AutoGenerateColumns = false;
            this.table_Materias_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Materias_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.table_Materias_DBDataGridView.DataSource = this.table_Materias_DBBindingSource;
            this.table_Materias_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Materias_DBDataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_Materias_DBDataGridView.Name = "table_Materias_DBDataGridView";
            this.table_Materias_DBDataGridView.Size = new System.Drawing.Size(180, 413);
            this.table_Materias_DBDataGridView.TabIndex = 0;
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
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Pswd
            // 
            this.Pswd.DataPropertyName = "Pswd";
            this.Pswd.HeaderText = "Pswd";
            this.Pswd.Name = "Pswd";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pswd";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pswd";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
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
            // table_Profesor_DBBindingSource
            // 
            this.table_Profesor_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Profesor_DB);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // table_Materias_DBBindingSource
            // 
            this.table_Materias_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materias_DB);
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
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UniversidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.BindingSource dB_UniversidadBindingSource;
        private System.Windows.Forms.BindingSource table_Profesor_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
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
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.BindingSource table_Materias_DBBindingSource;
        private System.Windows.Forms.ToolStripMenuItem altasMateria;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView table_Alumno_DBDataGridView;
        private System.Windows.Forms.DataGridView table_Profesor_DBDataGridView;
        private System.Windows.Forms.DataGridView table_Materias_DBDataGridView;
        private System.Windows.Forms.ToolStripMenuItem bajaMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pswd;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}