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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.ventasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_dbDataSet = new programacionII_estadistica.sistema_dbDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ventasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idVentaTextBox = new System.Windows.Forms.TextBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoventaComboBox = new System.Windows.Forms.ComboBox();
            this.ventasTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.ventasTableAdapter();
            this.tableAdapterManager = new programacionII_estadistica.sistema_dbDataSetTableAdapters.TableAdapterManager();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVenta = new programacionII_estadistica.sistema_dbDataSetTableAdapters.DetalleVenta();
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idVentaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            fecha_ventaLabel = new System.Windows.Forms.Label();
            tipodocumentoLabel = new System.Windows.Forms.Label();
            tipoventaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).BeginInit();
            this.ventasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idVentaLabel
            // 
            idVentaLabel.AutoSize = true;
            idVentaLabel.Location = new System.Drawing.Point(274, 64);
            idVentaLabel.Name = "idVentaLabel";
            idVentaLabel.Size = new System.Drawing.Size(21, 13);
            idVentaLabel.TabIndex = 1;
            idVentaLabel.Text = "ID:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(25, 61);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "Cliente:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(469, 61);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(66, 13);
            nfacturaLabel.TabIndex = 5;
            nfacturaLabel.Text = "Factura No.:";
            // 
            // fecha_ventaLabel
            // 
            fecha_ventaLabel.AutoSize = true;
            fecha_ventaLabel.Location = new System.Drawing.Point(25, 112);
            fecha_ventaLabel.Name = "fecha_ventaLabel";
            fecha_ventaLabel.Size = new System.Drawing.Size(59, 13);
            fecha_ventaLabel.TabIndex = 7;
            fecha_ventaLabel.Text = "Fecha Vta:";
            // 
            // tipodocumentoLabel
            // 
            tipodocumentoLabel.AutoSize = true;
            tipodocumentoLabel.Location = new System.Drawing.Point(469, 107);
            tipodocumentoLabel.Name = "tipodocumentoLabel";
            tipodocumentoLabel.Size = new System.Drawing.Size(65, 13);
            tipodocumentoLabel.TabIndex = 11;
            tipodocumentoLabel.Text = "Documento:";
            // 
            // tipoventaLabel
            // 
            tipoventaLabel.AutoSize = true;
            tipoventaLabel.Location = new System.Drawing.Point(298, 108);
            tipoventaLabel.Name = "tipoventaLabel";
            tipoventaLabel.Size = new System.Drawing.Size(35, 13);
            tipoventaLabel.TabIndex = 12;
            tipoventaLabel.Text = "Pago:";
            // 
            // ventasBindingNavigator
            // 
            this.ventasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventasBindingNavigator.BindingSource = this.ventasBindingSource;
            this.ventasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ventasBindingNavigatorSaveItem});
            this.ventasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventasBindingNavigator.Name = "ventasBindingNavigator";
            this.ventasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventasBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.ventasBindingNavigator.TabIndex = 0;
            this.ventasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ventasBindingNavigatorSaveItem
            // 
            this.ventasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasBindingNavigatorSaveItem.Image")));
            this.ventasBindingNavigatorSaveItem.Name = "ventasBindingNavigatorSaveItem";
            this.ventasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventasBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventasBindingNavigatorSaveItem_Click);
            // 
            // idVentaTextBox
            // 
            this.idVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idVenta", true));
            this.idVentaTextBox.Location = new System.Drawing.Point(301, 61);
            this.idVentaTextBox.Name = "idVentaTextBox";
            this.idVentaTextBox.Size = new System.Drawing.Size(70, 20);
            this.idVentaTextBox.TabIndex = 2;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idCliente", true));
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(68, 58);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idClienteComboBox.TabIndex = 4;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(541, 61);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.Size = new System.Drawing.Size(113, 20);
            this.nfacturaTextBox.TabIndex = 6;
            // 
            // fecha_ventaDateTimePicker
            // 
            this.fecha_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fecha_venta", true));
            this.fecha_ventaDateTimePicker.Location = new System.Drawing.Point(90, 105);
            this.fecha_ventaDateTimePicker.Name = "fecha_ventaDateTimePicker";
            this.fecha_ventaDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.fecha_ventaDateTimePicker.TabIndex = 8;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "tipodocumento", true));
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(541, 102);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(113, 21);
            this.tipodocumentoComboBox.TabIndex = 12;
            // 
            // tipoventaComboBox
            // 
            this.tipoventaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "tipoventa", true));
            this.tipoventaComboBox.FormattingEnabled = true;
            this.tipoventaComboBox.Location = new System.Drawing.Point(339, 104);
            this.tipoventaComboBox.Name = "tipoventaComboBox";
            this.tipoventaComboBox.Size = new System.Drawing.Size(84, 21);
            this.tipoventaComboBox.TabIndex = 13;
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
            this.tableAdapterManager.dventasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
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
            this.dataGridViewTextBoxColumn8,
            this.nombre,
            this.precio,
            this.descuento,
            this.subtotal});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(33, 156);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.ReadOnly = true;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(621, 220);
            this.detalleVentaDataGridView.TabIndex = 13;
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn8.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "cantidad";
            this.nombre.HeaderText = "CANT";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 80;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 539);
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
            this.Controls.Add(this.ventasBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).EndInit();
            this.ventasBindingNavigator.ResumeLayout(false);
            this.ventasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_dbDataSet sistema_dbDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private sistema_dbDataSetTableAdapters.ventasTableAdapter ventasTableAdapter;
        private sistema_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ventasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idVentaTextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ventaDateTimePicker;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.ComboBox tipoventaComboBox;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private sistema_dbDataSetTableAdapters.DetalleVenta detalleVenta;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}