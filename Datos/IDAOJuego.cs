using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    interface IDAOJuego
    {
        List<DTOJuego> listarJuegos(bool activo, float apuesta = 0);
        bool cambiarEstadoJuego(DTOJuego juego);
    }
}
