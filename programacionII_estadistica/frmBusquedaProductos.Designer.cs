namespace programacionII_estadistica
{
    partial class frmBusquedaProductos
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.grdBusquedaProductos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(545, 417);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // grdBusquedaProductos
            // 
            this.grdBusquedaProductos.AllowUserToAddRows = false;
            this.grdBusquedaProductos.AllowUserToDeleteRows = false;
            this.grdBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.categoria,
            this.codigo,
            this.nombre,
            this.marca,
            this.presentacion});
            this.grdBusquedaProductos.Location = new System.Drawing.Point(11, 55);
            this.grdBusquedaProductos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grdBusquedaProductos.Name = "grdBusquedaProductos";
            this.grdBusquedaProductos.ReadOnly = true;
            this.grdBusquedaProductos.RowHeadersWidth = 102;
            this.grdBusquedaProductos.RowTemplate.Height = 40;
            this.grdBusquedaProductos.Size = new System.Drawing.Size(611, 346);
            this.grdBusquedaProductos.TabIndex = 14;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(91, 13);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(295, 20);
            this.txtbuscar.TabIndex = 13;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(36, 16);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 12;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(449, 417);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 11;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.MinimumWidth = 12;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.MinimumWidth = 12;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 250;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 12;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 12;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.MinimumWidth = 12;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 250;
            // 
            // presentacion
            // 
            this.presentacion.DataPropertyName = "presentacion";
            this.presentacion.HeaderText = "PRESENTACION";
            this.presentacion.MinimumWidth = 12;
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            this.presentacion.Width = 250;
            // 
            // frmBusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 455);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaProductos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmBusquedaProductos";
            this.Text = "frmBusquedaProductos";
            this.Load += new System.EventHandler(this.frmBusquedaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaProductos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
    }
}