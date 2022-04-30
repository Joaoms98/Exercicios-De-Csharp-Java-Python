using API_Steam.src.models;
using Microsoft.EntityFrameworkCore;

namespace API_Steam.src.data
{
    public class AppSteamContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<LibraryModel> Librarys { get; set; }

        public AppSteamContext (DbContextOptions<AppSteamContext>options) : base (options)
        {
        }
    }
}
