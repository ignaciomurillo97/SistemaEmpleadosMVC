namespace SistemaEmpleadosMVC
{
    partial class VentanaPrincipal
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.transicion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.editarEmpleado1 = new SistemaEmpleadosMVC.UserControlForms.editarEmpleado();
            this.buscar = new SistemaEmpleadosMVC.UserControlForm.Buscador();
            this.agregarEmpleado2 = new SistemaEmpleadosMVC.agregarEmpleado();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.efecto = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.efecto1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.datosEmpleados1 = new SistemaEmpleadosMVC.UserControlForms.DatosEmpleados();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.transicion.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.efecto1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button4
            // 
            this.efecto1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.efecto1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.efecto1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editar_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.efecto1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.efecto1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.button6);
            this.transicion.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.efecto1.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // button6
            // 
            this.efecto1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // transicion
            // 
            this.transicion.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transicion.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.transicion.DefaultAnimation = animation7;
            // 
            // editarEmpleado1
            // 
            this.efecto1.SetDecoration(this.editarEmpleado1, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.editarEmpleado1, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.editarEmpleado1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.editarEmpleado1, "editarEmpleado1");
            this.editarEmpleado1.Name = "editarEmpleado1";
            // 
            // buscar
            // 
            this.efecto1.SetDecoration(this.buscar, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.buscar, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.buscar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.buscar, "buscar");
            this.buscar.Name = "buscar";
            // 
            // agregarEmpleado2
            // 
            resources.ApplyResources(this.agregarEmpleado2, "agregarEmpleado2");
            this.efecto1.SetDecoration(this.agregarEmpleado2, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.agregarEmpleado2, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.agregarEmpleado2, BunifuAnimatorNS.DecorationType.None);
            this.agregarEmpleado2.Name = "agregarEmpleado2";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // efecto
            // 
            this.efecto.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.efecto.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 1;
            animation9.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 2F;
            animation9.TransparencyCoeff = 0F;
            this.efecto.DefaultAnimation = animation9;
            // 
            // efecto1
            // 
            this.efecto1.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.efecto1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.efecto1.DefaultAnimation = animation8;
            // 
            // datosEmpleados1
            // 
            this.efecto1.SetDecoration(this.datosEmpleados1, BunifuAnimatorNS.DecorationType.None);
            this.efecto.SetDecoration(this.datosEmpleados1, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this.datosEmpleados1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.datosEmpleados1, "datosEmpleados1");
            this.datosEmpleados1.Name = "datosEmpleados1";
            this.datosEmpleados1.Tag = "";
            // 
            // VentanaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.datosEmpleados1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editarEmpleado1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.agregarEmpleado2);
            this.efecto.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transicion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.efecto1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button6;
        private agregarEmpleado agregarEmpleado2;
        private UserControlForm.Buscador buscar;
        private UserControlForms.editarEmpleado editarEmpleado1;
        private BunifuAnimatorNS.BunifuTransition transicion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BunifuAnimatorNS.BunifuTransition efecto;
        private BunifuAnimatorNS.BunifuTransition efecto1;
        private System.Windows.Forms.Button button4;
        private UserControlForms.DatosEmpleados datosEmpleados1;
    }
}