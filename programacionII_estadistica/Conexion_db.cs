using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para trabajar con BD
using System.Data;
using System.Data.SqlClient; //Libreria para conectarse una BD de SQL Server

namespace programacionII_estadistica
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistema_db.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;
            
            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select categorias.categoria, productos.idProducto, productos.codigo, productos.nombre, productos.marca, productos.presentacion from productos inner join categorias on(categorias.idCategoria=productos.idCategoria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos_categorias");

            comandosSQL.CommandText = "select * from categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            return ds;
        }
        public void mantenimiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,dui,nit) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            } else if (accion == "modificar") {
                sql = "UPDATE clientes SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "direccion      = '" + datos[3] + "'," +
                    "telefono       = '" + datos[4] + "'," +
                    "dui            = '" + datos[5] + "'," +
                    "nit            = '" + datos[6] + "'" +
                    "WHERE idCliente = '"+ datos[0] +"'";
            } else if (accion=="eliminar") {
                sql = "DELETE clientes FROM clientes WHERE idCliente='"+ datos[0] +"'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO productos (idCategoria,codigo,nombre,marca,presentacion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            } else if (accion == "modificar") {
                sql = "UPDATE productos SET " +
                    "idCategoria      = '" + datos[1] + "'," +
                    "codigo           = '" + datos[2] + "'," +
                    "nombre           = '" + datos[3] + "'," +
                    "marca            = '" + datos[4] + "'," +
                    "presentacion     = '" + datos[5] + "'" +
                    "WHERE idProducto = '" + datos[0] + "'";
            } else if (accion == "eliminar") {
                sql = "DELETE productos FROM productos WHERE idProducto='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_categorias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo"){
                sql = "INSERT INTO categorias (categoria) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }else if (accion == "modificar"){
                sql = "UPDATE categorias SET " +
                    "categoria            = '" + datos[1] + "'" +
                    "WHERE idCategoria = '" + datos[0] + "'";
            } else if (accion == "eliminar") {
                sql = "DELETE productos FROM categorias WHERE idCategoria='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }
}
