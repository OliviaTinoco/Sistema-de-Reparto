namespace sistemareparto
{
    partial class frmReporQuejaNegativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporQuejaNegativa));
            this.lbl_reporte = new System.Windows.Forms.Label();
            this.btn_ReporteQuejasNegativas = new System.Windows.Forms.Button();
            this.lbl_QuejasNegativas = new System.Windows.Forms.Label();
            this.dvg_QuejasNegativas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasNegativas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_reporte.Location = new System.Drawing.Point(523, 91);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(165, 20);
            this.lbl_reporte.TabIndex = 96;
            this.lbl_reporte.Text = "Generar Reporte PDF";
            // 
            // btn_ReporteQuejasNegativas
            // 
            this.btn_ReporteQuejasNegativas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReporteQuejasNegativas.BackgroundImage")));
            this.btn_ReporteQuejasNegativas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ReporteQuejasNegativas.Location = new System.Drawing.Point(569, 23);
            this.btn_ReporteQuejasNegativas.Name = "btn_ReporteQuejasNegativas";
            this.btn_ReporteQuejasNegativas.Size = new System.Drawing.Size(65, 65);
            this.btn_ReporteQuejasNegativas.TabIndex = 95;
            this.btn_ReporteQuejasNegativas.UseVisualStyleBackColor = true;
            this.btn_ReporteQuejasNegativas.Click += new System.EventHandler(this.btn_ReporteQuejasNegativas_Click);
            // 
            // lbl_QuejasNegativas
            // 
            this.lbl_QuejasNegativas.AutoSize = true;
            this.lbl_QuejasNegativas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuejasNegativas.Location = new System.Drawing.Point(60, 47);
            this.lbl_QuejasNegativas.Name = "lbl_QuejasNegativas";
            this.lbl_QuejasNegativas.Size = new System.Drawing.Size(479, 32);
            this.lbl_QuejasNegativas.TabIndex = 94;
            this.lbl_QuejasNegativas.Text = "Repartidores con Quejas Negativas";
            // 
            // dvg_QuejasNegativas
            // 
            this.dvg_QuejasNegativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_QuejasNegativas.Location = new System.Drawing.Point(24, 127);
            this.dvg_QuejasNegativas.Name = "dvg_QuejasNegativas";
            this.dvg_QuejasNegativas.Size = new System.Drawing.Size(676, 234);
            this.dvg_QuejasNegativas.TabIndex = 93;
            this.dvg_QuejasNegativas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_QuejasNegativas_CellContentClick);
            // 
            // frmReporQuejaNegativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(728, 373);
            this.Controls.Add(this.lbl_reporte);
            this.Controls.Add(this.btn_ReporteQuejasNegativas);
            this.Controls.Add(this.lbl_QuejasNegativas);
            this.Controls.Add(this.dvg_QuejasNegativas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmReporQuejaNegativa";
            this.Text = "frmReporQuejaNegativa";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasNegativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reporte;
        private System.Windows.Forms.Button btn_ReporteQuejasNegativas;
        private System.Windows.Forms.Label lbl_QuejasNegativas;
        private System.Windows.Forms.DataGridView dvg_QuejasNegativas;
    }
}