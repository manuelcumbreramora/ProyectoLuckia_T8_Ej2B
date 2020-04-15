using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioCasino;

namespace Ejercicio_T8_2B {
    public partial class PresentacionUsuario : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(DropDownJuego.Items.Count == 0)
            foreach (string s in RepositoryJuego.ObtenerJuegos(true) )
            {
                DropDownJuego.Items.Add( s );
            }
            
        }

        protected void BTN_Jugar_Click(object sender, EventArgs e) {
            Juegos juego;
            switch (DropDownJuego.SelectedItem.Text)
            {
                case "Ruleta":
                    juego = new JuegoRuleta();
                    break;
                case "ParesNones":
                    juego = new JuegoParesNones();
                    break;
                case "Cartas":
                   juego = new JuegoApuestaCarta();
                    break;
                default:
                    juego = null;
                    break;
            }
            try
            {
                juego.generarInfoTicket(1, 1, float.Parse(CantidadApostada.Text));
                juego.jugar(Int32.Parse(OpcionApuesta.Text), juego.infoticket.cantidadApostada, 2);
                ResultadoGanancia.Text = juego.infoticket.ganancia.ToString();
                ResultadoJuego.Text = juego.numGenerado.ToString();
            }
            catch(FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine( ex.Message );
            }
            

        }

        protected void BTN_ApostarRuleta_Click(object sender, EventArgs e) {

        }

        protected void DropDownJuego_SelectedIndexChanged(object sender, EventArgs e) {
        }

        protected void Button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Seleccinado cambiar juego");
            switch (DropDownJuego.SelectedItem.Text)
            {
                case "Ruleta":
                    TituloMaquina.Text = "Jugar a la Ruleta";
                    EnunciadoSeleccion.Text = "Selecciona un número entre 1 y 40";
                    break;
                case "ParesNones":
                    TituloMaquina.Text = "Jugar a Pares o Nones";
                    EnunciadoSeleccion.Text = "Selecciona un número entre 1 y 2";
                    break;
                case "Cartas":
                    TituloMaquina.Text = "Jugar a las cartas";
                    EnunciadoSeleccion.Text = "Selecciona un número entre 1 y 12";
                    break;
                default:
                    break;
            }

        }
    }
}