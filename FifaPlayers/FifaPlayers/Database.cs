using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaPlayers
{
    internal class Database
    {
        public static List<string> dataFill = new List<string>();
        public static DataTable dt = new DataTable();

        public static void GetPlayers()
        {

            dt.Clear();

            string query = "SELECT id, player, birthdate, height, weight, countries.country  FROM players INNER JOIN countries ON players.country_id = countries.id";


            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=fifaplayers;uid=root;password="))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public static void GetCountries()
        {

            MySqlConnection ligacao = new MySqlConnection("server=localhost;database=fifaplayers;uid=root;password=");
            try
            {

                string sqlcountries = "SELECT country FROM countries";
                MySqlCommand cmd = new MySqlCommand(sqlcountries, ligacao);
                ligacao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataFill.Add(reader.GetString("country"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);


            }
            finally
            {
                ligacao.Close();
            }

        }


        public static void InsertPlayer(string name, string birthdate, double height, double weight, int country)
        {
            MySqlConnection ligacao = new MySqlConnection("server=localhost;database=fifaplayers;uid=root;password=");
            try
            {
                string sqlinsert = "INSERT INTO players (player, birthdate, height, weight, country_id) VALUES ('" + name + "', '" + birthdate + "', '" + height + "', '" + weight + "', '" + country + "')";
                MySqlCommand cmd = new MySqlCommand(sqlinsert, ligacao);
                ligacao.Open();
                cmd.ExecuteReader();
                MessageBox.Show("jogador inserido");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);


            }
            finally
            {
                ligacao.Close();
            }
        }
    }
}
