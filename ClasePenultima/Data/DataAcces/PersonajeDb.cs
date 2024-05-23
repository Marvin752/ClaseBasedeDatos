using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePenultima.Data.DataAcces
{

    //Conecto la mera base de datos

    internal class PersonajeDb
    {
        private string connectionString = "Server = localhost;DataBase=db_universidad;Uid=root;Pwd=EggTortuga78";
        public bool probarConexion()
        {
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }catch(Exception)
                {
                    return false;
                }
            }
        }

        //Imprimo la mera base de datos

        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }


        //Creo un personaje

        public int CrearPersonaje(string nombre, string raza, int nivelPoder, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder,historia,fecha_creacion) VALUES (@nombre, @raza, @nivelPoder,@historia,current_timestamp())";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);

                    return command.ExecuteNonQuery();
                }
            }
        }

        //Elimino un personaje

        public void eliminar(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Busca por id

        public DataTable Buscar(int id)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;
        }

        //Busca por historia 

        public DataTable Buscar(string historia)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE historia like @historia";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@historia","%" + historia + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;
        }

        //Buscar por fecha

        public DataTable Buscarfecha(DateTime fecha, DateTime fecha2)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE fecha_creacion BETWEEN @fecha and @fecha2";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@fecha2", fecha2);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;
        }
    }
}
