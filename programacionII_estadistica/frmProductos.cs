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
    public partial class frmProductos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cboCategoriaProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaProductos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["productos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idProducto"] };

            cboCategoriaProductos.DataSource = objConexion.obtener_datos().Tables["categorias"];
            cboCategoriaProductos.DisplayMember = "categoria";
            cboCategoriaProductos.ValueMember = "categorias.idCategoria";


            /*cboGrupoProductos.DataSource = objConexion.obtener_datos().Tables["grupos"];
            cboGrupoProductos.DisplayMember = "grupo";
            cboGrupoProductos.ValueMember = "grupos.idGrupo";*/
        }
        void mostrarDatos()
        {
            try{
                cboCategoriaProductos.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                lblidProducto.Text = tbl.Rows[posicion].ItemArray[0].ToString(); 
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtmarca.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtpresentacion.Text = tbl.Rows[posicion].ItemArray[5].ToString(); 

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }catch (Exception ex){
                MessageBox.Show("No hay Datos que mostrar "+ ex.Message, "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtmarca.Text = "";
            txtpresentacion.Text = ""; 
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosProductos.Enabled = !valor;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo") {//boton de nuevo
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }else { //boton de guardar
                String[] valores = {
                    lblidProducto.Text,
                    cboCategoriaProductos.SelectedValue.ToString(),
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtmarca.Text,
                    txtpresentacion.Text
                };
                objConexion.mantenimiento_datos_productos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0) {
                posicion--;
                mostrarDatos();
            } else {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1) {
                posicion++;
                mostrarDatos();
            } else {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar") {//boton de modificar
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";

            } else { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaProductos buscarProducto = new frmBusquedaProductos();
            buscarProducto.ShowDialog(); 

            if (buscarProducto._idProducto > 0) {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarProducto._idProducto));
                mostrarDatos();
            }
        }

        private void btnBuscarCategoriaProductos_Click(object sender, EventArgs e)
        {
            frmBusquedaCategorias buscarCategoria = new frmBusquedaCategorias();
            buscarCategoria.ShowDialog();

            if (buscarCategoria._idCategoria > 0) {
                cboCategoriaProductos.SelectedValue = buscarCategoria._idCategoria;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliminando...");
        }
    }
}
