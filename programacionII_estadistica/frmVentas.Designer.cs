namespace programacionII_estadistica
{
    partial class frmVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idVentaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label fecha_ventaLabel;
            System.Windows.Forms.Label tipodocumentoLabel;
            System.Windows.Forms.Label tipoventaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_dbDataSet = new programacionII_estadistica.sistema_dbDataSet();
            this.idVentaTextBox = new System.Windows.Forms.TextBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoventaComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.ventasTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.sistema_dbDataSetTableAdapters.TableAdapterManager();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVenta = new programacionII_estadistica.sistema_dbDataSetTableAdapters.DetalleVenta();
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.clientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.condiciones_pagosTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.condiciones_pagosTableAdapter();
            this.tipo_documentoTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.tipo_documentoTableAdapter();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlProductosGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.dventasTableAdapter1 = new programacionII_estadistica.sistema_dbDataSetTableAdapters.dventasTableAdapter();
            idVentaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            fecha_ventaLabel = new System.Windows.Forms.Label();
            tipodocumentoLabel = new System.Windows.Forms.Label();
            tipoventaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNavegacion.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.pnlProductosGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // idVentaLabel
            // 
            idVentaLabel.AutoSize = true;
            idVentaLabel.Location = new System.Drawing.Point(274, 9);
            idVentaLabel.Name = "idVentaLabel";
            idVentaLabel.Size = new System.Drawing.Size(21, 13);
            idVentaLabel.TabIndex = 1;
            idVentaLabel.Text = "ID:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(25, 6);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "Cliente:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(469, 6);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(66, 13);
            nfacturaLabel.TabIndex = 5;
            nfacturaLabel.Text = "Factura No.:";
            // 
            // fecha_ventaLabel
            // 
            fecha_ventaLabel.AutoSize = true;
            fecha_ventaLabel.Location = new System.Drawing.Point(25, 57);
            fecha_ventaLabel.Name = "fecha_ventaLabel";
            fecha_ventaLabel.Size = new System.Drawing.Size(59, 13);
            fecha_ventaLabel.TabIndex = 7;
            fecha_ventaLabel.Text = "Fecha Vta:";
            // 
            // tipodocumentoLabel
            // 
            tipodocumentoLabel.AutoSize = true;
            tipodocumentoLabel.Location = new System.Drawing.Point(469, 52);
            tipodocumentoLabel.Name = "tipodocumentoLabel";
            tipodocumentoLabel.Size = new System.Drawing.Size(65, 13);
            tipodocumentoLabel.TabIndex = 11;
            tipodocumentoLabel.Text = "Documento:";
            // 
            // tipoventaLabel
            // 
            tipoventaLabel.AutoSize = true;
            tipoventaLabel.Location = new System.Drawing.Point(298, 53);
            tipoventaLabel.Name = "tipoventaLabel";
            tipoventaLabel.Size = new System.Drawing.Size(35, 13);
            tipoventaLabel.TabIndex = 12;
            tipoventaLabel.Text = "Pago:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // sistema_dbDataSet
            // 
            this.sistema_dbDataSet.DataSetName = "sistema_dbDataSet";
            this.sistema_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idVentaTextBox
            // 
            this.idVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idVenta", true));
            this.idVentaTextBox.Enabled = false;
            this.idVentaTextBox.Location = new System.Drawing.Point(301, 6);
            this.idVentaTextBox.Name = "idVentaTextBox";
            this.idVentaTextBox.Size = new System.Drawing.Size(70, 20);
            this.idVentaTextBox.TabIndex = 2;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "nombre";
            this.idClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClienteComboBox.Enabled = false;
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(68, 3);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idClienteComboBox.TabIndex = 4;
            this.idClienteComboBox.ValueMember = "idCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(541, 6);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.ReadOnly = true;
            this.nfacturaTextBox.Size = new System.Drawing.Size(113, 20);
            this.nfacturaTextBox.TabIndex = 6;
            // 
            // fecha_ventaDateTimePicker
            // 
            this.fecha_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fecha_venta", true));
            this.fecha_ventaDateTimePicker.Enabled = false;
            this.fecha_ventaDateTimePicker.Location = new System.Drawing.Point(90, 50);
            this.fecha_ventaDateTimePicker.Name = "fecha_ventaDateTimePicker";
            this.fecha_ventaDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.fecha_ventaDateTimePicker.TabIndex = 8;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idTipo", true));
            this.tipodocumentoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipodocumentoComboBox.DisplayMember = "tipo";
            this.tipodocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipodocumentoComboBox.Enabled = false;
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(541, 47);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(113, 21);
            this.tipodocumentoComboBox.TabIndex = 12;
            this.tipodocumentoComboBox.ValueMember = "idTipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // tipoventaComboBox
            // 
            this.tipoventaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idPago", true));
            this.tipoventaComboBox.DataSource = this.condicionespagosBindingSource;
            this.tipoventaComboBox.DisplayMember = "tipo";
            this.tipoventaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoventaComboBox.Enabled = false;
            this.tipoventaComboBox.FormattingEnabled = true;
            this.tipoventaComboBox.Location = new System.Drawing.Point(339, 49);
            this.tipoventaComboBox.Name = "tipoventaComboBox";
            this.tipoventaComboBox.Size = new System.Drawing.Size(84, 21);
            this.tipoventaComboBox.TabIndex = 13;
            this.tipoventaComboBox.ValueMember = "idPago";
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.condiciones_pagosTableAdapter = null;
            this.tableAdapterManager.dventasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.tipo_documentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = programacionII_estadistica.sistema_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = this.ventasTableAdapter;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "FK_dventas_ventas1";
            this.detalleVentaBindingSource.DataSource = this.ventasBindingSource;
            // 
            // detalleVenta
            // 
            this.detalleVenta.ClearBeforeFill = true;
            // 
            // detalleVentaDataGridView
            // 
            this.detalleVentaDataGridView.AllowUserToAddRows = false;
            this.detalleVentaDataGridView.AllowUserToDeleteRows = false;
            this.detalleVentaDataGridView.AutoGenerateColumns = false;
            this.detalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idVenta,
            this.idProducto,
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio,
            this.descuento,
            this.subtotal});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(33, 101);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.ReadOnly = true;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(621, 220);
            this.detalleVentaDataGridView.TabIndex = 13;
            this.detalleVentaDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalleVentaDataGridView_RowLeave);
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // idVenta
            // 
            this.idVenta.DataPropertyName = "idVenta";
            this.idVenta.HeaderText = "idVenta";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Visible = false;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = null;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.NullValue = null;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle7;
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaVenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(503, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 95);
            this.panel1.TabIndex = 14;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(102, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Location = new System.Drawing.Point(114, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(34, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Location = new System.Drawing.Point(102, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(46, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Location = new System.Drawing.Point(33, 373);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(191, 49);
            this.pnlNavegacion.TabIndex = 15;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(67, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(156, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(125, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(33, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(2, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // condiciones_pagosTableAdapter
            // 
            this.condiciones_pagosTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(230, 373);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(260, 49);
            this.pnlEdicion.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(73, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlProductosGrid
            // 
            this.pnlProductosGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlProductosGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlProductosGrid.Location = new System.Drawing.Point(33, 323);
            this.pnlProductosGrid.Name = "pnlProductosGrid";
            this.pnlProductosGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlProductosGrid.TabIndex = 17;
            this.pnlProductosGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(52, 4);
            this.btnQuitarProductosGrid.Name = "btnQuitarProductosGrid";
            this.btnQuitarProductosGrid.Size = new System.Drawing.Size(31, 38);
            this.btnQuitarProductosGrid.TabIndex = 1;
            this.btnQuitarProductosGrid.Text = "-";
            this.btnQuitarProductosGrid.UseVisualStyleBackColor = true;
            this.btnQuitarProductosGrid.Click += new System.EventHandler(this.btnQuitarProductosGrid_Click);
            // 
            // btnAgregarProductosGrid
            // 
            this.btnAgregarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosGrid.Location = new System.Drawing.Point(5, 4);
            this.btnAgregarProductosGrid.Name = "btnAgregarProductosGrid";
            this.btnAgregarProductosGrid.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarProductosGrid.TabIndex = 0;
            this.btnAgregarProductosGrid.Text = "+";
            this.btnAgregarProductosGrid.UseVisualStyleBackColor = true;
            this.btnAgregarProductosGrid.Click += new System.EventHandler(this.btnAgregarProductosGrid_Click);
            // 
            // dventasTableAdapter1
            // 
            this.dventasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.pnlProductosGrid);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detalleVentaDataGridView);
            this.Controls.Add(tipoventaLabel);
            this.Controls.Add(this.tipoventaComboBox);
            this.Controls.Add(idVentaLabel);
            this.Controls.Add(this.idVentaTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(fecha_ventaLabel);
            this.Controls.Add(this.fecha_ventaDateTimePicker);
            this.Controls.Add(tipodocumentoLabel);
            this.Controls.Add(this.tipodocumentoComboBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlProductosGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_dbDataSet sistema_dbDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private sistema_dbDataSetTableAdapters.ventasTableAdapter ventasTableAdapter;
        private sistema_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idVentaTextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ventaDateTimePicker;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.ComboBox tipoventaComboBox;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private sistema_dbDataSetTableAdapters.DetalleVenta detalleVenta;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private sistema_dbDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private sistema_dbDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private sistema_dbDataSetTableAdapters.tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlProductosGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private sistema_dbDataSetTableAdapters.dventasTableAdapter dventasTableAdapter1;
    }
}