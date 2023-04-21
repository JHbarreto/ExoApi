using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {

        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Essa string de conexão vai depender da sua maquina.
                optionsBuilder.UseSqlServer("User ID = sa; Password = 1234;Server=3I-GAMING\\SQLEXPRESS; Database = ExoApi; Trusted_Connection = false;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}