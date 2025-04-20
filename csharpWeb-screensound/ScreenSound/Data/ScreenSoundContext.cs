using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Data
{
    internal class ScreenSoundContext: DbContext
    {
        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Musica> Musicas { get; set; }

        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSoundV0;Integrated Security=True;Encrypt=False;TrustServerCertificate=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

    }
} 
