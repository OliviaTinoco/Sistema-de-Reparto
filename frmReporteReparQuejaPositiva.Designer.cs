namespace sistemareparto
{
    partial class frmReporteReparQuejaPositiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteReparQuejaPositiva));
            this.dvg_QuejasPositivas = new System.Windows.Forms.DataGridView();
            this.btn_ReporteQuejasPositivas = new System.Windows.Forms.Button();
            this.lbl_QuejasPositivas = new System.Windows.Forms.Label();
            this.lbl_reporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasPositivas)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_QuejasPositivas
            // 
            this.dvg_QuejasPositivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_QuejasPositivas.Location = new System.Drawing.Point(42, 159);
            this.dvg_QuejasPositivas.Name = "dvg_QuejasPositivas";
            this.dvg_QuejasPositivas.Size = new System.Drawing.Size(676, 234);
            this.dvg_QuejasPositivas.TabIndex = 0;
            // 
            // btn_ReporteQuejasPositivas
            // 
            this.btn_ReporteQuejasPositivas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReporteQuejasPositivas.BackgroundImage")));
            this.btn_ReporteQuejasPositivas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ReporteQuejasPositivas.Location = new System.Drawing.Point(613, 37);
            this.btn_ReporteQuejasPositivas.Name = "btn_ReporteQuejasPositivas";
            this.btn_ReporteQuejasPositivas.Size = new System.Drawing.Size(65, 65);
            this.btn_ReporteQuejasPositivas.TabIndex = 91;
            this.btn_ReporteQuejasPositivas.UseVisualStyleBackColor = true;
            this.btn_ReporteQuejasPositivas.Click += new System.EventHandler(this.btn_ReporteQuejasPositivas_Click);
            // 
            // lbl_QuejasPositivas
            // 
            this.lbl_QuejasPositivas.AutoSize = true;
            this.lbl_QuejasPositivas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuejasPositivas.Location = new System.Drawing.Point(110, 70);
            this.lbl_QuejasPositivas.Name = "lbl_QuejasPositivas";
            this.lbl_QuejasPositivas.Size = new System.Drawing.Size(456, 32);
            this.lbl_QuejasPositivas.TabIndex = 90;
            this.lbl_QuejasPositivas.Text = "Repartidores con Quejas Positivas";
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_reporte.Location = new System.Drawing.Point(562, 109);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(165, 20);
            this.lbl_reporte.TabIndex = 92;
            this.lbl_reporte.Text = "Generar Reporte PDF";
            // 
            // frmReporteReparQuejaPositiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(752, 423);
            this.Controls.Add(this.lbl_reporte);
            this.Controls.Add(this.btn_ReporteQuejasPositivas);
            this.Controls.Add(this.lbl_QuejasPositivas);
            this.Controls.Add(this.dvg_QuejasPositivas);
            this.Name = "frmReporteReparQuejaPositiva";
            this.Text = "frmReporteReparQuejaPositiva";
            this.Load += new System.EventHandler(this.frmReporteReparQuejaPositiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasPositivas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_QuejasPositivas;
        private System.Windows.Forms.Button btn_ReporteQuejasPositivas;
        private System.Windows.Forms.Label lbl_QuejasPositivas;
        private System.Windows.Forms.Label lbl_reporte;
    }
}