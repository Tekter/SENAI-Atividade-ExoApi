using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using ExoApi.Models;

namespace ExoApi
{
    public class ExoContext : DbContext{
        public ExoContext(){
        }

        public ExoContext(DbContextOptions<ExoContext>options) : base(options){
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(
                    /*
                    "User ID=sa;"+
                    "Password=enegetico123;"+
                    "Server=localhost;"+
                    "Database=Chapter;"+
                    "Trusted_Connection=False;"
                    */
                    
                    "Server=localhost\\SQLEXPRESS;"+
                    "Database=Chapter;"+
                    "Trusted_Connection=True;"
                    
                );
                // Exemplo 1 de string de conexão:
                /*
                "User ID=sa;"+
                "Password=enegetico123;"+
                "Server=localhost;"+
                "Database=Chapter;"+
                "Trusted_Connection=False;"
                */

                // Exemplo 2 de string de conexão:
                /*
                "Server=localhost\\SQLEXPRESS;"+
                "Database=Chapter;"+
                "Trusted_Connection=True;"
                */
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}