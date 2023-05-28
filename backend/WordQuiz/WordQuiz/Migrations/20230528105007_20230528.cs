using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class _20230528 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6f755a44-4e17-4bfc-9379-87b9156e46c3", 0, "06b48572-c4cd-4d90-aaf4-2cd15f45ee23", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAEEP75QjLG6iQT73FraYXQNNKPYNbxNNWMX80doXgeg60zuXNSFhs2MRCNMEuFrxpSg==", null, false, "SeedPlayer", "fd6336cd-0bf5-40bc-a008-47b4be6a06a6", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "2a0e8a42-15c1-4ff1-86bd-713977dd927d", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "301e3814-6756-45a1-8593-059e387c0ee9", "These words will help you cheer for your favorite team.", "Sports" },
                    { "930a39f6-5f49-4e70-925f-d5cfb986616b", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "9a8636be-cf28-4956-b2d4-5febb0c65766", "Learn how to address your or your partner's family at gatherings.", "Family" },
                    { "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" },
                    { "ecf340dd-8c1e-4537-bb15-e0f79a323252", "Words related to traveling abroad.", "Travel" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "0aa32f96-d418-4a14-8852-d4c8b892e029", "Uncle", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Nagybácsi" },
                    { "0c40796d-c469-4ff1-a8e1-6069ab0791f1", "Grandfather", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Nagypapa" },
                    { "21c86026-f37d-43b5-bc1e-b437b32c6e14", "Aunt", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Nagynéni" },
                    { "27a298b8-6bc2-460a-b89d-27b7bbd46728", "Lemon", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Citrom" },
                    { "2dd8da26-4c4e-4ec9-b566-d34aea952328", "Grandfather", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Nagyapa" },
                    { "39f1a884-c5a8-4c35-ae0d-1af53317c23e", "Coach", "301e3814-6756-45a1-8593-059e387c0ee9", "Edző" },
                    { "49af2d3d-a921-4d3a-a3b4-bcb63aa403a7", "Father", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Apa" },
                    { "51a979fb-aed1-435a-86b1-8b1afb6bd10a", "Broccoli", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Brokkoli" },
                    { "63942b08-799c-4ffa-abeb-6075255dfdab", "Carrot", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Répa" },
                    { "67fcae3b-1131-4b3d-a973-65d6ed355bd3", "Stadium", "301e3814-6756-45a1-8593-059e387c0ee9", "Stadion" },
                    { "6b906fef-b602-4168-a1ac-4cae74f50363", "Father-in-law", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Após" },
                    { "6d28a45d-40f0-4cad-92b6-da02b9cf7889", "Bean", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Bab" },
                    { "713b1bb3-ca29-4d85-9fac-33fe02484a4b", "Corn", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Kukorica" },
                    { "7200e70a-420b-4897-8c2f-e43404a81eb4", "Mushroom", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Gomba" },
                    { "797dbb0c-d15a-4c37-9254-91181d406e87", "Running", "301e3814-6756-45a1-8593-059e387c0ee9", "Futás" },
                    { "8f52c11f-f299-4f9b-8fe0-f06c63deabed", "Finish", "301e3814-6756-45a1-8593-059e387c0ee9", "Cél" },
                    { "90b4e8a8-603e-4316-914e-7ec52d72b463", "Mother-in-law", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Anyós" },
                    { "9cc43b61-f755-4e8b-b102-c2589cf524d1", "Final", "301e3814-6756-45a1-8593-059e387c0ee9", "Döntő" },
                    { "a7962a19-ed19-4904-b331-3916fc67b178", "Swimming", "301e3814-6756-45a1-8593-059e387c0ee9", "Úszás" },
                    { "a84ce285-ddb2-47e1-b1a3-5a9bb48e46e9", "Pea", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Borsó" },
                    { "aa868458-5165-4708-ade6-2c8a34a0c867", "Grandmother", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Nagymama" },
                    { "b9a5b082-0338-4365-b28f-9ed2ccb0d6b9", "Rope", "301e3814-6756-45a1-8593-059e387c0ee9", "Kötél" },
                    { "bd218318-17bb-4a74-9e9d-fbe341ce2f59", "Team", "301e3814-6756-45a1-8593-059e387c0ee9", "Csapat" },
                    { "cf04ac15-46a9-4ecd-b4e0-ccdbc3937651", "Mother", "9a8636be-cf28-4956-b2d4-5febb0c65766", "Anya" },
                    { "cf4b40f2-4ac9-4fbd-a0f6-86699cafc67b", "Peach", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Barack" },
                    { "d415768b-6d06-49f8-91f6-b252880753ab", "Opponent", "301e3814-6756-45a1-8593-059e387c0ee9", "Ellenfél" },
                    { "db19bbc6-4206-4b7f-85a1-35b86c75d9d0", "Rice", "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17", "Rizs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f755a44-4e17-4bfc-9379-87b9156e46c3");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "2a0e8a42-15c1-4ff1-86bd-713977dd927d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "930a39f6-5f49-4e70-925f-d5cfb986616b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ecf340dd-8c1e-4537-bb15-e0f79a323252");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0aa32f96-d418-4a14-8852-d4c8b892e029");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0c40796d-c469-4ff1-a8e1-6069ab0791f1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "21c86026-f37d-43b5-bc1e-b437b32c6e14");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "27a298b8-6bc2-460a-b89d-27b7bbd46728");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2dd8da26-4c4e-4ec9-b566-d34aea952328");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "39f1a884-c5a8-4c35-ae0d-1af53317c23e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "49af2d3d-a921-4d3a-a3b4-bcb63aa403a7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "51a979fb-aed1-435a-86b1-8b1afb6bd10a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "63942b08-799c-4ffa-abeb-6075255dfdab");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "67fcae3b-1131-4b3d-a973-65d6ed355bd3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6b906fef-b602-4168-a1ac-4cae74f50363");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6d28a45d-40f0-4cad-92b6-da02b9cf7889");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "713b1bb3-ca29-4d85-9fac-33fe02484a4b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "7200e70a-420b-4897-8c2f-e43404a81eb4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "797dbb0c-d15a-4c37-9254-91181d406e87");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8f52c11f-f299-4f9b-8fe0-f06c63deabed");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "90b4e8a8-603e-4316-914e-7ec52d72b463");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9cc43b61-f755-4e8b-b102-c2589cf524d1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a7962a19-ed19-4904-b331-3916fc67b178");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a84ce285-ddb2-47e1-b1a3-5a9bb48e46e9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "aa868458-5165-4708-ade6-2c8a34a0c867");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "b9a5b082-0338-4365-b28f-9ed2ccb0d6b9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bd218318-17bb-4a74-9e9d-fbe341ce2f59");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cf04ac15-46a9-4ecd-b4e0-ccdbc3937651");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cf4b40f2-4ac9-4fbd-a0f6-86699cafc67b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d415768b-6d06-49f8-91f6-b252880753ab");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "db19bbc6-4206-4b7f-85a1-35b86c75d9d0");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "301e3814-6756-45a1-8593-059e387c0ee9");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9a8636be-cf28-4956-b2d4-5febb0c65766");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a3ca0ece-3fa0-4978-ba80-0e6a0033ab17");

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
    }
}
