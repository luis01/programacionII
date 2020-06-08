using programacionII_estadistica.sistema_dbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class frmVentas : Form
    {
        private int _idVenta = 0;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            actualziarDs();
        }
        private void actualziarDs()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.tipo_documento' Puede moverla o quitarla según sea necesario.
                this.tipo_documentoTableAdapter.FillTipoDocumento(this.sistema_dbDataSet.tipo_documento);
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.condiciones_pagos' Puede moverla o quitarla según sea necesario.
                this.condiciones_pagosTableAdapter.FillCondicionesPago(this.sistema_dbDataSet.condiciones_pagos);
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.clientes' Puede moverla o quitarla según sea necesario.
                this.clientesTableAdapter.Fill(this.sistema_dbDataSet.clientes);
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
                this.detalleVenta.FillDetalleVenta(this.sistema_dbDataSet.DetalleVenta);
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.detalle_ventas' Puede moverla o quitarla según sea necesario.

                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.ventas' Puede moverla o quitarla según sea necesario.
                this.ventasTableAdapter.Fill(this.sistema_dbDataSet.ventas);

                totalizar();
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        private void totalizar()
        {
            try
            {
                int desc = 0, nfilas = 0;
                double cantidad=0, precio = 0, suma = 0, iva = 0, total = 0;
                nfilas = detalleVentaDataGridView.RowCount;
                DataGridViewRow fila = new DataGridViewRow();
                for(int i=0; i<nfilas; i++) {
                    fila = detalleVentaDataGridView.Rows[i];
                    cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                    desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                    precio = double.Parse(fila.Cells["precio"].Value.ToString());

                    suma += cantidad * precio * (1 - desc / 100);
                }
                iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString())==2 ? suma*13/100 : 0;
                total = suma + iva;
                lblSumaVenta.Text = "$"+ Math.Round(suma, 2);
                lblIvaVenta.Text = "$"+ Math.Round(iva,2);
                lblTotalVenta.Text = "$"+ Math.Round(total, 2);

                lblregistroxden.Text = ventasBindingSource.Position+1 + " de " + ventasBindingSource.Count;
            }catch (Exception e) {
                //eroor
            }
        }
        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
            totalizar();
        }
        private void habdes_controles(Boolean estado)
        {
            idClienteComboBox.Enabled = !estado;
            fecha_ventaDateTimePicker.Enabled = !estado;
            tipoventaComboBox.Enabled = !estado;
            tipodocumentoComboBox.Enabled = !estado;

            nfacturaTextBox.ReadOnly = estado;
            detalleVentaDataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            pnlNavegacion.Visible = estado;
            btnEliminar.Enabled = estado;
            btnBuscar.Enabled = estado;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Nuevo") {//nuevo
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                ventasBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else {//guardar
                _idVenta = int.Parse(idVentaTextBox.Text);
                this.Validate();
                this.ventasBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                ventasTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = ventasTableAdapter.Connection;

                if (_idVenta > 0) {//modificando...
                    sqlCmd.CommandText = "delete from dventyas where idVenta=" + _idVenta;
                    sqlCmd.ExecuteNonQuery();
                } else {//nuevo....
                    sqlCmd.CommandText = "select ident_current('ventas') + 1 AS idVenta";
                    _idVenta = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detalleVentaDataGridView.RowCount;
                string[,] dventas = new string[nfilas, 4];
                DataGridViewRow fila = new DataGridViewRow();
                for(int i = 0; i < nfilas; i++) {
                    fila = detalleVentaDataGridView.Rows[i];

                    dventas[i, 0] = fila.Cells["idProducto"].Value.ToString();
                    dventas[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    dventas[i, 2] = fila.Cells["precio"].Value.ToString();
                    dventas[i, 3] = fila.Cells["descuento"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet);

                for (int i = 0; i < nfilas; i++) {
                    dventasTableAdapter1.Insert(
                        _idVenta,
                        int.Parse( dventas[i, 0] ),
                        int.Parse( dventas[i, 1] ),
                        decimal.Parse( dventas[i, 2] ),
                        int.Parse(dventas[i, 3])
                    );
                }
                actualziarDs();
                ventasBindingSource.MoveLast();

                habdes_controles(true);
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar") {//modificar
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...

            }else {//cancelar
                ventasBindingSource.CancelEdit();
                detalleVentaBindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            frmBusquedaProductos buscarProductos = new frmBusquedaProductos();
            buscarProductos.ShowDialog();
            if( buscarProductos._idProducto>0) {
                detalleVentaBindingSource.AddNew();

                detalleVentaDataGridView.CurrentRow.Cells["idProducto"].Value = buscarProductos._idProducto;
                detalleVentaDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                detalleVentaDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                detalleVentaDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detalleVentaDataGridView.RowCount > 0) {
                detalleVentaDataGridView.Rows.Remove(detalleVentaDataGridView.CurrentRow);
            }
        }

        private void detalleVentaDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //totalizar();
            }catch(Exception ex) {
                //
            }
        }
    }
}
