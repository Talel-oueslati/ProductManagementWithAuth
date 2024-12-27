using System.Data.SQLite;

namespace ProductManagements
{
    internal class UserRepository
    {
        private readonly Database _database;

        public UserRepository()
        {
            _database = new Database();
        }

       
        public bool ValidateUser(string username, string password)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    var result = (long)command.ExecuteScalar();
                    return result > 0;
                }
            }
        }
    }
}
