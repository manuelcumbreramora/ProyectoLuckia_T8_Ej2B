using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace NegocioCasino {
    public static class RepositoryJuego {
        public static List<String> ObtenerJuegos(bool activo, float minBet = 0) {
            var dao = new DAOBImplJuego();
            

            var list = new List<String>();
            foreach (DTOJuego o in dao.listarJuegos(activo, minBet) )
            {
                list.Add( o.nombre );
            }
            return list;
        }
    }
}
