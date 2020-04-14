using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTOApuesta
    {
        public int idJugador { get; set; }
        public int tipoJuego { get; set; }
        public float cantidadApostada { get; set; }
        public float ganancia { get; set; }
    }
}
