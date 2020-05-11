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
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet);

        }
    }
}
