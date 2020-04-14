using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    class DAOBImplJuego : IDAOJuego
    {
        public bool cambiarEstadoJuego(DTOJuego juego)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=PLX001351010353\\SQLEXPRESS;Initial Catalog=Tema 8;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(String.Format("UPDATE Juego SET Activo ={0} WHERE ID = {1}; ",juego.activo,juego.id), connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.Message);
                }
                return false;
            }
        }

        public List<DTOJuego> listarJuegos(bool activo, float apuesta=0)
        {
            string comando = "";
            DTOJuego juego;
            List<DTOJuego> juegos = new List<DTOJuego>();
            using (SqlConnection connection = new SqlConnection("Data Source=PLX001351010353\\SQLEXPRESS;Initial Catalog=Tema 8;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    if (activo)
                    {
                        comando = "SELECT * FROM Juego WHERE Activo = 1";
                        if (apuesta != 0)
                        {
                            comando = string.Format("SELECT * FROM Juego WHERE Activo = 1 AND ApuestaMinima >= {0}", apuesta);
                        }
                    }
                    else {
                        if (apuesta != 0)
                        {
                            comando = string.Format("SELECT * FROM Juego WHERE ApuestaMinima >= {0}", apuesta);
                        }
                        else
                        {
                            comando = "SELECT * FROM Juego";
                        }
                    }
                    SqlCommand command = new SqlCommand(comando, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            juego = new DTOJuego();
                            juego.id = reader.GetInt32(0);
                            juego.nombre = reader.GetString(1);
                            juego.apuestaMinima = reader.GetFloat(2);
                            juego.activo = reader.GetInt32(3);
                            juegos.Add(juego);
                        }
                    }
                    reader.Close();
                    connection.Close();
                    return juegos;
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.Message);
                }
                return new List<DTOJuego>();
            }
        }
    }
}
