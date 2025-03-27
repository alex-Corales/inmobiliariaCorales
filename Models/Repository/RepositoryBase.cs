using MySql.Data.MySqlClient;

namespace inmobiliariaCorales.Models.Repository
{
    public abstract class RepositoryBase
    {
        protected readonly string connectionString;
        protected readonly MySqlConnection connection;

        protected RepositoryBase(string connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new MySqlConnection(connectionString);
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
