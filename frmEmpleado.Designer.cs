namespace sistemareparto
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_empleado = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pic_empleado = new System.Windows.Forms.PictureBox();
            this.lbl_imagen = new System.Windows.Forms.Label();
            this.lbl_aceptar = new System.Windows.Forms.Label();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_actualizar = new System.Windows.Forms.Label();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.lbl_nuevo = new System.Windows.Forms.Label();
            this.txt_correo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_calle1 = new System.Windows.Forms.TextBox();
            this.txt_avenida1 = new System.Windows.Forms.TextBox();
            this.txt_zona1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_avenida = new System.Windows.Forms.TextBox();
            this.txt_tel1 = new System.Windows.Forms.TextBox();
            this.txt_zona = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.txt_fechanac = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_sapellido = new System.Windows.Forms.TextBox();
            this.txt_papellido = new System.Windows.Forms.TextBox();
            this.txt_snombre = new System.Windows.Forms.TextBox();
            this.lbl_sapellido = new System.Windows.Forms.Label();
            this.lbl_fechanac = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_papellido = new System.Windows.Forms.Label();
            this.lbl_snombre = new System.Windows.Forms.Label();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.lbl_pnombre = new System.Windows.Forms.Label();
            this.cbo_emp = new System.Windows.Forms.ComboBox();
            this.dgv_diremp = new System.Windows.Forms.DataGridView();
            this.dgv_telemp = new System.Windows.Forms.DataGridView();
            this.dgv_correo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diremp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_correo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(354, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(156, 32);
            this.Lbl_titulo.TabIndex = 45;
            this.Lbl_titulo.Text = "EMPLEADO";
            // 
            // dgv_empleado
            // 
            this.dgv_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleado.Location = new System.Drawing.Point(38, 519);
            this.dgv_empleado.Name = "dgv_empleado";
            this.dgv_empleado.Size = new System.Drawing.Size(836, 100);
            this.dgv_empleado.TabIndex = 26;
            this.dgv_empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleado_CellContentClick);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(683, 65);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(65, 65);
            this.btn_aceptar.TabIndex = 76;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(496, 65);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 75;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.busc_btn_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(587, 63);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 74;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(148, 63);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 73;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(419, 63);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 72;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(328, 63);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(65, 65);
            this.btn_modificar.TabIndex = 71;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(238, 63);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 70;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pic_empleado
            // 
            this.pic_empleado.Location = new System.Drawing.Point(26, 41);
            this.pic_empleado.Name = "pic_empleado";
            this.pic_empleado.Size = new System.Drawing.Size(105, 64);
            this.pic_empleado.TabIndex = 77;
            this.pic_empleado.TabStop = false;
            // 
            // lbl_imagen
            // 
            this.lbl_imagen.AutoSize = true;
            this.lbl_imagen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imagen.Location = new System.Drawing.Point(41, 108);
            this.lbl_imagen.Name = "lbl_imagen";
            this.lbl_imagen.Size = new System.Drawing.Size(66, 20);
            this.lbl_imagen.TabIndex = 27;
            this.lbl_imagen.Text = "Imagen";
            // 
            // lbl_aceptar
            // 
            this.lbl_aceptar.AutoSize = true;
            this.lbl_aceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aceptar.Location = new System.Drawing.Point(679, 133);
            this.lbl_aceptar.Name = "lbl_aceptar";
            this.lbl_aceptar.Size = new System.Drawing.Size(70, 20);
            this.lbl_aceptar.TabIndex = 99;
            this.lbl_aceptar.Text = "Aceptar";
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelar.Location = new System.Drawing.Point(584, 133);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.lbl_cancelar.TabIndex = 98;
            this.lbl_cancelar.Text = "Cancelar";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(492, 133);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 97;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar.Location = new System.Drawing.Point(410, 131);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(63, 20);
            this.lbl_eliminar.TabIndex = 96;
            this.lbl_eliminar.Text = "Eliminar";
            // 
            // lbl_actualizar
            // 
            this.lbl_actualizar.AutoSize = true;
            this.lbl_actualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualizar.Location = new System.Drawing.Point(321, 131);
            this.lbl_actualizar.Name = "lbl_actualizar";
            this.lbl_actualizar.Size = new System.Drawing.Size(81, 20);
            this.lbl_actualizar.TabIndex = 95;
            this.lbl_actualizar.Text = "Actualizar";
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guardar.Location = new System.Drawing.Point(234, 131);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(71, 20);
            this.lbl_guardar.TabIndex = 94;
            this.lbl_guardar.Text = "Guardar";
            // 
            // lbl_nuevo
            // 
            this.lbl_nuevo.AutoSize = true;
            this.lbl_nuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo.Location = new System.Drawing.Point(154, 131);
            this.lbl_nuevo.Name = "lbl_nuevo";
            this.lbl_nuevo.Size = new System.Drawing.Size(59, 20);
            this.lbl_nuevo.TabIndex = 93;
            this.lbl_nuevo.Text = "Nuevo";
            // 
            // txt_correo1
            // 
            this.txt_correo1.Location = new System.Drawing.Point(640, 383);
            this.txt_correo1.Name = "txt_correo1";
            this.txt_correo1.Size = new System.Drawing.Size(150, 20);
            this.txt_correo1.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 152;
            this.label2.Text = "Correo 2";
            // 
            // txt_calle1
            // 
            this.txt_calle1.Location = new System.Drawing.Point(675, 231);
            this.txt_calle1.Name = "txt_calle1";
            this.txt_calle1.Size = new System.Drawing.Size(111, 20);
            this.txt_calle1.TabIndex = 151;
            // 
            // txt_avenida1
            // 
            this.txt_avenida1.Location = new System.Drawing.Point(792, 230);
            this.txt_avenida1.Name = "txt_avenida1";
            this.txt_avenida1.Size = new System.Drawing.Size(82, 20);
            this.txt_avenida1.TabIndex = 150;
            // 
            // txt_zona1
            // 
            this.txt_zona1.Location = new System.Drawing.Point(636, 231);
            this.txt_zona1.Name = "txt_zona1";
            this.txt_zona1.Size = new System.Drawing.Size(33, 20);
            this.txt_zona1.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Direccion 2";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(639, 270);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(150, 20);
            this.txt_tel.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 146;
            this.label1.Text = "Telefono 1*";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(675, 194);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(111, 20);
            this.txt_calle.TabIndex = 145;
            // 
            // txt_avenida
            // 
            this.txt_avenida.Location = new System.Drawing.Point(792, 193);
            this.txt_avenida.Name = "txt_avenida";
            this.txt_avenida.Size = new System.Drawing.Size(82, 20);
            this.txt_avenida.TabIndex = 144;
            // 
            // txt_tel1
            // 
            this.txt_tel1.Location = new System.Drawing.Point(639, 311);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.Size = new System.Drawing.Size(150, 20);
            this.txt_tel1.TabIndex = 143;
            // 
            // txt_zona
            // 
            this.txt_zona.Location = new System.Drawing.Point(636, 194);
            this.txt_zona.Name = "txt_zona";
            this.txt_zona.Size = new System.Drawing.Size(33, 20);
            this.txt_zona.TabIndex = 142;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(420, 311);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(83, 20);
            this.lbl_telefono.TabIndex = 141;
            this.lbl_telefono.Text = "Telefono 2";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(417, 193);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(98, 20);
            this.lbl_direccion.TabIndex = 140;
            this.lbl_direccion.Text = "Direccion 1*";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(640, 344);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 20);
            this.txt_correo.TabIndex = 138;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(216, 386);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(150, 20);
            this.txt_estado.TabIndex = 137;
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(216, 346);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(150, 20);
            this.txt_sueldo.TabIndex = 136;
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puesto.Location = new System.Drawing.Point(420, 423);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(58, 20);
            this.lbl_puesto.TabIndex = 135;
            this.lbl_puesto.Text = "Puesto";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(34, 383);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(58, 20);
            this.lbl_estado.TabIndex = 134;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(420, 344);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(67, 20);
            this.lbl_correo.TabIndex = 133;
            this.lbl_correo.Text = "Correo*";
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.Location = new System.Drawing.Point(34, 345);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(58, 20);
            this.lbl_sueldo.TabIndex = 132;
            this.lbl_sueldo.Text = "Sueldo";
            // 
            // txt_fechanac
            // 
            this.txt_fechanac.Location = new System.Drawing.Point(216, 462);
            this.txt_fechanac.Name = "txt_fechanac";
            this.txt_fechanac.Size = new System.Drawing.Size(150, 20);
            this.txt_fechanac.TabIndex = 131;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(216, 423);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(150, 20);
            this.txt_nit.TabIndex = 130;
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.Location = new System.Drawing.Point(216, 312);
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(150, 20);
            this.txt_sapellido.TabIndex = 129;
            // 
            // txt_papellido
            // 
            this.txt_papellido.Location = new System.Drawing.Point(216, 272);
            this.txt_papellido.Name = "txt_papellido";
            this.txt_papellido.Size = new System.Drawing.Size(150, 20);
            this.txt_papellido.TabIndex = 128;
            // 
            // txt_snombre
            // 
            this.txt_snombre.Location = new System.Drawing.Point(216, 234);
            this.txt_snombre.Name = "txt_snombre";
            this.txt_snombre.Size = new System.Drawing.Size(150, 20);
            this.txt_snombre.TabIndex = 127;
            // 
            // lbl_sapellido
            // 
            this.lbl_sapellido.AutoSize = true;
            this.lbl_sapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sapellido.Location = new System.Drawing.Point(34, 312);
            this.lbl_sapellido.Name = "lbl_sapellido";
            this.lbl_sapellido.Size = new System.Drawing.Size(138, 20);
            this.lbl_sapellido.TabIndex = 126;
            this.lbl_sapellido.Text = "Segundo Apellido";
            // 
            // lbl_fechanac
            // 
            this.lbl_fechanac.AutoSize = true;
            this.lbl_fechanac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechanac.Location = new System.Drawing.Point(34, 460);
            this.lbl_fechanac.Name = "lbl_fechanac";
            this.lbl_fechanac.Size = new System.Drawing.Size(167, 20);
            this.lbl_fechanac.TabIndex = 125;
            this.lbl_fechanac.Text = "Fecha de Nacimiento";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(34, 423);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(30, 20);
            this.lbl_nit.TabIndex = 124;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_papellido
            // 
            this.lbl_papellido.AutoSize = true;
            this.lbl_papellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_papellido.Location = new System.Drawing.Point(34, 272);
            this.lbl_papellido.Name = "lbl_papellido";
            this.lbl_papellido.Size = new System.Drawing.Size(124, 20);
            this.lbl_papellido.TabIndex = 123;
            this.lbl_papellido.Text = "Primer Apellido*";
            // 
            // lbl_snombre
            // 
            this.lbl_snombre.AutoSize = true;
            this.lbl_snombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snombre.Location = new System.Drawing.Point(34, 234);
            this.lbl_snombre.Name = "lbl_snombre";
            this.lbl_snombre.Size = new System.Drawing.Size(137, 20);
            this.lbl_snombre.TabIndex = 122;
            this.lbl_snombre.Text = "Segundo Nombre";
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.Location = new System.Drawing.Point(216, 195);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(150, 20);
            this.txt_pnombre.TabIndex = 121;
            // 
            // lbl_pnombre
            // 
            this.lbl_pnombre.AutoSize = true;
            this.lbl_pnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnombre.Location = new System.Drawing.Point(34, 192);
            this.lbl_pnombre.Name = "lbl_pnombre";
            this.lbl_pnombre.Size = new System.Drawing.Size(123, 20);
            this.lbl_pnombre.TabIndex = 120;
            this.lbl_pnombre.Text = "Primer Nombre*";
            // 
            // cbo_emp
            // 
            this.cbo_emp.FormattingEnabled = true;
            this.cbo_emp.Location = new System.Drawing.Point(640, 421);
            this.cbo_emp.Name = "cbo_emp";
            this.cbo_emp.Size = new System.Drawing.Size(150, 21);
            this.cbo_emp.TabIndex = 154;
            this.cbo_emp.SelectedIndexChanged += new System.EventHandler(this.cbo_emp_SelectedIndexChanged);
            // 
            // dgv_diremp
            // 
            this.dgv_diremp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diremp.Location = new System.Drawing.Point(38, 625);
            this.dgv_diremp.Name = "dgv_diremp";
            this.dgv_diremp.Size = new System.Drawing.Size(400, 85);
            this.dgv_diremp.TabIndex = 155;
            this.dgv_diremp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diremp_CellContentClick);
            // 
            // dgv_telemp
            // 
            this.dgv_telemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telemp.Location = new System.Drawing.Point(455, 625);
            this.dgv_telemp.Name = "dgv_telemp";
            this.dgv_telemp.Size = new System.Drawing.Size(200, 85);
            this.dgv_telemp.TabIndex = 156;
            // 
            // dgv_correo
            // 
            this.dgv_correo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_correo.Location = new System.Drawing.Point(674, 625);
            this.dgv_correo.Name = "dgv_correo";
            this.dgv_correo.Size = new System.Drawing.Size(200, 85);
            this.dgv_correo.TabIndex = 157;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(908, 741);
            this.Controls.Add(this.dgv_correo);
            this.Controls.Add(this.dgv_telemp);
            this.Controls.Add(this.dgv_diremp);
            this.Controls.Add(this.dgv_empleado);
            this.Controls.Add(this.cbo_emp);
            this.Controls.Add(this.txt_correo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_calle1);
            this.Controls.Add(this.txt_avenida1);
            this.Controls.Add(this.txt_zona1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_avenida);
            this.Controls.Add(this.txt_tel1);
            this.Controls.Add(this.txt_zona);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.lbl_puesto);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.txt_fechanac);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_sapellido);
            this.Controls.Add(this.txt_papellido);
            this.Controls.Add(this.txt_snombre);
            this.Controls.Add(this.lbl_sapellido);
            this.Controls.Add(this.lbl_fechanac);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.lbl_papellido);
            this.Controls.Add(this.lbl_snombre);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.lbl_pnombre);
            this.Controls.Add(this.lbl_aceptar);
            this.Controls.Add(this.lbl_cancelar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_eliminar);
            this.Controls.Add(this.lbl_actualizar);
            this.Controls.Add(this.lbl_guardar);
            this.Controls.Add(this.lbl_nuevo);
            this.Controls.Add(this.pic_empleado);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.lbl_imagen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diremp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_correo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_empleado;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.PictureBox pic_empleado;
        private System.Windows.Forms.Label lbl_imagen;
        private System.Windows.Forms.Label lbl_aceptar;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_actualizar;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.Label lbl_nuevo;
        private System.Windows.Forms.TextBox txt_correo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_calle1;
        private System.Windows.Forms.TextBox txt_avenida1;
        private System.Windows.Forms.TextBox txt_zona1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_avenida;
        private System.Windows.Forms.TextBox txt_tel1;
        private System.Windows.Forms.TextBox txt_zona;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.TextBox txt_fechanac;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_sapellido;
        private System.Windows.Forms.TextBox txt_papellido;
        private System.Windows.Forms.TextBox txt_snombre;
        private System.Windows.Forms.Label lbl_sapellido;
        private System.Windows.Forms.Label lbl_fechanac;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_papellido;
        private System.Windows.Forms.Label lbl_snombre;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.Label lbl_pnombre;
        private System.Windows.Forms.ComboBox cbo_emp;
        private System.Windows.Forms.DataGridView dgv_diremp;
        private System.Windows.Forms.DataGridView dgv_telemp;
        private System.Windows.Forms.DataGridView dgv_correo;
    }
}