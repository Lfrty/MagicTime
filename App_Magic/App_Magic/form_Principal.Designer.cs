namespace App_Magic
{
    partial class form_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Principal));
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.oFile_Coleccion = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Texto = new System.Windows.Forms.TextBox();
            this.tBox_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBox_ListaCartasDesdeBD = new System.Windows.Forms.ListBox();
            this.lBox_Ediciones = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_CargaEdicion = new System.Windows.Forms.Button();
            this.tBox_InsertarEdicion = new System.Windows.Forms.TextBox();
            this.btn_XmlBaseDeDatos = new System.Windows.Forms.Button();
            this.progBar_CargarABD = new System.Windows.Forms.ProgressBar();
            this.tBox_Borrar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_InfoConectado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(746, 110);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(119, 36);
            this.btn_Mostrar.TabIndex = 2;
            this.btn_Mostrar.Text = "<-- Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // oFile_Coleccion
            // 
            this.oFile_Coleccion.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // tBox_tipo
            // 
            this.tBox_tipo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_tipo.Location = new System.Drawing.Point(152, 106);
            this.tBox_tipo.Name = "tBox_tipo";
            this.tBox_tipo.ReadOnly = true;
            this.tBox_tipo.Size = new System.Drawing.Size(288, 26);
            this.tBox_tipo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo:";
            // 
            // tBox_Texto
            // 
            this.tBox_Texto.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Texto.Location = new System.Drawing.Point(39, 213);
            this.tBox_Texto.Multiline = true;
            this.tBox_Texto.Name = "tBox_Texto";
            this.tBox_Texto.ReadOnly = true;
            this.tBox_Texto.Size = new System.Drawing.Size(401, 267);
            this.tBox_Texto.TabIndex = 13;
            this.tBox_Texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_Nombre
            // 
            this.tBox_Nombre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Nombre.Location = new System.Drawing.Point(152, 13);
            this.tBox_Nombre.Name = "tBox_Nombre";
            this.tBox_Nombre.ReadOnly = true;
            this.tBox_Nombre.Size = new System.Drawing.Size(288, 33);
            this.tBox_Nombre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Coste:";
            // 
            // lBox_ListaCartasDesdeBD
            // 
            this.lBox_ListaCartasDesdeBD.FormattingEnabled = true;
            this.lBox_ListaCartasDesdeBD.Location = new System.Drawing.Point(446, 12);
            this.lBox_ListaCartasDesdeBD.Name = "lBox_ListaCartasDesdeBD";
            this.lBox_ListaCartasDesdeBD.Size = new System.Drawing.Size(228, 251);
            this.lBox_ListaCartasDesdeBD.TabIndex = 9;
            this.lBox_ListaCartasDesdeBD.SelectedIndexChanged += new System.EventHandler(this.lBox_Lista_SelectedIndexChanged);
            // 
            // lBox_Ediciones
            // 
            this.lBox_Ediciones.FormattingEnabled = true;
            this.lBox_Ediciones.Location = new System.Drawing.Point(746, 173);
            this.lBox_Ediciones.Name = "lBox_Ediciones";
            this.lBox_Ediciones.Size = new System.Drawing.Size(126, 147);
            this.lBox_Ediciones.TabIndex = 10;
            this.lBox_Ediciones.SelectedIndexChanged += new System.EventHandler(this.lBox_Ediciones_SelectedIndexChanged);
            this.lBox_Ediciones.DoubleClick += new System.EventHandler(this.lBox_Ediciones_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(679, 408);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(89, 29);
            this.btn_conectar.TabIndex = 18;
            this.btn_conectar.Text = "Conectar BD";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_CargaEdicion
            // 
            this.btn_CargaEdicion.Location = new System.Drawing.Point(612, 286);
            this.btn_CargaEdicion.Name = "btn_CargaEdicion";
            this.btn_CargaEdicion.Size = new System.Drawing.Size(102, 53);
            this.btn_CargaEdicion.TabIndex = 19;
            this.btn_CargaEdicion.Text = "Cargar Edicion desde BD";
            this.btn_CargaEdicion.UseVisualStyleBackColor = true;
            this.btn_CargaEdicion.Click += new System.EventHandler(this.btn_CargaEdicion_Click);
            // 
            // tBox_InsertarEdicion
            // 
            this.tBox_InsertarEdicion.Location = new System.Drawing.Point(468, 331);
            this.tBox_InsertarEdicion.Name = "tBox_InsertarEdicion";
            this.tBox_InsertarEdicion.Size = new System.Drawing.Size(120, 20);
            this.tBox_InsertarEdicion.TabIndex = 20;
            this.tBox_InsertarEdicion.TextChanged += new System.EventHandler(this.tBox_InsertarEdicion_TextChanged);
            // 
            // btn_XmlBaseDeDatos
            // 
            this.btn_XmlBaseDeDatos.Location = new System.Drawing.Point(646, 345);
            this.btn_XmlBaseDeDatos.Name = "btn_XmlBaseDeDatos";
            this.btn_XmlBaseDeDatos.Size = new System.Drawing.Size(94, 46);
            this.btn_XmlBaseDeDatos.TabIndex = 21;
            this.btn_XmlBaseDeDatos.Text = "XML A BD";
            this.btn_XmlBaseDeDatos.UseVisualStyleBackColor = true;
            this.btn_XmlBaseDeDatos.Click += new System.EventHandler(this.btn_XmlBaseDeDatos_Click);
            // 
            // progBar_CargarABD
            // 
            this.progBar_CargarABD.Location = new System.Drawing.Point(468, 398);
            this.progBar_CargarABD.Name = "progBar_CargarABD";
            this.progBar_CargarABD.Size = new System.Drawing.Size(120, 23);
            this.progBar_CargarABD.TabIndex = 22;
            // 
            // tBox_Borrar
            // 
            this.tBox_Borrar.Location = new System.Drawing.Point(99, 514);
            this.tBox_Borrar.Name = "tBox_Borrar";
            this.tBox_Borrar.Size = new System.Drawing.Size(100, 20);
            this.tBox_Borrar.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "<-- Borrar";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(319, 503);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 27;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // lbl_InfoConectado
            // 
            this.lbl_InfoConectado.Location = new System.Drawing.Point(705, 36);
            this.lbl_InfoConectado.Name = "lbl_InfoConectado";
            this.lbl_InfoConectado.Size = new System.Drawing.Size(100, 23);
            this.lbl_InfoConectado.TabIndex = 28;
            this.lbl_InfoConectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Magic.Properties.Resources.AltarSinDios;
            this.ClientSize = new System.Drawing.Size(912, 609);
            this.Controls.Add(this.lbl_InfoConectado);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBox_Borrar);
            this.Controls.Add(this.progBar_CargarABD);
            this.Controls.Add(this.btn_XmlBaseDeDatos);
            this.Controls.Add(this.tBox_InsertarEdicion);
            this.Controls.Add(this.btn_CargaEdicion);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBox_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBox_Ediciones);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.tBox_Texto);
            this.Controls.Add(this.tBox_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBox_ListaCartasDesdeBD);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Principal";
            this.Text = "MagicMatt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Principal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.OpenFileDialog oFile_Coleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_Texto;
        private System.Windows.Forms.TextBox tBox_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBox_ListaCartasDesdeBD;
        private System.Windows.Forms.TextBox tBox_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBox_Ediciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_CargaEdicion;
        private System.Windows.Forms.TextBox tBox_InsertarEdicion;
        private System.Windows.Forms.Button btn_XmlBaseDeDatos;
        private System.Windows.Forms.ProgressBar progBar_CargarABD;
        private System.Windows.Forms.TextBox tBox_Borrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Label lbl_InfoConectado;
    }
}

