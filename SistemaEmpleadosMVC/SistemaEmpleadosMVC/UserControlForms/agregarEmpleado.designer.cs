namespace SistemaEmpleadosMVC
{
    partial class agregarEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.respApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.respCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.respTelefono = new System.Windows.Forms.TextBox();
            this.respCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.respNombre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.respPuesto = new System.Windows.Forms.ComboBox();
            this.respSalario = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.respFechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // respApellido
            // 
            resources.ApplyResources(this.respApellido, "respApellido");
            this.respApellido.Name = "respApellido";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // respCedula
            // 
            resources.ApplyResources(this.respCedula, "respCedula");
            this.respCedula.Name = "respCedula";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // respTelefono
            // 
            resources.ApplyResources(this.respTelefono, "respTelefono");
            this.respTelefono.Name = "respTelefono";
            // 
            // respCorreo
            // 
            resources.ApplyResources(this.respCorreo, "respCorreo");
            this.respCorreo.Name = "respCorreo";
            this.respCorreo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.respNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.respCorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.respTelefono);
            this.groupBox1.Controls.Add(this.respCedula);
            this.groupBox1.Controls.Add(this.respApellido);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // respNombre
            // 
            resources.ApplyResources(this.respNombre, "respNombre");
            this.respNombre.Name = "respNombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.respPuesto);
            this.groupBox2.Controls.Add(this.respSalario);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Controls.Add(this.respFechaInicio);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // respPuesto
            // 
            this.respPuesto.FormattingEnabled = true;
            resources.ApplyResources(this.respPuesto, "respPuesto");
            this.respPuesto.Name = "respPuesto";
            this.respPuesto.SelectionChangeCommitted += new System.EventHandler(this.respPuesto_SelectionChangeCommitted);
            // 
            // respSalario
            // 
            this.respSalario.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.respSalario, "respSalario");
            this.respSalario.Name = "respSalario";
            this.respSalario.ReadOnly = true;
            // 
            // bunifuCustomLabel3
            // 
            resources.ApplyResources(this.bunifuCustomLabel3, "bunifuCustomLabel3");
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            // 
            // bunifuCustomLabel2
            // 
            resources.ApplyResources(this.bunifuCustomLabel2, "bunifuCustomLabel2");
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // respFechaInicio
            // 
            this.respFechaInicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.respFechaInicio.BorderRadius = 0;
            this.respFechaInicio.ForeColor = System.Drawing.Color.White;
            this.respFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.respFechaInicio.FormatCustom = null;
            resources.ApplyResources(this.respFechaInicio, "respFechaInicio");
            this.respFechaInicio.Name = "respFechaInicio";
            this.respFechaInicio.Value = new System.DateTime(2018, 2, 22, 23, 35, 51, 54);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // agregarEmpleado
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "agregarEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox respApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox respCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox respTelefono;
        private System.Windows.Forms.TextBox respCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox respNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox respSalario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker respFechaInicio;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox respPuesto;
    }
}
