using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica_CRUD_J.EN
{
    public class PersonaJ
    {
        public int Id { get; set; }
        public string NombreJ { get; set; }
        public string ApellidoJ { get; set; }
        public  DateTime FechaDeNacimiento {get; set;}
        public decimal SueldoJ { get; set; }
        public string EstatusJ { get; set; }
        public string ComentariosJ { get; set; }
    }
}
