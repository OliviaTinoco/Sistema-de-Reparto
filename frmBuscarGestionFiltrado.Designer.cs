namespace sistemareparto
{
    partial class frmBuscarGestionFiltrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarGestionFiltrado));
            this.dgv_vehiculo = new System.Windows.Forms.DataGridView();
            this.lbl_aceptar = new System.Windows.Forms.Label();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_chasis = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vehiculo
            // 
            this.dgv_vehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehiculo.Location = new System.Drawing.Point(24, 146);
            this.dgv_vehiculo.Name = "dgv_vehiculo";
            this.dgv_vehiculo.Size = new System.Drawing.Size(710, 150);
            this.dgv_vehiculo.TabIndex = 151;
            // 
            // lbl_aceptar
            // 
            this.lbl_aceptar.AutoSize = true;
            this.lbl_aceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aceptar.Location = new System.Drawing.Point(263, 388);
            this.lbl_aceptar.Name = "lbl_aceptar";
            this.lbl_aceptar.Size = new System.Drawing.Size(70, 20);
            this.lbl_aceptar.TabIndex = 150;
            this.lbl_aceptar.Text = "Aceptar";
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelar.Location = new System.Drawing.Point(373, 385);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.lbl_cancelar.TabIndex = 149;
            this.lbl_cancelar.Text = "Cancelar";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(267, 320);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(65, 65);
            this.btn_aceptar.TabIndex = 148;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(377, 320);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 147;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(442, 51);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 146;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.Location = new System.Drawing.Point(144, 111);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(59, 21);
            this.lbl_placa.TabIndex = 145;
            this.lbl_placa.Text = "Chasis";
            // 
            // txt_chasis
            // 
            this.txt_chasis.Location = new System.Drawing.Point(245, 111);
            this.txt_chasis.Name = "txt_chasis";
            this.txt_chasis.Size = new System.Drawing.Size(150, 20);
            this.txt_chasis.TabIndex = 144;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(245, 71);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(150, 20);
            this.txt_placa.TabIndex = 143;
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiculo.Location = new System.Drawing.Point(149, 71);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(54, 21);
            this.lbl_vehiculo.TabIndex = 142;
            this.lbl_vehiculo.Text = "Placa";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(453, 119);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 141;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(215, 7);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(292, 36);
            this.lbl_titulo.TabIndex = 140;
            this.lbl_titulo.Text = "BUSCAR VEHICULOS";
            // 
            // frmBuscarGestionFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(746, 415);
            this.Controls.Add(this.dgv_vehiculo);
            this.Controls.Add(this.lbl_aceptar);
            this.Controls.Add(this.lbl_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.txt_chasis);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_vehiculo);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frmBuscarGestionFiltrado";
            this.Text = "frmBuscarGestionFiltrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vehiculo;
        private System.Windows.Forms.Label lbl_aceptar;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_chasis;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_titulo;
    }
}