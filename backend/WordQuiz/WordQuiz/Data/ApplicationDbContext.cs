using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Player> Users { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<WordStatistic> WordStatistics { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Player", NormalizedName = "PLAYER" }
                );

            PasswordHasher<Player> ph = new PasswordHasher<Player>();
            Player seed = new Player
            {
                Id = Guid.NewGuid().ToString(),
                Email = "seedplayer@gmail.com",
                EmailConfirmed = true,
                UserName = "seedplayer@gmail.com",
                PlayerName = "SeedPlayer",
                NormalizedUserName = "SEEDPLAYER@gmail.com"
            };
            seed.PasswordHash = ph.HashPassword(seed, "almafa123");
            builder.Entity<Player>().HasData(seed);

            builder.Entity<Word>().HasOne(p => p.Topic)
                .WithMany(u => u.Words)
                .HasForeignKey(p => p.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WordStatistic>().HasOne(p => p.Player)
                .WithMany(u => u.WordStatistics)
                .HasForeignKey(p => p.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WordStatistic>().HasOne(p => p.Word)
                .WithMany()
                .HasForeignKey(p => p.WordId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }
    }
}