namespace sistemareparto
{
    partial class frmGestionVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionVehiculo));
            this.ltp_ingreso = new System.Windows.Forms.DateTimePicker();
            this.ltp_salida = new System.Windows.Forms.DateTimePicker();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.dgv_gestion = new System.Windows.Forms.DataGridView();
            this.txt_salida = new System.Windows.Forms.TextBox();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.lbl_entrada = new System.Windows.Forms.Label();
            this.lbl_esalida = new System.Windows.Forms.Label();
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.lbl_salida = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.lbl_actualizar = new System.Windows.Forms.Label();
            this.lbl_nuevo = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_gestion = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_BuscarVehi = new System.Windows.Forms.Button();
            this.txt_Vehiculo = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion)).BeginInit();
            this.SuspendLayout();
            // 
            // ltp_ingreso
            // 
            this.ltp_ingreso.Location = new System.Drawing.Point(600, 172);
            this.ltp_ingreso.Name = "ltp_ingreso";
            this.ltp_ingreso.Size = new System.Drawing.Size(150, 20);
            this.ltp_ingreso.TabIndex = 117;
            // 
            // ltp_salida
            // 
            this.ltp_salida.Location = new System.Drawing.Point(198, 213);
            this.ltp_salida.Name = "ltp_salida";
            this.ltp_salida.Size = new System.Drawing.Size(150, 20);
            this.ltp_salida.TabIndex = 116;
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiculo.Location = new System.Drawing.Point(95, 171);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(77, 21);
            this.lbl_vehiculo.TabIndex = 114;
            this.lbl_vehiculo.Text = "Vehiculo";
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_cancelar.Location = new System.Drawing.Point(491, 122);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.lbl_cancelar.TabIndex = 111;
            this.lbl_cancelar.Text = "Cancelar";
            // 
            // dgv_gestion
            // 
            this.dgv_gestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestion.Location = new System.Drawing.Point(10, 294);
            this.dgv_gestion.Name = "dgv_gestion";
            this.dgv_gestion.Size = new System.Drawing.Size(800, 150);
            this.dgv_gestion.TabIndex = 109;
            this.dgv_gestion.SelectionChanged += new System.EventHandler(this.dgv_gestion_SelectionChanged);
            // 
            // txt_salida
            // 
            this.txt_salida.Location = new System.Drawing.Point(197, 249);
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.Size = new System.Drawing.Size(151, 20);
            this.txt_salida.TabIndex = 108;
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(600, 213);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(150, 20);
            this.txt_entrada.TabIndex = 107;
            // 
            // lbl_entrada
            // 
            this.lbl_entrada.AutoSize = true;
            this.lbl_entrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrada.Location = new System.Drawing.Point(429, 210);
            this.lbl_entrada.Name = "lbl_entrada";
            this.lbl_entrada.Size = new System.Drawing.Size(161, 21);
            this.lbl_entrada.TabIndex = 105;
            this.lbl_entrada.Text = "Estado de Entrada ";
            // 
            // lbl_esalida
            // 
            this.lbl_esalida.AutoSize = true;
            this.lbl_esalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esalida.Location = new System.Drawing.Point(47, 249);
            this.lbl_esalida.Name = "lbl_esalida";
            this.lbl_esalida.Size = new System.Drawing.Size(144, 21);
            this.lbl_esalida.TabIndex = 104;
            this.lbl_esalida.Text = "Estado de Salida ";
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingreso.Location = new System.Drawing.Point(429, 171);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(156, 21);
            this.lbl_ingreso.TabIndex = 103;
            this.lbl_ingreso.Text = "Ingreso de Gestion";
            // 
            // lbl_salida
            // 
            this.lbl_salida.AutoSize = true;
            this.lbl_salida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salida.Location = new System.Drawing.Point(41, 211);
            this.lbl_salida.Name = "lbl_salida";
            this.lbl_salida.Size = new System.Drawing.Size(150, 21);
            this.lbl_salida.TabIndex = 102;
            this.lbl_salida.Text = " Salida de Gestion";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_buscar.Location = new System.Drawing.Point(596, 122);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 101;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_eliminar.Location = new System.Drawing.Point(414, 122);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(63, 20);
            this.lbl_eliminar.TabIndex = 100;
            this.lbl_eliminar.Text = "Eliminar";
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_guardar.Location = new System.Drawing.Point(227, 122);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(71, 20);
            this.lbl_guardar.TabIndex = 99;
            this.lbl_guardar.Text = "Guardar";
            // 
            // lbl_actualizar
            // 
            this.lbl_actualizar.AutoSize = true;
            this.lbl_actualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_actualizar.Location = new System.Drawing.Point(317, 122);
            this.lbl_actualizar.Name = "lbl_actualizar";
            this.lbl_actualizar.Size = new System.Drawing.Size(81, 20);
            this.lbl_actualizar.TabIndex = 98;
            this.lbl_actualizar.Text = "Actualizar";
            // 
            // lbl_nuevo
            // 
            this.lbl_nuevo.AutoSize = true;
            this.lbl_nuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo.Location = new System.Drawing.Point(147, 122);
            this.lbl_nuevo.Name = "lbl_nuevo";
            this.lbl_nuevo.Size = new System.Drawing.Size(59, 20);
            this.lbl_nuevo.TabIndex = 97;
            this.lbl_nuevo.Text = "Nuevo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(495, 54);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 123;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(141, 54);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 122;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(412, 54);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 121;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(321, 54);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.btn_modificar.TabIndex = 120;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(231, 54);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 119;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_gestion
            // 
            this.lbl_gestion.AutoSize = true;
            this.lbl_gestion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestion.Location = new System.Drawing.Point(276, 8);
            this.lbl_gestion.Name = "lbl_gestion";
            this.lbl_gestion.Size = new System.Drawing.Size(269, 32);
            this.lbl_gestion.TabIndex = 126;
            this.lbl_gestion.Text = "GESTION VEHICULO";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(589, 54);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 124;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.busc_btn_Click);
            // 
            // btn_BuscarVehi
            // 
            this.btn_BuscarVehi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarVehi.BackgroundImage")));
            this.btn_BuscarVehi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarVehi.Location = new System.Drawing.Point(354, 155);
            this.btn_BuscarVehi.Name = "btn_BuscarVehi";
            this.btn_BuscarVehi.Size = new System.Drawing.Size(35, 36);
            this.btn_BuscarVehi.TabIndex = 128;
            this.btn_BuscarVehi.UseVisualStyleBackColor = true;
            this.btn_BuscarVehi.Click += new System.EventHandler(this.btn_BuscarVehi_Click);
            // 
            // txt_Vehiculo
            // 
            this.txt_Vehiculo.Enabled = false;
            this.txt_Vehiculo.Location = new System.Drawing.Point(198, 171);
            this.txt_Vehiculo.Name = "txt_Vehiculo";
            this.txt_Vehiculo.Size = new System.Drawing.Size(150, 20);
            this.txt_Vehiculo.TabIndex = 127;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(198, 155);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 20);
            this.txt_Id.TabIndex = 129;
            this.txt_Id.Visible = false;
            // 
            // frmGestionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(819, 456);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_BuscarVehi);
            this.Controls.Add(this.txt_Vehiculo);
            this.Controls.Add(this.lbl_gestion);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.ltp_ingreso);
            this.Controls.Add(this.ltp_salida);
            this.Controls.Add(this.lbl_vehiculo);
            this.Controls.Add(this.lbl_cancelar);
            this.Controls.Add(this.dgv_gestion);
            this.Controls.Add(this.txt_salida);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.lbl_entrada);
            this.Controls.Add(this.lbl_esalida);
            this.Controls.Add(this.lbl_ingreso);
            this.Controls.Add(this.lbl_salida);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_eliminar);
            this.Controls.Add(this.lbl_guardar);
            this.Controls.Add(this.lbl_actualizar);
            this.Controls.Add(this.lbl_nuevo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker ltp_ingreso;
        private System.Windows.Forms.DateTimePicker ltp_salida;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.DataGridView dgv_gestion;
        private System.Windows.Forms.TextBox txt_salida;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Label lbl_entrada;
        private System.Windows.Forms.Label lbl_esalida;
        private System.Windows.Forms.Label lbl_ingreso;
        private System.Windows.Forms.Label lbl_salida;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.Label lbl_actualizar;
        private System.Windows.Forms.Label lbl_nuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_gestion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_BuscarVehi;
        private System.Windows.Forms.TextBox txt_Vehiculo;
        private System.Windows.Forms.TextBox txt_Id;
    }
}