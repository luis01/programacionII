using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
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

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.ventas' Puede moverla o quitarla según sea necesario.
                this.ventasTableAdapter.Fill(this.sistema_dbDataSet.ventas);
                
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }

        private void totalizar()
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
    }
}
