using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Data
{
    /// <summary>
    /// Our database context (DataContext) represents a session with the database that can be used to query and save instances of our entities (SuperHeroes).
    /// Query and save meaning HTTP requests: GET, POST, UPDATE, DELETE.
    /// It acts as a bridge between the code and the database. 
    /// By inheriting from DbContext, we can implement and handle CRUD operations on entities, configure our database connection and model relationships.
    /// Additionally, LINQ functionality to query is implemented to retrieve data from the DB.
    /// </summary>
    public class DataContext : DbContext
    {
        // Boiler-plate code
        // DbContextOptions instance carries configuration information such as connection string, DB provider to use, etc.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Name of the table that contains our SuperHero entries.
        // Our Database set.
        public DbSet<SuperHero> SuperHeroes { get; set; }

        // Our hard-coded connection string. Only created for visibility.
        // We get this using SMSS or SQL Server.
        // This is implemented in the appsettings.json file -> see ConnectionStrings section...
        private readonly string _connectionString = "Server=BYRDAL-DESKTOP\\SQLEXPRESS;Database=SuperHeroDb;Trusted_Connection=True;TrustServerCertificate=true;";
    }
}
