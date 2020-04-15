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
            int limite = 0;
            reiniciaLabl();
            switch (DropDownJuego.SelectedItem.Text)
            {
                case "Ruleta":
                    juego = new JuegoRuleta();
                    limite = 40;
                    break;
                case "ParesNones":
                    juego = new JuegoParesNones();
                    limite = 2;
                    break;
                case "Cartas":
                   juego = new JuegoApuestaCarta();
                    limite = 12;
                    break;
                default:
                    juego = null;
                    break;
            }
            try
            {
                int opcionApuesta = Int32.Parse(OpcionApuesta.Text);
                float cantidadApuesta = float.Parse(CantidadApostada.Text);
                if (opcionApuesta > 0 && opcionApuesta <= limite)
                {
                    if (cantidadApuesta <= 0)
                    {
                        lblErrores.Text = "Debe introducir una apuesta positiva";
                    }
                    else
                    {
                        juego.generarInfoTicket(1, 1, cantidadApuesta);
                        juego.jugar(Int32.Parse(OpcionApuesta.Text), juego.infoticket.cantidadApostada, 2);
                        ResultadoGanancia.Text = juego.infoticket.ganancia.ToString();
                        ResultadoJuego.Text = juego.numGenerado.ToString();
                    }
                }
                else
                {
                    lblErrores.Text = string.Format("El numero seleccionado debe estar entre 1 y {0}",limite);
                }
            }
            catch(FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine( ex.Message );
                lblErrores.Text = "Debes rellenar los dos campos";
            }
            

        }

        protected void DropDownJuego_SelectedIndexChanged(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Seleccinado cambiar juego");
            reiniciaLabl();
            reiniciaText();
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

        private void reiniciaLabl()
        {
            lblErrores.Text = "";
            ResultadoGanancia.Text = "";
            ResultadoJuego.Text = "";
        }

        private void reiniciaText()
        {
            OpcionApuesta.Text = "";
            CantidadApostada.Text = "";
        }

        protected void btnCambiarAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PresentacionAdmin.aspx");
        }
    }
}