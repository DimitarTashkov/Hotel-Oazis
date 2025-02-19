using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class addMediaToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("007fe70a-dfe1-4c3f-97ae-42581f452258"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("03eb4335-6cde-4615-ab53-9f0e41396b90"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("17400946-4310-4442-9f19-4c2d1ac53f06"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("318bb342-0389-4106-8d53-65ce6dccc713"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("32ad5279-2006-486c-a2c3-87e89e5629c7"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7a8303b0-480c-485a-b1bf-4b607605092f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7d97f290-8721-4eaf-8ff3-506dcf5ae297"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8e645159-207f-4184-a175-c80edbd4164a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a0cb3055-6151-4c1b-9862-99ee45285405"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a3f0599c-889e-4f5c-96f5-88b940121efd"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4d900cad-7daa-423e-90d0-bd2222754fcc"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6dc36277-da5b-4a3c-8bf7-475783c4d645"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("716acbfc-19c3-479a-b4a7-be7f67a6ca2a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("73dbe979-d1cf-4950-9bdf-0fd924b87f14"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a66dee05-14aa-4c0e-a077-b91b11f041a8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("03af2fd6-5231-4ef7-b7ed-c189f9a902c4"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4167be50-ee86-4e74-b743-8a17b053d02e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5a1a09fc-5f29-45ed-a794-1fad24597abd"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6bd7de13-2384-4040-ac4d-6f1840085062"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7691ecd6-b65a-47b1-8727-29e5877b10eb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9fc7af7d-4e73-430f-9b73-e1f43bcb1d6f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("aaa107e9-e46f-443e-b0cc-83905fb229fc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ab40bf45-beef-4675-8081-ec6a59a86219"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ee8f86ba-e261-4fd4-ba5a-6c3b383df3bd"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f3187c2a-4d47-4378-a7b7-d56afee5980a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0ecdd12b-ba6a-4543-a24f-7233708a0049"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2c2dd768-674f-4521-a9d9-d16fee6c9bb0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("687d1abc-8703-4e3b-8fb8-070ff692b652"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6a6ab7f8-94d1-4266-b1a2-be52e3492fc0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("761c2528-1422-4af2-a31a-016c7befa34e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9222ec31-5f3e-42d1-92a3-1a5adb6bd9fa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("926accff-5d05-458f-a382-b456276bc888"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ad970ff0-5807-4224-bf87-3c819c40a1cf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b4013462-e72b-4372-81e7-a6bb511d7575"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("be9c3511-252e-489b-954f-6acca8b6a99c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16130dfe-44a8-4fcd-9e85-b660abf3bd30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c2e67d4-af46-43dc-8263-07677ecfcc05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71fd4d6b-cbd2-4ebb-b5ee-219c3f18f559"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d75bd6bf-9c77-4da2-8a0d-ca8b626634a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fad98ae2-7f13-4358-8fa3-ff643da319ea"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("01d6a50b-30fb-4122-8ad6-79c392a57681"), "Charming double room with artistic decor.", true, 110, "System.Drawing.Bitmap", 135.00m, 2 },
                    { new Guid("27bbfcd2-71f7-4139-b0d2-f68fb9a6fd1b"), "Cozy single room with a city view.", true, 101, "System.Drawing.Bitmap", 80.00m, 1 },
                    { new Guid("5b9e4cf4-3f9e-4c90-9f49-ef84414b10fc"), "Exclusive suite with a private lounge area.", true, 109, "System.Drawing.Bitmap", 250.00m, 5 },
                    { new Guid("68087e4d-171d-4108-b03b-f113c8910ab7"), "Modern single room with a work desk.", true, 107, "System.Drawing.Bitmap", 85.00m, 1 },
                    { new Guid("743c241e-939e-4356-b045-f9fb09e26198"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "System.Drawing.Bitmap", 200.00m, 3 },
                    { new Guid("8719283f-b7bb-43ea-b297-9b0b5ad62515"), "Comfortable single room with free Wi-Fi.", true, 104, "System.Drawing.Bitmap", 75.00m, 1 },
                    { new Guid("94b77448-9596-4762-a1a8-d3628d36842b"), "Premium suite with a private hot tub.", true, 106, "System.Drawing.Bitmap", 220.00m, 4 },
                    { new Guid("a84bcd58-b3da-4a05-9827-16d1657b1fdd"), "Stylish double room with a city skyline view.", true, 108, "System.Drawing.Bitmap", 140.00m, 2 },
                    { new Guid("ab6b9572-0c6a-40c0-9d77-acc12a18b376"), "Elegant double room with a balcony.", true, 105, "System.Drawing.Bitmap", 130.00m, 2 },
                    { new Guid("be016646-e0f0-4b7a-bce5-d111f818f5d6"), "Spacious double room with modern amenities.", true, 102, "System.Drawing.Bitmap", 120.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("25382f6e-b58b-4048-ad83-6f8d848ad4ce"), "Access to our indoor heated pool.", "Swimming Pool" },
                    { new Guid("5b4be7ff-9a22-477e-ab74-53da3311304b"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("6ee972ef-08ff-451e-abdb-dd70aaabce4c"), "Guided tour of local attractions.", "City Tour" },
                    { new Guid("80d364e8-cde8-461d-ba9b-6f64f3d03e49"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("905cc535-6ed9-41d3-a974-ecf9bf2498c6"), "24/7 room service with gourmet meals.", "Room Service" },
                    { new Guid("b170a7d4-c667-44da-9960-82859f7284b1"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("b1e5b5c4-3e78-4c3f-8ecd-0e91a5dc63fc"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("cd47da36-6eb0-41a0-abf5-b598ee312664"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("e1a513f4-1e70-4a87-8bbe-1d4c7c8f9007"), "Same-day laundry and dry-cleaning services.", "Laundry Service" },
                    { new Guid("ef464667-1c16-4518-8e2d-b74ad057d664"), "Fully equipped meeting and conference facilities.", "Conference Room" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("03daa929-f93f-4ef2-a2ee-94c353ad546f"), 40, "System.Drawing.Bitmap", "charlie@example.com", "hashedpassword", "CharlieBrown" },
                    { new Guid("074b100e-a9f8-457c-b78f-2ed551a49562"), 33, "System.Drawing.Bitmap", "edward@example.com", "hashedpassword", "EdwardBlack" },
                    { new Guid("242983ba-944c-4d10-9352-46549f6ee28c"), 35, "System.Drawing.Bitmap", "bob@example.com", "hashedpassword", "BobJohnson" },
                    { new Guid("2db2afc8-43b0-4568-8582-dff7e7b9d47e"), 30, "System.Drawing.Bitmap", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("9dea0857-7d36-476b-a050-9945fdf44c11"), 28, "System.Drawing.Bitmap", "alice@example.com", "hashedpassword", "AliceSmith" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("32cac2ca-bc7b-4a72-8298-bf148a910f1b"), new DateTime(2025, 2, 26, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 3, 6, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6661), new Guid("27bbfcd2-71f7-4139-b0d2-f68fb9a6fd1b"), new Guid("9dea0857-7d36-476b-a050-9945fdf44c11") },
                    { new Guid("35ce2023-b565-44f3-9e6e-77e61c5f84fd"), new DateTime(2025, 2, 24, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6702), new DateTime(2025, 3, 2, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6702), new Guid("94b77448-9596-4762-a1a8-d3628d36842b"), new Guid("03daa929-f93f-4ef2-a2ee-94c353ad546f") },
                    { new Guid("54bc020f-0aef-4c8a-908e-84b0a54e2167"), new DateTime(2025, 2, 25, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 3, 2, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6710), new Guid("a84bcd58-b3da-4a05-9827-16d1657b1fdd"), new Guid("2db2afc8-43b0-4568-8582-dff7e7b9d47e") },
                    { new Guid("8635a81a-78f0-405b-a26c-043eb9a70807"), new DateTime(2025, 2, 22, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6717), new DateTime(2025, 3, 10, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6717), new Guid("01d6a50b-30fb-4122-8ad6-79c392a57681"), new Guid("074b100e-a9f8-457c-b78f-2ed551a49562") },
                    { new Guid("87fdd6f8-def3-49ee-9a1f-891c990cff58"), new DateTime(2025, 2, 27, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6671), new DateTime(2025, 3, 9, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6671), new Guid("be016646-e0f0-4b7a-bce5-d111f818f5d6"), new Guid("9dea0857-7d36-476b-a050-9945fdf44c11") },
                    { new Guid("906dca96-d20f-44c9-85f0-89427390ee45"), new DateTime(2025, 2, 21, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6683), new DateTime(2025, 3, 6, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6683), new Guid("ab6b9572-0c6a-40c0-9d77-acc12a18b376"), new Guid("03daa929-f93f-4ef2-a2ee-94c353ad546f") },
                    { new Guid("c0db48f9-1988-4a34-94a1-4d90c80dce6c"), new DateTime(2025, 2, 21, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 3, 8, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6679), new Guid("8719283f-b7bb-43ea-b297-9b0b5ad62515"), new Guid("242983ba-944c-4d10-9352-46549f6ee28c") },
                    { new Guid("c322a134-b384-4fac-9301-932c62930303"), new DateTime(2025, 2, 22, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 3, 2, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6706), new Guid("68087e4d-171d-4108-b03b-f113c8910ab7"), new Guid("2db2afc8-43b0-4568-8582-dff7e7b9d47e") },
                    { new Guid("c5f783b1-911e-4e1d-b64f-fda598817c9e"), new DateTime(2025, 2, 22, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6713), new DateTime(2025, 3, 8, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6713), new Guid("5b9e4cf4-3f9e-4c90-9f49-ef84414b10fc"), new Guid("074b100e-a9f8-457c-b78f-2ed551a49562") },
                    { new Guid("ec4a66aa-873c-4c49-acb8-f142377d60a0"), new DateTime(2025, 2, 28, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6675), new DateTime(2025, 3, 3, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6675), new Guid("743c241e-939e-4356-b045-f9fb09e26198"), new Guid("242983ba-944c-4d10-9352-46549f6ee28c") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("2cca1704-a2f7-421b-8f52-23a594048e72"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6872), 5, new Guid("2db2afc8-43b0-4568-8582-dff7e7b9d47e") },
                    { new Guid("36821a6e-94b3-404d-be5e-cc6e2b566b81"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6832), 5, new Guid("242983ba-944c-4d10-9352-46549f6ee28c") },
                    { new Guid("7d9fbde6-2cec-4408-8578-adf05fbc1438"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6880), 5, new Guid("074b100e-a9f8-457c-b78f-2ed551a49562") },
                    { new Guid("a01dd1c3-3e64-429d-a637-4a846ce64bbb"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6862), 5, new Guid("03daa929-f93f-4ef2-a2ee-94c353ad546f") },
                    { new Guid("e0f6b635-a807-4c95-aaa9-06db9834dd6f"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 1, 19, 212, DateTimeKind.Utc).AddTicks(6824), 5, new Guid("9dea0857-7d36-476b-a050-9945fdf44c11") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("32cac2ca-bc7b-4a72-8298-bf148a910f1b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("35ce2023-b565-44f3-9e6e-77e61c5f84fd"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("54bc020f-0aef-4c8a-908e-84b0a54e2167"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8635a81a-78f0-405b-a26c-043eb9a70807"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("87fdd6f8-def3-49ee-9a1f-891c990cff58"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("906dca96-d20f-44c9-85f0-89427390ee45"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c0db48f9-1988-4a34-94a1-4d90c80dce6c"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c322a134-b384-4fac-9301-932c62930303"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c5f783b1-911e-4e1d-b64f-fda598817c9e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ec4a66aa-873c-4c49-acb8-f142377d60a0"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2cca1704-a2f7-421b-8f52-23a594048e72"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("36821a6e-94b3-404d-be5e-cc6e2b566b81"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbde6-2cec-4408-8578-adf05fbc1438"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a01dd1c3-3e64-429d-a637-4a846ce64bbb"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e0f6b635-a807-4c95-aaa9-06db9834dd6f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("25382f6e-b58b-4048-ad83-6f8d848ad4ce"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5b4be7ff-9a22-477e-ab74-53da3311304b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6ee972ef-08ff-451e-abdb-dd70aaabce4c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("80d364e8-cde8-461d-ba9b-6f64f3d03e49"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("905cc535-6ed9-41d3-a974-ecf9bf2498c6"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b170a7d4-c667-44da-9960-82859f7284b1"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b1e5b5c4-3e78-4c3f-8ecd-0e91a5dc63fc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cd47da36-6eb0-41a0-abf5-b598ee312664"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e1a513f4-1e70-4a87-8bbe-1d4c7c8f9007"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ef464667-1c16-4518-8e2d-b74ad057d664"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("01d6a50b-30fb-4122-8ad6-79c392a57681"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("27bbfcd2-71f7-4139-b0d2-f68fb9a6fd1b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5b9e4cf4-3f9e-4c90-9f49-ef84414b10fc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("68087e4d-171d-4108-b03b-f113c8910ab7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("743c241e-939e-4356-b045-f9fb09e26198"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8719283f-b7bb-43ea-b297-9b0b5ad62515"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("94b77448-9596-4762-a1a8-d3628d36842b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a84bcd58-b3da-4a05-9827-16d1657b1fdd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ab6b9572-0c6a-40c0-9d77-acc12a18b376"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("be016646-e0f0-4b7a-bce5-d111f818f5d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03daa929-f93f-4ef2-a2ee-94c353ad546f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("074b100e-a9f8-457c-b78f-2ed551a49562"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("242983ba-944c-4d10-9352-46549f6ee28c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2db2afc8-43b0-4568-8582-dff7e7b9d47e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dea0857-7d36-476b-a050-9945fdf44c11"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("0ecdd12b-ba6a-4543-a24f-7233708a0049"), "Comfortable single room with free Wi-Fi.", true, 104, "https://example.com/room104.jpg", 75.00m, 1 },
                    { new Guid("2c2dd768-674f-4521-a9d9-d16fee6c9bb0"), "Modern single room with a work desk.", true, 107, "https://example.com/room107.jpg", 85.00m, 1 },
                    { new Guid("687d1abc-8703-4e3b-8fb8-070ff692b652"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "https://example.com/room103.jpg", 200.00m, 3 },
                    { new Guid("6a6ab7f8-94d1-4266-b1a2-be52e3492fc0"), "Elegant double room with a balcony.", true, 105, "https://example.com/room105.jpg", 130.00m, 2 },
                    { new Guid("761c2528-1422-4af2-a31a-016c7befa34e"), "Charming double room with artistic decor.", true, 110, "https://example.com/room110.jpg", 135.00m, 2 },
                    { new Guid("9222ec31-5f3e-42d1-92a3-1a5adb6bd9fa"), "Exclusive suite with a private lounge area.", true, 109, "https://example.com/room109.jpg", 250.00m, 5 },
                    { new Guid("926accff-5d05-458f-a382-b456276bc888"), "Cozy single room with a city view.", true, 101, "https://example.com/room101.jpg", 80.00m, 1 },
                    { new Guid("ad970ff0-5807-4224-bf87-3c819c40a1cf"), "Premium suite with a private hot tub.", true, 106, "https://example.com/room106.jpg", 220.00m, 4 },
                    { new Guid("b4013462-e72b-4372-81e7-a6bb511d7575"), "Spacious double room with modern amenities.", true, 102, "https://example.com/room102.jpg", 120.00m, 2 },
                    { new Guid("be9c3511-252e-489b-954f-6acca8b6a99c"), "Stylish double room with a city skyline view.", true, 108, "https://example.com/room108.jpg", 140.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("03af2fd6-5231-4ef7-b7ed-c189f9a902c4"), "24/7 room service with gourmet meals.", "Room Service" },
                    { new Guid("4167be50-ee86-4e74-b743-8a17b053d02e"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("5a1a09fc-5f29-45ed-a794-1fad24597abd"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("6bd7de13-2384-4040-ac4d-6f1840085062"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("7691ecd6-b65a-47b1-8727-29e5877b10eb"), "Fully equipped meeting and conference facilities.", "Conference Room" },
                    { new Guid("9fc7af7d-4e73-430f-9b73-e1f43bcb1d6f"), "Same-day laundry and dry-cleaning services.", "Laundry Service" },
                    { new Guid("aaa107e9-e46f-443e-b0cc-83905fb229fc"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("ab40bf45-beef-4675-8081-ec6a59a86219"), "Access to our indoor heated pool.", "Swimming Pool" },
                    { new Guid("ee8f86ba-e261-4fd4-ba5a-6c3b383df3bd"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("f3187c2a-4d47-4378-a7b7-d56afee5980a"), "Guided tour of local attractions.", "City Tour" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("16130dfe-44a8-4fcd-9e85-b660abf3bd30"), 28, "https://example.com/avatar1.jpg", "alice@example.com", "hashedpassword", "AliceSmith" },
                    { new Guid("1c2e67d4-af46-43dc-8263-07677ecfcc05"), 40, "https://example.com/avatar3.jpg", "charlie@example.com", "hashedpassword", "CharlieBrown" },
                    { new Guid("71fd4d6b-cbd2-4ebb-b5ee-219c3f18f559"), 30, "https://example.com/avatar4.jpg", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("d75bd6bf-9c77-4da2-8a0d-ca8b626634a1"), 35, "https://example.com/avatar2.jpg", "bob@example.com", "hashedpassword", "BobJohnson" },
                    { new Guid("fad98ae2-7f13-4358-8fa3-ff643da319ea"), 33, "https://example.com/avatar5.jpg", "edward@example.com", "hashedpassword", "EdwardBlack" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("007fe70a-dfe1-4c3f-97ae-42581f452258"), new DateTime(2025, 2, 28, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6059), new DateTime(2025, 3, 3, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6059), new Guid("761c2528-1422-4af2-a31a-016c7befa34e"), new Guid("fad98ae2-7f13-4358-8fa3-ff643da319ea") },
                    { new Guid("03eb4335-6cde-4615-ab53-9f0e41396b90"), new DateTime(2025, 2, 25, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6019), new DateTime(2025, 3, 5, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6029), new Guid("926accff-5d05-458f-a382-b456276bc888"), new Guid("16130dfe-44a8-4fcd-9e85-b660abf3bd30") },
                    { new Guid("17400946-4310-4442-9f19-4c2d1ac53f06"), new DateTime(2025, 2, 24, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6055), new DateTime(2025, 3, 8, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6056), new Guid("9222ec31-5f3e-42d1-92a3-1a5adb6bd9fa"), new Guid("fad98ae2-7f13-4358-8fa3-ff643da319ea") },
                    { new Guid("318bb342-0389-4106-8d53-65ce6dccc713"), new DateTime(2025, 2, 26, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6048), new DateTime(2025, 3, 10, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6049), new Guid("ad970ff0-5807-4224-bf87-3c819c40a1cf"), new Guid("1c2e67d4-af46-43dc-8263-07677ecfcc05") },
                    { new Guid("32ad5279-2006-486c-a2c3-87e89e5629c7"), new DateTime(2025, 2, 21, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6053), new DateTime(2025, 3, 6, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6053), new Guid("be9c3511-252e-489b-954f-6acca8b6a99c"), new Guid("71fd4d6b-cbd2-4ebb-b5ee-219c3f18f559") },
                    { new Guid("7a8303b0-480c-485a-b1bf-4b607605092f"), new DateTime(2025, 2, 23, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6045), new DateTime(2025, 3, 3, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6045), new Guid("6a6ab7f8-94d1-4266-b1a2-be52e3492fc0"), new Guid("1c2e67d4-af46-43dc-8263-07677ecfcc05") },
                    { new Guid("7d97f290-8721-4eaf-8ff3-506dcf5ae297"), new DateTime(2025, 2, 20, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6042), new DateTime(2025, 3, 9, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6043), new Guid("0ecdd12b-ba6a-4543-a24f-7233708a0049"), new Guid("d75bd6bf-9c77-4da2-8a0d-ca8b626634a1") },
                    { new Guid("8e645159-207f-4184-a175-c80edbd4164a"), new DateTime(2025, 2, 25, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6033), new DateTime(2025, 3, 6, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6034), new Guid("b4013462-e72b-4372-81e7-a6bb511d7575"), new Guid("16130dfe-44a8-4fcd-9e85-b660abf3bd30") },
                    { new Guid("a0cb3055-6151-4c1b-9862-99ee45285405"), new DateTime(2025, 2, 22, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 3, 9, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6051), new Guid("2c2dd768-674f-4521-a9d9-d16fee6c9bb0"), new Guid("71fd4d6b-cbd2-4ebb-b5ee-219c3f18f559") },
                    { new Guid("a3f0599c-889e-4f5c-96f5-88b940121efd"), new DateTime(2025, 2, 26, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6036), new DateTime(2025, 3, 7, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6036), new Guid("687d1abc-8703-4e3b-8fb8-070ff692b652"), new Guid("d75bd6bf-9c77-4da2-8a0d-ca8b626634a1") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("4d900cad-7daa-423e-90d0-bd2222754fcc"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 2, 19, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6138), 4, new Guid("d75bd6bf-9c77-4da2-8a0d-ca8b626634a1") },
                    { new Guid("6dc36277-da5b-4a3c-8bf7-475783c4d645"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 2, 19, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6145), 4, new Guid("71fd4d6b-cbd2-4ebb-b5ee-219c3f18f559") },
                    { new Guid("716acbfc-19c3-479a-b4a7-be7f67a6ca2a"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 2, 19, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6141), 4, new Guid("1c2e67d4-af46-43dc-8263-07677ecfcc05") },
                    { new Guid("73dbe979-d1cf-4950-9bdf-0fd924b87f14"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 2, 19, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6128), 4, new Guid("16130dfe-44a8-4fcd-9e85-b660abf3bd30") },
                    { new Guid("a66dee05-14aa-4c0e-a077-b91b11f041a8"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 2, 19, 15, 38, 29, 893, DateTimeKind.Utc).AddTicks(6148), 4, new Guid("fad98ae2-7f13-4358-8fa3-ff643da319ea") }
                });
        }
    }
}
