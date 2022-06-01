using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1BC13Crud.Clases
{
    //conexion con base de datos
    public class ClsConexion
    {
        private string NombreServidor= "DESKTOP-NCRGUFK";
        private string NombreBaseDatos = "db_alumnos";

        public SqlConnection conexion;

        private String CadenaConexion { get; }

        public ClsConexion()
        {
            CadenaConexion= $"Data Source={NombreServidor};User ID=sa;Password=sa;Initial Catalog={NombreBaseDatos};Integrated Security=True";
        }

        
        /// <summary>
        /// Metodo para ejecutar una consulta SQL y devuelve un Data Table
        /// </summary>
        /// <param name="ConsultaSql"></param>
        /// <returns></returns>
        public DataTable consultaTablaDirecta(String ConsultaSql)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataReader dr;
                    SqlCommand comm = new SqlCommand(ConsultaSql, conexion);
                    dr = comm.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(dr);
                    return dataTable;
                } catch (Exception ex)
                {
                    Console.WriteLine("ups error en consulta directa DataTable:"+ex.Message);
                    return null;
                }

                
            }
        }




        public int EjecutarSQLDirecto(string instruccionSQL)
        {

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                int status = -1;
                try
                {
                    conexion.Open();
                    SqlCommand comm = new SqlCommand(instruccionSQL, conexion);
                    status = comm.ExecuteNonQuery();
                    return status;
                    ////if (estado > 0)
                    ////{
                    ////    Console.WriteLine("se ejecuto con exito");
                    ////}
                }
                catch (Exception ex)
                {
                    return status;
                    //Console.WriteLine("ups error en consulta directa:" + ex.Message);

                }

            }


        }




    }
}
