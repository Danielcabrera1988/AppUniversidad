namespace AppUniversidad.Forms
{
    partial class ModificarAlumno
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label faltasLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label notasLabel;
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faltasTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            faltasLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(182, 41);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(65, 17);
            apellidoLabel.TabIndex = 29;
            apellidoLabel.Text = "Apellido:";
            // 
            // faltasLabel
            // 
            faltasLabel.AutoSize = true;
            faltasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faltasLabel.Location = new System.Drawing.Point(182, 81);
            faltasLabel.Name = "faltasLabel";
            faltasLabel.Size = new System.Drawing.Size(49, 17);
            faltasLabel.TabIndex = 31;
            faltasLabel.Text = "Faltas:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(182, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(65, 17);
            nombreLabel.TabIndex = 33;
            nombreLabel.Text = "Nombre:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(182, 107);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(50, 17);
            notasLabel.TabIndex = 35;
            notasLabel.Text = "Notas:";
            // 
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
            // 
            // faltasTextBox
            // 
            this.faltasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Faltas", true));
            this.faltasTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faltasTextBox.Location = new System.Drawing.Point(235, 78);
            this.faltasTextBox.Name = "faltasTextBox";
            this.faltasTextBox.Size = new System.Drawing.Size(56, 23);
            this.faltasTextBox.TabIndex = 1;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Notas", true));
            this.notasTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasTextBox.Location = new System.Drawing.Point(235, 104);
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(56, 23);
            this.notasTextBox.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(308, 76);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(70, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(308, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppUniversidad.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(253, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 17);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "label1";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(253, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 17);
            this.lblApellido.TabIndex = 41;
            this.lblApellido.Text = "label2";
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 136);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(faltasLabel);
            this.Controls.Add(this.faltasTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Name = "ModificarAlumno";
            this.Text = "Modificar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
        private System.Windows.Forms.TextBox faltasTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
    }
}