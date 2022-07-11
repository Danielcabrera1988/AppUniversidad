namespace AppUniversidad.Forms
{
    partial class AsociacionMaterias_Profes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.table_Profesor_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.table_Materias_DBDataGridView = new System.Windows.Forms.DataGridView();
            this.table_Materias_ProfeDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.table_Profesor_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Materias_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Materias_ProfeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_ProfeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_ProfeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAsignar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(826, 450);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "la Asociación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(3, 37);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.table_Profesor_DBDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Materias_DBDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_Materias_ProfeDataGridView, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // table_Profesor_DBDataGridView
            // 
            this.table_Profesor_DBDataGridView.AutoGenerateColumns = false;
            this.table_Profesor_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Profesor_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.id_Materia,
            this.dataGridViewTextBoxColumn12});
            this.table_Profesor_DBDataGridView.DataSource = this.table_Profesor_DBBindingSource;
            this.table_Profesor_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Profesor_DBDataGridView.Location = new System.Drawing.Point(241, 3);
            this.table_Profesor_DBDataGridView.Name = "table_Profesor_DBDataGridView";
            this.table_Profesor_DBDataGridView.Size = new System.Drawing.Size(232, 444);
            this.table_Profesor_DBDataGridView.TabIndex = 6;
            // 
            // table_Materias_DBDataGridView
            // 
            this.table_Materias_DBDataGridView.AutoGenerateColumns = false;
            this.table_Materias_DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Materias_DBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.id_Profesor,
            this.dataGridViewTextBoxColumn2});
            this.table_Materias_DBDataGridView.DataSource = this.table_Materias_DBBindingSource;
            this.table_Materias_DBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Materias_DBDataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_Materias_DBDataGridView.Name = "table_Materias_DBDataGridView";
            this.table_Materias_DBDataGridView.Size = new System.Drawing.Size(232, 444);
            this.table_Materias_DBDataGridView.TabIndex = 6;
            // 
            // table_Materias_ProfeDataGridView
            // 
            this.table_Materias_ProfeDataGridView.AutoGenerateColumns = false;
            this.table_Materias_ProfeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Materias_ProfeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.table_Materias_ProfeDataGridView.DataSource = this.table_Materias_ProfeBindingSource;
            this.table_Materias_ProfeDataGridView.Location = new System.Drawing.Point(479, 3);
            this.table_Materias_ProfeDataGridView.Name = "table_Materias_ProfeDataGridView";
            this.table_Materias_ProfeDataGridView.ReadOnly = true;
            this.table_Materias_ProfeDataGridView.Size = new System.Drawing.Size(234, 444);
            this.table_Materias_ProfeDataGridView.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(3, 95);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // table_Profesor_DBBindingSource
            // 
            this.table_Profesor_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Profesor_DB);
            // 
            // table_Materias_DBBindingSource
            // 
            this.table_Materias_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materias_DB);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_Materia";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_Materia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_Profesor";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_Profesor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nombre_Materia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre_Materia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nombre_Profesor";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre_Profesor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // table_Materias_ProfeBindingSource
            // 
            this.table_Materias_ProfeBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Materias_Profe);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // id_Profesor
            // 
            this.id_Profesor.DataPropertyName = "id_Profesor";
            this.id_Profesor.HeaderText = "id_Profesor";
            this.id_Profesor.Name = "id_Profesor";
            this.id_Profesor.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 30;
            // 
            // id_Materia
            // 
            this.id_Materia.DataPropertyName = "id_Materia";
            this.id_Materia.HeaderText = "id_Materia";
            this.id_Materia.Name = "id_Materia";
            this.id_Materia.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // AsociacionMaterias_Profes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AsociacionMaterias_Profes";
            this.ShowIcon = false;
            this.Text = "AsociacionMaterias_Profes";
            this.Load += new System.EventHandler(this.AsociacionMaterias_Profes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_ProfeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Materias_ProfeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource table_Materias_ProfeBindingSource;
        private System.Windows.Forms.BindingSource table_Materias_DBBindingSource;
        private System.Windows.Forms.BindingSource table_Profesor_DBBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView table_Profesor_DBDataGridView;
        private System.Windows.Forms.DataGridView table_Materias_DBDataGridView;
        private System.Windows.Forms.DataGridView table_Materias_ProfeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}