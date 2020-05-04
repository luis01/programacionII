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

            //inicializar los parametros que se van en las consultas
            parametrizacion();
        }
        private void parametrizacion()
        {
            comandosSQL.Parameters.Add("@id", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@idC", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dir", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tel", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dui", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nit", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@mar", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@pre", SqlDbType.Char).Value = "";
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
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,dui,nit) VALUES(@cod,@nom,@dir,@tel,@dui,@nit)";
            } else if (accion == "modificar") {
                sql = "UPDATE clientes SET " +
                    "codigo         = @cod," +
                    "nombre         = @nom," +
                    "direccion      = @dir," +
                    "telefono       = @tel," +
                    "dui            = @dui," +
                    "nit            = @nit " +
                    "WHERE idCliente = @id";
            } else if (accion=="eliminar") {
                sql = "DELETE clientes FROM clientes WHERE idCliente=@id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if( accion!="eliminar") { 
                comandosSQL.Parameters["@cod"].Value = datos[1];
                comandosSQL.Parameters["@nom"].Value = datos[2];
                comandosSQL.Parameters["@dir"].Value = datos[3];
                comandosSQL.Parameters["@tel"].Value = datos[4];
                comandosSQL.Parameters["@dui"].Value = datos[5];
                comandosSQL.Parameters["@nit"].Value = datos[6];
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO productos (idCategoria,codigo,nombre,marca,presentacion) VALUES(@idC,@cod,@nom,@mar,@pre)";
            } else if (accion == "modificar") {
                sql = "UPDATE productos SET " +
                    "idCategoria      = @idC," +
                    "codigo           = @cod," +
                    "nombre           = @nom," +
                    "marca            = @mar," +
                    "presentacion     = @pre " +
                    "WHERE idProducto = @id";
            } else if (accion == "eliminar") {
                sql = "DELETE productos FROM productos WHERE idProducto=@id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if ( accion!="eliminar") { 
                comandosSQL.Parameters["@idC"].Value = datos[1];
                comandosSQL.Parameters["@cod"].Value = datos[2];
                comandosSQL.Parameters["@nom"].Value = datos[3];
                comandosSQL.Parameters["@mar"].Value = datos[4];
                comandosSQL.Parameters["@pre"].Value = datos[5];
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
