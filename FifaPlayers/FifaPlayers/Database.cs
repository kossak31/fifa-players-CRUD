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
        public static string conn = "server=localhost;database=fifaplayers;uid=root;password=;Convert Zero Datetime=True";
        public static List<string> dataFill = new List<string>();

        public static DataTable dt = new DataTable();

        public static void GetPlayers()
        {

            dt.Clear();

            MySqlConnection ligacao = new MySqlConnection(conn);
            try
            {

                string query = "SELECT players.id, player, birthdate, height, weight, countries.country  FROM players INNER JOIN countries ON players.country_id = countries.id";

                MySqlCommand cmd = new MySqlCommand(query, ligacao);
                ligacao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
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

        public static void GetCountries()
        {

            //add Todos item to list
            dataFill.Add("Todos");

            MySqlConnection ligacao = new MySqlConnection(conn);
            try
            {
                string sqlcountries = "SELECT id, country FROM countries";
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

        public static void Search(string player, string country_id)
        {
            dt.Clear();
            //if selected Todos in combobox show all
            if (country_id == "Todos")
            {

                MySqlConnection ligacao = new MySqlConnection(conn);
                try
                {
                    ligacao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = ligacao;

                    cmd.CommandText = "SELECT players.id, player, birthdate, height, weight, countries.country  FROM players INNER JOIN countries ON players.country_id = countries.id WHERE player LIKE @player";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@player", "%" + player + "%");


                    MySqlDataReader reader = cmd.ExecuteReader();


                    dt.Load(reader);
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
            else
            {

                MySqlConnection ligacao = new MySqlConnection(conn);
                try
                {
                    ligacao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = ligacao;

                    cmd.CommandText = "SELECT players.id, player, birthdate, height, weight, countries.country  FROM players INNER JOIN countries ON players.country_id = countries.id WHERE player LIKE @player AND countries.country = @country_id";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@player", "%" + player + "%");
                    cmd.Parameters.AddWithValue("@country_id", country_id);

                    MySqlDataReader reader = cmd.ExecuteReader();


                    dt.Load(reader);
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

        public static void InsertPlayer(string name, string birthdate, double height, double weight, int country)
        {
            MySqlConnection ligacao = new MySqlConnection(conn);
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

        public static void UpdatePlayer(string id, string name, string birthdate, string height, string weight, int country_id)
        {
            MySqlConnection ligacao = new MySqlConnection(conn);
            try
            {
                ligacao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ligacao;

                cmd.CommandText = "UPDATE players SET player = @name, birthdate = @birthdate, height = @height, weight = @weight, country_id = @country_id  WHERE id = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@country_id", country_id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("atualizou jogador!");

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




        public static void DeletePlayer(string id)
        {
            MySqlConnection ligacao = new MySqlConnection(conn);
            try
            {
                ligacao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = ligacao;

                cmd.CommandText = "DELETE FROM players WHERE id = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", int.Parse(id));

                cmd.ExecuteNonQuery();
                MessageBox.Show("jogador apagado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);




            }
        }
    }
}