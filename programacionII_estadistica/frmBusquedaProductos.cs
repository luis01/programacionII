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
    public partial class frmBusquedaProductos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idProducto;
        public String _nombreProducto, _codigoProducto;
        public frmBusquedaProductos()
        {
            InitializeComponent();
        }

        private void frmBusquedaProductos_Load(object sender, EventArgs e)
        {
            grdBusquedaProductos.DataSource = objConexion.obtener_datos().Tables["productos_categorias"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaProductos.DataSource;
            bs.Filter = "categoria like '%"+ valor +"%' or codigo like '%"+valor+"%' or nombre like '%" + valor + "%'";
            grdBusquedaProductos.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaProductos.RowCount > 0) {
                _idProducto = int.Parse(grdBusquedaProductos.CurrentRow.Cells["idProducto"].Value.ToString());
                _nombreProducto = grdBusquedaProductos.CurrentRow.Cells["nombre"].Value.ToString();
                _codigoProducto = grdBusquedaProductos.CurrentRow.Cells["codigo"].Value.ToString();
                Close();
            } else {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
