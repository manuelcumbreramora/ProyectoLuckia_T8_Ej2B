using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTOJuego
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float apuestaMinima { get; set; }
        public int activo { get; set; }
    }
}
