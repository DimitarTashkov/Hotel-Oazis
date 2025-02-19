using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
