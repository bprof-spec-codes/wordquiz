using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class finalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WordStatistics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WordId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordStatistics_AspNetUsers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordStatistics_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Player", "PLAYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlayerName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef359a77-196a-4e0f-9216-1381ac4601d0", 0, "daa21a2a-a180-4287-9778-50c42cbfcf6f", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEChObQYQWozWcptPpqiD+oY9vhA3ivnkXprSDL/hpMHaIx3ClPCqKGa3bgX5FlXlsA==", null, false, "SeedPlayer", "d1da9584-c36b-45c7-9b2d-54d0eae69f49", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "These words will help you cheer for your favorite team.", "Sports" },
                    { "647bfa7e-4314-4640-beaa-151275e12291", "Learn how to address your or your partner's family at gatherings.", "Family" },
                    { "7b68a801-15f0-4ddc-a164-e43c83687f25", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "83006284-5128-4fad-a877-edad83aa3b9f", "Words related to traveling abroad.", "Travel" },
                    { "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ef359a77-196a-4e0f-9216-1381ac4601d0" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "01078166-6a63-43d3-b12d-ffe0c8a6c9f4", "Tennis", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Tenisz" },
                    { "01ab9fad-f30d-4cfa-b3e3-d41af0f4d60a", "Underwear", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Alsónemű" },
                    { "03679e94-6178-4c8c-a3e3-29e223c1ce2a", "Baseball", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Baseball" },
                    { "06578855-d864-4db0-bb2f-cd5579555d87", "Gloves", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Kesztyű" },
                    { "07275fa2-0a27-4823-91a4-55be7e994826", "Boarding pass", "83006284-5128-4fad-a877-edad83aa3b9f", "Beszállókártya" },
                    { "075f1649-8180-4a84-b8f4-be6f8bcb7b45", "Soil", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Termőföld" },
                    { "077b1509-d324-4c1c-a040-19aea351bda4", "Guide", "83006284-5128-4fad-a877-edad83aa3b9f", "Idegenvezető" },
                    { "0893a104-1d79-4e15-9dbd-5c07a7476474", "Travel agency", "83006284-5128-4fad-a877-edad83aa3b9f", "Utazási iroda" },
                    { "0a2bf8f9-c757-4137-8b75-9985ce070f71", "Wheelbarrow", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Talicska" },
                    { "0a4bc4a0-4c5f-485a-8584-b5aa5493746a", "Diving", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Merülés" },
                    { "0e2b1e2b-902d-41eb-bd05-5e095a5fecf3", "Lawn mowing", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Fűnyírás" },
                    { "109c56e1-c344-4df8-bb8a-15482db22019", "T-shirt", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Póló" },
                    { "15b575a0-98a8-45d1-8c66-d655e39a9f00", "Belt", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Öv" },
                    { "15dc981a-86ca-4048-b83b-35cfae454970", "Tie", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Nyakkendő" },
                    { "16635eef-838e-4f5c-9102-acce6a575726", "Bread", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Kenyér" },
                    { "16681583-c002-499e-8218-e11bead5e332", "Mountain", "83006284-5128-4fad-a877-edad83aa3b9f", "Hegy" },
                    { "16fcef79-edee-4d98-9736-3711ce726912", "Hole", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Lyuk" },
                    { "172576d8-0f27-4aaf-a7f6-3c4e07d83010", "Great-grandmother", "647bfa7e-4314-4640-beaa-151275e12291", "Dédnagymama" },
                    { "188235b1-b7da-4ef6-835b-726effe2981d", "Great-grandson", "647bfa7e-4314-4640-beaa-151275e12291", "Dédunoka" },
                    { "1a1b5917-ff6e-4ec5-92ca-1810f3d4675b", "Opponent", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Ellenfél" },
                    { "1a3dc8be-424b-40b4-a799-1ab9748ce6a8", "Reception", "83006284-5128-4fad-a877-edad83aa3b9f", "Recepció" },
                    { "1d4cfef8-5679-43cb-888f-b27225a7b0ae", "Bracelet", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Karkötő" },
                    { "2089c011-b1b7-4f0a-87fa-fd821e331f01", "Hotel", "83006284-5128-4fad-a877-edad83aa3b9f", "Szálloda" },
                    { "20edd234-5699-4d61-b320-a2954b1475c7", "Watermelon", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Görögdinnye" },
                    { "21fe4307-53ce-4ff2-9b69-511c10975aca", "Wrestling", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Birkózás" },
                    { "226a0020-fd97-48ff-9113-2aceb7744505", "Mother", "647bfa7e-4314-4640-beaa-151275e12291", "Anya" },
                    { "23d45a5c-0481-48d1-8ee6-26dbc74a6f10", "Niece", "647bfa7e-4314-4640-beaa-151275e12291", "Unokahúg" },
                    { "23dfc930-1927-443a-892a-4b4cd4ce8c2d", "Uncle", "647bfa7e-4314-4640-beaa-151275e12291", "Nagybácsi" },
                    { "242734aa-74db-40cd-b38d-34f8cf666247", "Destination", "83006284-5128-4fad-a877-edad83aa3b9f", "Célállomás" },
                    { "24422a0e-95bb-4778-87f6-59725c5271fa", "Cousin", "647bfa7e-4314-4640-beaa-151275e12291", "Unokatestvér" },
                    { "26e28558-bcb8-439a-8721-ee87eda521d5", "Hat", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Kalap" },
                    { "27bcf317-f527-4120-8f39-f2b63b531026", "Swimming", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Úszás" },
                    { "29905d8b-0360-4e06-bc7b-5e744d5b7c76", "Great-grandfather", "647bfa7e-4314-4640-beaa-151275e12291", "Dédnagypapa" },
                    { "2a362481-d823-4d4e-9f5a-399cd16adea5", "Father", "647bfa7e-4314-4640-beaa-151275e12291", "Apa" },
                    { "2a637aca-e165-4030-a9e2-f62210e1bc9a", "Grandmother", "647bfa7e-4314-4640-beaa-151275e12291", "Nagymama" },
                    { "2a987d08-266a-49e2-a68d-f4141a16edd4", "Fashionable", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Divatos" },
                    { "2db3c158-ee32-4d8b-a0a0-82cb7934daa2", "Island", "83006284-5128-4fad-a877-edad83aa3b9f", "Sziget" },
                    { "2ed0ae48-5452-42ab-9fd4-ef68ad6a451c", "Adventure", "83006284-5128-4fad-a877-edad83aa3b9f", "Kaland" },
                    { "2fc8ac7c-f711-4d3b-98d7-1e4e440e87b4", "Sightseeing", "83006284-5128-4fad-a877-edad83aa3b9f", "Városnézés" },
                    { "315ddebe-4af5-46be-af91-120d4d525573", "Broccoli", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Brokkoli" },
                    { "330b6573-f2d9-47d8-bf55-cb23de6ce569", "Sister-in-law", "647bfa7e-4314-4640-beaa-151275e12291", "Sógornő" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "33e06efa-2122-4589-8016-5a024b17bc90", "Corn", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Kukorica" },
                    { "34074980-8633-41a0-aba8-a9360c88b6b6", "Daughter", "647bfa7e-4314-4640-beaa-151275e12291", "Lánya" },
                    { "356cecc7-a3e7-460b-9e0f-3ed6b7783890", "Cheese", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Sajt" },
                    { "357d142c-45b6-4b6f-a6c7-a1571ddf233c", "Garden sprayer", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti permetező" },
                    { "35ec9d7f-dd73-447b-81d0-6850b671e144", "Service", "83006284-5128-4fad-a877-edad83aa3b9f", "Szolgáltatás" },
                    { "3621d517-36be-4c59-a263-3bebb4ee2ac5", "Honey", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Méz" },
                    { "364640aa-1ac3-4a93-9f1c-91fa05772351", "Referee", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Játékvezető" },
                    { "36d3c807-6907-47f2-9f08-0894db59450b", "Tourist", "83006284-5128-4fad-a877-edad83aa3b9f", "Turista" },
                    { "38f8d04a-f0e2-49db-9a7a-6ea670a426bc", "Coat", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Kabát" },
                    { "3a0c1098-b21a-4b4c-8948-ec33cd1b3242", "Bus", "83006284-5128-4fad-a877-edad83aa3b9f", "Busz" },
                    { "3a3268b3-bb39-429d-bdd0-76053dbce896", "Rope", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Kötél" },
                    { "3a762716-941c-4856-a829-2349a6dec7c0", "Scarf", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Sál" },
                    { "3b60215a-bea2-4fea-8c7e-287f65e287b8", "Hockey", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Hoki" },
                    { "3dc045a7-6868-4e1d-9be7-d2cfc31e4496", "Seed", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Mag" },
                    { "3e5ae013-7b33-44f0-a5f7-92d21078f224", "Brother-in-law", "647bfa7e-4314-4640-beaa-151275e12291", "Sógor" },
                    { "3efa9f68-e693-4ab4-b9ae-db9900726aba", "Gym", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Edzőterem" },
                    { "3f1ce9c9-c318-44e6-b192-5abaa786b7b3", "Beach", "83006284-5128-4fad-a877-edad83aa3b9f", "Strand" },
                    { "3f2139e9-a442-49fc-9ccf-1c3acc24e788", "Godmother", "647bfa7e-4314-4640-beaa-151275e12291", "Keresztanya" },
                    { "402c788a-5b4f-4d18-8224-f2df312d45ea", "Compost bin", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Komposztáló" },
                    { "403851db-4f82-46cb-8a75-ab03db54fc61", "Pajamas", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Pizsama" },
                    { "4039bb04-0215-4b17-bcf6-de1ea27c166c", "Half-sister", "647bfa7e-4314-4640-beaa-151275e12291", "Félnővér" },
                    { "4178d2fd-c0d6-4e01-be34-5b7c7c2325c4", "Garden rake", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti gereblye" },
                    { "41e4b538-4b3c-440f-bea3-34db3e43ff62", "Grandfather", "647bfa7e-4314-4640-beaa-151275e12291", "Nagyapa" },
                    { "427511ca-22eb-4b84-812d-d28c94775330", "Trousers", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Nadrág" },
                    { "453cbb13-1fdc-4815-bad7-56dda243d3eb", "Half-brother", "647bfa7e-4314-4640-beaa-151275e12291", "Félfivér" },
                    { "4a0cc628-ad3d-45d6-b9f7-e23ffe587803", "Sugar", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Cukor" },
                    { "4e03a077-08e0-4395-8609-75c86d11043d", "Map", "83006284-5128-4fad-a877-edad83aa3b9f", "Térkép" },
                    { "50e3745f-c7d7-45cd-90b7-fe24fd7fc60d", "Train", "83006284-5128-4fad-a877-edad83aa3b9f", "Vonat" },
                    { "560844b5-56d1-48db-b4c7-512f2472382b", "Running", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Futás" },
                    { "5645ef18-d7a7-4422-858b-9d4409baab95", "Passport", "83006284-5128-4fad-a877-edad83aa3b9f", "Útlevél" },
                    { "56e04ace-d36e-407d-b9dd-f0cc80eab323", "Grapes", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Szőlő" },
                    { "57a863bb-1766-4173-8f7d-68456a31c229", "Garden hose", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti tömlő" },
                    { "59f88726-783e-4b67-8db4-27ba6aeb31df", "Apple", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Alma" },
                    { "5cfd0bfa-47bc-425d-a553-1e3e9dcc10e0", "Dirt", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Föld" },
                    { "5fa5123e-94d9-4551-be42-71ce2f087aff", "Medal", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Érem" },
                    { "61e5fdea-d0b7-4ad5-a7f3-d348266eb179", "Ticket", "83006284-5128-4fad-a877-edad83aa3b9f", "Jegy" },
                    { "6555fae1-d674-49f0-9795-b09a5c8c020a", "Boots", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Csizma" },
                    { "683c2a93-1686-4915-8750-87cd04dcd402", "Basketball", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Kosárlabda" },
                    { "6869e403-62bc-494e-bf8d-68d75dc368a8", "Finish", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Cél" },
                    { "68f21638-6aa4-4b41-871b-4b3abe0ac68b", "Airline", "83006284-5128-4fad-a877-edad83aa3b9f", "Légitársaság" },
                    { "69005d9a-dde8-461e-9ec1-79a48ce4761e", "Archery", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Íjászat" },
                    { "694a805e-a804-4d3c-9aaa-2cd99cf7d9db", "Mushroom", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Gomba" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "69e5c983-ea59-43d6-b8cd-47be45b48b6f", "Strawberry", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Eper" },
                    { "6ac4ccbb-7233-44d2-bba6-6c54d8b9def1", "Lemon", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Citrom" },
                    { "70495c05-1595-4a45-ae8c-6eb046862ae8", "Final", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Döntő" },
                    { "70f818a4-ab19-4d02-bcb6-ac06b8435b69", "Garden trellis", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti rács" },
                    { "72d1b11c-8131-4f0e-bd4f-0fc6b1b9980a", "Luggage", "83006284-5128-4fad-a877-edad83aa3b9f", "Csomag" },
                    { "73f1457a-e0bc-4aad-b157-82196f4fdade", "Garden bench", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti pad" },
                    { "75274785-ba14-48eb-993b-dd2668ed99c1", "Delay", "83006284-5128-4fad-a877-edad83aa3b9f", "Késés" },
                    { "7633deb7-ebe9-426a-a8f1-2b76aaea3d25", "Nephew", "647bfa7e-4314-4640-beaa-151275e12291", "Unokaöccs" },
                    { "78cec0dc-1c32-479a-ac0b-bc84c89d1640", "Boxing", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Boksz" },
                    { "79785406-bbda-4026-a269-048ccd4c7f8d", "Garden fork", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti villa" },
                    { "79d8ce6b-92ca-470c-ac41-d1796142218c", "Currency", "83006284-5128-4fad-a877-edad83aa3b9f", "Pénznem" },
                    { "7acfb5ec-97e7-4806-9af2-00389184a315", "Garden hoe", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti kapa" },
                    { "7d31cf20-1662-4296-944e-47eb3aae314a", "Bean", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Bab" },
                    { "7f271ff5-e9ca-4feb-adf4-6de58bd0106f", "Football", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Labdarúgás" },
                    { "7f2eab09-af3e-49c4-a60b-12a91c697aec", "Aunt", "647bfa7e-4314-4640-beaa-151275e12291", "Nagynéni" },
                    { "7f6efbb7-d8c6-4d4e-9acc-e592f6a7531b", "Garden gloves", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti kesztyű" },
                    { "80f93de3-84b0-44b9-9636-243c2af50feb", "Brother", "647bfa7e-4314-4640-beaa-151275e12291", "Fivér" },
                    { "817c54df-6598-4c44-97ef-a87531173e38", "Stepson", "647bfa7e-4314-4640-beaa-151275e12291", "Mostohafiú" },
                    { "81869dae-488e-472f-8437-85d6c7e80abe", "Skirt", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Szoknya" },
                    { "81df600c-dac2-451a-a044-c887ea3ac9c3", "Plant pot", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Növényi edény" },
                    { "82997420-3865-4b02-9f24-d0b0245673c4", "Handbag", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Kézitáska" },
                    { "832ff1e5-352f-463a-82b6-349849d3f07d", "Garden cart", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti szekér" },
                    { "86a01e8b-b962-41e5-9aa2-96ac0f7a9c93", "Shovel", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Ásó" },
                    { "880aed5e-9c7c-4332-adeb-b0566c0a6260", "Spade", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Ásó" },
                    { "8b3b2731-3919-44ea-81f6-de6ec42e3c0c", "Meat", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Hús" },
                    { "8e356a0c-dcb8-4a35-b576-5e3678b0174f", "Peach", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Barack" },
                    { "8e796924-74de-4fb3-a5e7-19deb57fd790", "Airport", "83006284-5128-4fad-a877-edad83aa3b9f", "Reptér" },
                    { "91535ae3-c9e2-42fc-af1d-bd11f199e76c", "Stepdaughter", "647bfa7e-4314-4640-beaa-151275e12291", "Mostohalány" },
                    { "97cb1b95-c1b7-4037-8343-79a921b49137", "Mother-in-law", "647bfa7e-4314-4640-beaa-151275e12291", "Anyós" },
                    { "98cad703-4afd-4ede-b62e-c2c776bf9725", "Stadium", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Stadion" },
                    { "9912ec53-c116-49ed-98ce-2b04584cc950", "Son", "647bfa7e-4314-4640-beaa-151275e12291", "Fia" },
                    { "9cb0532f-5d76-4efd-9934-09ddf93ddc04", "Team", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Csapat" },
                    { "9cdbd50c-07b9-4dd3-8b2a-9e095b0592ff", "Ferry", "83006284-5128-4fad-a877-edad83aa3b9f", "Komp" },
                    { "9dc6cb23-2817-459f-918d-a8d58fbe2409", "Pepper", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Bors" },
                    { "a0d28bc6-6ca7-4ccc-b5fd-df5634501c79", "Flowerpot", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Virágcserép" },
                    { "a1139c0a-b23b-41b6-b27b-8427c37e0a7a", "Stepmother", "647bfa7e-4314-4640-beaa-151275e12291", "Mostohaanya" },
                    { "a2b5ec1d-17d4-478f-8979-9aa0709eeef2", "Great-granddaughter", "647bfa7e-4314-4640-beaa-151275e12291", "Dédunoka" },
                    { "a2d8b566-b864-42f3-89b7-2195e9da2d71", "Jacket", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Kabát" },
                    { "a5bfe016-790d-439f-821b-faf939c74525", "Cap", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Sapka" },
                    { "accf6bce-9595-4fab-aa4a-08810549c82c", "Champion", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Bajnok" },
                    { "adc4e43b-d20d-4315-9c54-9a2e8093c00c", "Potato", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Krumpli" },
                    { "b0550cab-7857-4f84-a097-7c23179b46bb", "Raking", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Gereblyézés" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "b0aa219f-0f5d-4730-8c36-52575b054f71", "Souvenir", "83006284-5128-4fad-a877-edad83aa3b9f", "Szouvenir" },
                    { "b0c38406-b5a2-41ae-b39e-751c4eb87fa7", "Rake", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Gereblye" },
                    { "b100269e-290e-42c8-9ef7-362e2772e2a3", "Garden trowel", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti talicska" },
                    { "b157a11c-8b71-4a22-861c-8497d8aae1c4", "Shirt", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Ing" },
                    { "b329269e-ece6-4130-bb71-d3ad9e6f60d0", "Volleyball", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Röplabda" },
                    { "b3f832af-a989-4483-9d7f-d3a197af57e6", "Suitcase", "83006284-5128-4fad-a877-edad83aa3b9f", "Bőrönd" },
                    { "b6b9922d-4a48-4ffe-99c3-ae8c570e8187", "Athletics", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Atlétika" },
                    { "b880f3b1-b6ba-4391-9f0b-0b99550f4c5a", "Taxi", "83006284-5128-4fad-a877-edad83aa3b9f", "Taxi" },
                    { "bcfadcbb-3beb-46fd-86a8-4c7a87752da9", "Carrot", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Répa" },
                    { "be3da671-c97c-4589-9a08-67d9aeed0d78", "Father-in-law", "647bfa7e-4314-4640-beaa-151275e12291", "Após" },
                    { "bec6de99-cdb0-45c8-9bbf-1bced1462095", "Garden gnome", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti törpe" },
                    { "bf073520-bcae-474d-8b20-81061c39c494", "Cucumber", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Uborka" },
                    { "c0ee81f3-2f90-42a9-9033-21057cf6b530", "Skiing", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Síelés" },
                    { "c42923e9-3a62-4691-92a4-523450565dac", "Pea", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Borsó" },
                    { "c5022f6e-4cf4-46ec-9d1d-0ac08288c2fe", "Golf", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Golf" },
                    { "cc41298a-546b-48d9-9359-92d9655a5491", "Surfing", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Szörfözés" },
                    { "cc9bfa52-3723-4518-a587-cc7cb71df434", "Rice", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Rizs" },
                    { "ce4fda20-5a1f-4a4e-9b67-f195504b91f6", "Wallet", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Pénztárca" },
                    { "ce55a2c4-fb24-4a6e-a3c6-3a7c28098d87", "Jeans", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Farmernadrág" },
                    { "ce8e0f53-0bcb-454b-8299-570f3bd4348d", "Banana", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Banán" },
                    { "cf003e92-b372-4cdc-9a76-dad5888764b5", "Pruner", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Metszőolló" },
                    { "cf69a620-3e14-4755-b4cf-fc83a02f89b1", "Egg", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Tojás" },
                    { "cffddfa3-b6a4-426d-967f-9f4a30d9b4aa", "Car", "83006284-5128-4fad-a877-edad83aa3b9f", "Autó" },
                    { "d13dac83-89a4-4a6e-9de5-f8dd376fdcf2", "Sweater", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Pulóver" },
                    { "d1bfa1cd-2536-402f-b53c-208c3419b7d9", "Watering can", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Öntözőkanna" },
                    { "d3a9c894-1e53-4731-816f-63d1d7ffff01", "Butter", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Vaj" },
                    { "d78b6850-b5c5-4f0b-a6b1-9c86bbb44324", "Stepfather", "647bfa7e-4314-4640-beaa-151275e12291", "Mostohaapa" },
                    { "dbe73d21-9188-439e-b676-8cd03f10bd1e", "Shoes", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Cipő" },
                    { "dc50a877-922a-4552-bff4-8ff39219c768", "Bathrobe", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Fürdőköpeny" },
                    { "dd2b33e2-5974-4fe2-892c-07197074d31c", "Swimsuit", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Fürdőruha" },
                    { "dd57bc12-4db4-4d43-ac9b-b29b4084b473", "Watch", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Óra" },
                    { "de543f59-38b4-4eb3-a88c-6b698da40cbc", "Ice cream", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Fagylalt" },
                    { "e311a4a6-5432-44b5-a9da-ee0b1bdf764c", "Fish", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Hal" },
                    { "eb1fbfad-e268-4fa2-949c-0c2b1dcd945b", "Karate", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Karate" },
                    { "ed01835f-d67b-4fe9-9064-423e05b24c13", "Socks", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Zokni" },
                    { "edc85930-9315-41f1-9360-1abc25d3b25a", "Bikini", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Bikini" },
                    { "ee9d48a2-4f29-4aaf-8b2a-18bb436e1a56", "Grandfather", "647bfa7e-4314-4640-beaa-151275e12291", "Nagypapa" },
                    { "ef78173f-b552-432f-8b19-87889d42419e", "Cycling", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Kerékpározás" },
                    { "f07a3b83-95ce-487b-9ca4-bc8e61f31074", "Pruning shears", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Metszőolló" },
                    { "f0c2b552-b0b5-4eb0-9912-461097d0379f", "Sister", "647bfa7e-4314-4640-beaa-151275e12291", "Húg" },
                    { "f2b53256-3444-4613-925c-7af7e053ca32", "Dress", "44fe9a36-27bf-468a-b75d-ab2da7a02d27", "Ruha" },
                    { "f34a9829-8672-40b4-9671-78bfb1b3110c", "Garden stake", "7b68a801-15f0-4ddc-a164-e43c83687f25", "Kerti tüske" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "f7a722cb-2c59-4cb7-82e9-82f164d87c06", "Godfather", "647bfa7e-4314-4640-beaa-151275e12291", "Keresztapa" },
                    { "f92ba7e7-0477-48ce-9fbb-17c366ec546b", "Gymnastics", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Gimnasztika" },
                    { "fb1cb957-7561-472e-9322-d952a9dcf1ba", "Lake", "83006284-5128-4fad-a877-edad83aa3b9f", "Tó" },
                    { "fca40a44-91f5-46b2-be13-c08222db7b94", "Salt", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Só" },
                    { "fdb99c0d-8090-4df3-91ff-9959dfc7d3ce", "Orange", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Narancs" },
                    { "fefbc6d4-768c-48c2-8319-21eeb5c1d51d", "Coach", "5ca5eddc-16c2-4f8b-bb31-8fbe050ebde7", "Edző" },
                    { "ff49c96e-8b34-4a90-81c4-21b9dbcccea5", "Tomato", "99dd7578-b8e7-4728-9813-9c9bfb9f7f17", "Paradicsom" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Words_TopicId",
                table: "Words",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_WordStatistics_PlayerId",
                table: "WordStatistics",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_WordStatistics_WordId",
                table: "WordStatistics",
                column: "WordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "WordStatistics");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
