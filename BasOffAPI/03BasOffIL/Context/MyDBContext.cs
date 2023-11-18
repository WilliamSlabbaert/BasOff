using _01BasOffEL.Entities;
using Microsoft.EntityFrameworkCore;

namespace _01BasOffDL.Context
{
    public class MyDBContext : DbContext
    {

        public List<UserCredentialsEntity> Users { get; set; } = new List<UserCredentialsEntity>()
        {
            new UserCredentialsEntity { Id = 1, Username = "user1", Password = "hash1" },
            new UserCredentialsEntity { Id = 2, Username = "user2", Password = "hash2" }
        };

        public MyDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCredentialsEntity>().HasData(
                new UserCredentialsEntity { Id = 1, Username = "user1", Password = "hash1" },
                new UserCredentialsEntity { Id = 2, Username = "user2", Password = "hash2" }
            );
        }
    }
}
