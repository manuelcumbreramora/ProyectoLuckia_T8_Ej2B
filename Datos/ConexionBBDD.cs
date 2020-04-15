using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public static class ConexionBBDD
    {
        public static SqlConnection obtenerConexion()
        {
            return new SqlConnection("Data Source=PLX001351010353\\SQLEXPRESS;Initial Catalog=Tema8;Integrated Security=True");
        }
    }
}
