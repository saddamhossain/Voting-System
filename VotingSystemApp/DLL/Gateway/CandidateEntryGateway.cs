using System.Configuration;
using System.Data.SqlClient;

namespace VotingSystemApp
{
    internal class CandidateEntryGateway
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
        public void Save(Candidate aCandidate)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO t_candidate (Name,Symbol) Values(@0,@1)";
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@0", aCandidate.Name);
            command.Parameters.AddWithValue("@1", aCandidate.Symbol);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}