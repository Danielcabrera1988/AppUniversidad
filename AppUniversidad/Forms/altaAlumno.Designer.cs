namespace AppUniversidad.Forms
{
    partial class altaAlumno
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label pswdLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.table_Alumno_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            pswdLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(201, 41);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(53, 16);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(312, 38);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 21);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(201, 67);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(60, 16);
            direccionLabel.TabIndex = 3;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(312, 64);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 21);
            this.direccionTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(201, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(39, 16);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(312, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 21);
            this.emailTextBox.TabIndex = 4;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.Location = new System.Drawing.Point(201, 146);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(109, 16);
            fechaNacimientoLabel.TabIndex = 9;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_Alumno_DBBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(312, 142);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(201, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(53, 16);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(312, 12);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 21);
            this.nombreTextBox.TabIndex = 1;
            // 
            // pswdLabel
            // 
            pswdLabel.AutoSize = true;
            pswdLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pswdLabel.Location = new System.Drawing.Point(201, 197);
            pswdLabel.Name = "pswdLabel";
            pswdLabel.Size = new System.Drawing.Size(39, 16);
            pswdLabel.TabIndex = 21;
            pswdLabel.Text = "Pswd:";
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Pswd", true));
            this.pswdTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdTextBox.Location = new System.Drawing.Point(312, 194);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(200, 21);
            this.pswdTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(201, 119);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(55, 16);
            telefonoLabel.TabIndex = 23;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(312, 116);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 21);
            this.telefonoTextBox.TabIndex = 5;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(201, 171);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(49, 16);
            usuarioLabel.TabIndex = 25;
            usuarioLabel.Text = "Usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Alumno_DBBindingSource, "Usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(312, 168);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 21);
            this.usuarioTextBox.TabIndex = 7;
            // 
            // table_Alumno_DBBindingSource
            // 
            this.table_Alumno_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Alumno_DB);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppUniversidad.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(312, 230);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(437, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // altaAlumno
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 265);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(pswdLabel);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Name = "altaAlumno";
            this.Text = "altaAlumno";
            this.Load += new System.EventHandler(this.altaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_Alumno_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource table_Alumno_DBBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}