using marvel_api.Models;
using Microsoft.EntityFrameworkCore;

namespace marvel_api.Data
{
    //Data context = central entity framework class, contains all methods/classes
    public class DataContext : DbContext
    {
        //field for configuration object
        private readonly IConfiguration _config;

        //constructor for datacontext object
        public DataContext(IConfiguration config)
        {
            _config = config;
        }
        
        public virtual DbSet<Comic> Comics {get; set;}

        //Runs actions during creation of connections to db within a context or 'API surface'
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure());
            }
        }

        //Runs actions during creation of 'entities' from models in EF.
        //The model builder arg tells EF what models to connect to.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //defines the shape of an entity using the comic model
            modelBuilder.Entity<Comic>()

            //selects the table for the entity to use (second argument is available for schemas that aren't dto)
            .ToTable("ComicsTest").HasNoKey();
        }

    }
}