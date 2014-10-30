using System;
using System.Configuration;
using System.Data.SqlClient;

namespace VotingSystemApp
{
    internal class ElectionResultGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["VotingSystem"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public static int GetCandidateVote(int candidateId)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM t_voting");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            int count = 0;

            if (aReader.HasRows)
                while (aReader.Read())
                {
                    if (candidateId == (int)aReader[2])
                        count++;

                }
            connection.Close();
            return count;
        }
    }
}