namespace SistemaEmpleadosMVC.UserControlForms
{
    partial class DatosEmpleados
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpleados));
            this.botonHistorialPagos = new System.Windows.Forms.Button();
            this.botonHistorialVacaciones = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.campoCedula = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.campoTelefono = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.campoCorreo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.campoPuesto = new System.Windows.Forms.Label();
            this.campoSalario = new System.Windows.Forms.Label();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.campoApellido = new System.Windows.Forms.Label();
            this.DatosFamiliares = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // botonHistorialPagos
            // 
            this.botonHistorialPagos.BackColor = System.Drawing.Color.White;
            this.botonHistorialPagos.FlatAppearance.BorderSize = 0;
            this.botonHistorialPagos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonHistorialPagos.Image = ((System.Drawing.Image)(resources.GetObject("botonHistorialPagos.Image")));
            this.botonHistorialPagos.Location = new System.Drawing.Point(919, 394);
            this.botonHistorialPagos.Margin = new System.Windows.Forms.Padding(4);
            this.botonHistorialPagos.Name = "botonHistorialPagos";
            this.botonHistorialPagos.Size = new System.Drawing.Size(98, 88);
            this.botonHistorialPagos.TabIndex = 13;
            this.botonHistorialPagos.Text = "Pagos";
            this.botonHistorialPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonHistorialPagos.UseVisualStyleBackColor = false;
            // 
            // botonHistorialVacaciones
            // 
            this.botonHistorialVacaciones.BackColor = System.Drawing.Color.White;
            this.botonHistorialVacaciones.FlatAppearance.BorderSize = 0;
            this.botonHistorialVacaciones.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonHistorialVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("botonHistorialVacaciones.Image")));
            this.botonHistorialVacaciones.Location = new System.Drawing.Point(799, 393);
            this.botonHistorialVacaciones.Margin = new System.Windows.Forms.Padding(0);
            this.botonHistorialVacaciones.Name = "botonHistorialVacaciones";
            this.botonHistorialVacaciones.Size = new System.Drawing.Size(105, 88);
            this.botonHistorialVacaciones.TabIndex = 13;
            this.botonHistorialVacaciones.Text = "Vacaciones";
            this.botonHistorialVacaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonHistorialVacaciones.UseVisualStyleBackColor = false;
            this.botonHistorialVacaciones.Click += new System.EventHandler(this.botonHistorialVacaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoApellido);
            this.groupBox1.Controls.Add(this.campoCorreo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.campoTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.campoNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.campoCedula);
            this.groupBox1.Controls.Add(this.labelCedula);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 306);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelCedula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCedula.Location = new System.Drawing.Point(46, 21);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(83, 22);
            this.labelCedula.TabIndex = 22;
            this.labelCedula.Text = "Cédula:";
            // 
            // campoCedula
            // 
            this.campoCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoCedula.AutoSize = true;
            this.campoCedula.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoCedula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoCedula.Location = new System.Drawing.Point(65, 44);
            this.campoCedula.Name = "campoCedula";
            this.campoCedula.Size = new System.Drawing.Size(98, 22);
            this.campoCedula.TabIndex = 23;
            this.campoCedula.Text = "12345678";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombre.Location = new System.Drawing.Point(46, 74);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(89, 22);
            this.labelNombre.TabIndex = 24;
            this.labelNombre.Text = "Nombre:";
            // 
            // campoNombre
            // 
            this.campoNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoNombre.AutoSize = true;
            this.campoNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoNombre.Location = new System.Drawing.Point(65, 97);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(98, 22);
            this.campoNombre.TabIndex = 25;
            this.campoNombre.Text = "12345678";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(46, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefono:";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoTelefono.AutoSize = true;
            this.campoTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoTelefono.Location = new System.Drawing.Point(65, 168);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(98, 22);
            this.campoTelefono.TabIndex = 28;
            this.campoTelefono.Text = "12345678";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(46, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Correo";
            // 
            // campoCorreo
            // 
            this.campoCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoCorreo.AutoSize = true;
            this.campoCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoCorreo.Location = new System.Drawing.Point(65, 232);
            this.campoCorreo.Name = "campoCorreo";
            this.campoCorreo.Size = new System.Drawing.Size(98, 22);
            this.campoCorreo.TabIndex = 30;
            this.campoCorreo.Text = "12345678";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatosFamiliares);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(322, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 306);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Familiares";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.campoPuesto);
            this.groupBox3.Controls.Add(this.campoSalario);
            this.groupBox3.Controls.Add(this.labelPuesto);
            this.groupBox3.Controls.Add(this.labelSalario);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 159);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Laboral";
            // 
            // campoPuesto
            // 
            this.campoPuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoPuesto.AutoSize = true;
            this.campoPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoPuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoPuesto.Location = new System.Drawing.Point(30, 48);
            this.campoPuesto.Name = "campoPuesto";
            this.campoPuesto.Size = new System.Drawing.Size(71, 22);
            this.campoPuesto.TabIndex = 17;
            this.campoPuesto.Text = "Puesto";
            // 
            // campoSalario
            // 
            this.campoSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoSalario.AutoSize = true;
            this.campoSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoSalario.Location = new System.Drawing.Point(29, 115);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(69, 22);
            this.campoSalario.TabIndex = 18;
            this.campoSalario.Text = "Salario";
            // 
            // labelPuesto
            // 
            this.labelPuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelPuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPuesto.Location = new System.Drawing.Point(11, 18);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(76, 22);
            this.labelPuesto.TabIndex = 15;
            this.labelPuesto.Text = "Puesto:";
            // 
            // labelSalario
            // 
            this.labelSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSalario.Location = new System.Drawing.Point(10, 86);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(69, 22);
            this.labelSalario.TabIndex = 16;
            this.labelSalario.Text = "Salario";
            // 
            // campoApellido
            // 
            this.campoApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.campoApellido.AutoSize = true;
            this.campoApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.campoApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoApellido.Location = new System.Drawing.Point(160, 97);
            this.campoApellido.Name = "campoApellido";
            this.campoApellido.Size = new System.Drawing.Size(98, 22);
            this.campoApellido.TabIndex = 31;
            this.campoApellido.Text = "12345678";
            // 
            // DatosFamiliares
            // 
            this.DatosFamiliares.AllowUserToAddRows = false;
            this.DatosFamiliares.AllowUserToDeleteRows = false;
            this.DatosFamiliares.AllowUserToResizeColumns = false;
            this.DatosFamiliares.AllowUserToResizeRows = false;
            this.DatosFamiliares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DatosFamiliares.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DatosFamiliares.BackgroundColor = System.Drawing.Color.White;
            this.DatosFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosFamiliares.Location = new System.Drawing.Point(7, 30);
            this.DatosFamiliares.Margin = new System.Windows.Forms.Padding(4);
            this.DatosFamiliares.Name = "DatosFamiliares";
            this.DatosFamiliares.ReadOnly = true;
            this.DatosFamiliares.Size = new System.Drawing.Size(691, 248);
            this.DatosFamiliares.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(685, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 88);
            this.button1.TabIndex = 17;
            this.button1.Text = "Permisos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonHistorialPagos);
            this.Controls.Add(this.botonHistorialVacaciones);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DatosEmpleados";
            this.Size = new System.Drawing.Size(1030, 505);
            this.Tag = "";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFamiliares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonHistorialPagos;
        private System.Windows.Forms.Button botonHistorialVacaciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label campoCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label campoTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label campoNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label campoCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label campoPuesto;
        private System.Windows.Forms.Label campoSalario;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label campoApellido;
        private System.Windows.Forms.DataGridView DatosFamiliares;
        private System.Windows.Forms.Button button1;
    }
}
