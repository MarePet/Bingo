using Domain;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlCommand command;
        private static Broker instance;
        public static Broker Instance
        {
            get
            {
                if (instance == null) instance = new Broker();
                return instance;
            }
        }
        private Broker()
        {
            connection = new SqlConnection($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"ROK - Bingo\";Integrated Security=True;");
        }

        public bool SaveGame(Igra igra)
        {
            try
            {
                connection.Open();
                igra.IgraID = GetMaxId();
                command = new SqlCommand("", connection);
                command.CommandText = "INSERT INTO Igra VALUES(@IgraId,@Datum,@ZadataKombinacija,@BrojPokusaja,@Rezultal)";
                command.Parameters.AddWithValue("@IgraId", igra.IgraID);
                command.Parameters.AddWithValue("@Datum", igra.Datum);
                command.Parameters.AddWithValue("@ZadataKombinacija", igra.ZadtataKombinacija);
                command.Parameters.AddWithValue("BrojPokusaja", igra.BrojPokusaja);
                command.Parameters.AddWithValue("@Rezultal", igra.Rezultat);
                command.ExecuteNonQuery();

                

                foreach (Pogadjanje pogadjanje in igra.Pogadjanja)
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO Pogadjanje VALUES(@RB,@Kombinacija,@PogodjenihNaMestu,@PogodjenihNISUNaMestu,@IgraId)";
                    command.Parameters.AddWithValue("@RB", pogadjanje.RB);
                    command.Parameters.AddWithValue("@Kombinacija", pogadjanje.Kombinacija);
                    command.Parameters.AddWithValue("PogodjenihNaMestu", pogadjanje.BrojPogodjenihNaMestu);
                    command.Parameters.AddWithValue("@PogodjenihNisuNaMestu", pogadjanje.BrojPogodjenihNISUNaMestu);
                    command.Parameters.AddWithValue("@IgraId", igra.IgraID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("At SaveGame: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private int GetMaxId()
        {
            command = new SqlCommand("", connection);
            command.CommandText = "SELECT MAX(IgraId) FROM Igra";

            object maxId = command.ExecuteScalar();

            if (maxId is DBNull)
            {
                return default(int);
            }
            return (int)maxId + 1;
        }
    }
}
