using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
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

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = seed.Id,
            });

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
              new Word() { Original = "Father-in-law", Translation = "Após", TopicId = family.Id },
              new Word() { Original = "Son", Translation = "Fia", TopicId = family.Id },
              new Word() { Original = "Daughter", Translation = "Lánya", TopicId = family.Id },
              new Word() { Original = "Brother", Translation = "Fivér", TopicId = family.Id },
              new Word() { Original = "Sister", Translation = "Húg", TopicId = family.Id },
              new Word() { Original = "Cousin", Translation = "Unokatestvér", TopicId = family.Id },
              new Word() { Original = "Nephew", Translation = "Unokaöccs", TopicId = family.Id },
              new Word() { Original = "Niece", Translation = "Unokahúg", TopicId = family.Id },
              new Word() { Original = "Stepfather", Translation = "Mostohaapa", TopicId = family.Id },
              new Word() { Original = "Stepmother", Translation = "Mostohaanya", TopicId = family.Id },
              new Word() { Original = "Stepson", Translation = "Mostohafiú", TopicId = family.Id },
              new Word() { Original = "Stepdaughter", Translation = "Mostohalány", TopicId = family.Id },
              new Word() { Original = "Half-brother", Translation = "Félfivér", TopicId = family.Id },
              new Word() { Original = "Half-sister", Translation = "Félnővér", TopicId = family.Id },
              new Word() { Original = "Sister-in-law", Translation = "Sógornő", TopicId = family.Id },
              new Word() { Original = "Brother-in-law", Translation = "Sógor", TopicId = family.Id },
              new Word() { Original = "Godfather", Translation = "Keresztapa", TopicId = family.Id },
              new Word() { Original = "Godmother", Translation = "Keresztanya", TopicId = family.Id },
              new Word() { Original = "Great-grandmother", Translation = "Dédnagymama", TopicId = family.Id },
              new Word() { Original = "Great-grandfather", Translation = "Dédnagypapa", TopicId = family.Id },
              new Word() { Original = "Great-grandson", Translation = "Dédunoka", TopicId = family.Id },
              new Word() { Original = "Great-granddaughter", Translation = "Dédunoka", TopicId = family.Id }
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
             new Word() { Original = "Final", Translation = "Döntő", TopicId = sports.Id },
             new Word() { Original = "Basketball", Translation = "Kosárlabda", TopicId = sports.Id },
             new Word() { Original = "Football", Translation = "Labdarúgás", TopicId = sports.Id },
             new Word() { Original = "Tennis", Translation = "Tenisz", TopicId = sports.Id },
             new Word() { Original = "Baseball", Translation = "Baseball", TopicId = sports.Id },
             new Word() { Original = "Golf", Translation = "Golf", TopicId = sports.Id },
             new Word() { Original = "Volleyball", Translation = "Röplabda", TopicId = sports.Id },
             new Word() { Original = "Hockey", Translation = "Hoki", TopicId = sports.Id },
             new Word() { Original = "Boxing", Translation = "Boksz", TopicId = sports.Id },
             new Word() { Original = "Athletics", Translation = "Atlétika", TopicId = sports.Id },
             new Word() { Original = "Cycling", Translation = "Kerékpározás", TopicId = sports.Id },
             new Word() { Original = "Gymnastics", Translation = "Gimnasztika", TopicId = sports.Id },
             new Word() { Original = "Skiing", Translation = "Síelés", TopicId = sports.Id },
             new Word() { Original = "Wrestling", Translation = "Birkózás", TopicId = sports.Id },
             new Word() { Original = "Diving", Translation = "Merülés", TopicId = sports.Id },
             new Word() { Original = "Archery", Translation = "Íjászat", TopicId = sports.Id },
             new Word() { Original = "Surfing", Translation = "Szörfözés", TopicId = sports.Id },
             new Word() { Original = "Karate", Translation = "Karate", TopicId = sports.Id },
             new Word() { Original = "Gym", Translation = "Edzőterem", TopicId = sports.Id },
             new Word() { Original = "Champion", Translation = "Bajnok", TopicId = sports.Id },
             new Word() { Original = "Referee", Translation = "Játékvezető", TopicId = sports.Id },
             new Word() { Original = "Medal", Translation = "Érem", TopicId = sports.Id }
             );

            builder.Entity<Word>().HasData(
            /* Food */
            new Word() { Original = "Lemon", Translation = "Citrom", TopicId = food.Id },
            new Word() { Original = "Peach", Translation = "Barack", TopicId = food.Id },
            new Word() { Original = "Bean", Translation = "Bab", TopicId = food.Id },
            new Word() { Original = "Pea", Translation = "Borsó", TopicId = food.Id },
            new Word() { Original = "Broccoli", Translation = "Brokkoli", TopicId = food.Id },
            new Word() { Original = "Corn", Translation = "Kukorica", TopicId = food.Id },
            new Word() { Original = "Rice", Translation = "Rizs", TopicId = food.Id },
            new Word() { Original = "Mushroom", Translation = "Gomba", TopicId = food.Id },
            new Word() { Original = "Carrot", Translation = "Répa", TopicId = food.Id },
            new Word() { Original = "Apple", Translation = "Alma", TopicId = food.Id },
            new Word() { Original = "Banana", Translation = "Banán", TopicId = food.Id },
            new Word() { Original = "Orange", Translation = "Narancs", TopicId = food.Id },
            new Word() { Original = "Strawberry", Translation = "Eper", TopicId = food.Id },
            new Word() { Original = "Grapes", Translation = "Szőlő", TopicId = food.Id },
            new Word() { Original = "Watermelon", Translation = "Görögdinnye", TopicId = food.Id },
            new Word() { Original = "Tomato", Translation = "Paradicsom", TopicId = food.Id },
            new Word() { Original = "Potato", Translation = "Krumpli", TopicId = food.Id },
            new Word() { Original = "Cucumber", Translation = "Uborka", TopicId = food.Id },
            new Word() { Original = "Cheese", Translation = "Sajt", TopicId = food.Id },
            new Word() { Original = "Bread", Translation = "Kenyér", TopicId = food.Id },
            new Word() { Original = "Meat", Translation = "Hús", TopicId = food.Id },
            new Word() { Original = "Fish", Translation = "Hal", TopicId = food.Id },
            new Word() { Original = "Egg", Translation = "Tojás", TopicId = food.Id },
            new Word() { Original = "Butter", Translation = "Vaj", TopicId = food.Id },
            new Word() { Original = "Sugar", Translation = "Cukor", TopicId = food.Id },
            new Word() { Original = "Salt", Translation = "Só", TopicId = food.Id },
            new Word() { Original = "Pepper", Translation = "Bors", TopicId = food.Id },
            new Word() { Original = "Honey", Translation = "Méz", TopicId = food.Id },
            new Word() { Original = "Ice cream", Translation = "Fagylalt", TopicId = food.Id }
            );

            builder.Entity<Word>().HasData(
           /* Travel */
           new Word() { Original = "Suitcase", Translation = "Bőrönd", TopicId = travel.Id },
           new Word() { Original = "Ferry", Translation = "Komp", TopicId = travel.Id },
           new Word() { Original = "Airport", Translation = "Reptér", TopicId = travel.Id },
           new Word() { Original = "Travel agency", Translation = "Utazási iroda", TopicId = travel.Id },
           new Word() { Original = "Service", Translation = "Szolgáltatás", TopicId = travel.Id },
           new Word() { Original = "Reception", Translation = "Recepció", TopicId = travel.Id },
           new Word() { Original = "Delay", Translation = "Késés", TopicId = travel.Id },
           new Word() { Original = "Airline", Translation = "Légitársaság", TopicId = travel.Id },
           new Word() { Original = "Passport", Translation = "Útlevél", TopicId = travel.Id },
           new Word() { Original = "Hotel", Translation = "Szálloda", TopicId = travel.Id },
           new Word() { Original = "Train", Translation = "Vonat", TopicId = travel.Id },
           new Word() { Original = "Bus", Translation = "Busz", TopicId = travel.Id },
           new Word() { Original = "Taxi", Translation = "Taxi", TopicId = travel.Id },
           new Word() { Original = "Car", Translation = "Autó", TopicId = travel.Id },
           new Word() { Original = "Ticket", Translation = "Jegy", TopicId = travel.Id },
           new Word() { Original = "Boarding pass", Translation = "Beszállókártya", TopicId = travel.Id },
           new Word() { Original = "Luggage", Translation = "Csomag", TopicId = travel.Id },
           new Word() { Original = "Destination", Translation = "Célállomás", TopicId = travel.Id },
           new Word() { Original = "Tourist", Translation = "Turista", TopicId = travel.Id },
           new Word() { Original = "Guide", Translation = "Idegenvezető", TopicId = travel.Id },
           new Word() { Original = "Map", Translation = "Térkép", TopicId = travel.Id },
           new Word() { Original = "Beach", Translation = "Strand", TopicId = travel.Id },
           new Word() { Original = "Mountain", Translation = "Hegy", TopicId = travel.Id },
           new Word() { Original = "Lake", Translation = "Tó", TopicId = travel.Id },
           new Word() { Original = "Island", Translation = "Sziget", TopicId = travel.Id },
           new Word() { Original = "Sightseeing", Translation = "Városnézés", TopicId = travel.Id },
           new Word() { Original = "Currency", Translation = "Pénznem", TopicId = travel.Id },
           new Word() { Original = "Souvenir", Translation = "Szouvenir", TopicId = travel.Id },
           new Word() { Original = "Adventure", Translation = "Kaland", TopicId = travel.Id }
           );

            builder.Entity<Word>().HasData(
          /* Clothing */
          new Word() { Original = "Dress", Translation = "Ruha", TopicId = clothing.Id },
          new Word() { Original = "Fashionable", Translation = "Divatos", TopicId = clothing.Id },
          new Word() { Original = "Cap", Translation = "Sapka", TopicId = clothing.Id },
          new Word() { Original = "Bathrobe", Translation = "Fürdőköpeny", TopicId = clothing.Id },
          new Word() { Original = "Belt", Translation = "Öv", TopicId = clothing.Id },
          new Word() { Original = "Jeans", Translation = "Farmernadrág", TopicId = clothing.Id },
          new Word() { Original = "Boots", Translation = "Csizma", TopicId = clothing.Id },
          new Word() { Original = "Bracelet", Translation = "Karkötő", TopicId = clothing.Id },
          new Word() { Original = "Coat", Translation = "Kabát", TopicId = clothing.Id },
          new Word() { Original = "Shirt", Translation = "Ing", TopicId = clothing.Id },
          new Word() { Original = "T-shirt", Translation = "Póló", TopicId = clothing.Id },
          new Word() { Original = "Skirt", Translation = "Szoknya", TopicId = clothing.Id },
          new Word() { Original = "Trousers", Translation = "Nadrág", TopicId = clothing.Id },
          new Word() { Original = "Sweater", Translation = "Pulóver", TopicId = clothing.Id },
          new Word() { Original = "Jacket", Translation = "Kabát", TopicId = clothing.Id },
          new Word() { Original = "Socks", Translation = "Zokni", TopicId = clothing.Id },
          new Word() { Original = "Shoes", Translation = "Cipő", TopicId = clothing.Id },
          new Word() { Original = "Hat", Translation = "Kalap", TopicId = clothing.Id },
          new Word() { Original = "Gloves", Translation = "Kesztyű", TopicId = clothing.Id },
          new Word() { Original = "Scarf", Translation = "Sál", TopicId = clothing.Id },
          new Word() { Original = "Underwear", Translation = "Alsónemű", TopicId = clothing.Id },
          new Word() { Original = "Pajamas", Translation = "Pizsama", TopicId = clothing.Id },
          new Word() { Original = "Swimsuit", Translation = "Fürdőruha", TopicId = clothing.Id },
          new Word() { Original = "Bikini", Translation = "Bikini", TopicId = clothing.Id },
          new Word() { Original = "Tie", Translation = "Nyakkendő", TopicId = clothing.Id },
          new Word() { Original = "Handbag", Translation = "Kézitáska", TopicId = clothing.Id },
          new Word() { Original = "Wallet", Translation = "Pénztárca", TopicId = clothing.Id },
          new Word() { Original = "Watch", Translation = "Óra", TopicId = clothing.Id }
          );

            builder.Entity<Word>().HasData(
         /* Gardening */
         new Word() { Original = "Flowerpot", Translation = "Virágcserép", TopicId = gardening.Id },
         new Word() { Original = "Raking", Translation = "Gereblyézés", TopicId = gardening.Id },
         new Word() { Original = "Seed", Translation = "Mag", TopicId = gardening.Id },
         new Word() { Original = "Soil", Translation = "Termőföld", TopicId = gardening.Id },
         new Word() { Original = "Hole", Translation = "Lyuk", TopicId = gardening.Id },
         new Word() { Original = "Dirt", Translation = "Föld", TopicId = gardening.Id },
         new Word() { Original = "Lawn mowing", Translation = "Fűnyírás", TopicId = gardening.Id },
         new Word() { Original = "Spade", Translation = "Ásó", TopicId = gardening.Id },
         new Word() { Original = "Wheelbarrow", Translation = "Talicska", TopicId = gardening.Id },
         new Word() { Original = "Watering can", Translation = "Öntözőkanna", TopicId = gardening.Id },
         new Word() { Original = "Garden hose", Translation = "Kerti tömlő", TopicId = gardening.Id },
         new Word() { Original = "Pruning shears", Translation = "Metszőolló", TopicId = gardening.Id },
         new Word() { Original = "Garden gloves", Translation = "Kerti kesztyű", TopicId = gardening.Id },
         new Word() { Original = "Shovel", Translation = "Ásó", TopicId = gardening.Id },
         new Word() { Original = "Rake", Translation = "Gereblye", TopicId = gardening.Id },
         new Word() { Original = "Garden fork", Translation = "Kerti villa", TopicId = gardening.Id },
         new Word() { Original = "Pruner", Translation = "Metszőolló", TopicId = gardening.Id },
         new Word() { Original = "Garden trowel", Translation = "Kerti talicska", TopicId = gardening.Id },
         new Word() { Original = "Garden hoe", Translation = "Kerti kapa", TopicId = gardening.Id },
         new Word() { Original = "Garden rake", Translation = "Kerti gereblye", TopicId = gardening.Id },
         new Word() { Original = "Garden sprayer", Translation = "Kerti permetező", TopicId = gardening.Id },
         new Word() { Original = "Garden cart", Translation = "Kerti szekér", TopicId = gardening.Id },
         new Word() { Original = "Garden stake", Translation = "Kerti tüske", TopicId = gardening.Id },
         new Word() { Original = "Garden trellis", Translation = "Kerti rács", TopicId = gardening.Id },
         new Word() { Original = "Plant pot", Translation = "Növényi edény", TopicId = gardening.Id },
         new Word() { Original = "Compost bin", Translation = "Komposztáló", TopicId = gardening.Id },
         new Word() { Original = "Garden bench", Translation = "Kerti pad", TopicId = gardening.Id },
         new Word() { Original = "Garden gnome", Translation = "Kerti törpe", TopicId = gardening.Id }

         );

            base.OnModelCreating(builder);
        }
    }
}