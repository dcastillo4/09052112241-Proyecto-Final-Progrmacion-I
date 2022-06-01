using p1BC13Crud.Clases;
using p1BC13Crud.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1BC13Crud.Servicios
{
    public class ServicioAlumno
    {
        //sevicio alumnoo
        ClsConexion cone = new ClsConexion();
        static void Main(string[] args) { }

        public void lee(string instruccion)
        {
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);

            foreach (DataRow dr in respuesta.Rows)
            {
                Console.WriteLine($"Carnet={dr["carnet"]} Nombre={dr["nombre"]} Seccion={dr["seccion"]} P1={dr["parcial1"]}");
            }
        }

        public DataTable ConsultaSQL(string instruccion)
        {
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);
            return respuesta;
        }

        public int CrearAlumno(MdAlumno alu)
        {
         
                string instruccion = $"insert into tb_alumnos (carnet,nombre,correo,clase,seccion,parcial1,parcial2,parcial3) values('{alu.carnet}','{alu.nombre}','{alu.correo}','{alu.clase}','{alu.seccion}','{alu.parcial1}','{alu.parcial2}','{alu.parcial3}')";
                return cone.EjecutarSQLDirecto(instruccion);

          




        }





        public MdAlumno ObtenerAlumno(string carnet)
        {
            ClsConexion conn = new ClsConexion();
            MdAlumno alu = new MdAlumno();

            DataTable resp = conn.consultaTablaDirecta($"select * from tb_alumnos where carnet ='{carnet}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    alu.idAlumno = Convert.ToInt32(item["idAlumno"]);
                    alu.carnet = item["carnet"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.seccion = item["seccion"].ToString();
                    alu.clase = item["clase"].ToString();
                    alu.correo = item["correo"].ToString();
                    alu.parcial1 = Convert.ToInt32(item["parcial1"]);
                    alu.parcial2 = Convert.ToInt32(item["parcial2"]);
                    alu.parcial3 = Convert.ToInt32(item["parcial3"]);



                }
                return alu;
            }
            else
            {
                return null;
            }
        }




        public int actualizarAlumno(MdAlumno alu)
        {
            ClsConexion conn = new ClsConexion();
            string instruccion = $"update tb_alumnos set nombre = '{alu.nombre}',correo = '{alu.correo}',clase = '{alu.clase}',seccion= '{alu.seccion}' where carnet='{alu.carnet}'";
            return conn.EjecutarSQLDirecto(instruccion);
        }

        public int BorrarAlumno(MdAlumno alu)
        {
            string instruccion = $"delete from tb_alumnos where carnet = '{alu.carnet}'";
            return cone.EjecutarSQLDirecto(instruccion);

        }




    }
}
