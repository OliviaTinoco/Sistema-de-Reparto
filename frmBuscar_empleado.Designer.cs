namespace sistemareparto
{
    partial class frmBuscar_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar_empleado));
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dgv_buscemp = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_aceptar = new System.Windows.Forms.Label();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.dgv_buscdir = new System.Windows.Forms.DataGridView();
            this.dgv_buscor = new System.Windows.Forms.DataGridView();
            this.dgv_busctel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscdir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busctel)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(264, 140);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 20);
            this.txt_apellido.TabIndex = 143;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(100, 137);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(74, 21);
            this.lbl_apellido.TabIndex = 142;
            this.lbl_apellido.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 141;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(264, 89);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 140;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(100, 86);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 139;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(461, 137);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 138;
            this.lbl_buscar.Text = "Buscar";
            // 
            // dgv_buscemp
            // 
            this.dgv_buscemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscemp.Location = new System.Drawing.Point(27, 182);
            this.dgv_buscemp.Name = "dgv_buscemp";
            this.dgv_buscemp.Size = new System.Drawing.Size(800, 110);
            this.dgv_buscemp.TabIndex = 137;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(465, 79);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_buscar.Size = new System.Drawing.Size(54, 55);
            this.btn_buscar.TabIndex = 136;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(349, 446);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(65, 65);
            this.btn_aceptar.TabIndex = 135;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(438, 446);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 134;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 133;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(242, 34);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(269, 32);
            this.lbl_titulo.TabIndex = 132;
            this.lbl_titulo.Text = "BUSCAR EMPLEADO";
            // 
            // lbl_aceptar
            // 
            this.lbl_aceptar.AutoSize = true;
            this.lbl_aceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aceptar.Location = new System.Drawing.Point(345, 514);
            this.lbl_aceptar.Name = "lbl_aceptar";
            this.lbl_aceptar.Size = new System.Drawing.Size(70, 20);
            this.lbl_aceptar.TabIndex = 145;
            this.lbl_aceptar.Text = "Aceptar";
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelar.Location = new System.Drawing.Point(434, 514);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.lbl_cancelar.TabIndex = 144;
            this.lbl_cancelar.Text = "Cancelar";
            // 
            // dgv_buscdir
            // 
            this.dgv_buscdir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscdir.Location = new System.Drawing.Point(27, 298);
            this.dgv_buscdir.Name = "dgv_buscdir";
            this.dgv_buscdir.Size = new System.Drawing.Size(325, 110);
            this.dgv_buscdir.TabIndex = 146;
            // 
            // dgv_buscor
            // 
            this.dgv_buscor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscor.Location = new System.Drawing.Point(619, 298);
            this.dgv_buscor.Name = "dgv_buscor";
            this.dgv_buscor.Size = new System.Drawing.Size(208, 110);
            this.dgv_buscor.TabIndex = 147;
            // 
            // dgv_busctel
            // 
            this.dgv_busctel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busctel.Location = new System.Drawing.Point(375, 298);
            this.dgv_busctel.Name = "dgv_busctel";
            this.dgv_busctel.Size = new System.Drawing.Size(223, 110);
            this.dgv_busctel.TabIndex = 148;
            // 
            // frmBuscar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(851, 548);
            this.Controls.Add(this.dgv_busctel);
            this.Controls.Add(this.dgv_buscor);
            this.Controls.Add(this.dgv_buscdir);
            this.Controls.Add(this.lbl_aceptar);
            this.Controls.Add(this.lbl_cancelar);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dgv_buscemp);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_empleado";
            this.Load += new System.EventHandler(this.frmBuscar_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscdir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busctel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DataGridView dgv_buscemp;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_aceptar;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.DataGridView dgv_buscdir;
        private System.Windows.Forms.DataGridView dgv_buscor;
        private System.Windows.Forms.DataGridView dgv_busctel;
    }
}