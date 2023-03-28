using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d266f818-d255-4b9f-adbf-c866c68d9609");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlayerName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5bcff92-c0bc-4eca-8155-af2e96520a60", 0, "a10f5ca0-fcd9-4272-8ea0-5f9d932e1e89", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEI2bRoKvO0V95+rmhvkyCIbvOVOZIzdaAAL/j1pNi9djW2/j87vN28h9IAj3yg1oXg==", null, false, "SeedPlayer", "52f5bfc3-c7ec-41b1-9527-be246a471a69", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "263323b5-4a07-470d-a70f-bcfa9bc31a52", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "36beb080-cc92-49a1-b695-982bd6d6fced", "Learn how to address your or your partner's family at gatherings.", "Family" },
                    { "4cfe0f00-1809-41c8-89f4-88f1643d9e5e", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "502ebbe2-e45c-42b3-95f5-8b3d380ff15b", "Words related to traveling abroad.", "Travel" },
                    { "9dd65c01-6126-4af1-8a74-a775a30991ba", "These words will help you cheer for your favorite team.", "Sports" },
                    { "f22a21a2-1500-49ca-91dd-e5920fee812b", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "2f726723-73da-4713-8cc2-f8bcc0cb0cd4", "Mother-in-law", "36beb080-cc92-49a1-b695-982bd6d6fced", "Anyós" },
                    { "5dbea794-8d23-422c-b7cb-82fb7fcb3a0c", "Father", "36beb080-cc92-49a1-b695-982bd6d6fced", "Apa" },
                    { "636cd12c-15e2-4b17-a96b-a1dabbd950ad", "Mother", "36beb080-cc92-49a1-b695-982bd6d6fced", "Anya" },
                    { "6eac9ea4-f47e-4fd4-8925-d95a951de3df", "Aunt", "36beb080-cc92-49a1-b695-982bd6d6fced", "Nagynéni" },
                    { "753aaea6-7696-48ad-854e-9161c4610b66", "Father-in-law", "36beb080-cc92-49a1-b695-982bd6d6fced", "Após" },
                    { "8c58a2ce-c035-4e3d-83e4-fa4e7ff3d331", "Uncle", "36beb080-cc92-49a1-b695-982bd6d6fced", "Nagybácsi" },
                    { "b7d86a56-5ae7-4204-9735-0e605c1d1b28", "Grandfather", "36beb080-cc92-49a1-b695-982bd6d6fced", "Nagypapa" },
                    { "c3afa9ac-065f-415e-81d2-f0800e291bb3", "Grandmother", "36beb080-cc92-49a1-b695-982bd6d6fced", "Nagymama" },
                    { "f3dd361f-6f2a-4e8e-9fbc-300435cc44ca", "Grandfather", "36beb080-cc92-49a1-b695-982bd6d6fced", "Nagyapa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5bcff92-c0bc-4eca-8155-af2e96520a60");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "263323b5-4a07-470d-a70f-bcfa9bc31a52");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "4cfe0f00-1809-41c8-89f4-88f1643d9e5e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "502ebbe2-e45c-42b3-95f5-8b3d380ff15b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9dd65c01-6126-4af1-8a74-a775a30991ba");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f22a21a2-1500-49ca-91dd-e5920fee812b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2f726723-73da-4713-8cc2-f8bcc0cb0cd4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5dbea794-8d23-422c-b7cb-82fb7fcb3a0c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "636cd12c-15e2-4b17-a96b-a1dabbd950ad");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6eac9ea4-f47e-4fd4-8925-d95a951de3df");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "753aaea6-7696-48ad-854e-9161c4610b66");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8c58a2ce-c035-4e3d-83e4-fa4e7ff3d331");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "b7d86a56-5ae7-4204-9735-0e605c1d1b28");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c3afa9ac-065f-415e-81d2-f0800e291bb3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f3dd361f-6f2a-4e8e-9fbc-300435cc44ca");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "36beb080-cc92-49a1-b695-982bd6d6fced");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlayerName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d266f818-d255-4b9f-adbf-c866c68d9609", 0, "3ae80698-3925-4e85-8a68-d5d9d3ec69d6", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEPl/ncIbm2q6kwaGISjyKbdYg8jyVMR8B9jdAYWG+YC8uwFXMsvZ3udsuStZtu3wGQ==", null, false, "SeedPlayer", "02a6400a-0717-445f-988b-dc23b93d000c", false, "seedplayer@gmail.com" });
        }
    }
}
