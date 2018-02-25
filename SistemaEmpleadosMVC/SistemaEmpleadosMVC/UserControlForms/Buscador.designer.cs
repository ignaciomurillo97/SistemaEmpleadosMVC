﻿namespace SistemaEmpleadosMVC.UserControlForm
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.busca = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.data = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.busca);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.White;
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageActive = null;
            this.buscar.Location = new System.Drawing.Point(252, 29);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(30, 30);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscar.TabIndex = 2;
            this.buscar.TabStop = false;
            this.buscar.Zoom = 10;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // busca
            // 
            this.busca.BorderColor = System.Drawing.Color.SeaGreen;
            this.busca.Location = new System.Drawing.Point(24, 29);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(205, 30);
            this.busca.TabIndex = 1;
            this.busca.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            this.busca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle4;
            this.data.Location = new System.Drawing.Point(18, 65);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(608, 211);
            this.data.TabIndex = 3;
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Buscador";
            this.Size = new System.Drawing.Size(640, 303);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox busca;
        private Bunifu.Framework.UI.BunifuImageButton buscar;
        private System.Windows.Forms.DataGridView data;
    }
}
