using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class _20230527 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e05685b5-6e69-4747-a282-d6c4a35f26a5");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "6f6b38ac-da17-467a-a890-0181abb08965");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9749a65a-200d-47fc-9402-bdf3955440b5");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "bc508cd2-0db1-4c78-8d08-adfcd201ff51");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "14238d69-bcdc-4f2c-9eee-8a02214cceba");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "30bdc2b3-aa79-4fad-8ed4-f0b44b454fd0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3b5d99bc-b9b6-4f3e-a64b-4f33f3fae42f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3f31de49-5c4e-4f24-8b99-21387a856dff");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "479a54d0-4cf4-4c76-8551-006a1e485af4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4851bcd0-498c-4bff-871f-d324ab41b7e4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4a1c36f9-e9a0-4d1c-8dd0-f727b67446d4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5153d2e3-0c9a-4b2e-91eb-ed1abffcc24a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5c444e98-58e9-4438-a589-08bccf34149e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "608b552d-5134-4bcb-94f6-b2c7dacab8a7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "68ff04fc-ff73-42ad-ac6d-8c1664338b17");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6a6f011c-6667-4488-aa58-647c6d810fd5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "75a166f5-2952-4201-b4bc-3ee66d3c39a7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "90ec983e-2c5f-4d22-8c39-3aa44ccc71a0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9757a31a-f635-4e51-b86c-d67a021b3a62");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9818f431-91ce-48ef-9fed-0878a59f4de2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9d8227d3-b049-420c-9377-a264fe2c3764");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a7cb3c50-71a0-42cd-9838-def0a47b10d3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a843dc55-b8af-4c4c-a1c6-8e23e546bb88");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "beb4c76c-d9fa-4207-9601-29bbc2f86852");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c0a10236-ffdf-44dd-b752-cc5c0a0b36bb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cac94c6b-4dbc-40a4-b700-69c2cebcd85e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d1af9757-f0b3-4d3c-b8bd-0e8c07677076");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d3806da7-8498-47af-bd6c-2f4461305fef");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "dc20d280-f009-4b27-b052-24cf33e175c9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "dc6ced7b-7749-46e1-899d-e725c79a2ece");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fe938b14-1a96-434e-9edb-26e617768ebf");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5257a489-8112-47a3-a34d-767d665c25c2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "cfe64dcb-e9a9-471c-a0f4-c97110d900a9");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e4f8cb9d-d365-4cc5-80e4-9a3a003e8234");

            migrationBuilder.AddColumn<int>(
                name: "CorrectGuesses",
                table: "WordStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncorrectGuesses",
                table: "WordStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlayerName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4e3c2278-833f-4c36-9567-ba6db126c4f9", 0, "93fe5985-3ae3-4aaa-a745-46919e8a1407", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEJliqkLzVYiFtEMF7nanI/ArKDuwBK9BGcP7xBOCUjI2pPiDv56/IjsM2oaWT2mrTQ==", null, false, "SeedPlayer", "22943c27-0011-4484-8724-57fcf929a83b", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "113c7ee1-802f-4855-a2d0-55cffe943c0b", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" },
                    { "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Learn how to address your or your partner's family at gatherings.", "Family" },
                    { "5dd7c2f6-9261-431f-968f-bf072f0909df", "Words related to traveling abroad.", "Travel" },
                    { "5fce3c94-b8d0-4c9f-ab33-429db46996bf", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "e138d205-06d5-447c-9c9d-8b7d5023c139", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "These words will help you cheer for your favorite team.", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "0221bc9e-17fb-4293-8efb-1599ea9a2c80", "Finish", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Cél" },
                    { "0310397b-853d-4d68-a56a-8e1cb4660e52", "Opponent", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Ellenfél" },
                    { "0ed80c94-0e50-4187-9457-9741771ad58c", "Swimming", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Úszás" },
                    { "1ed56a1a-0d41-4d16-92bd-e1cad2159545", "Running", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Futás" },
                    { "2d5cd120-4432-4ec2-8ca5-d0c679d83dbc", "Rope", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Kötél" },
                    { "30766bd1-1892-4be7-bd58-65ad057b8cf3", "Pea", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Borsó" },
                    { "372ca771-69fb-4f69-a0dd-c04b1140aca5", "Mother", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Anya" },
                    { "455ef039-62d2-4482-af97-305f2cf96a36", "Stadium", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Stadion" },
                    { "4cfed6e5-fc15-472c-b82c-1574b071f6f1", "Mushroom", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Gomba" },
                    { "5d01043c-ec9c-4856-89ac-c20a6ddb575c", "Mother-in-law", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Anyós" },
                    { "65eca4d3-3b1d-47d9-80bb-3fbbc230b508", "Father-in-law", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Após" },
                    { "6754b19a-3024-4288-be4e-1a9a882e025f", "Aunt", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Nagynéni" },
                    { "750cd415-f6b7-4492-b024-283e337f797f", "Carrot", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Répa" },
                    { "7eed3cb8-d3a9-48f4-a1cd-3dcc08e55d59", "Uncle", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Nagybácsi" },
                    { "8294b229-d800-47c2-91f9-95b8e8ee1bd1", "Lemon", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Citrom" },
                    { "a08b38f8-04e6-4204-a34d-410c2e8a2920", "Father", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Apa" },
                    { "a1d23303-e174-412c-b501-9a3428fd474a", "Final", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Döntő" },
                    { "bd1cefce-4d46-4cd0-86c9-7333fa591fef", "Corn", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Kukorica" },
                    { "c2d79916-4192-4c25-ad02-18d8aa598bf7", "Grandfather", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Nagypapa" },
                    { "cc0c9de4-d1df-4609-8b51-0e6319ae4767", "Broccoli", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Brokkoli" },
                    { "ce12bdd7-bbd0-42f4-982f-945cfa7a171d", "Grandmother", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Nagymama" },
                    { "d0f665ff-d052-4235-925b-06ef7f273f06", "Rice", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Rizs" },
                    { "d42e1925-c0c8-41a3-a1f9-951c8a76d027", "Peach", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Barack" },
                    { "d524e424-bd81-4dbd-b31e-6c7bbc12faca", "Coach", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Edző" },
                    { "e1ce0a94-b71f-49dc-9d42-84abff5ba21a", "Grandfather", "160d157c-cbc2-4380-bfb9-6a6a47bf6989", "Nagyapa" },
                    { "ea14b086-3b0e-4f0e-af7e-777916516b30", "Bean", "113c7ee1-802f-4855-a2d0-55cffe943c0b", "Bab" },
                    { "faafdb4a-c206-4668-9fe6-8b187cb8de00", "Team", "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce", "Csapat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e3c2278-833f-4c36-9567-ba6db126c4f9");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5dd7c2f6-9261-431f-968f-bf072f0909df");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5fce3c94-b8d0-4c9f-ab33-429db46996bf");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e138d205-06d5-447c-9c9d-8b7d5023c139");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0221bc9e-17fb-4293-8efb-1599ea9a2c80");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0310397b-853d-4d68-a56a-8e1cb4660e52");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0ed80c94-0e50-4187-9457-9741771ad58c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1ed56a1a-0d41-4d16-92bd-e1cad2159545");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2d5cd120-4432-4ec2-8ca5-d0c679d83dbc");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "30766bd1-1892-4be7-bd58-65ad057b8cf3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "372ca771-69fb-4f69-a0dd-c04b1140aca5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "455ef039-62d2-4482-af97-305f2cf96a36");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4cfed6e5-fc15-472c-b82c-1574b071f6f1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5d01043c-ec9c-4856-89ac-c20a6ddb575c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "65eca4d3-3b1d-47d9-80bb-3fbbc230b508");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6754b19a-3024-4288-be4e-1a9a882e025f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "750cd415-f6b7-4492-b024-283e337f797f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "7eed3cb8-d3a9-48f4-a1cd-3dcc08e55d59");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8294b229-d800-47c2-91f9-95b8e8ee1bd1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a08b38f8-04e6-4204-a34d-410c2e8a2920");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a1d23303-e174-412c-b501-9a3428fd474a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bd1cefce-4d46-4cd0-86c9-7333fa591fef");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c2d79916-4192-4c25-ad02-18d8aa598bf7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cc0c9de4-d1df-4609-8b51-0e6319ae4767");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ce12bdd7-bbd0-42f4-982f-945cfa7a171d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d0f665ff-d052-4235-925b-06ef7f273f06");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d42e1925-c0c8-41a3-a1f9-951c8a76d027");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d524e424-bd81-4dbd-b31e-6c7bbc12faca");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e1ce0a94-b71f-49dc-9d42-84abff5ba21a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ea14b086-3b0e-4f0e-af7e-777916516b30");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "faafdb4a-c206-4668-9fe6-8b187cb8de00");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "113c7ee1-802f-4855-a2d0-55cffe943c0b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "160d157c-cbc2-4380-bfb9-6a6a47bf6989");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e8b7b57e-a2fb-4c03-a3a2-1031898f59ce");

            migrationBuilder.DropColumn(
                name: "CorrectGuesses",
                table: "WordStatistics");

            migrationBuilder.DropColumn(
                name: "IncorrectGuesses",
                table: "WordStatistics");

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
        }
    }
}
