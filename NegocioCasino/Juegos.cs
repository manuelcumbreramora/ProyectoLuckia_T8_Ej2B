using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioCasino
{
    public abstract class Juegos
    {
        //Cuando se instancia un juego se genera la informacion en generarInfoticket (que tiene que ser modificado cdc salga la ganancia)
        //Se instancia el propio juego con su resultado
        public Infoticket infoticket;
        public int numGenerado, randNum;
        float ganancia;
        public int probRandom;

        public void generarInfoTicket(int idJugador, int tipoJuego, float cantidadApostada)
        {
            infoticket = new Infoticket(idJugador, tipoJuego, cantidadApostada);
        }
        public void jugar(int opcionJugador, float cantidadApostada, float cuota)
        {
            //pedir a monedero cantidad apostada e idjugador

            numGenerado = generarResultado();
            if (opcionJugador == numGenerado)
            {
                ganancia = calcularGanancia(cantidadApostada, cuota);
            }
            else
            {
                ganancia = 0;
            }

            infoticket.ganancia = ganancia;
            
        }

        protected int generarResultado()
        {
            var rand = new Random();
            randNum = rand.Next(1, probRandom);
            return randNum;
        }

        protected float calcularGanancia(float cantidadApostada, float cuota)
        {
            ganancia = cuota * cantidadApostada;
            return ganancia;

        }

        public void enviarInfoTicket ()
        {
            
        }


    }
}
