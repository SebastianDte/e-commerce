namespace Vistas
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlAdministracion = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnAdministracion = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.pxtbLogo = new System.Windows.Forms.PictureBox();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnFiltroAvanzado = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlVistas = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.pnlAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtbLogo)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.White;
            this.pnlLateral.Controls.Add(this.btnAyuda);
            this.pnlLateral.Controls.Add(this.btnFiltroAvanzado);
            this.pnlLateral.Controls.Add(this.btnProductos);
            this.pnlLateral.Controls.Add(this.pnlAdministracion);
            this.pnlLateral.Controls.Add(this.btnAdministracion);
            this.pnlLateral.Controls.Add(this.btnInicio);
            this.pnlLateral.Controls.Add(this.pxtbLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 582);
            this.pnlLateral.TabIndex = 0;
            // 
            // pnlAdministracion
            // 
            this.pnlAdministracion.Controls.Add(this.btnEliminar);
            this.pnlAdministracion.Controls.Add(this.btnModificar);
            this.pnlAdministracion.Controls.Add(this.btnAgregar);
            this.pnlAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdministracion.Location = new System.Drawing.Point(0, 160);
            this.pnlAdministracion.Name = "pnlAdministracion";
            this.pnlAdministracion.Size = new System.Drawing.Size(200, 100);
            this.pnlAdministracion.TabIndex = 3;
            this.pnlAdministracion.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(0, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(0, 30);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(200, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.White;
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnAdministracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnAdministracion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdministracion.IconColor = System.Drawing.Color.Black;
            this.btnAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 120);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(200, 40);
            this.btnAdministracion.TabIndex = 2;
            this.btnAdministracion.Text = "Administración";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInicio.IconColor = System.Drawing.Color.Black;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.Location = new System.Drawing.Point(0, 80);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(200, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pxtbLogo
            // 
            this.pxtbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pxtbLogo.Location = new System.Drawing.Point(0, 0);
            this.pxtbLogo.Name = "pxtbLogo";
            this.pxtbLogo.Size = new System.Drawing.Size(200, 80);
            this.pxtbLogo.TabIndex = 0;
            this.pxtbLogo.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.Location = new System.Drawing.Point(0, 260);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 40);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.BackColor = System.Drawing.Color.White;
            this.btnFiltroAvanzado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltroAvanzado.FlatAppearance.BorderSize = 0;
            this.btnFiltroAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAvanzado.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnFiltroAvanzado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnFiltroAvanzado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFiltroAvanzado.IconColor = System.Drawing.Color.Black;
            this.btnFiltroAvanzado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(0, 300);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(200, 40);
            this.btnFiltroAvanzado.TabIndex = 5;
            this.btnFiltroAvanzado.Text = "Filtrar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.White;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAyuda.IconColor = System.Drawing.Color.Black;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.Location = new System.Drawing.Point(0, 340);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(200, 40);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(17, 23);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "label1";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.lblNombreUsuario);
            this.pnlSuperior.Location = new System.Drawing.Point(220, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(768, 80);
            this.pnlSuperior.TabIndex = 1;
            // 
            // pnlVistas
            // 
            this.pnlVistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVistas.BackColor = System.Drawing.Color.White;
            this.pnlVistas.Location = new System.Drawing.Point(220, 80);
            this.pnlVistas.Name = "pnlVistas";
            this.pnlVistas.Size = new System.Drawing.Size(768, 490);
            this.pnlVistas.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.pnlVistas);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlLateral);
            this.MinimumSize = new System.Drawing.Size(919, 457);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlAdministracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxtbLogo)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox pxtbLogo;
        private System.Windows.Forms.Panel pnlAdministracion;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnAdministracion;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnFiltroAvanzado;
        private FontAwesome.Sharp.IconButton btnProductos;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlVistas;
    }
}

