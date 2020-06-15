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
    public partial class frmImpresionVenta : Form
    {
        private int _idVenta = 0;
        public frmImpresionVenta(int idVta)
        {
            InitializeComponent();
            _idVenta = idVta;
        }

        private void frmImpresionVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.rptVentas' Puede moverla o quitarla según sea necesario.
            this.rptVentasTableAdapter.FillRptVentas(this.sistema_dbDataSet.rptVentas, _idVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
