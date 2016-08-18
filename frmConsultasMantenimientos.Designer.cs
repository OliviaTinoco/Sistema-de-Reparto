namespace sistemareparto
{
    partial class frmConsultasMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasMantenimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuejasPositivas = new System.Windows.Forms.Button();
            this.lbl_QuejasPositivas = new System.Windows.Forms.Label();
            this.dvg_Mantenimientos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(641, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Consultar";
            // 
            // btn_QuejasPositivas
            // 
            this.btn_QuejasPositivas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuejasPositivas.BackgroundImage")));
            this.btn_QuejasPositivas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuejasPositivas.Location = new System.Drawing.Point(636, 30);
            this.btn_QuejasPositivas.Name = "btn_QuejasPositivas";
            this.btn_QuejasPositivas.Size = new System.Drawing.Size(74, 65);
            this.btn_QuejasPositivas.TabIndex = 93;
            this.btn_QuejasPositivas.UseVisualStyleBackColor = true;
            this.btn_QuejasPositivas.Click += new System.EventHandler(this.btn_QuejasPositivas_Click);
            // 
            // lbl_QuejasPositivas
            // 
            this.lbl_QuejasPositivas.AutoSize = true;
            this.lbl_QuejasPositivas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuejasPositivas.Location = new System.Drawing.Point(171, 72);
            this.lbl_QuejasPositivas.Name = "lbl_QuejasPositivas";
            this.lbl_QuejasPositivas.Size = new System.Drawing.Size(398, 32);
            this.lbl_QuejasPositivas.TabIndex = 92;
            this.lbl_QuejasPositivas.Text = "Mantenimientos de Vehiculos";
            // 
            // dvg_Mantenimientos
            // 
            this.dvg_Mantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Mantenimientos.Location = new System.Drawing.Point(34, 142);
            this.dvg_Mantenimientos.Name = "dvg_Mantenimientos";
            this.dvg_Mantenimientos.Size = new System.Drawing.Size(712, 230);
            this.dvg_Mantenimientos.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 95;
            this.label2.Text = "Consultas de";
            // 
            // frmConsultasMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(795, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_QuejasPositivas);
            this.Controls.Add(this.lbl_QuejasPositivas);
            this.Controls.Add(this.dvg_Mantenimientos);
            this.Name = "frmConsultasMantenimientos";
            this.Text = "frmConsultasMantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuejasPositivas;
        private System.Windows.Forms.Label lbl_QuejasPositivas;
        private System.Windows.Forms.DataGridView dvg_Mantenimientos;
        private System.Windows.Forms.Label label2;
    }
}