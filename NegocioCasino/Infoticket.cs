using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioCasino
{
    public class Infoticket
    {
        public Infoticket(int idJugador, int tipoJuego, float cantidadApostada)
        {
            this.idJugador = idJugador;
            this.tipoJuego = tipoJuego;
            this.cantidadApostada = cantidadApostada;
        }

        public int idJugador { get; set; }
        public int tipoJuego { get; set; }
        public float cantidadApostada { get; set; }
        public float ganancia { get; set; }
        
    }
}
