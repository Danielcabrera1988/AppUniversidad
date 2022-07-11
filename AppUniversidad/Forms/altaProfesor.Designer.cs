namespace AppUniversidad.Forms
{
    partial class altaProfesor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ctnCancelar = new System.Windows.Forms.Button();
            this.table_Profesor_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            pswdLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(151, 41);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 22;
            apellidoLabel.Text = "Apellido:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(151, 101);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 24;
            direccionLabel.Text = "Direccion:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(151, 127);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "email:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(151, 68);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 28;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(151, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 36;
            nombreLabel.Text = "Nombre:";
            // 
            // pswdLabel
            // 
            pswdLabel.AutoSize = true;
            pswdLabel.Location = new System.Drawing.Point(151, 179);
            pswdLabel.Name = "pswdLabel";
            pswdLabel.Size = new System.Drawing.Size(36, 13);
            pswdLabel.TabIndex = 38;
            pswdLabel.Text = "Pswd:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(151, 153);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 40;
            telefonoLabel.Text = "Telefono:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(151, 205);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 42;
            usuarioLabel.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppUniversidad.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(253, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ctnCancelar
            // 
            this.ctnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnCancelar.Location = new System.Drawing.Point(377, 241);
            this.ctnCancelar.Name = "ctnCancelar";
            this.ctnCancelar.Size = new System.Drawing.Size(75, 23);
            this.ctnCancelar.TabIndex = 10;
            this.ctnCancelar.Text = "Cancelar";
            this.ctnCancelar.UseVisualStyleBackColor = true;
            this.ctnCancelar.Click += new System.EventHandler(this.ctnCancelar_Click);
            // 
            // table_Profesor_DBBindingSource
            // 
            this.table_Profesor_DBBindingSource.DataSource = typeof(AppUniversidad.Model.Table_Profesor_DB);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(253, 38);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 23;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(253, 98);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(253, 124);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 27;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_Profesor_DBBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(253, 64);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 29;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(253, 12);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 37;
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Pswd", true));
            this.pswdTextBox.Location = new System.Drawing.Point(253, 176);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(200, 20);
            this.pswdTextBox.TabIndex = 39;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(253, 150);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 41;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_Profesor_DBBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(253, 202);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioTextBox.TabIndex = 43;
            // 
            // altaProfesor
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 272);
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
            this.Controls.Add(this.ctnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "altaProfesor";
            this.Text = "altaProfesor";
            this.Load += new System.EventHandler(this.altaProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Profesor_DBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource table_Profesor_DBBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button ctnCancelar;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
    }
}