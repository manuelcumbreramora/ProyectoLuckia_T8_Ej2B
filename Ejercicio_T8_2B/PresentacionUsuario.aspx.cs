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
            foreach (string s in RepositoryJuego.ObtenerJuegos(true) )
            {
                ListBoxJuegos.Items.Add( s );
            }
            
        }

        protected void ListBoxJuegos_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}