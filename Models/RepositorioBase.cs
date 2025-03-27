using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;

namespace Proyecto_Inmobiliaria_MVC.Models
{
    public abstract class RepositorioBase
    {
        protected readonly string connectionString;

        protected RepositorioBase(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("MySqlConnection") 
                               ?? throw new ArgumentNullException("Connection string 'MySqlConnection' not found");
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
