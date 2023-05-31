using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordQuiz.Migrations
{
    public partial class _seedWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlayerName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ce7248c-40dd-4100-9479-ba188dcaf259", 0, "1c61fbd1-4bf0-4639-b1d2-6fa822f451bc", "Player", "seedplayer@gmail.com", true, false, null, null, "SEEDPLAYER@gmail.com", "AQAAAAEAACcQAAAAENm5xfHW5HtV0YEN47n9N6E9grtGkLZlqco7Q6ozn+bGrdSW5r0Tl4NbEeDPJrwpxw==", null, false, "SeedPlayer", "13f94942-73af-4964-ad47-a47fd1bc8fdd", false, "seedplayer@gmail.com" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { "058be191-523d-4501-b6f6-3bf57263d568", "Words related to traveling abroad.", "Travel" },
                    { "211b3d26-fb6a-438e-af53-d8124e9c0911", "A vocabulary aimed to help you avoid embarrassment while going out to eat.", "Food" },
                    { "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "These words will help you cheer for your favorite team.", "Sports" },
                    { "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Everything you need to know regarding fashion or about simply going shopping for clothes.", "Clothing" },
                    { "b7e85018-1d81-4e39-b50f-e213f95579d2", "Become an Oxford level green-thumb with this vocabulary.", "Gardening" },
                    { "d717aa31-70c0-41b5-8632-3472e63711f2", "Learn how to address your or your partner's family at gatherings.", "Family" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "01eada5d-57dd-469b-b9a5-355e55bee7d2", "Lake", "058be191-523d-4501-b6f6-3bf57263d568", "Tó" },
                    { "03023803-b3cc-4cc8-b6f0-2f1f49000870", "Final", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Döntő" },
                    { "04bf015d-fabf-45bf-b304-a6ad85653083", "Orange", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Narancs" },
                    { "06acdf02-693d-43b0-a9e4-d55d99e1cc67", "Currency", "058be191-523d-4501-b6f6-3bf57263d568", "Pénznem" },
                    { "0745c491-bf21-44bb-977a-83cd1ac6d53a", "Stadium", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Stadion" },
                    { "08f76bbe-9341-442f-9c83-5b521193f0e8", "Skiing", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Síelés" },
                    { "0af3c16b-2cb3-4276-8a99-bfa4c8125cfa", "Sister-in-law", "d717aa31-70c0-41b5-8632-3472e63711f2", "Sógornő" },
                    { "0cc467e2-db0e-41d7-a9aa-f3bce3059b73", "Adventure", "058be191-523d-4501-b6f6-3bf57263d568", "Kaland" },
                    { "0d6a6dc4-4284-4cef-ae71-ae9c2cdaf5a9", "Sugar", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Cukor" },
                    { "0e1d923e-b476-4d21-89fe-d6eb4ac0ddf0", "Bathrobe", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Fürdőköpeny" },
                    { "0ffda06d-c6de-4bb0-9e80-ed1eaaa63cdf", "Gym", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Edzőterem" },
                    { "11c221dd-2a6c-4248-8a2c-af0cc71640a7", "Basketball", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Kosárlabda" },
                    { "1427d0f5-7119-4748-92c6-e56a7615e50e", "Jacket", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Kabát" },
                    { "142a7886-9628-4326-9517-b7ba74534092", "Team", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Csapat" },
                    { "186a0e51-d104-4450-b667-1e61cb5d3656", "Godfather", "d717aa31-70c0-41b5-8632-3472e63711f2", "Keresztapa" },
                    { "18b28cb6-f0ca-4e31-b6a4-36575e024814", "Sister", "d717aa31-70c0-41b5-8632-3472e63711f2", "Húg" },
                    { "1a6752d4-f5fc-422d-b2d1-8ceac2b3cc68", "Peach", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Barack" },
                    { "1d41e060-5ff7-4590-a89b-0fda05f9eb65", "Rake", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Gereblye" },
                    { "1e93c242-653e-440a-98aa-2feaf8b985b1", "Swimming", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Úszás" },
                    { "1f5ed071-bce5-4df7-b746-8df573375fb1", "Beach", "058be191-523d-4501-b6f6-3bf57263d568", "Strand" },
                    { "1ff02caa-610f-4c61-9131-252a25b0f1a0", "Volleyball", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Röplabda" },
                    { "222b14aa-f63f-4ad2-8200-192b00b60a3a", "Bus", "058be191-523d-4501-b6f6-3bf57263d568", "Busz" },
                    { "24de935e-3a9f-4275-9c59-246db878b1f0", "Diving", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Merülés" },
                    { "2784f4ed-25f7-4d50-ba69-645f4eb032eb", "Garden rake", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti gereblye" },
                    { "27d7a53b-cbb1-4f60-80f6-9a586f0d5526", "Great-grandmother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Dédnagymama" },
                    { "298ee59d-0359-4a0e-971f-803ab03ab332", "Cycling", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Kerékpározás" },
                    { "29d48c52-e602-4db5-997e-fab81f04ba1f", "Hockey", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Hoki" },
                    { "2a171a7e-02ec-46e3-a8ae-c32b0610edfd", "Carrot", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Répa" },
                    { "2b0ca402-3d81-4b79-bb7b-6268c97c2d2d", "Pruning shears", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Metszőolló" },
                    { "2b1d5315-9199-4f23-bdd1-af5269132138", "Pea", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Borsó" },
                    { "2c4c52ab-1c12-40d5-b576-0711f3309e05", "Father", "d717aa31-70c0-41b5-8632-3472e63711f2", "Apa" },
                    { "2d0000f0-0938-4924-bbe4-8ccc151cd7e3", "Wrestling", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Birkózás" },
                    { "2d6a69d6-5b44-4f05-9565-efae6569f554", "Lawn mowing", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Fűnyírás" },
                    { "2d952cf9-e68b-417e-9d13-11e350775237", "Airline", "058be191-523d-4501-b6f6-3bf57263d568", "Légitársaság" },
                    { "2f4dfc8c-b64b-4eaa-b1ed-60ec5099fa2e", "Son", "d717aa31-70c0-41b5-8632-3472e63711f2", "Fia" },
                    { "31fdbab7-cee6-4554-83bf-a3e12ad52b83", "Bean", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Bab" },
                    { "322889a7-2d58-41be-8c08-d54f28cf0fbb", "Fish", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Hal" },
                    { "323d5a54-f4cc-413f-a664-a34fef2bf0fc", "Ice cream", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Fagylalt" },
                    { "325a1c43-93ca-4b43-88b9-d7045c87aefc", "Compost bin", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Komposztáló" },
                    { "32da101f-1521-460e-bd1f-933cdc04a108", "Wheelbarrow", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Talicska" },
                    { "332f4070-b4fd-4d7b-997b-2a06b269be6b", "Raking", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Gereblyézés" },
                    { "33327233-88d7-4cec-bcb9-92c624b69c2c", "Soil", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Termőföld" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "35f38af0-10e3-4127-aae8-d924708500b5", "Karate", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Karate" },
                    { "37091163-9574-48f0-807f-ca528b5dd90a", "Great-granddaughter", "d717aa31-70c0-41b5-8632-3472e63711f2", "Dédunoka" },
                    { "3727ab75-4736-4f55-b45f-2bd5d9e57449", "Bracelet", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Karkötő" },
                    { "3ad1f127-be3a-42a2-9ac6-aaee3e01afc3", "Guide", "058be191-523d-4501-b6f6-3bf57263d568", "Idegenvezető" },
                    { "3daa6d99-c778-4750-b9a5-3c217cbc301e", "Banana", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Banán" },
                    { "3eca87c9-0890-4e61-b328-84e18933ba2e", "Garden fork", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti villa" },
                    { "3ed5a587-ad8e-41e9-aa04-b74d525cfcbe", "Dress", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Ruha" },
                    { "3fc5d467-99ad-428c-908d-be694da87023", "Watch", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Óra" },
                    { "4106e5d1-672d-4aae-bd1f-e9b9d772b1bb", "Cucumber", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Uborka" },
                    { "412863f4-b751-44f4-93e3-7e1aac992759", "Stepmother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Mostohaanya" },
                    { "41e672b0-b77a-4677-a380-6f13193dec3d", "Aunt", "d717aa31-70c0-41b5-8632-3472e63711f2", "Nagynéni" },
                    { "42874afe-f962-4daf-b927-aaa88d439ef1", "Pruner", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Metszőolló" },
                    { "44c89a1a-7569-47a0-a639-200c60bee0cb", "Strawberry", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Eper" },
                    { "475af656-d5f6-4884-8c88-385e1d70d8c7", "Potato", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Krumpli" },
                    { "47b97f4c-0a74-4985-97e0-4bb8837ad5a3", "Sightseeing", "058be191-523d-4501-b6f6-3bf57263d568", "Városnézés" },
                    { "4a957b42-d853-48b3-822a-c01f153995ac", "Grandfather", "d717aa31-70c0-41b5-8632-3472e63711f2", "Nagypapa" },
                    { "4d30dae0-ed68-45c4-a693-84fce6668524", "Grandmother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Nagymama" },
                    { "4d385a97-04c6-4e2d-b0c6-3c14b8e3a8e9", "Spade", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Ásó" },
                    { "4e50e2f0-3666-4abf-980c-8a984a15ff50", "Socks", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Zokni" },
                    { "4e57f400-567c-49c5-afde-8f18cd53015d", "Taxi", "058be191-523d-4501-b6f6-3bf57263d568", "Taxi" },
                    { "4e9d4b93-d5f2-4455-82da-32467a54fa71", "Salt", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Só" },
                    { "4fe235f1-f9c6-4a9e-9342-ea6259612c87", "T-shirt", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Póló" },
                    { "50ca6c3f-634a-42cc-b544-f9c92505b6ef", "Pajamas", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Pizsama" },
                    { "52c9328a-e4d7-423f-bc5f-6a3bca53e904", "Stepfather", "d717aa31-70c0-41b5-8632-3472e63711f2", "Mostohaapa" },
                    { "53ae977d-5a53-440d-b7c5-15d26d24c4a5", "Meat", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Hús" },
                    { "59a125f1-ee2d-48ae-b5dc-f60d61d673e2", "Delay", "058be191-523d-4501-b6f6-3bf57263d568", "Késés" },
                    { "5b2548e7-9acd-46a8-9bdd-b1d2143124ed", "Garden stake", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti tüske" },
                    { "5b639996-2d25-49b2-b0c3-59ab14de7179", "Swimsuit", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Fürdőruha" },
                    { "5f0a0443-4555-4ba8-bdba-89188d8923e2", "Seed", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Mag" },
                    { "61bfd035-a269-4616-b496-f276aa00f864", "Tomato", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Paradicsom" },
                    { "62918290-8438-48ce-8527-f689b807f1bb", "Wallet", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Pénztárca" },
                    { "63e3534c-15b6-4f76-89f1-4621a2744d92", "Dirt", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Föld" },
                    { "67845502-4ead-49b7-a487-3656c49eb7c8", "Mushroom", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Gomba" },
                    { "69265688-9884-4690-86e2-9274bbfe86a7", "Cheese", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Sajt" },
                    { "69e526d4-0945-41a9-ab29-135c23478a8e", "Destination", "058be191-523d-4501-b6f6-3bf57263d568", "Célállomás" },
                    { "6e966891-5ba6-4861-8feb-22dcb9dc4288", "Father-in-law", "d717aa31-70c0-41b5-8632-3472e63711f2", "Após" },
                    { "6fe27dc2-2cd1-4745-9d63-a03a4e7e0b41", "Garden bench", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti pad" },
                    { "70bdde49-bb63-466f-bbe1-71bff4373533", "Bread", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Kenyér" },
                    { "711c7cb7-4cc6-4ebb-a8b7-f3873e07ab79", "Tourist", "058be191-523d-4501-b6f6-3bf57263d568", "Turista" },
                    { "718cce81-eff8-4f33-aaf2-1bc2c60b8c11", "Passport", "058be191-523d-4501-b6f6-3bf57263d568", "Útlevél" },
                    { "738d4d8c-178b-44ef-aad6-43ebf2b97477", "Hotel", "058be191-523d-4501-b6f6-3bf57263d568", "Szálloda" },
                    { "757c7ab7-6fbb-4f13-b48f-d0dd85c444f1", "Tennis", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Tenisz" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "76d057d5-9177-47ea-8853-5c0b4674dc37", "Pepper", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Bors" },
                    { "77723b1a-a884-44e1-b994-5b5a3045647e", "Cap", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Sapka" },
                    { "778642db-3d47-42a3-b249-641a8c0cf337", "Hat", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Kalap" },
                    { "787d3919-16de-4c7d-9724-8d187eefa230", "Great-grandfather", "d717aa31-70c0-41b5-8632-3472e63711f2", "Dédnagypapa" },
                    { "79151322-1ee1-4c6a-8722-42cf856013e9", "Honey", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Méz" },
                    { "79b36af8-0f47-46e8-b223-1537ee713844", "Boots", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Csizma" },
                    { "7de9d869-7085-4283-99a9-eb05a607475c", "Ticket", "058be191-523d-4501-b6f6-3bf57263d568", "Jegy" },
                    { "8132b99e-9acf-446d-b2e1-7a61a3b278dd", "Half-sister", "d717aa31-70c0-41b5-8632-3472e63711f2", "Félnővér" },
                    { "8524ff17-dfc3-438a-9e9a-1a1f28ab315d", "Skirt", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Szoknya" },
                    { "85a008fb-b904-423f-9777-1f7ce9d2439b", "Golf", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Golf" },
                    { "85e1e83a-d0a3-4c7b-abc3-2e06e92cf04a", "Uncle", "d717aa31-70c0-41b5-8632-3472e63711f2", "Nagybácsi" },
                    { "87c195f8-760a-41fd-8259-e8999b68a760", "Rope", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Kötél" },
                    { "895447a4-051c-42db-8d80-9a8bf7655f80", "Coach", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Edző" },
                    { "89e03846-091e-4c25-8344-84a40e008c9e", "Map", "058be191-523d-4501-b6f6-3bf57263d568", "Térkép" },
                    { "8cc0e8c4-d32c-4220-91cc-323f373c218d", "Garden gloves", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti kesztyű" },
                    { "8e7f1e8a-17a3-457b-be67-19ac45fc574c", "Fashionable", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Divatos" },
                    { "917ffadf-e008-4e8f-b39a-635555380600", "Garden hoe", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti kapa" },
                    { "928c3618-f9d2-413c-b1ef-8005e6839038", "Scarf", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Sál" },
                    { "94ba16dd-f547-49fd-9247-0023a89233f3", "Sweater", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Pulóver" },
                    { "94c570f6-0e57-4e74-9bed-436cbb89d912", "Half-brother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Félfivér" },
                    { "965d53f4-edf7-420c-8f91-34cd494b21d0", "Gloves", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Kesztyű" },
                    { "969950d1-f1b6-4997-aabc-edf6f21262fb", "Broccoli", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Brokkoli" },
                    { "9820d79c-6bd0-4725-b959-9a4fe39c8843", "Corn", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Kukorica" },
                    { "985cdc76-2604-45dc-9617-d88d19cc41ce", "Mother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Anya" },
                    { "9c1936e5-8c20-411f-8211-b32708420f20", "Mother-in-law", "d717aa31-70c0-41b5-8632-3472e63711f2", "Anyós" },
                    { "9d03b22e-3642-401b-ac11-b40258469175", "Garden sprayer", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti permetező" },
                    { "9d12c34d-a909-4b0c-b93e-dc20a51c39de", "Souvenir", "058be191-523d-4501-b6f6-3bf57263d568", "Szouvenir" },
                    { "9ed2759a-6e44-4bc8-bdb0-ef7868c37421", "Garden trellis", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti rács" },
                    { "9f09e020-069a-44ee-9a4f-a0e642cb5f7e", "Travel agency", "058be191-523d-4501-b6f6-3bf57263d568", "Utazási iroda" },
                    { "9f189fb7-3857-408c-b145-fee4be37c9de", "Brother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Fivér" },
                    { "a0937c30-67e2-4f5e-ad65-7c61d48f1ea0", "Opponent", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Ellenfél" },
                    { "a1a94b03-13e4-4941-9069-0fb16ebf4a25", "Stepdaughter", "d717aa31-70c0-41b5-8632-3472e63711f2", "Mostohalány" },
                    { "a1dac59d-44c8-4022-8411-27aa3ce687f2", "Jeans", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Farmernadrág" },
                    { "a1edabbf-3ffb-49d8-ae21-154ad1b59142", "Suitcase", "058be191-523d-4501-b6f6-3bf57263d568", "Bőrönd" },
                    { "a291e78d-2b14-4d0b-a744-c38d28bcacb5", "Hole", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Lyuk" },
                    { "a688355d-01f4-48fe-b772-d4d212ed8efb", "Service", "058be191-523d-4501-b6f6-3bf57263d568", "Szolgáltatás" },
                    { "a98bb43b-9d20-479f-ba26-cf38fa6d4934", "Stepson", "d717aa31-70c0-41b5-8632-3472e63711f2", "Mostohafiú" },
                    { "a9b71551-519e-4979-a127-186f4e7396a9", "Reception", "058be191-523d-4501-b6f6-3bf57263d568", "Recepció" },
                    { "ac60c8f0-cb69-4571-8d35-fdfb60e9f1b3", "Athletics", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Atlétika" },
                    { "ae7b20bb-a295-4536-96e6-e8dfadf470e7", "Plant pot", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Növényi edény" },
                    { "af028216-4bf5-43cc-b2c1-7c508c768a0d", "Godmother", "d717aa31-70c0-41b5-8632-3472e63711f2", "Keresztanya" },
                    { "b1ee970a-ccd5-46c7-ae14-c262c2784601", "Garden hose", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti tömlő" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "b94b9b0e-5027-48ca-9cbd-f45276f8ac49", "Bikini", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Bikini" },
                    { "bdc65f48-e8fc-4ec9-9353-fcb982e74bab", "Apple", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Alma" },
                    { "be54e9e6-5a53-4371-9ca1-e99276678fba", "Gymnastics", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Gimnasztika" },
                    { "bed28035-bb6e-49bf-9e2a-16a1c893735f", "Football", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Labdarúgás" },
                    { "bf2092ef-b924-453e-a413-2f7734bd25ff", "Airport", "058be191-523d-4501-b6f6-3bf57263d568", "Reptér" },
                    { "bf8ee4e9-6217-46c3-bdcb-4d244b3b1856", "Watering can", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Öntözőkanna" },
                    { "bf8f7883-ce9b-4268-ac3d-99f78609987f", "Medal", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Érem" },
                    { "c1f21270-e043-426c-9230-2e9d7e73382e", "Garden cart", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti szekér" },
                    { "c268549f-cc06-4f24-8101-be1daadf016f", "Finish", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Cél" },
                    { "c45e084b-87ba-4c98-8eee-cf5b2b9ac9c7", "Watermelon", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Görögdinnye" },
                    { "c4de93c8-4781-4cf3-8857-5e1505855377", "Surfing", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Szörfözés" },
                    { "c4e3b70c-10e4-46e0-abdf-75feae5cc49e", "Car", "058be191-523d-4501-b6f6-3bf57263d568", "Autó" },
                    { "c5783716-9815-43fb-9ea5-166765f28a3c", "Niece", "d717aa31-70c0-41b5-8632-3472e63711f2", "Unokahúg" },
                    { "c7ce4d9a-716c-4189-aa09-a6475b73f8fb", "Shovel", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Ásó" },
                    { "c826d8fb-cca7-435f-96dd-5dd87ee17b4f", "Ferry", "058be191-523d-4501-b6f6-3bf57263d568", "Komp" },
                    { "c92ade77-bb83-4aed-a5a7-f61f6338f59c", "Garden trowel", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti talicska" },
                    { "cb1175d2-93d4-42cf-ba92-ef133629c9dd", "Baseball", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Baseball" },
                    { "cbb50883-ba66-4811-9659-05d018d0bd53", "Shirt", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Ing" },
                    { "cc81df8a-e5ce-4352-8add-5245711b4335", "Grandfather", "d717aa31-70c0-41b5-8632-3472e63711f2", "Nagyapa" },
                    { "cecbd99b-d26d-48e0-9da1-ef88ec11a836", "Rice", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Rizs" },
                    { "d0264f44-297e-401e-9eba-c37eb5e91c45", "Running", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Futás" },
                    { "d78a03f5-a502-45ac-9d12-3e2d343afd85", "Coat", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Kabát" },
                    { "da81ea42-40f3-4c67-a8a9-5f61ed9d9c09", "Handbag", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Kézitáska" },
                    { "dab4ec53-c882-4277-8c7d-f70c98794c16", "Flowerpot", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Virágcserép" },
                    { "dc06fe8a-7362-4818-93a7-a759db5ed508", "Archery", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Íjászat" },
                    { "de64811e-5f1e-47bb-92dc-602e5debc1ca", "Nephew", "d717aa31-70c0-41b5-8632-3472e63711f2", "Unokaöccs" },
                    { "e02c59da-ab75-4dcb-b3bf-c1554f3a1061", "Underwear", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Alsónemű" },
                    { "e402b3a5-f7df-46b1-9aa1-696e0a041c9c", "Train", "058be191-523d-4501-b6f6-3bf57263d568", "Vonat" },
                    { "e414ff2a-ba6a-4f31-9f19-5fe9b7c7c393", "Butter", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Vaj" },
                    { "e49a86e4-260b-436d-8034-9a1708715094", "Boxing", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Boksz" },
                    { "e5a9e2e7-667b-48ad-a3a2-e0c5be0dbcf4", "Luggage", "058be191-523d-4501-b6f6-3bf57263d568", "Csomag" },
                    { "e9ec5284-b040-4b23-8e2c-12673e1966cc", "Cousin", "d717aa31-70c0-41b5-8632-3472e63711f2", "Unokatestvér" },
                    { "ebc64c31-0328-4a31-b1f9-9f2ff84b676a", "Champion", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Bajnok" },
                    { "efc6c8c2-cf7b-4915-be2f-fd44e8c2d12d", "Boarding pass", "058be191-523d-4501-b6f6-3bf57263d568", "Beszállókártya" },
                    { "f017de93-1bd3-4706-ba9c-7b2327e8ea90", "Grapes", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Szőlő" },
                    { "f0909c15-4ace-4a1a-8748-c2fc28fcf677", "Lemon", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Citrom" },
                    { "f169605e-567c-4b7b-8d19-8757b466910c", "Shoes", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Cipő" },
                    { "f1b00c5c-7775-4646-98b5-12d206273bf6", "Island", "058be191-523d-4501-b6f6-3bf57263d568", "Sziget" },
                    { "f366d539-ecce-40bb-acd0-38ddece1ce95", "Referee", "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a", "Játékvezető" },
                    { "f5e8941b-7893-4599-b9b3-c0bdec993334", "Mountain", "058be191-523d-4501-b6f6-3bf57263d568", "Hegy" },
                    { "f60fe7ca-5d83-4298-901c-544995511f33", "Brother-in-law", "d717aa31-70c0-41b5-8632-3472e63711f2", "Sógor" },
                    { "f67d678a-6ab4-400d-81da-a58d76d55552", "Egg", "211b3d26-fb6a-438e-af53-d8124e9c0911", "Tojás" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Original", "TopicId", "Translation" },
                values: new object[,]
                {
                    { "fc0ed19a-cf3f-468a-af52-320d94c96707", "Garden gnome", "b7e85018-1d81-4e39-b50f-e213f95579d2", "Kerti törpe" },
                    { "fcb03109-59d4-4f73-b903-1a52cb985496", "Great-grandson", "d717aa31-70c0-41b5-8632-3472e63711f2", "Dédunoka" },
                    { "fd56a7f3-2292-4044-903f-8f194b8d0522", "Tie", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Nyakkendő" },
                    { "fe0d968c-c2af-4be4-b423-aded07173f1b", "Daughter", "d717aa31-70c0-41b5-8632-3472e63711f2", "Lánya" },
                    { "fe7fdf5b-8304-4610-a6cb-a746b784a2ca", "Trousers", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Nadrág" },
                    { "ffcbda1d-d498-467a-8acd-0273fbbdc9b0", "Belt", "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15", "Öv" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ce7248c-40dd-4100-9479-ba188dcaf259");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "01eada5d-57dd-469b-b9a5-355e55bee7d2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "03023803-b3cc-4cc8-b6f0-2f1f49000870");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "04bf015d-fabf-45bf-b304-a6ad85653083");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "06acdf02-693d-43b0-a9e4-d55d99e1cc67");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0745c491-bf21-44bb-977a-83cd1ac6d53a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "08f76bbe-9341-442f-9c83-5b521193f0e8");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0af3c16b-2cb3-4276-8a99-bfa4c8125cfa");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0cc467e2-db0e-41d7-a9aa-f3bce3059b73");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0d6a6dc4-4284-4cef-ae71-ae9c2cdaf5a9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0e1d923e-b476-4d21-89fe-d6eb4ac0ddf0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "0ffda06d-c6de-4bb0-9e80-ed1eaaa63cdf");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "11c221dd-2a6c-4248-8a2c-af0cc71640a7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1427d0f5-7119-4748-92c6-e56a7615e50e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "142a7886-9628-4326-9517-b7ba74534092");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "186a0e51-d104-4450-b667-1e61cb5d3656");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "18b28cb6-f0ca-4e31-b6a4-36575e024814");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1a6752d4-f5fc-422d-b2d1-8ceac2b3cc68");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1d41e060-5ff7-4590-a89b-0fda05f9eb65");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1e93c242-653e-440a-98aa-2feaf8b985b1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1f5ed071-bce5-4df7-b746-8df573375fb1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "1ff02caa-610f-4c61-9131-252a25b0f1a0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "222b14aa-f63f-4ad2-8200-192b00b60a3a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "24de935e-3a9f-4275-9c59-246db878b1f0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2784f4ed-25f7-4d50-ba69-645f4eb032eb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "27d7a53b-cbb1-4f60-80f6-9a586f0d5526");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "298ee59d-0359-4a0e-971f-803ab03ab332");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "29d48c52-e602-4db5-997e-fab81f04ba1f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2a171a7e-02ec-46e3-a8ae-c32b0610edfd");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2b0ca402-3d81-4b79-bb7b-6268c97c2d2d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2b1d5315-9199-4f23-bdd1-af5269132138");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2c4c52ab-1c12-40d5-b576-0711f3309e05");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2d0000f0-0938-4924-bbe4-8ccc151cd7e3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2d6a69d6-5b44-4f05-9565-efae6569f554");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2d952cf9-e68b-417e-9d13-11e350775237");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "2f4dfc8c-b64b-4eaa-b1ed-60ec5099fa2e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "31fdbab7-cee6-4554-83bf-a3e12ad52b83");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "322889a7-2d58-41be-8c08-d54f28cf0fbb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "323d5a54-f4cc-413f-a664-a34fef2bf0fc");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "325a1c43-93ca-4b43-88b9-d7045c87aefc");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "32da101f-1521-460e-bd1f-933cdc04a108");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "332f4070-b4fd-4d7b-997b-2a06b269be6b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "33327233-88d7-4cec-bcb9-92c624b69c2c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "35f38af0-10e3-4127-aae8-d924708500b5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "37091163-9574-48f0-807f-ca528b5dd90a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3727ab75-4736-4f55-b45f-2bd5d9e57449");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3ad1f127-be3a-42a2-9ac6-aaee3e01afc3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3daa6d99-c778-4750-b9a5-3c217cbc301e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3eca87c9-0890-4e61-b328-84e18933ba2e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3ed5a587-ad8e-41e9-aa04-b74d525cfcbe");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "3fc5d467-99ad-428c-908d-be694da87023");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4106e5d1-672d-4aae-bd1f-e9b9d772b1bb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "412863f4-b751-44f4-93e3-7e1aac992759");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "41e672b0-b77a-4677-a380-6f13193dec3d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "42874afe-f962-4daf-b927-aaa88d439ef1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "44c89a1a-7569-47a0-a639-200c60bee0cb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "475af656-d5f6-4884-8c88-385e1d70d8c7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "47b97f4c-0a74-4985-97e0-4bb8837ad5a3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4a957b42-d853-48b3-822a-c01f153995ac");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4d30dae0-ed68-45c4-a693-84fce6668524");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4d385a97-04c6-4e2d-b0c6-3c14b8e3a8e9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4e50e2f0-3666-4abf-980c-8a984a15ff50");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4e57f400-567c-49c5-afde-8f18cd53015d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4e9d4b93-d5f2-4455-82da-32467a54fa71");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "4fe235f1-f9c6-4a9e-9342-ea6259612c87");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "50ca6c3f-634a-42cc-b544-f9c92505b6ef");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "52c9328a-e4d7-423f-bc5f-6a3bca53e904");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "53ae977d-5a53-440d-b7c5-15d26d24c4a5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "59a125f1-ee2d-48ae-b5dc-f60d61d673e2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5b2548e7-9acd-46a8-9bdd-b1d2143124ed");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5b639996-2d25-49b2-b0c3-59ab14de7179");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "5f0a0443-4555-4ba8-bdba-89188d8923e2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "61bfd035-a269-4616-b496-f276aa00f864");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "62918290-8438-48ce-8527-f689b807f1bb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "63e3534c-15b6-4f76-89f1-4621a2744d92");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "67845502-4ead-49b7-a487-3656c49eb7c8");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "69265688-9884-4690-86e2-9274bbfe86a7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "69e526d4-0945-41a9-ab29-135c23478a8e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6e966891-5ba6-4861-8feb-22dcb9dc4288");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "6fe27dc2-2cd1-4745-9d63-a03a4e7e0b41");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "70bdde49-bb63-466f-bbe1-71bff4373533");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "711c7cb7-4cc6-4ebb-a8b7-f3873e07ab79");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "718cce81-eff8-4f33-aaf2-1bc2c60b8c11");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "738d4d8c-178b-44ef-aad6-43ebf2b97477");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "757c7ab7-6fbb-4f13-b48f-d0dd85c444f1");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "76d057d5-9177-47ea-8853-5c0b4674dc37");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "77723b1a-a884-44e1-b994-5b5a3045647e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "778642db-3d47-42a3-b249-641a8c0cf337");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "787d3919-16de-4c7d-9724-8d187eefa230");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "79151322-1ee1-4c6a-8722-42cf856013e9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "79b36af8-0f47-46e8-b223-1537ee713844");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "7de9d869-7085-4283-99a9-eb05a607475c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8132b99e-9acf-446d-b2e1-7a61a3b278dd");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8524ff17-dfc3-438a-9e9a-1a1f28ab315d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "85a008fb-b904-423f-9777-1f7ce9d2439b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "85e1e83a-d0a3-4c7b-abc3-2e06e92cf04a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "87c195f8-760a-41fd-8259-e8999b68a760");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "895447a4-051c-42db-8d80-9a8bf7655f80");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "89e03846-091e-4c25-8344-84a40e008c9e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8cc0e8c4-d32c-4220-91cc-323f373c218d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "8e7f1e8a-17a3-457b-be67-19ac45fc574c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "917ffadf-e008-4e8f-b39a-635555380600");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "928c3618-f9d2-413c-b1ef-8005e6839038");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "94ba16dd-f547-49fd-9247-0023a89233f3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "94c570f6-0e57-4e74-9bed-436cbb89d912");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "965d53f4-edf7-420c-8f91-34cd494b21d0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "969950d1-f1b6-4997-aabc-edf6f21262fb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9820d79c-6bd0-4725-b959-9a4fe39c8843");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "985cdc76-2604-45dc-9617-d88d19cc41ce");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9c1936e5-8c20-411f-8211-b32708420f20");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9d03b22e-3642-401b-ac11-b40258469175");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9d12c34d-a909-4b0c-b93e-dc20a51c39de");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9ed2759a-6e44-4bc8-bdb0-ef7868c37421");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9f09e020-069a-44ee-9a4f-a0e642cb5f7e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "9f189fb7-3857-408c-b145-fee4be37c9de");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a0937c30-67e2-4f5e-ad65-7c61d48f1ea0");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a1a94b03-13e4-4941-9069-0fb16ebf4a25");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a1dac59d-44c8-4022-8411-27aa3ce687f2");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a1edabbf-3ffb-49d8-ae21-154ad1b59142");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a291e78d-2b14-4d0b-a744-c38d28bcacb5");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a688355d-01f4-48fe-b772-d4d212ed8efb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a98bb43b-9d20-479f-ba26-cf38fa6d4934");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "a9b71551-519e-4979-a127-186f4e7396a9");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ac60c8f0-cb69-4571-8d35-fdfb60e9f1b3");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ae7b20bb-a295-4536-96e6-e8dfadf470e7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "af028216-4bf5-43cc-b2c1-7c508c768a0d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "b1ee970a-ccd5-46c7-ae14-c262c2784601");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "b94b9b0e-5027-48ca-9cbd-f45276f8ac49");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bdc65f48-e8fc-4ec9-9353-fcb982e74bab");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "be54e9e6-5a53-4371-9ca1-e99276678fba");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bed28035-bb6e-49bf-9e2a-16a1c893735f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bf2092ef-b924-453e-a413-2f7734bd25ff");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bf8ee4e9-6217-46c3-bdcb-4d244b3b1856");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "bf8f7883-ce9b-4268-ac3d-99f78609987f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c1f21270-e043-426c-9230-2e9d7e73382e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c268549f-cc06-4f24-8101-be1daadf016f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c45e084b-87ba-4c98-8eee-cf5b2b9ac9c7");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c4de93c8-4781-4cf3-8857-5e1505855377");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c4e3b70c-10e4-46e0-abdf-75feae5cc49e");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c5783716-9815-43fb-9ea5-166765f28a3c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c7ce4d9a-716c-4189-aa09-a6475b73f8fb");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c826d8fb-cca7-435f-96dd-5dd87ee17b4f");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "c92ade77-bb83-4aed-a5a7-f61f6338f59c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cb1175d2-93d4-42cf-ba92-ef133629c9dd");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cbb50883-ba66-4811-9659-05d018d0bd53");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cc81df8a-e5ce-4352-8add-5245711b4335");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "cecbd99b-d26d-48e0-9da1-ef88ec11a836");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d0264f44-297e-401e-9eba-c37eb5e91c45");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "d78a03f5-a502-45ac-9d12-3e2d343afd85");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "da81ea42-40f3-4c67-a8a9-5f61ed9d9c09");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "dab4ec53-c882-4277-8c7d-f70c98794c16");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "dc06fe8a-7362-4818-93a7-a759db5ed508");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "de64811e-5f1e-47bb-92dc-602e5debc1ca");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e02c59da-ab75-4dcb-b3bf-c1554f3a1061");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e402b3a5-f7df-46b1-9aa1-696e0a041c9c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e414ff2a-ba6a-4f31-9f19-5fe9b7c7c393");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e49a86e4-260b-436d-8034-9a1708715094");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e5a9e2e7-667b-48ad-a3a2-e0c5be0dbcf4");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "e9ec5284-b040-4b23-8e2c-12673e1966cc");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ebc64c31-0328-4a31-b1f9-9f2ff84b676a");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "efc6c8c2-cf7b-4915-be2f-fd44e8c2d12d");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f017de93-1bd3-4706-ba9c-7b2327e8ea90");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f0909c15-4ace-4a1a-8748-c2fc28fcf677");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f169605e-567c-4b7b-8d19-8757b466910c");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f1b00c5c-7775-4646-98b5-12d206273bf6");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f366d539-ecce-40bb-acd0-38ddece1ce95");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f5e8941b-7893-4599-b9b3-c0bdec993334");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f60fe7ca-5d83-4298-901c-544995511f33");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "f67d678a-6ab4-400d-81da-a58d76d55552");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fc0ed19a-cf3f-468a-af52-320d94c96707");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fcb03109-59d4-4f73-b903-1a52cb985496");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fd56a7f3-2292-4044-903f-8f194b8d0522");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fe0d968c-c2af-4be4-b423-aded07173f1b");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "fe7fdf5b-8304-4610-a6cb-a746b784a2ca");

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: "ffcbda1d-d498-467a-8acd-0273fbbdc9b0");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "058be191-523d-4501-b6f6-3bf57263d568");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "211b3d26-fb6a-438e-af53-d8124e9c0911");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "229f3ebe-81a8-4b8e-a8b6-b82bdbaa723a");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "8f3b5b7d-b2b5-44e5-bf9d-5cf765efda15");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b7e85018-1d81-4e39-b50f-e213f95579d2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "d717aa31-70c0-41b5-8632-3472e63711f2");

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
    }
}
