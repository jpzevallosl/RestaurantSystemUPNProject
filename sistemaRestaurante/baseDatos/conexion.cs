using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sistemaRestaurante.baseDatos
{
    class conexion
    {
        private String cadenaConexionBaseDeDatos;
        public String obtenerCadenaDeConexion()
        {
            //aqui se encuentra la cadena de conexion
            cadenaConexionBaseDeDatos = "Data Source=127.0.0.1\\SLQLEXPRESS;Initial Catalog=restaurante;Integrated Security=True";
            return cadenaConexionBaseDeDatos;
        }


        ///////
        private string conexionBaseDatos;
        private SqlConnection oConn;
        public conexion()
        {
            conexionBaseDatos =  ("Data Source=127.0.0.1\\SLQLEXPRESS;Initial Catalog=restaurante;Integrated Security=True");


        }
        public SqlConnection openDataBase()
        {
            /*  conexionBaseDatos.Open();
              if (conexionBaseDatos == null)
              {
                  conexionBaseDatos.Close();
              }
              return conexionBaseDatos;*/
            try
            {
                string CadenaDeConexion = "Data Source=127.0.0.1\\SLQLEXPRESS;Initial Catalog=restaurante;Integrated Security=True";
                oConn = new SqlConnection(CadenaDeConexion);
                oConn.Open();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
            return oConn;
        }

        /// <summary>
        /// Metodo encargado de Cerrar la conexion si esta Abierta.
        /// </summary>
        public void closeDatabase()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
        }



    }
}
