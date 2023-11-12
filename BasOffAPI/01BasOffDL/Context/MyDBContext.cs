using _01BasOffDL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace _01BasOffDL.Context
{
    public class MyDBContext : DbContext
    {

        public DbSet<UserCredentialsDataModel> Users { get; set; }

        public MyDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCredentialsDataModel>().HasData(
                new UserCredentialsDataModel { Id = 1, Username = "user1", Password = "hash1" },
                new UserCredentialsDataModel { Id = 2, Username = "user2", Password = "hash2" }
            );
        }
    }
}
