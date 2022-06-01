using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1BC13Crud.Entidades
{
    public class MdAlumno
    {
        public int idAlumno { get; set; }
        public string? carnet { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? clase { get; set; }
        public string? seccion { get; set; }
        public int parcial1 { get; set; }
        public int parcial2 { get; set; }
        public int parcial3 { get; set; }

        //base
        public override string ToString()
        {
            return $"id:{idAlumno} Nombre:{nombre} Seccion:{seccion}Clase{ clase}Parcial 1 { parcial1}Parcial 2 { parcial2}Parcial 3 { parcial3}";
;
        }

    }
}
