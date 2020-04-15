using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class DAOBImplApuesta : IDAOApuesta
    {
        public bool guardaApuesta(DTOApuesta apuesta)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=PLX300000000664\\SQLEXPRESS;Initial Catalog=Tema8;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(String.Format("INSERT INTO Apuesta (IdJugador,TipoJuego, CantidadApostada, Ganancia) VALUES ({0},{1},{2},{3})",
                        apuesta.idJugador, apuesta.tipoJuego, apuesta.cantidadApostada, apuesta.ganancia), connection);

                    if (command.ExecuteNonQuery()> 0){
                        return true;
                    }
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.Message);
                }
                return false;
            }
        }
    }
}
