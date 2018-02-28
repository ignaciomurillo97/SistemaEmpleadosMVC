namespace SistemaEmpleadosMVC.UserControlForms
{
    partial class HistorialVacaciones
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
            this.TablaVacaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.FechaFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVacaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaVacaciones
            // 
            this.TablaVacaciones.BackgroundColor = System.Drawing.Color.White;
            this.TablaVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVacaciones.Location = new System.Drawing.Point(19, 42);
            this.TablaVacaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TablaVacaciones.Name = "TablaVacaciones";
            this.TablaVacaciones.Size = new System.Drawing.Size(491, 322);
            this.TablaVacaciones.TabIndex = 0;
            this.TablaVacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaVacaciones_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.FechaInicio);
            this.groupBox1.Controls.Add(this.FechaFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(593, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(427, 335);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Vacaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Final";
            // 
            // FechaInicio
            // 
            this.FechaInicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.FechaInicio.BorderRadius = 0;
            this.FechaInicio.ForeColor = System.Drawing.Color.White;
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FechaInicio.FormatCustom = null;
            this.FechaInicio.Location = new System.Drawing.Point(13, 62);
            this.FechaInicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(396, 52);
            this.FechaInicio.TabIndex = 7;
            this.FechaInicio.Value = new System.DateTime(2018, 2, 27, 22, 42, 52, 792);
            // 
            // FechaFinal
            // 
            this.FechaFinal.BackColor = System.Drawing.Color.DodgerBlue;
            this.FechaFinal.BorderRadius = 0;
            this.FechaFinal.ForeColor = System.Drawing.Color.White;
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FechaFinal.FormatCustom = null;
            this.FechaFinal.Location = new System.Drawing.Point(12, 176);
            this.FechaFinal.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(397, 52);
            this.FechaFinal.TabIndex = 8;
            this.FechaFinal.Value = new System.DateTime(2018, 2, 27, 22, 42, 52, 792);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TablaVacaciones);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 419);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Vacaciones";
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "Agregar Vacaciones";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = null;
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 90D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(90, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(275, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Vacaciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HistorialVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistorialVacaciones";
            this.Size = new System.Drawing.Size(1026, 482);
            ((System.ComponentModel.ISupportInitialize)(this.TablaVacaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaVacaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker FechaInicio;
        private Bunifu.Framework.UI.BunifuDatepicker FechaFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
    }
}
