namespace SVent.Presentaciones
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDatosNoEncontrado = new System.Windows.Forms.Label();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SVent.Properties.Resources.SVents_Login;
            this.pictureBox1.Location = new System.Drawing.Point(296, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(295, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 208);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Categoria";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::SVent.Properties.Resources.exit_32;
            this.btnSalir.Location = new System.Drawing.Point(246, 114);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::SVent.Properties.Resources.redo_32;
            this.btnCancelar.Location = new System.Drawing.Point(86, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 59);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = global::SVent.Properties.Resources.save_32;
            this.btnGuardar.Location = new System.Drawing.Point(10, 149);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 59);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = global::SVent.Properties.Resources.delete_32;
            this.btnEliminar.Location = new System.Drawing.Point(167, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 59);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = global::SVent.Properties.Resources.edit_32;
            this.btnEditar.Location = new System.Drawing.Point(86, 114);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 59);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::SVent.Properties.Resources.new_32;
            this.btnNuevo.Location = new System.Drawing.Point(10, 114);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 59);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 21);
            this.textBox2.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(108, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDatosNoEncontrado);
            this.groupBox1.Controls.Add(this.pbError);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dgvCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 389);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Buscar Categoria:";
            // 
            // lblDatosNoEncontrado
            // 
            this.lblDatosNoEncontrado.AutoSize = true;
            this.lblDatosNoEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNoEncontrado.Location = new System.Drawing.Point(32, 168);
            this.lblDatosNoEncontrado.Name = "lblDatosNoEncontrado";
            this.lblDatosNoEncontrado.Size = new System.Drawing.Size(217, 58);
            this.lblDatosNoEncontrado.TabIndex = 3;
            this.lblDatosNoEncontrado.Text = "No se encontraron \r\n           datos.";
            // 
            // pbError
            // 
            this.pbError.BackColor = System.Drawing.Color.Transparent;
            this.pbError.Image = global::SVent.Properties.Resources.error_64;
            this.pbError.Location = new System.Drawing.Point(108, 103);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(66, 62);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbError.TabIndex = 3;
            this.pbError.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(116, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 21);
            this.txtBuscar.TabIndex = 2;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvCategoria.Location = new System.Drawing.Point(6, 47);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(263, 333);
            this.dgvCategoria.TabIndex = 0;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 60;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDatosNoEncontrado;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;

    }
}