using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class seedByRelativePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("3afa5a1c-0cb8-482a-a962-005d04275b4c"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("58564acf-7d26-49da-85b8-40b15043f2ad"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("619bedf4-3f5d-4a42-9bb6-832532a157f1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("676b7b41-71ce-4b40-aa81-35f8c84de5b2"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("72dc62d0-b51f-4779-b02f-dbc86ea15aa7"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7ee9e9b6-3b24-4657-95f5-f5165005f10d"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("98b7c879-edd0-4b47-8c07-d3d7c1e8b2c3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("9943b652-0b0d-4212-ace9-626178817c6d"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("caf089cf-4a38-459f-88e4-79529bc6b353"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("e38701f9-9fab-424b-aebc-2593e13806af"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("381d1416-5485-4c02-bc10-77dd323f4560"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a85ae2af-3fd8-41db-903f-361245ce8d02"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("b98179f4-d4b6-4254-b685-761408a32340"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d55299e0-3cb5-497a-8654-da6bc55c91b8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("de50f482-75fd-4d45-98ba-a5c2f80ab05b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("084351f1-5a43-4c93-9f8a-a91d9c7a07b6"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2653362b-e5b8-4ac8-ab2b-854223c3295c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2ae4400d-feb8-422a-ad38-048c9633f0ac"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("58fedb43-8839-4882-a0f1-475e26c9887e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("60001d98-db11-40c0-8f6a-7100f35018a1"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("668c20de-df47-49dd-a1d7-b853130943d7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8766b52b-5ffb-4218-9bfc-e3a3fe9dc0c6"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8dc46eb6-f066-435e-9460-89f651f39e2c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("904c7622-cbb0-4385-ba25-be86d9a72f23"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cf20bfed-8041-4068-a1a2-26bb321e836f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4deddfad-47ef-4186-885a-6ba00f3075f4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("80b43ac7-4c5f-4539-9b94-85d3f66aaf2b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8a3d96eb-df23-4651-9b71-3f44fab59d3f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c28064b3-e0b7-4a28-9a52-9ac4cf9953ea"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c43b4bae-81a5-472c-bb91-ec308f19af2c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d68bcd5f-000e-459a-8755-6baa90c71e3f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d882fecd-4047-43dc-a47d-010541ffcce0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("da09cb3d-9cd9-412c-8ce6-d384f335bb83"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e0e1c9f5-4bee-4d5d-ae36-ce19da53cb37"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fe7a7a29-074a-462b-afdc-75b2fcfc62e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c7635b3-4ac3-4632-9583-b665c6f8eac3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76894076-8074-4db0-86d4-7edd4fb69484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4b88f2c-8e57-485d-bdcb-a4c70e7b1d0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5fe45ce-cd83-4093-82be-72e8b95deb31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2eaf91d-124f-46fb-9503-43939fb9026b"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("6035eec3-f804-4d98-ad45-9e55516bc0c2"), "Charming double room with artistic decor.", true, 110, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\doubleRoom4.jpg", 135.00m, 2 },
                    { new Guid("7485521e-126d-4044-bb34-7a98c36f5e27"), "Stylish double room with a city skyline view.", true, 108, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\doubleRoom3.jpg", 140.00m, 2 },
                    { new Guid("8fd80935-2588-4422-9846-7e7f847e7f46"), "Spacious double room with modern amenities.", true, 102, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\doubleRoom.jpg", 120.00m, 2 },
                    { new Guid("a4d9e735-1f9c-4bcf-994d-fdb933f4b1bd"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\tripleRoom1.jpg", 200.00m, 3 },
                    { new Guid("a610b314-c5ab-42eb-b9eb-82285e28fda0"), "Premium suite with a private hot tub.", true, 106, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\quadRoom.jpg", 220.00m, 4 },
                    { new Guid("b34b8faf-902e-48a4-8c57-71d60bf8effe"), "Modern single room with a work desk.", true, 107, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\singleRoom3.jpg", 85.00m, 1 },
                    { new Guid("c3d8ff66-b605-4752-a641-5ffe16bef122"), "Comfortable single room with free Wi-Fi.", true, 104, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\singleRoom2.jpg", 75.00m, 1 },
                    { new Guid("d2258c92-e082-4703-9d09-c6fbe3e60560"), "Elegant double room with a balcony.", true, 105, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\doubleRoom2.jpg", 130.00m, 2 },
                    { new Guid("e382d7d8-4350-46cb-82d5-1350c1dcbb47"), "Exclusive suite with a private lounge area.", true, 109, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\familyRoom.jpg", 250.00m, 5 },
                    { new Guid("f32b8731-9a32-4166-bd9c-ce87b0f751f1"), "Cozy single room with a city view.", true, 101, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\singleRoom1.jpg", 80.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("16506d12-fc37-4146-b837-910b942bb287"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("48aacee4-3887-4440-9c39-c1d768d1d695"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("66b94d19-c295-4f74-809e-8be2759867e0"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("6d008672-1bf1-42cf-ade3-11810d1e168f"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("7a183520-3bc4-4680-979c-1314b4ba0431"), "Fully equipped meeting and conference facilities.", "Conference Room" },
                    { new Guid("8bf4edfe-a162-4c68-9c9c-e9c5183ff3de"), "Same-day laundry and dry-cleaning services.", "Laundry Service" },
                    { new Guid("91a85990-a7d9-4665-989a-68f7bab57908"), "Guided tour of local attractions.", "City Tour" },
                    { new Guid("b373b4e9-9ffa-43a4-b7d7-54f1bfb68d69"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("e53fe1b4-138b-40e9-8645-cb4f7fd7580b"), "Access to our indoor heated pool.", "Swimming Pool" },
                    { new Guid("f027d1f3-2587-49d5-8728-024181f152c3"), "24/7 room service with gourmet meals.", "Room Service" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("62e49715-f9c3-4cfa-8684-e4ef56553bd1"), 28, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\womanAvatar.jpg", "alice@example.com", "hashedpassword", "AliceSmith" },
                    { new Guid("7ae8b066-2a15-488f-9045-3d895bce6a01"), 33, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\manAvatar.jpg", "edward@example.com", "hashedpassword", "EdwardBlack" },
                    { new Guid("89fd0f00-7a3e-4649-a3ad-ed4a21da66ba"), 30, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\womanAvatar.jpg", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("a620c127-8fdf-4b0e-b2e7-14d6f7bc0542"), 40, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\womanAvatar.jpg", "charlie@example.com", "hashedpassword", "CharlieBrown" },
                    { new Guid("ab7438cf-2d2e-4ca8-a0fe-a8de9ce87232"), 35, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\bin\\Debug\\net8.0-windows\\Resources\\manAvatar.jpg", "bob@example.com", "hashedpassword", "BobJohnson" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a347187-74b8-40d2-833c-0d55cd126f8a"), new DateTime(2025, 3, 14, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4314), new DateTime(2025, 3, 24, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4315), new Guid("7485521e-126d-4044-bb34-7a98c36f5e27"), new Guid("89fd0f00-7a3e-4649-a3ad-ed4a21da66ba") },
                    { new Guid("208123a6-d362-4c38-ae1d-5204de092dd1"), new DateTime(2025, 3, 19, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4312), new DateTime(2025, 3, 27, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4312), new Guid("b34b8faf-902e-48a4-8c57-71d60bf8effe"), new Guid("89fd0f00-7a3e-4649-a3ad-ed4a21da66ba") },
                    { new Guid("2947acfc-ba5c-409d-b23c-ad23e216c6a3"), new DateTime(2025, 3, 18, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4281), new DateTime(2025, 3, 26, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4292), new Guid("f32b8731-9a32-4166-bd9c-ce87b0f751f1"), new Guid("62e49715-f9c3-4cfa-8684-e4ef56553bd1") },
                    { new Guid("6eed5880-db6a-4854-b195-6f0419509efa"), new DateTime(2025, 3, 17, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 3, 29, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4323), new Guid("6035eec3-f804-4d98-ad45-9e55516bc0c2"), new Guid("7ae8b066-2a15-488f-9045-3d895bce6a01") },
                    { new Guid("a29087b5-5013-4ba9-83c7-5f29406783bc"), new DateTime(2025, 3, 15, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4301), new DateTime(2025, 3, 26, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4302), new Guid("a4d9e735-1f9c-4bcf-994d-fdb933f4b1bd"), new Guid("ab7438cf-2d2e-4ca8-a0fe-a8de9ce87232") },
                    { new Guid("bb378855-43de-4232-ac81-389701f963ad"), new DateTime(2025, 3, 15, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4304), new DateTime(2025, 3, 27, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4304), new Guid("c3d8ff66-b605-4752-a641-5ffe16bef122"), new Guid("ab7438cf-2d2e-4ca8-a0fe-a8de9ce87232") },
                    { new Guid("bf78e66c-9fc3-45fb-b5fd-1b67e9aa3e9b"), new DateTime(2025, 3, 18, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 3, 30, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4320), new Guid("e382d7d8-4350-46cb-82d5-1350c1dcbb47"), new Guid("7ae8b066-2a15-488f-9045-3d895bce6a01") },
                    { new Guid("d0589d88-10ff-4468-b92c-b12f95f89104"), new DateTime(2025, 3, 19, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4310), new DateTime(2025, 3, 27, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4310), new Guid("a610b314-c5ab-42eb-b9eb-82285e28fda0"), new Guid("a620c127-8fdf-4b0e-b2e7-14d6f7bc0542") },
                    { new Guid("fc20368d-6bc9-4aa4-904d-141fee12a0ab"), new DateTime(2025, 3, 16, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4306), new DateTime(2025, 3, 27, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4307), new Guid("d2258c92-e082-4703-9d09-c6fbe3e60560"), new Guid("a620c127-8fdf-4b0e-b2e7-14d6f7bc0542") },
                    { new Guid("fd4afc8c-5895-459d-b05c-286aaceabc0c"), new DateTime(2025, 3, 20, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4298), new DateTime(2025, 3, 26, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4299), new Guid("8fd80935-2588-4422-9846-7e7f847e7f46"), new Guid("62e49715-f9c3-4cfa-8684-e4ef56553bd1") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("55636731-a94d-4258-9706-995f22686f56"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 3, 12, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4394), 3, new Guid("ab7438cf-2d2e-4ca8-a0fe-a8de9ce87232") },
                    { new Guid("7ec6dd3c-5307-4fc0-b3d3-26ce1e233750"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 3, 12, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4400), 5, new Guid("89fd0f00-7a3e-4649-a3ad-ed4a21da66ba") },
                    { new Guid("9dcc7619-bd84-4d80-a0a2-2c0293b5062c"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 3, 12, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4397), 3, new Guid("a620c127-8fdf-4b0e-b2e7-14d6f7bc0542") },
                    { new Guid("e9a81dea-35c0-4ef9-88e8-418a6f05c456"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 3, 12, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4402), 3, new Guid("7ae8b066-2a15-488f-9045-3d895bce6a01") },
                    { new Guid("fdfeac9f-a884-4ce5-b4f1-c96a19e5d084"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 3, 12, 20, 50, 38, 458, DateTimeKind.Utc).AddTicks(4387), 4, new Guid("62e49715-f9c3-4cfa-8684-e4ef56553bd1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("1a347187-74b8-40d2-833c-0d55cd126f8a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("208123a6-d362-4c38-ae1d-5204de092dd1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2947acfc-ba5c-409d-b23c-ad23e216c6a3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("6eed5880-db6a-4854-b195-6f0419509efa"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a29087b5-5013-4ba9-83c7-5f29406783bc"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bb378855-43de-4232-ac81-389701f963ad"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bf78e66c-9fc3-45fb-b5fd-1b67e9aa3e9b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d0589d88-10ff-4468-b92c-b12f95f89104"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("fc20368d-6bc9-4aa4-904d-141fee12a0ab"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("fd4afc8c-5895-459d-b05c-286aaceabc0c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("55636731-a94d-4258-9706-995f22686f56"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7ec6dd3c-5307-4fc0-b3d3-26ce1e233750"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("9dcc7619-bd84-4d80-a0a2-2c0293b5062c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e9a81dea-35c0-4ef9-88e8-418a6f05c456"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fdfeac9f-a884-4ce5-b4f1-c96a19e5d084"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16506d12-fc37-4146-b837-910b942bb287"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("48aacee4-3887-4440-9c39-c1d768d1d695"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("66b94d19-c295-4f74-809e-8be2759867e0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6d008672-1bf1-42cf-ade3-11810d1e168f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7a183520-3bc4-4680-979c-1314b4ba0431"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8bf4edfe-a162-4c68-9c9c-e9c5183ff3de"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("91a85990-a7d9-4665-989a-68f7bab57908"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b373b4e9-9ffa-43a4-b7d7-54f1bfb68d69"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e53fe1b4-138b-40e9-8645-cb4f7fd7580b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f027d1f3-2587-49d5-8728-024181f152c3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6035eec3-f804-4d98-ad45-9e55516bc0c2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7485521e-126d-4044-bb34-7a98c36f5e27"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8fd80935-2588-4422-9846-7e7f847e7f46"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a4d9e735-1f9c-4bcf-994d-fdb933f4b1bd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a610b314-c5ab-42eb-b9eb-82285e28fda0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b34b8faf-902e-48a4-8c57-71d60bf8effe"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c3d8ff66-b605-4752-a641-5ffe16bef122"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d2258c92-e082-4703-9d09-c6fbe3e60560"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e382d7d8-4350-46cb-82d5-1350c1dcbb47"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f32b8731-9a32-4166-bd9c-ce87b0f751f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62e49715-f9c3-4cfa-8684-e4ef56553bd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ae8b066-2a15-488f-9045-3d895bce6a01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89fd0f00-7a3e-4649-a3ad-ed4a21da66ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a620c127-8fdf-4b0e-b2e7-14d6f7bc0542"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab7438cf-2d2e-4ca8-a0fe-a8de9ce87232"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("4deddfad-47ef-4186-885a-6ba00f3075f4"), "Elegant double room with a balcony.", true, 105, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\doubleRoom2.jpg", 130.00m, 2 },
                    { new Guid("80b43ac7-4c5f-4539-9b94-85d3f66aaf2b"), "Stylish double room with a city skyline view.", true, 108, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\doubleRoom3.jpg", 140.00m, 2 },
                    { new Guid("8a3d96eb-df23-4651-9b71-3f44fab59d3f"), "Premium suite with a private hot tub.", true, 106, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\quadRoom.jpg", 220.00m, 4 },
                    { new Guid("c28064b3-e0b7-4a28-9a52-9ac4cf9953ea"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\tripleRoom1.jpg", 200.00m, 3 },
                    { new Guid("c43b4bae-81a5-472c-bb91-ec308f19af2c"), "Spacious double room with modern amenities.", true, 102, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\doubleRoom.jpg", 120.00m, 2 },
                    { new Guid("d68bcd5f-000e-459a-8755-6baa90c71e3f"), "Charming double room with artistic decor.", true, 110, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\doubleRoom4.jpg", 135.00m, 2 },
                    { new Guid("d882fecd-4047-43dc-a47d-010541ffcce0"), "Cozy single room with a city view.", true, 101, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\singleRoom1.jpg", 80.00m, 1 },
                    { new Guid("da09cb3d-9cd9-412c-8ce6-d384f335bb83"), "Comfortable single room with free Wi-Fi.", true, 104, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\singleRoom2.jpg", 75.00m, 1 },
                    { new Guid("e0e1c9f5-4bee-4d5d-ae36-ce19da53cb37"), "Exclusive suite with a private lounge area.", true, 109, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\familyRoom.jpg", 250.00m, 5 },
                    { new Guid("fe7a7a29-074a-462b-afdc-75b2fcfc62e9"), "Modern single room with a work desk.", true, 107, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\singleRoom3.jpg", 85.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("084351f1-5a43-4c93-9f8a-a91d9c7a07b6"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("2653362b-e5b8-4ac8-ab2b-854223c3295c"), "Same-day laundry and dry-cleaning services.", "Laundry Service" },
                    { new Guid("2ae4400d-feb8-422a-ad38-048c9633f0ac"), "24/7 room service with gourmet meals.", "Room Service" },
                    { new Guid("58fedb43-8839-4882-a0f1-475e26c9887e"), "Fully equipped meeting and conference facilities.", "Conference Room" },
                    { new Guid("60001d98-db11-40c0-8f6a-7100f35018a1"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("668c20de-df47-49dd-a1d7-b853130943d7"), "Guided tour of local attractions.", "City Tour" },
                    { new Guid("8766b52b-5ffb-4218-9bfc-e3a3fe9dc0c6"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("8dc46eb6-f066-435e-9460-89f651f39e2c"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("904c7622-cbb0-4385-ba25-be86d9a72f23"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("cf20bfed-8041-4068-a1a2-26bb321e836f"), "Access to our indoor heated pool.", "Swimming Pool" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("6c7635b3-4ac3-4632-9583-b665c6f8eac3"), 33, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\manAvatar.jpg", "edward@example.com", "hashedpassword", "EdwardBlack" },
                    { new Guid("76894076-8074-4db0-86d4-7edd4fb69484"), 35, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\manAvatar.jpg", "bob@example.com", "hashedpassword", "BobJohnson" },
                    { new Guid("a4b88f2c-8e57-485d-bdcb-a4c70e7b1d0e"), 30, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\womanAvatar.jpg", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("b5fe45ce-cd83-4093-82be-72e8b95deb31"), 40, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\womanAvatar.jpg", "charlie@example.com", "hashedpassword", "CharlieBrown" },
                    { new Guid("e2eaf91d-124f-46fb-9503-43939fb9026b"), 28, "C:\\Users\\mitko\\source\\repos\\HotelOazis\\HotelOazis\\Resources\\womanAvatar.jpg", "alice@example.com", "hashedpassword", "AliceSmith" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3afa5a1c-0cb8-482a-a962-005d04275b4c"), new DateTime(2025, 3, 12, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 3, 22, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2726), new Guid("8a3d96eb-df23-4651-9b71-3f44fab59d3f"), new Guid("b5fe45ce-cd83-4093-82be-72e8b95deb31") },
                    { new Guid("58564acf-7d26-49da-85b8-40b15043f2ad"), new DateTime(2025, 3, 16, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 3, 25, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2720), new Guid("da09cb3d-9cd9-412c-8ce6-d384f335bb83"), new Guid("76894076-8074-4db0-86d4-7edd4fb69484") },
                    { new Guid("619bedf4-3f5d-4a42-9bb6-832532a157f1"), new DateTime(2025, 3, 16, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 3, 22, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2722), new Guid("4deddfad-47ef-4186-885a-6ba00f3075f4"), new Guid("b5fe45ce-cd83-4093-82be-72e8b95deb31") },
                    { new Guid("676b7b41-71ce-4b40-aa81-35f8c84de5b2"), new DateTime(2025, 3, 15, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2735), new DateTime(2025, 3, 23, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2736), new Guid("e0e1c9f5-4bee-4d5d-ae36-ce19da53cb37"), new Guid("6c7635b3-4ac3-4632-9583-b665c6f8eac3") },
                    { new Guid("72dc62d0-b51f-4779-b02f-dbc86ea15aa7"), new DateTime(2025, 3, 12, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 3, 27, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2710), new Guid("d882fecd-4047-43dc-a47d-010541ffcce0"), new Guid("e2eaf91d-124f-46fb-9503-43939fb9026b") },
                    { new Guid("7ee9e9b6-3b24-4657-95f5-f5165005f10d"), new DateTime(2025, 3, 19, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2739), new DateTime(2025, 3, 22, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2739), new Guid("d68bcd5f-000e-459a-8755-6baa90c71e3f"), new Guid("6c7635b3-4ac3-4632-9583-b665c6f8eac3") },
                    { new Guid("98b7c879-edd0-4b47-8c07-d3d7c1e8b2c3"), new DateTime(2025, 3, 15, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 3, 26, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2728), new Guid("fe7a7a29-074a-462b-afdc-75b2fcfc62e9"), new Guid("a4b88f2c-8e57-485d-bdcb-a4c70e7b1d0e") },
                    { new Guid("9943b652-0b0d-4212-ace9-626178817c6d"), new DateTime(2025, 3, 17, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2733), new DateTime(2025, 3, 29, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2733), new Guid("80b43ac7-4c5f-4539-9b94-85d3f66aaf2b"), new Guid("a4b88f2c-8e57-485d-bdcb-a4c70e7b1d0e") },
                    { new Guid("caf089cf-4a38-459f-88e4-79529bc6b353"), new DateTime(2025, 3, 18, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 3, 26, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2718), new Guid("c28064b3-e0b7-4a28-9a52-9ac4cf9953ea"), new Guid("76894076-8074-4db0-86d4-7edd4fb69484") },
                    { new Guid("e38701f9-9fab-424b-aebc-2593e13806af"), new DateTime(2025, 3, 12, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2715), new DateTime(2025, 3, 22, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2715), new Guid("c43b4bae-81a5-472c-bb91-ec308f19af2c"), new Guid("e2eaf91d-124f-46fb-9503-43939fb9026b") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("381d1416-5485-4c02-bc10-77dd323f4560"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 3, 10, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2809), 4, new Guid("a4b88f2c-8e57-485d-bdcb-a4c70e7b1d0e") },
                    { new Guid("a85ae2af-3fd8-41db-903f-361245ce8d02"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 3, 10, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2804), 5, new Guid("76894076-8074-4db0-86d4-7edd4fb69484") },
                    { new Guid("b98179f4-d4b6-4254-b685-761408a32340"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 3, 10, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2812), 4, new Guid("6c7635b3-4ac3-4632-9583-b665c6f8eac3") },
                    { new Guid("d55299e0-3cb5-497a-8654-da6bc55c91b8"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 3, 10, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2800), 5, new Guid("e2eaf91d-124f-46fb-9503-43939fb9026b") },
                    { new Guid("de50f482-75fd-4d45-98ba-a5c2f80ab05b"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 3, 10, 21, 4, 45, 235, DateTimeKind.Utc).AddTicks(2807), 4, new Guid("b5fe45ce-cd83-4093-82be-72e8b95deb31") }
                });
        }
    }
}
