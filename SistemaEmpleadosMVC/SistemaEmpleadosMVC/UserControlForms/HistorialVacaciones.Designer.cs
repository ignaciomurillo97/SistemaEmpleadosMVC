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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.FechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVacaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaVacaciones
            // 
            this.TablaVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVacaciones.Location = new System.Drawing.Point(18, 16);
            this.TablaVacaciones.Name = "TablaVacaciones";
            this.TablaVacaciones.Size = new System.Drawing.Size(405, 418);
            this.TablaVacaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FechaFinal);
            this.groupBox1.Controls.Add(this.FechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(445, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Vacaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Vacaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Final";
            // 
            // FechaFinal
            // 
            this.FechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FechaFinal.Location = new System.Drawing.Point(4, 109);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(296, 20);
            this.FechaFinal.TabIndex = 2;
            // 
            // FechaInicio
            // 
            this.FechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FechaInicio.Location = new System.Drawing.Point(4, 52);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(296, 20);
            this.FechaInicio.TabIndex = 3;
            // 
            // HistorialVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablaVacaciones);
            this.Name = "HistorialVacaciones";
            this.Size = new System.Drawing.Size(769, 475);
            ((System.ComponentModel.ISupportInitialize)(this.TablaVacaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaVacaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.DateTimePicker FechaInicio;
    }
}
