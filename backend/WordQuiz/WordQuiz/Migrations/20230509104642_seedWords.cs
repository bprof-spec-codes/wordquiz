using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class seedWords : Migration
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
                values: new object[] { "e05685b5-6e69-4747-a282-d6c4a35f26a5", 0, "f34da1b7-ec61-4e6d-9cde-4ffeebfadba9", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEEAsipOlfrSQEpimSfKVXMmkLnrgEjO4nbK2JlRMyzuAS9gjARM/xKgWV2vlHMZQzw==", null, false, "SeedPlayer", "64e70670-d2ec-4456-bdcd-8fd467a77ad6", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "5257a489-8112-47a3-a34d-767d665c25c2", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" },
                    { "6f6b38ac-da17-467a-a890-0181abb08965", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "9749a65a-200d-47fc-9402-bdf3955440b5", "Words related to traveling abroad.", "Travel" },
                    { "bc508cd2-0db1-4c78-8d08-adfcd201ff51", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Learn how to address your or your partner's family at gatherings.", "Family" },
                    { "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "These words will help you cheer for your favorite team.", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "14238d69-bcdc-4f2c-9eee-8a02214cceba", "Team", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Csapat" },
                    { "30bdc2b3-aa79-4fad-8ed4-f0b44b454fd0", "Corn", "5257a489-8112-47a3-a34d-767d665c25c2", "Kukorica" },
                    { "3b5d99bc-b9b6-4f3e-a64b-4f33f3fae42f", "Peach", "5257a489-8112-47a3-a34d-767d665c25c2", "Barack" },
                    { "3f31de49-5c4e-4f24-8b99-21387a856dff", "Uncle", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Nagybácsi" },
                    { "479a54d0-4cf4-4c76-8551-006a1e485af4", "Mother-in-law", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Anyós" },
                    { "4851bcd0-498c-4bff-871f-d324ab41b7e4", "Father-in-law", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Após" },
                    { "4a1c36f9-e9a0-4d1c-8dd0-f727b67446d4", "Swimming", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Úszás" },
                    { "5153d2e3-0c9a-4b2e-91eb-ed1abffcc24a", "Grandmother", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Nagymama" },
                    { "5c444e98-58e9-4438-a589-08bccf34149e", "Grandfather", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Nagyapa" },
                    { "608b552d-5134-4bcb-94f6-b2c7dacab8a7", "Opponent", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Ellenfél" },
                    { "68ff04fc-ff73-42ad-ac6d-8c1664338b17", "Carrot", "5257a489-8112-47a3-a34d-767d665c25c2", "Répa" },
                    { "6a6f011c-6667-4488-aa58-647c6d810fd5", "Mushroom", "5257a489-8112-47a3-a34d-767d665c25c2", "Gomba" },
                    { "75a166f5-2952-4201-b4bc-3ee66d3c39a7", "Broccoli", "5257a489-8112-47a3-a34d-767d665c25c2", "Brokkoli" },
                    { "90ec983e-2c5f-4d22-8c39-3aa44ccc71a0", "Coach", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Edző" },
                    { "9757a31a-f635-4e51-b86c-d67a021b3a62", "Rope", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Kötél" },
                    { "9818f431-91ce-48ef-9fed-0878a59f4de2", "Grandfather", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Nagypapa" },
                    { "9d8227d3-b049-420c-9377-a264fe2c3764", "Finish", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Cél" },
                    { "a7cb3c50-71a0-42cd-9838-def0a47b10d3", "Mother", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Anya" },
                    { "a843dc55-b8af-4c4c-a1c6-8e23e546bb88", "Pea", "5257a489-8112-47a3-a34d-767d665c25c2", "Borsó" },
                    { "beb4c76c-d9fa-4207-9601-29bbc2f86852", "Running", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Futás" },
                    { "c0a10236-ffdf-44dd-b752-cc5c0a0b36bb", "Stadium", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Stadion" },
                    { "cac94c6b-4dbc-40a4-b700-69c2cebcd85e", "Rice", "5257a489-8112-47a3-a34d-767d665c25c2", "Rizs" },
                    { "d1af9757-f0b3-4d3c-b8bd-0e8c07677076", "Lemon", "5257a489-8112-47a3-a34d-767d665c25c2", "Citrom" },
                    { "d3806da7-8498-47af-bd6c-2f4461305fef", "Bean", "5257a489-8112-47a3-a34d-767d665c25c2", "Bab" },
                    { "dc20d280-f009-4b27-b052-24cf33e175c9", "Final", "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234", "Döntő" },
                    { "dc6ced7b-7749-46e1-899d-e725c79a2ece", "Father", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Apa" },
                    { "fe938b14-1a96-434e-9edb-26e617768ebf", "Aunt", "cfe64dcb-e9a9-471c-a0f4-c97110d900a9", "Nagynéni" }
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
