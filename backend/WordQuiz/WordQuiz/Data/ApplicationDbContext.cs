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

            var family = new Topic() { Title = "Family", Description = "Learn how to address your or your partner's family at gatherings." };
            var sports = new Topic() { Title = "Sports", Description = "These words will help you cheer for your favorite team." };
            var gardening = new Topic() { Title = "Gardening", Description = "Become an Oxford level green-thumb with this vocabulary." };
            var travel = new Topic() { Title = "Travel", Description = "Words related to traveling abroad." };
            var clothing = new Topic() { Title = "Clothing", Description = "Everything you need to know regarding fashion or about simply going shopping for clothes." };
            var food = new Topic() { Title = "Food", Description = "A vocabulary aimed to help you avoid embarrassment while going out to eat." };
            builder.Entity<Topic>().HasData(family, sports, gardening, travel, clothing, food);

            builder.Entity<Word>().HasData(
                /* Fam */
                new Word() { Original = "Father", Translation = "Apa", TopicId = family.Id },
                new Word() { Original = "Mother", Translation = "Anya", TopicId = family.Id },
                new Word() { Original = "Aunt", Translation = "Nagynéni", TopicId = family.Id },
                new Word() { Original = "Uncle", Translation = "Nagybácsi", TopicId = family.Id },
                new Word() { Original = "Grandmother", Translation = "Nagymama", TopicId = family.Id },
                new Word() { Original = "Grandfather", Translation = "Nagypapa", TopicId = family.Id },
                new Word() { Original = "Grandfather", Translation = "Nagyapa", TopicId = family.Id },
                new Word() { Original = "Mother-in-law", Translation = "Anyós", TopicId = family.Id },
                new Word() { Original = "Father-in-law", Translation = "Após", TopicId = family.Id }
            );

            builder.Entity<Word>().HasData(
                /* Sport */
                new Word() { Original = "Team", Translation = "Csapat", TopicId = sports.Id },
                new Word() { Original = "Opponent", Translation = "Ellenfél", TopicId = sports.Id },
                new Word() { Original = "Stadium", Translation = "Stadion", TopicId = sports.Id },
                new Word() { Original = "Running", Translation = "Futás", TopicId = sports.Id },
                new Word() { Original = "Finish", Translation = "Cél", TopicId = sports.Id },
                new Word() { Original = "Swimming", Translation = "Úszás", TopicId = sports.Id },
                new Word() { Original = "Rope", Translation = "Kötél", TopicId = sports.Id },
                new Word() { Original = "Coach", Translation = "Edző", TopicId = sports.Id },
                new Word() { Original = "Final", Translation = "Döntő", TopicId = sports.Id }
            );

            base.OnModelCreating(builder);
        }
    }
}