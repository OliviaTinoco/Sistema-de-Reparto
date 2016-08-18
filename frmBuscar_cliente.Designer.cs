namespace sistemareparto
{
    partial class frmBuscar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar_cliente));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dgv_buscac = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_aceptar = new System.Windows.Forms.Label();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.dgv_buscdir = new System.Windows.Forms.DataGridView();
            this.dgv_busctel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscdir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busctel)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(266, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 128;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(102, 76);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 127;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(463, 127);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 126;
            this.lbl_buscar.Text = "Buscar";
            // 
            // dgv_buscac
            // 
            this.dgv_buscac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscac.Location = new System.Drawing.Point(29, 172);
            this.dgv_buscac.Name = "dgv_buscac";
            this.dgv_buscac.Size = new System.Drawing.Size(710, 150);
            this.dgv_buscac.TabIndex = 125;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(467, 69);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_buscar.Size = new System.Drawing.Size(54, 55);
            this.btn_buscar.TabIndex = 124;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(266, 483);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(65, 65);
            this.btn_aceptar.TabIndex = 123;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(355, 483);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 122;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 121;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(260, 22);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(228, 32);
            this.lbl_titulo.TabIndex = 120;
            this.lbl_titulo.Text = "BUSCAR CLIENTE";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(266, 130);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 20);
            this.txt_apellido.TabIndex = 131;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(102, 127);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(74, 21);
            this.lbl_apellido.TabIndex = 130;
            this.lbl_apellido.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 129;
            // 
            // lbl_aceptar
            // 
            this.lbl_aceptar.AutoSize = true;
            this.lbl_aceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aceptar.Location = new System.Drawing.Point(262, 547);
            this.lbl_aceptar.Name = "lbl_aceptar";
            this.lbl_aceptar.Size = new System.Drawing.Size(70, 20);
            this.lbl_aceptar.TabIndex = 133;
            this.lbl_aceptar.Text = "Aceptar";
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelar.Location = new System.Drawing.Point(357, 547);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.lbl_cancelar.TabIndex = 132;
            this.lbl_cancelar.Text = "Cancelar";
            // 
            // dgv_buscdir
            // 
            this.dgv_buscdir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscdir.Location = new System.Drawing.Point(29, 328);
            this.dgv_buscdir.Name = "dgv_buscdir";
            this.dgv_buscdir.Size = new System.Drawing.Size(359, 117);
            this.dgv_buscdir.TabIndex = 134;
            // 
            // dgv_busctel
            // 
            this.dgv_busctel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busctel.Location = new System.Drawing.Point(394, 328);
            this.dgv_busctel.Name = "dgv_busctel";
            this.dgv_busctel.Size = new System.Drawing.Size(345, 117);
            this.dgv_busctel.TabIndex = 135;
            // 
            // frmBuscar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(764, 583);
            this.Controls.Add(this.dgv_busctel);
            this.Controls.Add(this.dgv_buscdir);
            this.Controls.Add(this.lbl_aceptar);
            this.Controls.Add(this.lbl_cancelar);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dgv_buscac);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_cliente";
            this.Load += new System.EventHandler(this.frmBuscar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscdir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busctel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DataGridView dgv_buscac;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_aceptar;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.DataGridView dgv_buscdir;
        private System.Windows.Forms.DataGridView dgv_busctel;
    }
}