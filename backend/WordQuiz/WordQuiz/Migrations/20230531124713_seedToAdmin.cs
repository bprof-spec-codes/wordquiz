using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class seedToAdmin : Migration
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
                values: new object[] { "66b21145-d508-4234-9464-97ded4cf805a", 0, "d631b54b-4240-45c4-bde6-c2f24ac0d489", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAELcExb9V5J4E19rWmBPjjHbDN1TUAx1U2s1tet4Z5oR7HSb7K5a14nl38CNgrqZlTA==", null, false, "SeedPlayer", "a74cc864-3b8f-49ba-8ed4-15129d8136ca", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "These words will help you cheer for your favorite team.", "Sports" },
                    { "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Words related to traveling abroad.", "Travel" },
                    { "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "90dd5f7c-c22a-4a74-8139-c94da35edc45", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" },
                    { "a3626b87-e171-4417-af81-3d55a17a4803", "Learn how to address your or your partner's family at gatherings.", "Family" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "66b21145-d508-4234-9464-97ded4cf805a" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "029f88f6-076d-46e3-bbd1-6e264b14bb41", "Compost bin", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Komposztáló" },
                    { "03072284-06b8-4d8a-a4f1-1edb80c13c8f", "Train", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Vonat" },
                    { "03088e60-e337-401b-876a-04011be6a3b6", "Luggage", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Csomag" },
                    { "03d3d594-d66e-4262-80e2-3d5db09061d4", "Scarf", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Sál" },
                    { "076a8a96-e01c-4a10-af9d-19ee31a123b2", "Egg", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Tojás" },
                    { "07a80b0e-18a3-4136-b562-5a798229b217", "Hotel", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Szálloda" },
                    { "07bbba5c-b015-4f47-9b7f-3fb7ebd66031", "Great-granddaughter", "a3626b87-e171-4417-af81-3d55a17a4803", "Dédunoka" },
                    { "08d84742-0237-4680-b347-854710881c46", "Daughter", "a3626b87-e171-4417-af81-3d55a17a4803", "Lánya" },
                    { "094cf5b8-d5d4-4350-b8e3-f56400308a33", "Handbag", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Kézitáska" },
                    { "099b7383-327f-4a4b-8d13-df8388c8293d", "Boarding pass", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Beszállókártya" },
                    { "0a292a14-2afe-4390-ab4e-88cc3b1729f8", "Archery", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Íjászat" },
                    { "0c68b910-9dbe-46ca-83d5-fbfbb199fd3c", "Boots", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Csizma" },
                    { "0cc7d5d8-8e4d-4788-b249-58eb66bf4e21", "Referee", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Játékvezető" },
                    { "0ce09eb7-9b1a-4ab9-ae29-dd2a5445fd36", "T-shirt", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Póló" },
                    { "0d88145a-b2ef-431a-8f13-74483f928b7b", "Suitcase", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Bőrönd" },
                    { "0e84f7e1-afa8-4331-993b-7ab7d250740b", "Fashionable", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Divatos" },
                    { "0fd174c9-6a98-4059-b722-280e91ac9b7c", "Adventure", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Kaland" },
                    { "10ad8e75-0750-4830-8549-b8dda8735cb6", "Grandmother", "a3626b87-e171-4417-af81-3d55a17a4803", "Nagymama" },
                    { "11fcb03e-ec29-4e8b-8bf2-158d1ff5bc5c", "Half-sister", "a3626b87-e171-4417-af81-3d55a17a4803", "Félnővér" },
                    { "1203b806-0bd8-4367-83f6-ffb0f24bdd99", "Garden gloves", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti kesztyű" },
                    { "163c26bc-1174-4eda-8538-88ff669f7c09", "Tomato", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Paradicsom" },
                    { "18829a9c-df0c-4c9d-9b6d-e212a50435db", "Peach", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Barack" },
                    { "204c6e83-6195-44a8-8bc8-66394bf0c7a8", "Pajamas", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Pizsama" },
                    { "20ddd5ca-c14c-4e65-b80a-e8f6b0951d14", "Finish", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Cél" },
                    { "21a5e4ad-041b-4ee2-bb94-997bd5b77dba", "Banana", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Banán" },
                    { "21c1448b-d464-49b9-b5ac-16915494f4ed", "Boxing", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Boksz" },
                    { "2598aca6-6f65-4e16-960c-e1bd54d23f38", "Grapes", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Szőlő" },
                    { "2616e0f4-21ae-457a-b9a6-5aa251d88260", "Sugar", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Cukor" },
                    { "26a49f34-4f0c-4f8c-9fc6-2787e13e9b3e", "Wallet", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Pénztárca" },
                    { "28927ecf-37c4-4066-a491-e619254a997f", "Stepson", "a3626b87-e171-4417-af81-3d55a17a4803", "Mostohafiú" },
                    { "29f9dfbb-2a7e-4045-9138-eebd4998a42e", "Butter", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Vaj" },
                    { "2ba21e05-f00b-44ff-90b7-4822c7dacc73", "Island", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Sziget" },
                    { "2ce46178-ffe6-4c40-866a-e153f5a1ec17", "Garden rake", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti gereblye" },
                    { "31b20862-21a9-45d1-8120-7b5f39437b45", "Watch", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Óra" },
                    { "320905d1-e42d-410d-96d5-be6618e9ee0f", "Raking", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Gereblyézés" },
                    { "3328a458-d709-4076-b90f-11a96fedf070", "Bread", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Kenyér" },
                    { "3353fdc6-e153-425c-aec8-f762f3e18750", "Coat", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Kabát" },
                    { "34d0b1af-b46d-4dcd-ad5c-897cb2fd49ea", "Socks", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Zokni" },
                    { "39e2b4c8-c450-4eb9-9726-b3eb477b6baf", "Underwear", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Alsónemű" },
                    { "3c8286c0-68f8-440b-b122-6ef11eb75326", "Medal", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Érem" },
                    { "3cb9a5e1-6fe0-4299-bd64-4081cda4be59", "Father-in-law", "a3626b87-e171-4417-af81-3d55a17a4803", "Após" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "3e720743-ceb5-4a8d-965e-9a6d55cee80c", "Athletics", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Atlétika" },
                    { "3f26cfab-914c-46e6-8c55-1fc2462312d7", "Cycling", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Kerékpározás" },
                    { "400e55ac-0d54-43e5-a43e-d89d32e14831", "Cucumber", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Uborka" },
                    { "4486bae2-a628-4cfd-a0b1-86e103d02855", "Garden hose", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti tömlő" },
                    { "4543a8ba-0d70-43f5-a275-86bf70a6e19f", "Garden sprayer", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti permetező" },
                    { "47874879-d0bc-4e7c-88d0-b6b175f863a5", "Ticket", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Jegy" },
                    { "484d5a2c-1d5d-4acd-a30a-4dc6e5b293e5", "Wrestling", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Birkózás" },
                    { "48ccd606-1734-46f6-8119-6da11395af85", "Tourist", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Turista" },
                    { "48eb9b21-a5f7-47a4-b5e5-947f1a80d76c", "Rice", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Rizs" },
                    { "4c400c4c-79f1-438b-99ac-736e880fdc04", "Sightseeing", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Városnézés" },
                    { "4ed8129c-1d44-44cf-aacf-b854eb496001", "Karate", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Karate" },
                    { "52ea22a7-adeb-40bb-831e-28aca7d0f525", "Garden cart", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti szekér" },
                    { "53496c82-ee05-408c-b8da-505e8358fd56", "Watermelon", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Görögdinnye" },
                    { "53c1322b-a3e1-4f34-97a0-f64f24a68b6f", "Shirt", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Ing" },
                    { "544c6413-9bd3-443c-b0b6-025e95aa516d", "Team", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Csapat" },
                    { "549f9a77-1e47-4cc0-8929-562792650287", "Reception", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Recepció" },
                    { "54a07b84-e887-4f77-b298-f946226d856f", "Diving", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Merülés" },
                    { "55ebe2cb-7f92-4c6e-8561-dfb8f245a0b6", "Apple", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Alma" },
                    { "562649e7-016d-4a62-912b-9d8202e11086", "Great-grandmother", "a3626b87-e171-4417-af81-3d55a17a4803", "Dédnagymama" },
                    { "567b19ef-3f56-4d6c-b4a4-a22f5bdf9b3f", "Grandfather", "a3626b87-e171-4417-af81-3d55a17a4803", "Nagypapa" },
                    { "56ae2976-bac2-4724-9bc3-06775c0cf249", "Bean", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Bab" },
                    { "581425f2-373f-42f2-9735-77af33685a21", "Golf", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Golf" },
                    { "59549e43-e629-4736-91e6-4fbb7a300fd7", "Stadium", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Stadion" },
                    { "59cfe750-391f-4022-a990-976e4ed34107", "Passport", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Útlevél" },
                    { "5dab28cb-aa72-477e-9271-e3bb8c5277ce", "Garden fork", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti villa" },
                    { "5ec5cb8e-5f2e-4a5a-98f8-444df3a00b7d", "Aunt", "a3626b87-e171-4417-af81-3d55a17a4803", "Nagynéni" },
                    { "5ff9683f-9552-4a4e-9f43-bded903163d0", "Basketball", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Kosárlabda" },
                    { "6017f634-09ff-4c86-9530-983666eca343", "Salt", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Só" },
                    { "609ca916-3b90-4313-b9e6-5514bfef7346", "Trousers", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Nadrág" },
                    { "633d23d3-2020-4070-bd6c-a8d1d0586a73", "Airline", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Légitársaság" },
                    { "6728addb-59e7-4532-8987-17fa3c52817f", "Tie", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Nyakkendő" },
                    { "68f47182-240c-4f07-b065-ce7545bdffa6", "Strawberry", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Eper" },
                    { "69151328-0c92-4219-a744-b94132196be1", "Taxi", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Taxi" },
                    { "6928d1e0-336d-4533-b869-068b0f240e70", "Shoes", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Cipő" },
                    { "6a8b7e15-6436-4d63-bbcc-e97d153449d1", "Dress", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Ruha" },
                    { "6b9bc1bf-44bb-461f-9b6d-b11d9167ebfa", "Half-brother", "a3626b87-e171-4417-af81-3d55a17a4803", "Félfivér" },
                    { "6d5eda65-2c2a-4459-a7de-1e9b27254cf4", "Beach", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Strand" },
                    { "6ee3188d-b74e-4d5a-8e3d-24a492512d52", "Orange", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Narancs" },
                    { "74c05452-35f4-4b77-b8fd-78e75dedebd4", "Surfing", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Szörfözés" },
                    { "7595ad6f-0f5f-4d75-a3e3-b67772f1358c", "Cap", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Sapka" },
                    { "7686521a-10f4-4a00-aa3b-079c29de3685", "Champion", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Bajnok" },
                    { "76c94983-7695-4c5e-8e72-7f406b31411d", "Jeans", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Farmernadrág" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "77c69054-f15f-49d1-91f8-d66b8fc9223e", "Baseball", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Baseball" },
                    { "78c2ffaa-26d4-4144-801a-f6abd3d4a72c", "Sister", "a3626b87-e171-4417-af81-3d55a17a4803", "Húg" },
                    { "79447893-c38b-4d5a-b62d-79f3f4658235", "Fish", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Hal" },
                    { "7a536aa1-197a-49b4-aeaf-769e740eb66d", "Stepmother", "a3626b87-e171-4417-af81-3d55a17a4803", "Mostohaanya" },
                    { "7aa6442b-1cf4-4399-8d55-8a3f9f2d41fe", "Soil", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Termőföld" },
                    { "7b3640ad-1080-4973-8ed5-7aa64ea58d38", "Opponent", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Ellenfél" },
                    { "7b8a2e4b-7484-4dd6-ad0e-a98540bd9cb4", "Potato", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Krumpli" },
                    { "7d2f6039-3331-4f0c-9889-bcce2df21634", "Garden gnome", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti törpe" },
                    { "7f643b24-02fc-4820-96b7-ae53a11b3fde", "Seed", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Mag" },
                    { "7f8a7a8d-2456-4fc5-a86d-97f8a0a423da", "Mother", "a3626b87-e171-4417-af81-3d55a17a4803", "Anya" },
                    { "7fbe9429-fe06-40f5-8f37-884c7650235f", "Son", "a3626b87-e171-4417-af81-3d55a17a4803", "Fia" },
                    { "83c8ac13-2ea2-4c5e-beb8-31132826d376", "Broccoli", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Brokkoli" },
                    { "850c889f-2b76-4fe8-9337-f6e3ecaa2e57", "Lemon", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Citrom" },
                    { "85d4b5e3-0c4e-4197-91c3-2ffd47dad43b", "Airport", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Reptér" },
                    { "87709b3f-43c7-4f23-bf3f-a9b666ca2383", "Skiing", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Síelés" },
                    { "8c037be8-6e47-4445-9208-891b621ce909", "Stepdaughter", "a3626b87-e171-4417-af81-3d55a17a4803", "Mostohalány" },
                    { "9083f7f7-f128-42f6-aa42-d2b413f9f9dc", "Brother", "a3626b87-e171-4417-af81-3d55a17a4803", "Fivér" },
                    { "93e354ed-1c22-4521-893e-d87e4b7b20b4", "Coach", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Edző" },
                    { "9b514f4a-9b53-403d-9fe0-f4b61966a9f4", "Meat", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Hús" },
                    { "9b53d34d-c160-4c88-86a2-0679f1a87ac6", "Dirt", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Föld" },
                    { "9d4e90b2-6e1d-4b35-bcca-317b2961b2e8", "Hockey", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Hoki" },
                    { "9dcad437-c1b3-49a0-a19c-5860d822b501", "Garden stake", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti tüske" },
                    { "9fccd5d0-0039-416d-86f2-e189c25135ae", "Great-grandfather", "a3626b87-e171-4417-af81-3d55a17a4803", "Dédnagypapa" },
                    { "a0130b40-240e-470c-ad26-e06b4512be75", "Volleyball", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Röplabda" },
                    { "a291e160-8b80-49cb-9ab6-c2b2be385b62", "Bus", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Busz" },
                    { "ad133d93-8594-49fa-b8ee-3f305b28011a", "Gym", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Edzőterem" },
                    { "ad26f5ef-a81b-459a-8372-7255976a8fb9", "Destination", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Célállomás" },
                    { "adf29173-2fd9-4a85-b30e-985ccb010a30", "Gymnastics", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Gimnasztika" },
                    { "aeed3a13-b78c-40f0-9259-2634d8811069", "Corn", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Kukorica" },
                    { "b027c7ad-4bee-4b8c-8c88-022fd13f8708", "Great-grandson", "a3626b87-e171-4417-af81-3d55a17a4803", "Dédunoka" },
                    { "b0f0ca11-d058-4184-8a13-be40a8e1f577", "Final", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Döntő" },
                    { "b1a2bf8d-6955-4deb-a2a0-766e91698e35", "Father", "a3626b87-e171-4417-af81-3d55a17a4803", "Apa" },
                    { "b35becc1-0300-4488-b09c-ec391e7bf610", "Running", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Futás" },
                    { "b4ddce81-e5de-490d-bf68-4014b6bc4763", "Bathrobe", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Fürdőköpeny" },
                    { "b4f16b33-0f8d-4aa9-bbc8-df990f46959f", "Ice cream", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Fagylalt" },
                    { "b51d8c23-31fe-4e28-866d-a250092ce012", "Garden hoe", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti kapa" },
                    { "b93e2950-1a57-4377-b6f7-ac1225a97d4d", "Rake", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Gereblye" },
                    { "ba390d74-b766-41bb-9837-99ce39e8dbd2", "Lawn mowing", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Fűnyírás" },
                    { "bb036f1c-6544-4e11-a330-c8f4d5a6f0d1", "Service", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Szolgáltatás" },
                    { "bc1d803a-1581-4b01-ac92-413c21109fc9", "Wheelbarrow", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Talicska" },
                    { "bc2fd609-6459-4a2a-91a7-e14fd906b9ea", "Hat", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Kalap" },
                    { "bc99bbc6-fc36-4f31-90d9-9045e51f7f4a", "Lake", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Tó" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "bd81f085-594f-4235-a4de-4b760006d084", "Currency", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Pénznem" },
                    { "c00306a9-3fad-47fc-80b8-8ac3521e9856", "Bikini", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Bikini" },
                    { "c09074ad-1fbd-4a8c-9a5e-ac9db88ba3d9", "Souvenir", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Szouvenir" },
                    { "c26ebee5-a824-444b-8478-ffe7b87a90c4", "Skirt", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Szoknya" },
                    { "c38ce348-80aa-4941-bfe3-71afdf453ab7", "Pruning shears", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Metszőolló" },
                    { "c48dca60-73c8-4d40-a48b-8d1b3248d7b8", "Bracelet", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Karkötő" },
                    { "c4ea547b-985d-44bd-9100-82fdb4bcc53f", "Mountain", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Hegy" },
                    { "ca458f72-74f8-4162-aff9-2c20a3efbd6f", "Pruner", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Metszőolló" },
                    { "cd2ee3b1-8335-4d93-ac3b-036d2bc0dcad", "Garden trowel", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti talicska" },
                    { "d07159cb-3c65-4c28-9423-9c39861b1e7c", "Shovel", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Ásó" },
                    { "d14e1367-ef02-43e4-b713-cb9114d37558", "Niece", "a3626b87-e171-4417-af81-3d55a17a4803", "Unokahúg" },
                    { "d1e31d0f-2cf8-4c00-bc5e-a1b9a2f6eba0", "Brother-in-law", "a3626b87-e171-4417-af81-3d55a17a4803", "Sógor" },
                    { "d3aa30e8-6b83-4a6b-858f-9b8ee1513399", "Cousin", "a3626b87-e171-4417-af81-3d55a17a4803", "Unokatestvér" },
                    { "d44b847b-b6eb-40f8-9728-cd400e69ad19", "Delay", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Késés" },
                    { "d53f7e60-9d0b-4784-bde1-1e18ac2a96ae", "Garden bench", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti pad" },
                    { "d689378c-d92e-46ad-bead-5a298debc34d", "Mother-in-law", "a3626b87-e171-4417-af81-3d55a17a4803", "Anyós" },
                    { "d76bbfff-a97f-4511-83d4-3fa31e4d7d6f", "Sweater", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Pulóver" },
                    { "d837b78d-ced4-4eb2-8079-ab278bdc64ab", "Pepper", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Bors" },
                    { "da2a21f2-7a0d-4c72-b938-ea1dbf175992", "Ferry", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Komp" },
                    { "daf243b4-0749-412f-98c7-57ba58e5616e", "Swimsuit", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Fürdőruha" },
                    { "db5eb7ac-6ef9-42be-9142-4a96ee432ce1", "Mushroom", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Gomba" },
                    { "db9f0e8c-fc14-4b1f-a1bd-c0ec946d9546", "Cheese", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Sajt" },
                    { "dbdfa678-7810-4caa-add6-047a398a892b", "Grandfather", "a3626b87-e171-4417-af81-3d55a17a4803", "Nagyapa" },
                    { "dc5910be-6edf-4f99-a323-9f134dca61db", "Garden trellis", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Kerti rács" },
                    { "dcade8da-26ac-4dc2-93cd-16cc19f98d08", "Gloves", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Kesztyű" },
                    { "ddb43bce-aaa2-4bd8-b70f-d45e50303a38", "Plant pot", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Növényi edény" },
                    { "de37137c-a9dc-4f54-b3d7-3feaa6d20f48", "Hole", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Lyuk" },
                    { "de3a348b-5475-40fa-986a-e7dc8dfe3709", "Nephew", "a3626b87-e171-4417-af81-3d55a17a4803", "Unokaöccs" },
                    { "df1a103e-074a-43df-9187-19b481769e48", "Guide", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Idegenvezető" },
                    { "df57ebfc-3c25-49a7-ab3d-95a93a5d6701", "Map", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Térkép" },
                    { "e058ce51-dbd4-4720-90e5-04fbe785434e", "Football", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Labdarúgás" },
                    { "e38f08d4-c323-4b96-8fce-658f98a1a96c", "Tennis", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Tenisz" },
                    { "e399517e-f7c2-405b-a134-76ed3672eab9", "Godmother", "a3626b87-e171-4417-af81-3d55a17a4803", "Keresztanya" },
                    { "eaae48e3-47a5-4625-a996-cf11ea398446", "Belt", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Öv" },
                    { "eac74ed6-7856-4d7f-ae7d-96a11603f8de", "Honey", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Méz" },
                    { "ebdd57b2-94b6-4c5e-8a8d-90f5ca2e566a", "Jacket", "02c7ee1a-dd21-4e6c-84a6-e4acb4f7b130", "Kabát" },
                    { "ee0848d1-eca6-42e6-929d-f0f0a92f96f8", "Travel agency", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Utazási iroda" },
                    { "ee7a83eb-298b-4f2a-9379-247ef8471c5c", "Flowerpot", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Virágcserép" },
                    { "f0343fb3-8247-4c67-b6e7-4a6c6a00aae2", "Carrot", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Répa" },
                    { "f134e36f-fbf6-4e74-b70a-c5fdc4134093", "Car", "6fb7305d-5041-4fc5-8540-08eb8ee4cb32", "Autó" },
                    { "f1c43c7f-259e-4e0d-815e-8be7918ee111", "Rope", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Kötél" },
                    { "f3661d5b-ae28-4cc3-ac21-872db074280d", "Stepfather", "a3626b87-e171-4417-af81-3d55a17a4803", "Mostohaapa" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "f5cc3a2d-72e9-4afe-8056-46b6d9032a28", "Swimming", "5aeebccf-fab5-41f4-be5d-cac6ce23c557", "Úszás" },
                    { "f667d140-1d9f-4770-844c-d690dfb38490", "Uncle", "a3626b87-e171-4417-af81-3d55a17a4803", "Nagybácsi" },
                    { "f6902519-18ce-49b3-9317-528d9e58cd43", "Sister-in-law", "a3626b87-e171-4417-af81-3d55a17a4803", "Sógornő" },
                    { "f6fcb6cc-5b22-4f97-8899-aaff152ff8fc", "Spade", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Ásó" },
                    { "f7268db6-c035-496b-8566-3e767a112a08", "Godfather", "a3626b87-e171-4417-af81-3d55a17a4803", "Keresztapa" },
                    { "f9abf6aa-be2e-4e60-a444-2a68ea50ba5c", "Pea", "90dd5f7c-c22a-4a74-8139-c94da35edc45", "Borsó" },
                    { "fdf1e53d-67d9-4dfd-a17e-3cd5efa296ce", "Watering can", "77d07ab6-c7c6-40e6-8151-b1b036b4a04b", "Öntözőkanna" }
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
