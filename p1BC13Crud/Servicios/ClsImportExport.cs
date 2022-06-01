using p1BC13Crud.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1BC13Crud.Servicios
{
    public class ClsImportExport
    {
        private ClsConexion cone;

        public ClsImportExport()
        {
            cone = new ClsConexion();
        }

        //inicio de estructura
        public string importar(String archivo)
        {
            string texto = "";
            try
            {
                texto = System.IO.File.ReadAllText(archivo);
                return $"Procesados: {cone.EjecutarSQLDirecto(texto)}";
            }
            catch (Exception ex)
            {
                return $"Hubo un Clavo {ex.Message}";
            }

        }


        public string exportar(string insturccion,string archivoDestino)
        {
            string textoSalida = "";
            DataTable resupesta = cone.consultaTablaDirecta(insturccion);

            foreach(DataRow dr in resupesta.Rows)
            {
                textoSalida += $"{dr["idAlumno"]};{dr["carnet"]};{dr["nombre"]};{dr["seccion"]};{dr["parcial1"]};{dr["parcial2"]},{dr["parcial3"]}\n";
            }


            if (!string.IsNullOrEmpty(textoSalida))
            {
                try
                {
                    File.WriteAllText(archivoDestino, textoSalida);
                    return $"Procesado: {archivoDestino}";
                } catch(Exception ex)
                {
                    return $"hay clavo {ex.Message}";
                }
            }

            return "no se encontro nada";
        }


    }
}
