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
            this.btn_anyadeColeccion = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.oFile_Coleccion = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Texto = new System.Windows.Forms.TextBox();
            this.tBox_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBox_Lista = new System.Windows.Forms.ListBox();
            this.lBox_Ediciones = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_CargaEdicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_anyadeColeccion
            // 
            this.btn_anyadeColeccion.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anyadeColeccion.Location = new System.Drawing.Point(746, 26);
            this.btn_anyadeColeccion.Name = "btn_anyadeColeccion";
            this.btn_anyadeColeccion.Size = new System.Drawing.Size(119, 51);
            this.btn_anyadeColeccion.TabIndex = 1;
            this.btn_anyadeColeccion.Text = "Añadir Colección";
            this.btn_anyadeColeccion.UseVisualStyleBackColor = true;
            this.btn_anyadeColeccion.Click += new System.EventHandler(this.btn_anyadeColeccion_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(746, 110);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(119, 36);
            this.btn_Mostrar.TabIndex = 2;
            this.btn_Mostrar.Text = "Mostrar";
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
            // lBox_Lista
            // 
            this.lBox_Lista.FormattingEnabled = true;
            this.lBox_Lista.Location = new System.Drawing.Point(446, 12);
            this.lBox_Lista.Name = "lBox_Lista";
            this.lBox_Lista.Size = new System.Drawing.Size(228, 251);
            this.lBox_Lista.TabIndex = 9;
            this.lBox_Lista.SelectedIndexChanged += new System.EventHandler(this.lBox_Lista_SelectedIndexChanged);
            // 
            // lBox_Ediciones
            // 
            this.lBox_Ediciones.FormattingEnabled = true;
            this.lBox_Ediciones.Location = new System.Drawing.Point(746, 173);
            this.lBox_Ediciones.Name = "lBox_Ediciones";
            this.lBox_Ediciones.Size = new System.Drawing.Size(126, 147);
            this.lBox_Ediciones.TabIndex = 10;
            this.lBox_Ediciones.SelectedIndexChanged += new System.EventHandler(this.lBox_Ediciones_SelectedIndexChanged);
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
            this.btn_CargaEdicion.Location = new System.Drawing.Point(635, 296);
            this.btn_CargaEdicion.Name = "btn_CargaEdicion";
            this.btn_CargaEdicion.Size = new System.Drawing.Size(86, 34);
            this.btn_CargaEdicion.TabIndex = 19;
            this.btn_CargaEdicion.Text = "Cargar Edicion";
            this.btn_CargaEdicion.UseVisualStyleBackColor = true;
            this.btn_CargaEdicion.Click += new System.EventHandler(this.btn_CargaEdicion_Click);
            // 
            // form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Magic.Properties.Resources.AltarSinDios;
            this.ClientSize = new System.Drawing.Size(912, 609);
            this.Controls.Add(this.btn_CargaEdicion);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBox_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBox_Ediciones);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.tBox_Texto);
            this.Controls.Add(this.btn_anyadeColeccion);
            this.Controls.Add(this.tBox_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBox_Lista);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Principal";
            this.Text = "MagicMatt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anyadeColeccion;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.OpenFileDialog oFile_Coleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_Texto;
        private System.Windows.Forms.TextBox tBox_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBox_Lista;
        private System.Windows.Forms.TextBox tBox_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBox_Ediciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_CargaEdicion;
    }
}

