namespace sistemareparto
{
    partial class frmReporteMantenimientoVehi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMantenimientoVehi));
            this.lbl_reporte = new System.Windows.Forms.Label();
            this.btn_ReporMantenimiento = new System.Windows.Forms.Button();
            this.lbl_QuejasNegativas = new System.Windows.Forms.Label();
            this.dvg_Mantenimientos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_reporte.Location = new System.Drawing.Point(575, 120);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(165, 20);
            this.lbl_reporte.TabIndex = 100;
            this.lbl_reporte.Text = "Generar Reporte PDF";
            // 
            // btn_ReporMantenimiento
            // 
            this.btn_ReporMantenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReporMantenimiento.BackgroundImage")));
            this.btn_ReporMantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ReporMantenimiento.Location = new System.Drawing.Point(630, 52);
            this.btn_ReporMantenimiento.Name = "btn_ReporMantenimiento";
            this.btn_ReporMantenimiento.Size = new System.Drawing.Size(65, 65);
            this.btn_ReporMantenimiento.TabIndex = 99;
            this.btn_ReporMantenimiento.UseVisualStyleBackColor = true;
            this.btn_ReporMantenimiento.Click += new System.EventHandler(this.btn_ReporMantenimiento_Click);
            // 
            // lbl_QuejasNegativas
            // 
            this.lbl_QuejasNegativas.AutoSize = true;
            this.lbl_QuejasNegativas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuejasNegativas.Location = new System.Drawing.Point(169, 68);
            this.lbl_QuejasNegativas.Name = "lbl_QuejasNegativas";
            this.lbl_QuejasNegativas.Size = new System.Drawing.Size(406, 32);
            this.lbl_QuejasNegativas.TabIndex = 98;
            this.lbl_QuejasNegativas.Text = " Mantenimientos de Vehiculos";
            // 
            // dvg_Mantenimientos
            // 
            this.dvg_Mantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Mantenimientos.Location = new System.Drawing.Point(43, 169);
            this.dvg_Mantenimientos.Name = "dvg_Mantenimientos";
            this.dvg_Mantenimientos.Size = new System.Drawing.Size(735, 219);
            this.dvg_Mantenimientos.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Reporte de ";
            // 
            // frmReporteMantenimientoVehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(807, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_reporte);
            this.Controls.Add(this.btn_ReporMantenimiento);
            this.Controls.Add(this.lbl_QuejasNegativas);
            this.Controls.Add(this.dvg_Mantenimientos);
            this.Name = "frmReporteMantenimientoVehi";
            this.Text = "frmReporteMantenimientoVehi";
            this.Load += new System.EventHandler(this.frmReporteMantenimientoVehi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reporte;
        private System.Windows.Forms.Button btn_ReporMantenimiento;
        private System.Windows.Forms.Label lbl_QuejasNegativas;
        private System.Windows.Forms.DataGridView dvg_Mantenimientos;
        private System.Windows.Forms.Label label1;
    }
}