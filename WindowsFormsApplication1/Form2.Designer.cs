namespace WindowsFormsApplication1
{
    partial class Form_modificar_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_modificar_pedido));
            this.gbp_menu = new System.Windows.Forms.GroupBox();
            this.Btn_registro_pedido = new System.Windows.Forms.Button();
            this.Btn_modificar_pedido = new System.Windows.Forms.Button();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.Lbl_marca = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.cbo_nombre = new System.Windows.Forms.ComboBox();
            this.dgv_pedido_cliente = new System.Windows.Forms.DataGridView();
            this.Lbl_pedido_cliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_guardar_pedido = new System.Windows.Forms.Button();
            this.Btn_cancelar_pedido = new System.Windows.Forms.Button();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.Lbl_cancelar = new System.Windows.Forms.Label();
            this.Lbl_eliminar = new System.Windows.Forms.Label();
            this.gbp_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gbp_menu
            // 
            this.gbp_menu.Controls.Add(this.Btn_registro_pedido);
            this.gbp_menu.Controls.Add(this.Btn_modificar_pedido);
            this.gbp_menu.Location = new System.Drawing.Point(61, 55);
            this.gbp_menu.Name = "gbp_menu";
            this.gbp_menu.Size = new System.Drawing.Size(805, 57);
            this.gbp_menu.TabIndex = 32;
            this.gbp_menu.TabStop = false;
            this.gbp_menu.Text = "MENU";
            // 
            // Btn_registro_pedido
            // 
            this.Btn_registro_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registro_pedido.Location = new System.Drawing.Point(198, 19);
            this.Btn_registro_pedido.Name = "Btn_registro_pedido";
            this.Btn_registro_pedido.Size = new System.Drawing.Size(91, 30);
            this.Btn_registro_pedido.TabIndex = 2;
            this.Btn_registro_pedido.Text = "Registro";
            this.Btn_registro_pedido.UseVisualStyleBackColor = true;
            this.Btn_registro_pedido.Click += new System.EventHandler(this.Btn_registro_pedido_Click);
            // 
            // Btn_modificar_pedido
            // 
            this.Btn_modificar_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar_pedido.Location = new System.Drawing.Point(482, 19);
            this.Btn_modificar_pedido.Name = "Btn_modificar_pedido";
            this.Btn_modificar_pedido.Size = new System.Drawing.Size(91, 30);
            this.Btn_modificar_pedido.TabIndex = 1;
            this.Btn_modificar_pedido.Text = "Modificar";
            this.Btn_modificar_pedido.UseVisualStyleBackColor = true;
            this.Btn_modificar_pedido.Click += new System.EventHandler(this.Btn_modificar_pedido_Click);
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(458, 169);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(150, 21);
            this.cbo_cliente.TabIndex = 31;
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cliente.Location = new System.Drawing.Point(393, 170);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_cliente.Size = new System.Drawing.Size(65, 20);
            this.Lbl_cliente.TabIndex = 30;
            this.Lbl_cliente.Text = "Cliente:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(458, 136);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(150, 20);
            this.txt_fecha.TabIndex = 29;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(393, 136);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_fecha.Size = new System.Drawing.Size(59, 20);
            this.Lbl_fecha.TabIndex = 28;
            this.Lbl_fecha.Text = "Fecha:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(207, 210);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(150, 20);
            this.txt_cantidad.TabIndex = 27;
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad.Location = new System.Drawing.Point(57, 208);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(82, 20);
            this.Lbl_cantidad.TabIndex = 26;
            this.Lbl_cantidad.Text = "Cantidad:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(207, 170);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(150, 20);
            this.txt_marca.TabIndex = 25;
            // 
            // Lbl_marca
            // 
            this.Lbl_marca.AutoSize = true;
            this.Lbl_marca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_marca.Location = new System.Drawing.Point(57, 170);
            this.Lbl_marca.Name = "Lbl_marca";
            this.Lbl_marca.Size = new System.Drawing.Size(135, 20);
            this.Lbl_marca.TabIndex = 24;
            this.Lbl_marca.Text = "Marca Producto:";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(57, 136);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(144, 20);
            this.Lbl_nombre.TabIndex = 23;
            this.Lbl_nombre.Text = "Nombre Producto:";
            // 
            // cbo_nombre
            // 
            this.cbo_nombre.FormattingEnabled = true;
            this.cbo_nombre.Location = new System.Drawing.Point(207, 135);
            this.cbo_nombre.Name = "cbo_nombre";
            this.cbo_nombre.Size = new System.Drawing.Size(150, 21);
            this.cbo_nombre.TabIndex = 22;
            // 
            // dgv_pedido_cliente
            // 
            this.dgv_pedido_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido_cliente.Location = new System.Drawing.Point(61, 324);
            this.dgv_pedido_cliente.Name = "dgv_pedido_cliente";
            this.dgv_pedido_cliente.Size = new System.Drawing.Size(800, 150);
            this.dgv_pedido_cliente.TabIndex = 20;
            // 
            // Lbl_pedido_cliente
            // 
            this.Lbl_pedido_cliente.AutoSize = true;
            this.Lbl_pedido_cliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pedido_cliente.Location = new System.Drawing.Point(253, 20);
            this.Lbl_pedido_cliente.Name = "Lbl_pedido_cliente";
            this.Lbl_pedido_cliente.Size = new System.Drawing.Size(381, 32);
            this.Lbl_pedido_cliente.TabIndex = 19;
            this.Lbl_pedido_cliente.Text = "MODIFICAR PEDIDO CLIENTE";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(779, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar_pedido
            // 
            this.Btn_guardar_pedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_guardar_pedido.BackgroundImage")));
            this.Btn_guardar_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar_pedido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_guardar_pedido.Location = new System.Drawing.Point(779, 114);
            this.Btn_guardar_pedido.Name = "Btn_guardar_pedido";
            this.Btn_guardar_pedido.Size = new System.Drawing.Size(65, 65);
            this.Btn_guardar_pedido.TabIndex = 34;
            this.Btn_guardar_pedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_guardar_pedido.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar_pedido
            // 
            this.Btn_cancelar_pedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar_pedido.BackgroundImage")));
            this.Btn_cancelar_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cancelar_pedido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_cancelar_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar_pedido.Location = new System.Drawing.Point(779, 185);
            this.Btn_cancelar_pedido.Name = "Btn_cancelar_pedido";
            this.Btn_cancelar_pedido.Size = new System.Drawing.Size(65, 65);
            this.Btn_cancelar_pedido.TabIndex = 35;
            this.Btn_cancelar_pedido.UseVisualStyleBackColor = true;
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.AutoSize = true;
            this.Lbl_guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(702, 134);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_guardar.Size = new System.Drawing.Size(71, 20);
            this.Lbl_guardar.TabIndex = 36;
            this.Lbl_guardar.Text = "Guardar";
            // 
            // Lbl_cancelar
            // 
            this.Lbl_cancelar.AutoSize = true;
            this.Lbl_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cancelar.Location = new System.Drawing.Point(695, 208);
            this.Lbl_cancelar.Name = "Lbl_cancelar";
            this.Lbl_cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_cancelar.Size = new System.Drawing.Size(78, 20);
            this.Lbl_cancelar.TabIndex = 37;
            this.Lbl_cancelar.Text = "Cancelar";
            // 
            // Lbl_eliminar
            // 
            this.Lbl_eliminar.AutoSize = true;
            this.Lbl_eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_eliminar.Location = new System.Drawing.Point(702, 278);
            this.Lbl_eliminar.Name = "Lbl_eliminar";
            this.Lbl_eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_eliminar.Size = new System.Drawing.Size(63, 20);
            this.Lbl_eliminar.TabIndex = 38;
            this.Lbl_eliminar.Text = "Eliminar";
            // 
            // Form_modificar_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 516);
            this.Controls.Add(this.Lbl_eliminar);
            this.Controls.Add(this.Lbl_cancelar);
            this.Controls.Add(this.Lbl_guardar);
            this.Controls.Add(this.Btn_cancelar_pedido);
            this.Controls.Add(this.Btn_guardar_pedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbp_menu);
            this.Controls.Add(this.cbo_cliente);
            this.Controls.Add(this.Lbl_cliente);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.Lbl_marca);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.cbo_nombre);
            this.Controls.Add(this.dgv_pedido_cliente);
            this.Controls.Add(this.Lbl_pedido_cliente);
            this.Name = "Form_modificar_pedido";
            this.Text = "MODIFICAR PEDIDO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbp_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbp_menu;
        private System.Windows.Forms.Button Btn_registro_pedido;
        private System.Windows.Forms.Button Btn_modificar_pedido;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label Lbl_marca;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.ComboBox cbo_nombre;
        private System.Windows.Forms.DataGridView dgv_pedido_cliente;
        private System.Windows.Forms.Label Lbl_pedido_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_guardar_pedido;
        private System.Windows.Forms.Button Btn_cancelar_pedido;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Label Lbl_cancelar;
        private System.Windows.Forms.Label Lbl_eliminar;
    }
}