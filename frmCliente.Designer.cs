namespace sistemareparto
{
    partial class cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente));
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.lbl_pnombre = new System.Windows.Forms.Label();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.lbl_snombre = new System.Windows.Forms.Label();
            this.lbl_papellido = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_fechanac = new System.Windows.Forms.Label();
            this.lbl_sapellido = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_snombre = new System.Windows.Forms.TextBox();
            this.txt_papellido = new System.Windows.Forms.TextBox();
            this.txt_sapellido = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_fechanac = new System.Windows.Forms.TextBox();
            this.txt_zona = new System.Windows.Forms.TextBox();
            this.txt_tel1 = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_avenida = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_calle2 = new System.Windows.Forms.TextBox();
            this.txt_avenida2 = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_zona2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_calle1 = new System.Windows.Forms.TextBox();
            this.txt_avenida1 = new System.Windows.Forms.TextBox();
            this.txt_zona1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_dir = new System.Windows.Forms.DataGridView();
            this.dgv_tel = new System.Windows.Forms.DataGridView();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(26, 451);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.Size = new System.Drawing.Size(877, 150);
            this.dgv_cliente.TabIndex = 1;
            this.dgv_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellContentClick);
            // 
            // lbl_pnombre
            // 
            this.lbl_pnombre.AutoSize = true;
            this.lbl_pnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnombre.Location = new System.Drawing.Point(22, 166);
            this.lbl_pnombre.Name = "lbl_pnombre";
            this.lbl_pnombre.Size = new System.Drawing.Size(123, 20);
            this.lbl_pnombre.TabIndex = 2;
            this.lbl_pnombre.Text = "Primer Nombre*";
            this.lbl_pnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.Location = new System.Drawing.Point(204, 169);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(150, 20);
            this.txt_pnombre.TabIndex = 3;
            // 
            // lbl_snombre
            // 
            this.lbl_snombre.AutoSize = true;
            this.lbl_snombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snombre.Location = new System.Drawing.Point(22, 216);
            this.lbl_snombre.Name = "lbl_snombre";
            this.lbl_snombre.Size = new System.Drawing.Size(137, 20);
            this.lbl_snombre.TabIndex = 4;
            this.lbl_snombre.Text = "Segundo Nombre";
            // 
            // lbl_papellido
            // 
            this.lbl_papellido.AutoSize = true;
            this.lbl_papellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_papellido.Location = new System.Drawing.Point(22, 262);
            this.lbl_papellido.Name = "lbl_papellido";
            this.lbl_papellido.Size = new System.Drawing.Size(124, 20);
            this.lbl_papellido.TabIndex = 5;
            this.lbl_papellido.Text = "Primer Apellido*";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(22, 352);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(30, 20);
            this.lbl_nit.TabIndex = 6;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_fechanac
            // 
            this.lbl_fechanac.AutoSize = true;
            this.lbl_fechanac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechanac.Location = new System.Drawing.Point(22, 399);
            this.lbl_fechanac.Name = "lbl_fechanac";
            this.lbl_fechanac.Size = new System.Drawing.Size(167, 20);
            this.lbl_fechanac.TabIndex = 7;
            this.lbl_fechanac.Text = "Fecha de Nacimiento";
            // 
            // lbl_sapellido
            // 
            this.lbl_sapellido.AutoSize = true;
            this.lbl_sapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sapellido.Location = new System.Drawing.Point(22, 307);
            this.lbl_sapellido.Name = "lbl_sapellido";
            this.lbl_sapellido.Size = new System.Drawing.Size(138, 20);
            this.lbl_sapellido.TabIndex = 8;
            this.lbl_sapellido.Text = "Segundo Apellido";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(412, 169);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(98, 20);
            this.lbl_direccion.TabIndex = 9;
            this.lbl_direccion.Text = "Direccion 1*";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(412, 353);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(83, 20);
            this.lbl_telefono.TabIndex = 10;
            this.lbl_telefono.Text = "Telefono 2";
            // 
            // txt_snombre
            // 
            this.txt_snombre.Location = new System.Drawing.Point(204, 216);
            this.txt_snombre.Name = "txt_snombre";
            this.txt_snombre.Size = new System.Drawing.Size(150, 20);
            this.txt_snombre.TabIndex = 11;
            // 
            // txt_papellido
            // 
            this.txt_papellido.Location = new System.Drawing.Point(204, 262);
            this.txt_papellido.Name = "txt_papellido";
            this.txt_papellido.Size = new System.Drawing.Size(150, 20);
            this.txt_papellido.TabIndex = 12;
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.Location = new System.Drawing.Point(204, 307);
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(150, 20);
            this.txt_sapellido.TabIndex = 13;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(204, 352);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(150, 20);
            this.txt_nit.TabIndex = 14;
            // 
            // txt_fechanac
            // 
            this.txt_fechanac.Location = new System.Drawing.Point(204, 399);
            this.txt_fechanac.Name = "txt_fechanac";
            this.txt_fechanac.Size = new System.Drawing.Size(150, 20);
            this.txt_fechanac.TabIndex = 15;
            // 
            // txt_zona
            // 
            this.txt_zona.Location = new System.Drawing.Point(631, 170);
            this.txt_zona.Name = "txt_zona";
            this.txt_zona.Size = new System.Drawing.Size(33, 20);
            this.txt_zona.TabIndex = 16;
            // 
            // txt_tel1
            // 
            this.txt_tel1.Location = new System.Drawing.Point(631, 353);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.Size = new System.Drawing.Size(150, 20);
            this.txt_tel1.TabIndex = 17;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(380, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(115, 32);
            this.lbl_titulo.TabIndex = 20;
            this.lbl_titulo.Text = "CLIENTE";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(498, 49);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 73;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(584, 49);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 71;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(408, 49);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 74;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(321, 49);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.btn_modificar.TabIndex = 70;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(236, 49);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 69;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(150, 49);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 68;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_avenida
            // 
            this.txt_avenida.Location = new System.Drawing.Point(787, 169);
            this.txt_avenida.Name = "txt_avenida";
            this.txt_avenida.Size = new System.Drawing.Size(82, 20);
            this.txt_avenida.TabIndex = 83;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(670, 170);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(111, 20);
            this.txt_calle.TabIndex = 84;
            // 
            // txt_calle2
            // 
            this.txt_calle2.Location = new System.Drawing.Point(670, 262);
            this.txt_calle2.Name = "txt_calle2";
            this.txt_calle2.Size = new System.Drawing.Size(111, 20);
            this.txt_calle2.TabIndex = 91;
            // 
            // txt_avenida2
            // 
            this.txt_avenida2.Location = new System.Drawing.Point(787, 261);
            this.txt_avenida2.Name = "txt_avenida2";
            this.txt_avenida2.Size = new System.Drawing.Size(82, 20);
            this.txt_avenida2.TabIndex = 90;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(631, 307);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(150, 20);
            this.txt_tel.TabIndex = 88;
            // 
            // txt_zona2
            // 
            this.txt_zona2.Location = new System.Drawing.Point(631, 262);
            this.txt_zona2.Name = "txt_zona2";
            this.txt_zona2.Size = new System.Drawing.Size(33, 20);
            this.txt_zona2.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Telefono 1*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Direccion 3";
            // 
            // txt_calle1
            // 
            this.txt_calle1.Location = new System.Drawing.Point(670, 215);
            this.txt_calle1.Name = "txt_calle1";
            this.txt_calle1.Size = new System.Drawing.Size(111, 20);
            this.txt_calle1.TabIndex = 95;
            // 
            // txt_avenida1
            // 
            this.txt_avenida1.Location = new System.Drawing.Point(787, 214);
            this.txt_avenida1.Name = "txt_avenida1";
            this.txt_avenida1.Size = new System.Drawing.Size(82, 20);
            this.txt_avenida1.TabIndex = 94;
            // 
            // txt_zona1
            // 
            this.txt_zona1.Location = new System.Drawing.Point(631, 215);
            this.txt_zona1.Name = "txt_zona1";
            this.txt_zona1.Size = new System.Drawing.Size(33, 20);
            this.txt_zona1.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Direccion 2";
            // 
            // txt_tel2
            // 
            this.txt_tel2.Location = new System.Drawing.Point(631, 399);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Size = new System.Drawing.Size(150, 20);
            this.txt_tel2.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Telefono 3";
            // 
            // dgv_dir
            // 
            this.dgv_dir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dir.Location = new System.Drawing.Point(26, 607);
            this.dgv_dir.Name = "dgv_dir";
            this.dgv_dir.Size = new System.Drawing.Size(438, 122);
            this.dgv_dir.TabIndex = 98;
            // 
            // dgv_tel
            // 
            this.dgv_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel.Location = new System.Drawing.Point(470, 607);
            this.dgv_tel.Name = "dgv_tel";
            this.dgv_tel.Size = new System.Drawing.Size(433, 122);
            this.dgv_tel.TabIndex = 99;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ayuda.BackgroundImage")));
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.Location = new System.Drawing.Point(670, 49);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(65, 65);
            this.btn_ayuda.TabIndex = 100;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(936, 733);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.dgv_tel);
            this.Controls.Add(this.dgv_dir);
            this.Controls.Add(this.txt_tel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_calle1);
            this.Controls.Add(this.txt_avenida1);
            this.Controls.Add(this.txt_zona1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_calle2);
            this.Controls.Add(this.txt_avenida2);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_zona2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_avenida);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_tel1);
            this.Controls.Add(this.txt_zona);
            this.Controls.Add(this.txt_fechanac);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_sapellido);
            this.Controls.Add(this.txt_papellido);
            this.Controls.Add(this.txt_snombre);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_sapellido);
            this.Controls.Add(this.lbl_fechanac);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.lbl_papellido);
            this.Controls.Add(this.lbl_snombre);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.lbl_pnombre);
            this.Controls.Add(this.dgv_cliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.Label lbl_pnombre;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.Label lbl_snombre;
        private System.Windows.Forms.Label lbl_papellido;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_fechanac;
        private System.Windows.Forms.Label lbl_sapellido;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_snombre;
        private System.Windows.Forms.TextBox txt_papellido;
        private System.Windows.Forms.TextBox txt_sapellido;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_fechanac;
        private System.Windows.Forms.TextBox txt_zona;
        private System.Windows.Forms.TextBox txt_tel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox txt_avenida;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_calle2;
        private System.Windows.Forms.TextBox txt_avenida2;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_zona2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_calle1;
        private System.Windows.Forms.TextBox txt_avenida1;
        private System.Windows.Forms.TextBox txt_zona1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_dir;
        private System.Windows.Forms.DataGridView dgv_tel;
        private System.Windows.Forms.Button btn_ayuda;
    }
}

