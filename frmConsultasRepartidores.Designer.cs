namespace sistemareparto
{
    partial class frmConsultasRepartidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasRepartidores));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_QuejasNegativas = new System.Windows.Forms.Button();
            this.dvg_QuejasNegativas = new System.Windows.Forms.DataGridView();
            this.lbl_Repartidores = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuejasPositivas = new System.Windows.Forms.Button();
            this.lbl_QuejasPositivas = new System.Windows.Forms.Label();
            this.dvg_QuejasPositivas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasNegativas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasPositivas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_buscar);
            this.tabPage2.Controls.Add(this.btn_QuejasNegativas);
            this.tabPage2.Controls.Add(this.dvg_QuejasNegativas);
            this.tabPage2.Controls.Add(this.lbl_Repartidores);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quejas Negativas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_buscar.Location = new System.Drawing.Point(603, 100);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(78, 20);
            this.lbl_buscar.TabIndex = 87;
            this.lbl_buscar.Text = "Consultar";
            this.lbl_buscar.Click += new System.EventHandler(this.lbl_buscar_Click);
            // 
            // btn_QuejasNegativas
            // 
            this.btn_QuejasNegativas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuejasNegativas.BackgroundImage")));
            this.btn_QuejasNegativas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuejasNegativas.Location = new System.Drawing.Point(596, 32);
            this.btn_QuejasNegativas.Name = "btn_QuejasNegativas";
            this.btn_QuejasNegativas.Size = new System.Drawing.Size(65, 65);
            this.btn_QuejasNegativas.TabIndex = 86;
            this.btn_QuejasNegativas.UseVisualStyleBackColor = true;
            this.btn_QuejasNegativas.Click += new System.EventHandler(this.btn_QuejasNegativas_Click);
            // 
            // dvg_QuejasNegativas
            // 
            this.dvg_QuejasNegativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_QuejasNegativas.Location = new System.Drawing.Point(22, 150);
            this.dvg_QuejasNegativas.Name = "dvg_QuejasNegativas";
            this.dvg_QuejasNegativas.Size = new System.Drawing.Size(742, 230);
            this.dvg_QuejasNegativas.TabIndex = 85;
            // 
            // lbl_Repartidores
            // 
            this.lbl_Repartidores.AutoSize = true;
            this.lbl_Repartidores.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Repartidores.Location = new System.Drawing.Point(58, 64);
            this.lbl_Repartidores.Name = "lbl_Repartidores";
            this.lbl_Repartidores.Size = new System.Drawing.Size(479, 32);
            this.lbl_Repartidores.TabIndex = 84;
            this.lbl_Repartidores.Text = "Repartidores con Quejas Negativas";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_QuejasPositivas);
            this.tabPage1.Controls.Add(this.lbl_QuejasPositivas);
            this.tabPage1.Controls.Add(this.dvg_QuejasPositivas);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quejas Positivas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(618, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Consultar";
            // 
            // btn_QuejasPositivas
            // 
            this.btn_QuejasPositivas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuejasPositivas.BackgroundImage")));
            this.btn_QuejasPositivas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuejasPositivas.Location = new System.Drawing.Point(622, 24);
            this.btn_QuejasPositivas.Name = "btn_QuejasPositivas";
            this.btn_QuejasPositivas.Size = new System.Drawing.Size(65, 65);
            this.btn_QuejasPositivas.TabIndex = 89;
            this.btn_QuejasPositivas.UseVisualStyleBackColor = true;
            this.btn_QuejasPositivas.Click += new System.EventHandler(this.btn_QuejasPositivas_Click);
            // 
            // lbl_QuejasPositivas
            // 
            this.lbl_QuejasPositivas.AutoSize = true;
            this.lbl_QuejasPositivas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuejasPositivas.Location = new System.Drawing.Point(99, 57);
            this.lbl_QuejasPositivas.Name = "lbl_QuejasPositivas";
            this.lbl_QuejasPositivas.Size = new System.Drawing.Size(456, 32);
            this.lbl_QuejasPositivas.TabIndex = 88;
            this.lbl_QuejasPositivas.Text = "Repartidores con Quejas Positivas";
            // 
            // dvg_QuejasPositivas
            // 
            this.dvg_QuejasPositivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_QuejasPositivas.Location = new System.Drawing.Point(39, 143);
            this.dvg_QuejasPositivas.Name = "dvg_QuejasPositivas";
            this.dvg_QuejasPositivas.Size = new System.Drawing.Size(703, 234);
            this.dvg_QuejasPositivas.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // frmConsultasRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConsultasRepartidores";
            this.Text = "frmConsultasRepartidores";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasNegativas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_QuejasPositivas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dvg_QuejasPositivas;
        private System.Windows.Forms.DataGridView dvg_QuejasNegativas;
        private System.Windows.Forms.Label lbl_Repartidores;
        private System.Windows.Forms.Button btn_QuejasNegativas;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Button btn_QuejasPositivas;
        private System.Windows.Forms.Label lbl_QuejasPositivas;
        private System.Windows.Forms.Label label1;
    }
}