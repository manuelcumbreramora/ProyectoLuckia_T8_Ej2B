using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioCasino;

namespace Ejercicio_T8_2B {
    public partial class PresentacionAdmin : System.Web.UI.Page {
        Dictionary<string, bool> Juegos = new Dictionary<string, bool>();
        protected void Page_Load(object sender, EventArgs e) {
            //Obtener datos relevantes
            var nombres = RepositoryJuego.ObtenerJuegos(false);
            var estados = RepositoryJuego.ObtenerEstadosJuegos(false);
            //Llenar ListaJuegos con todos los juegos en base de datos
            if (ListaJuegos.Items.Count == 0)
            foreach (string s in nombres)
            {
                ListaJuegos.Items.Add(s);
            }
            //Crear diccionario con nombre:estado
            for (int i = 0; i < nombres.Count; i++ )
            {
                Juegos.Add(nombres[i], estados[i]);
            }
            Update_ActiveCheckbox();

        }

        protected void Update_ActiveCheckbox() 
        {
            System.Diagnostics.Debug.WriteLine("Updating");
            CheckBoxActivo.Checked = Juegos[ListaJuegos.SelectedItem.Text];
        }

        protected void ListaJuegos_SelectedIndexChanged(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("selected");
            Update_ActiveCheckbox();
        }

        protected void CheckBoxActivo_CheckedChanged(object sender, EventArgs e) {
            Juegos[ListaJuegos.SelectedItem.Text] = !Juegos[ListaJuegos.SelectedItem.Text];
            RepositoryJuego.CambiarEstadoJuego( !CheckBoxActivo.Checked, ListaJuegos.SelectedItem.Text);
            Update_ActiveCheckbox();
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PresentacionUsuario.aspx");
        }
    }
}