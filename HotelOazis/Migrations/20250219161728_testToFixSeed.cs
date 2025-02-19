using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class testToFixSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("1c706a82-6c42-4040-86ba-d5f00d53b3a4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("3ce15e72-cf24-4625-89b8-70bfb4038f4e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("6283b8f4-685f-4f1e-ae86-6ed93a3bb1ef"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("86987b2e-9bc9-416f-992f-876a02c73a5a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("9e631902-41e5-44f1-b60c-c2e251ddaa4b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a60929cb-5e8c-4531-8829-51d5a5a5dac7"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("b12ee2fe-7734-4ce9-89e6-def4db28be77"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("b177b9dc-96e4-4c1d-af1b-55ded58e6cc0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cf0a9a8a-a797-4cad-861f-8f083a2fcae1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ec46bc45-055a-4425-9176-c4eae3950b01"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1ce4f88f-9d45-4449-bb00-50cf2a6212ce"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("bbc4cf9c-1413-4dd6-a661-d6ebeea961e4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c818d597-779b-4775-94ea-fc1044c04cba"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e71b5313-b1f2-4022-9e50-006c8b34a81b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fff76c67-2d40-40ad-a71d-2d4ad647ae06"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("0a277483-efb7-4a0a-90bc-ea94b67394c2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("0ff5f592-9d21-40b5-8aba-e30853ba565b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b4efcc2-43d0-4526-b909-a34c71a6119e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4145eeed-83a8-4a07-89aa-de1e8bf373f4"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("602a96fe-cf84-45fe-ae7a-9465112384ba"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6e878fa7-45d9-4ab5-b4b2-60eb9678179d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6e97adc4-c99e-428c-bc30-b16fb7894225"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d66fb193-2365-4183-8906-0c790c00cf59"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d6c4923e-5106-4cf4-bbc6-1c7df4691566"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f7a1a02e-6306-46a1-910e-0a64c95c3d20"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("02ca5ab3-879d-43ee-8011-cfb9645e0eb0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1251b1d1-a62c-4e91-80cc-7e3af0d0487f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2a8738e1-49b3-4bc7-a66c-2b288553a186"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("41f40c30-c38d-4226-910b-a0732e5f2d7d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("52cd8e0e-157c-4fdd-b58b-ab1a77025328"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("868e8158-15af-4e66-bfb9-b587bcbd0341"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8850cdd5-0693-4b41-978c-0868310f85bd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a29813fb-af91-4a35-94dd-d3a9cd79cbcc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b7e342e3-78f8-4efa-9220-96057a4a9235"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fd7057b0-3173-4830-8d91-60b12588cc5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7113759c-a0b6-426a-a198-eef3138f180b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a751c353-65a2-4071-908f-eaac110f174a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa3f6bb0-ce24-41c0-a8a8-23faacf8601b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bad94b84-51b7-4149-8c7b-47f58cb97216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4b02a34-0e59-4cf8-90b6-de80d09f5bf8"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("0617f41a-28e9-4cba-b3b1-2d9f870006e2"), "Cozy single room with a city view.", true, 101, "Resources\\singleRoom1.jpg", 80.00m, 1 },
                    { new Guid("0ca732f4-fc2a-41ce-8aa6-d23c1157ce30"), "Charming double room with artistic decor.", true, 110, "Resources\\doubleRoom4.jpg", 135.00m, 2 },
                    { new Guid("33d254dc-746f-4485-b029-f6a6223068ee"), "Elegant double room with a balcony.", true, 105, "Resources\\doubleRoom2.jpg", 130.00m, 2 },
                    { new Guid("3f139227-9fb9-4394-a5b9-7053064aa97f"), "Comfortable single room with free Wi-Fi.", true, 104, "Resources\\singleRoom2.jpg", 75.00m, 1 },
                    { new Guid("94771e5d-5686-45ad-88d5-fa9d60a703e5"), "Modern single room with a work desk.", true, 107, "Resources\\singleRoom3.jpg", 85.00m, 1 },
                    { new Guid("9ce523d8-f6e0-437c-b367-d04f49e8b739"), "Premium suite with a private hot tub.", true, 106, "Resources\\quadRoom.jpg", 220.00m, 4 },
                    { new Guid("ae7cfc55-7e2d-4ff9-b5bb-df17ea169db7"), "Exclusive suite with a private lounge area.", true, 109, "Resources\\familyRoom.jpg", 250.00m, 5 },
                    { new Guid("cf62803b-5741-423b-90d5-fd70d40db155"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "Resources\\tripleRoom1.jpg", 200.00m, 3 },
                    { new Guid("efba83a0-8572-4721-bd8b-e6879be3e31b"), "Stylish double room with a city skyline view.", true, 108, "Resources\\doubleRoom3.jpg", 140.00m, 2 },
                    { new Guid("fbb6d60e-61d7-4e9b-81d8-dcd4fbbcdaf1"), "Spacious double room with modern amenities.", true, 102, "Resources\\doubleRoom.jpg", 120.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("025aeb44-2606-4f10-9ab7-6ce7fe2a3d04"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("313c974e-73d9-4229-ae58-12c456ceedca"), "Guided tour of local attractions.", "City Tour" },
                    { new Guid("3eb58096-5b1f-4e72-a1f8-82166c0c851b"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("597faf59-d72d-4215-9f34-933f778be4eb"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("78a5ef2b-caa3-4233-94b4-defbf6940b0d"), "Fully equipped meeting and conference facilities.", "Conference Room" },
                    { new Guid("a0c9e877-1eca-4ce2-99d3-d2979fa1f490"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("a3b996fe-0a69-4077-af78-94ca72f31346"), "24/7 room service with gourmet meals.", "Room Service" },
                    { new Guid("acbfa524-c66b-40a5-a319-3603bbd2b613"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("e1ca0d37-ec45-4592-972d-82911e22ec59"), "Access to our indoor heated pool.", "Swimming Pool" },
                    { new Guid("e6fe14a8-d619-44fd-b43e-f623e651ac04"), "Same-day laundry and dry-cleaning services.", "Laundry Service" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("1bea04f7-0b83-4466-9e7b-9ede5ee22c04"), 35, "Resources/manAvatar.jpg", "bob@example.com", "hashedpassword", "BobJohnson" },
                    { new Guid("66845820-77b6-42a7-86da-48d5a0cceddb"), 28, "Resources/womanAvatar.jpg", "alice@example.com", "hashedpassword", "AliceSmith" },
                    { new Guid("9c68104f-86e1-4e91-9970-91c21dff19d2"), 33, "Resources/manAvatar.jpg", "edward@example.com", "hashedpassword", "EdwardBlack" },
                    { new Guid("a8ee301e-35e9-49b7-baa4-59e826eef00f"), 30, "Resources/womanAvatar.jpg", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("c6deb7a6-f8cd-4f32-8e60-4d56988d243c"), 40, "Resources/womanAvatar.jpg", "charlie@example.com", "hashedpassword", "CharlieBrown" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("062d7ca3-eb81-403b-bda3-179b562a2d42"), new DateTime(2025, 2, 28, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9695), new DateTime(2025, 3, 4, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9707), new Guid("0617f41a-28e9-4cba-b3b1-2d9f870006e2"), new Guid("66845820-77b6-42a7-86da-48d5a0cceddb") },
                    { new Guid("1a6d430d-1e99-4b45-b7ef-7416741b410a"), new DateTime(2025, 2, 25, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9720), new DateTime(2025, 3, 5, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9721), new Guid("33d254dc-746f-4485-b029-f6a6223068ee"), new Guid("c6deb7a6-f8cd-4f32-8e60-4d56988d243c") },
                    { new Guid("2218441e-c534-4e6f-a19f-3a1179c07e8e"), new DateTime(2025, 2, 26, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 3, 6, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9775), new Guid("9ce523d8-f6e0-437c-b367-d04f49e8b739"), new Guid("c6deb7a6-f8cd-4f32-8e60-4d56988d243c") },
                    { new Guid("430caa84-7584-4de4-bb16-853bc2df60ec"), new DateTime(2025, 2, 22, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 3, 10, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9713), new Guid("fbb6d60e-61d7-4e9b-81d8-dcd4fbbcdaf1"), new Guid("66845820-77b6-42a7-86da-48d5a0cceddb") },
                    { new Guid("47230278-304a-457e-8220-be3dde1c6104"), new DateTime(2025, 2, 27, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 3, 4, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9778), new Guid("94771e5d-5686-45ad-88d5-fa9d60a703e5"), new Guid("a8ee301e-35e9-49b7-baa4-59e826eef00f") },
                    { new Guid("47ecf625-14d2-473e-8b5a-6fe67da56c93"), new DateTime(2025, 2, 25, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9716), new DateTime(2025, 3, 2, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9716), new Guid("cf62803b-5741-423b-90d5-fd70d40db155"), new Guid("1bea04f7-0b83-4466-9e7b-9ede5ee22c04") },
                    { new Guid("7c798069-ff66-4a7a-aeae-d369ddcc6e83"), new DateTime(2025, 2, 20, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9789), new DateTime(2025, 3, 4, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9789), new Guid("0ca732f4-fc2a-41ce-8aa6-d23c1157ce30"), new Guid("9c68104f-86e1-4e91-9970-91c21dff19d2") },
                    { new Guid("8b78d0e5-0b3f-479e-9801-e03b5fa0a3c8"), new DateTime(2025, 2, 23, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 3, 3, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9786), new Guid("ae7cfc55-7e2d-4ff9-b5bb-df17ea169db7"), new Guid("9c68104f-86e1-4e91-9970-91c21dff19d2") },
                    { new Guid("c06bd730-378b-4248-9fa8-4cb898f9d7ff"), new DateTime(2025, 2, 21, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9718), new DateTime(2025, 3, 9, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9718), new Guid("3f139227-9fb9-4394-a5b9-7053064aa97f"), new Guid("1bea04f7-0b83-4466-9e7b-9ede5ee22c04") },
                    { new Guid("dd9d1499-5dc7-4cc4-a3b6-5497012ccc91"), new DateTime(2025, 2, 21, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9783), new DateTime(2025, 3, 2, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9783), new Guid("efba83a0-8572-4721-bd8b-e6879be3e31b"), new Guid("a8ee301e-35e9-49b7-baa4-59e826eef00f") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("2c0d1bb7-6fbd-42ce-81ed-6e2cddcb10e4"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9860), 3, new Guid("9c68104f-86e1-4e91-9970-91c21dff19d2") },
                    { new Guid("3e1be673-fd21-4bb3-8693-b3449bd2c5bd"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9856), 5, new Guid("c6deb7a6-f8cd-4f32-8e60-4d56988d243c") },
                    { new Guid("4fc7a994-0788-40ed-a90e-fd6820fd221c"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9848), 3, new Guid("66845820-77b6-42a7-86da-48d5a0cceddb") },
                    { new Guid("512f6cd7-ac2c-4138-9dd8-df95cd5f6c06"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9858), 3, new Guid("a8ee301e-35e9-49b7-baa4-59e826eef00f") },
                    { new Guid("6b6219a9-ff68-48e0-8324-8abf5a105709"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 17, 27, 666, DateTimeKind.Utc).AddTicks(9853), 4, new Guid("1bea04f7-0b83-4466-9e7b-9ede5ee22c04") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("062d7ca3-eb81-403b-bda3-179b562a2d42"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("1a6d430d-1e99-4b45-b7ef-7416741b410a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2218441e-c534-4e6f-a19f-3a1179c07e8e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("430caa84-7584-4de4-bb16-853bc2df60ec"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("47230278-304a-457e-8220-be3dde1c6104"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("47ecf625-14d2-473e-8b5a-6fe67da56c93"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7c798069-ff66-4a7a-aeae-d369ddcc6e83"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8b78d0e5-0b3f-479e-9801-e03b5fa0a3c8"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c06bd730-378b-4248-9fa8-4cb898f9d7ff"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("dd9d1499-5dc7-4cc4-a3b6-5497012ccc91"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2c0d1bb7-6fbd-42ce-81ed-6e2cddcb10e4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3e1be673-fd21-4bb3-8693-b3449bd2c5bd"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4fc7a994-0788-40ed-a90e-fd6820fd221c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("512f6cd7-ac2c-4138-9dd8-df95cd5f6c06"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6b6219a9-ff68-48e0-8324-8abf5a105709"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("025aeb44-2606-4f10-9ab7-6ce7fe2a3d04"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("313c974e-73d9-4229-ae58-12c456ceedca"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("3eb58096-5b1f-4e72-a1f8-82166c0c851b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("597faf59-d72d-4215-9f34-933f778be4eb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("78a5ef2b-caa3-4233-94b4-defbf6940b0d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a0c9e877-1eca-4ce2-99d3-d2979fa1f490"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3b996fe-0a69-4077-af78-94ca72f31346"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("acbfa524-c66b-40a5-a319-3603bbd2b613"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e1ca0d37-ec45-4592-972d-82911e22ec59"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e6fe14a8-d619-44fd-b43e-f623e651ac04"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0617f41a-28e9-4cba-b3b1-2d9f870006e2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0ca732f4-fc2a-41ce-8aa6-d23c1157ce30"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("33d254dc-746f-4485-b029-f6a6223068ee"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3f139227-9fb9-4394-a5b9-7053064aa97f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("94771e5d-5686-45ad-88d5-fa9d60a703e5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9ce523d8-f6e0-437c-b367-d04f49e8b739"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ae7cfc55-7e2d-4ff9-b5bb-df17ea169db7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cf62803b-5741-423b-90d5-fd70d40db155"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("efba83a0-8572-4721-bd8b-e6879be3e31b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fbb6d60e-61d7-4e9b-81d8-dcd4fbbcdaf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bea04f7-0b83-4466-9e7b-9ede5ee22c04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66845820-77b6-42a7-86da-48d5a0cceddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c68104f-86e1-4e91-9970-91c21dff19d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8ee301e-35e9-49b7-baa4-59e826eef00f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6deb7a6-f8cd-4f32-8e60-4d56988d243c"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "IsAvailable", "Number", "Picture", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("02ca5ab3-879d-43ee-8011-cfb9645e0eb0"), "Exclusive suite with a private lounge area.", true, 109, "Resources/familyRoom.jpg", 250.00m, 5 },
                    { new Guid("1251b1d1-a62c-4e91-80cc-7e3af0d0487f"), "Charming double room with artistic decor.", true, 110, "Resources/doubleRoom4.jpg", 135.00m, 2 },
                    { new Guid("2a8738e1-49b3-4bc7-a66c-2b288553a186"), "Cozy single room with a city view.", true, 101, "Resources/singleRoom1.jpg", 80.00m, 1 },
                    { new Guid("41f40c30-c38d-4226-910b-a0732e5f2d7d"), "Comfortable single room with free Wi-Fi.", true, 104, "Resources/singleRoom2.jpg", 75.00m, 1 },
                    { new Guid("52cd8e0e-157c-4fdd-b58b-ab1a77025328"), "Premium suite with a private hot tub.", true, 106, "Resources/quadRoom.jpg", 220.00m, 4 },
                    { new Guid("868e8158-15af-4e66-bfb9-b587bcbd0341"), "Luxury suite with a king-sized bed and ocean view.", true, 103, "Resources/tripleRoom1.jpg", 200.00m, 3 },
                    { new Guid("8850cdd5-0693-4b41-978c-0868310f85bd"), "Stylish double room with a city skyline view.", true, 108, "Resources/doubleRoom3.jpg", 140.00m, 2 },
                    { new Guid("a29813fb-af91-4a35-94dd-d3a9cd79cbcc"), "Spacious double room with modern amenities.", true, 102, "Resources/doubleRoom.jpg", 120.00m, 2 },
                    { new Guid("b7e342e3-78f8-4efa-9220-96057a4a9235"), "Elegant double room with a balcony.", true, 105, "Resources/doubleRoom2.jpg", 130.00m, 2 },
                    { new Guid("fd7057b0-3173-4830-8d91-60b12588cc5f"), "Modern single room with a work desk.", true, 107, "Resources/singleRoom3.jpg", 85.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0a277483-efb7-4a0a-90bc-ea94b67394c2"), "High-speed internet available in all areas.", "Wi-Fi Access" },
                    { new Guid("0ff5f592-9d21-40b5-8aba-e30853ba565b"), "Same-day laundry and dry-cleaning services.", "Laundry Service" },
                    { new Guid("2b4efcc2-43d0-4526-b909-a34c71a6119e"), "Convenient transport to and from the airport.", "Airport Shuttle" },
                    { new Guid("4145eeed-83a8-4a07-89aa-de1e8bf373f4"), "Fully equipped meeting and conference facilities.", "Conference Room" },
                    { new Guid("602a96fe-cf84-45fe-ae7a-9465112384ba"), "Access to our indoor heated pool.", "Swimming Pool" },
                    { new Guid("6e878fa7-45d9-4ab5-b4b2-60eb9678179d"), "Delicious breakfast with a variety of options.", "Breakfast Buffet" },
                    { new Guid("6e97adc4-c99e-428c-bc30-b16fb7894225"), "Relaxing full-body spa experience.", "Spa Treatment" },
                    { new Guid("d66fb193-2365-4183-8906-0c790c00cf59"), "Guided tour of local attractions.", "City Tour" },
                    { new Guid("d6c4923e-5106-4cf4-bbc6-1c7df4691566"), "Unlimited access to our state-of-the-art fitness center.", "Gym Access" },
                    { new Guid("f7a1a02e-6306-46a1-910e-0a64c95c3d20"), "24/7 room service with gourmet meals.", "Room Service" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AvatarUrl", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("7113759c-a0b6-426a-a198-eef3138f180b"), 35, "Resources/manAvatar.jpg", "bob@example.com", "hashedpassword", "BobJohnson" },
                    { new Guid("a751c353-65a2-4071-908f-eaac110f174a"), 28, "Resources/womanAvatar.jpg", "alice@example.com", "hashedpassword", "AliceSmith" },
                    { new Guid("aa3f6bb0-ce24-41c0-a8a8-23faacf8601b"), 30, "Resources/womanAvatar.jpg", "diana@example.com", "hashedpassword", "DianaWhite" },
                    { new Guid("bad94b84-51b7-4149-8c7b-47f58cb97216"), 33, "Resources/manAvatar.jpg", "edward@example.com", "hashedpassword", "EdwardBlack" },
                    { new Guid("f4b02a34-0e59-4cf8-90b6-de80d09f5bf8"), 40, "Resources/womanAvatar.jpg", "charlie@example.com", "hashedpassword", "CharlieBrown" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c706a82-6c42-4040-86ba-d5f00d53b3a4"), new DateTime(2025, 2, 20, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(537), new DateTime(2025, 3, 10, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(537), new Guid("868e8158-15af-4e66-bfb9-b587bcbd0341"), new Guid("7113759c-a0b6-426a-a198-eef3138f180b") },
                    { new Guid("3ce15e72-cf24-4625-89b8-70bfb4038f4e"), new DateTime(2025, 2, 28, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(541), new DateTime(2025, 3, 5, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(542), new Guid("b7e342e3-78f8-4efa-9220-96057a4a9235"), new Guid("f4b02a34-0e59-4cf8-90b6-de80d09f5bf8") },
                    { new Guid("6283b8f4-685f-4f1e-ae86-6ed93a3bb1ef"), new DateTime(2025, 2, 23, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(553), new DateTime(2025, 3, 2, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(553), new Guid("8850cdd5-0693-4b41-978c-0868310f85bd"), new Guid("aa3f6bb0-ce24-41c0-a8a8-23faacf8601b") },
                    { new Guid("86987b2e-9bc9-416f-992f-876a02c73a5a"), new DateTime(2025, 2, 28, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 3, 3, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(548), new Guid("fd7057b0-3173-4830-8d91-60b12588cc5f"), new Guid("aa3f6bb0-ce24-41c0-a8a8-23faacf8601b") },
                    { new Guid("9e631902-41e5-44f1-b60c-c2e251ddaa4b"), new DateTime(2025, 2, 25, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(539), new DateTime(2025, 3, 2, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(539), new Guid("41f40c30-c38d-4226-910b-a0732e5f2d7d"), new Guid("7113759c-a0b6-426a-a198-eef3138f180b") },
                    { new Guid("a60929cb-5e8c-4531-8829-51d5a5a5dac7"), new DateTime(2025, 2, 21, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(558), new DateTime(2025, 3, 7, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(559), new Guid("1251b1d1-a62c-4e91-80cc-7e3af0d0487f"), new Guid("bad94b84-51b7-4149-8c7b-47f58cb97216") },
                    { new Guid("b12ee2fe-7734-4ce9-89e6-def4db28be77"), new DateTime(2025, 2, 20, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 3, 8, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(528), new Guid("2a8738e1-49b3-4bc7-a66c-2b288553a186"), new Guid("a751c353-65a2-4071-908f-eaac110f174a") },
                    { new Guid("b177b9dc-96e4-4c1d-af1b-55ded58e6cc0"), new DateTime(2025, 2, 23, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(534), new DateTime(2025, 3, 8, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(535), new Guid("a29813fb-af91-4a35-94dd-d3a9cd79cbcc"), new Guid("a751c353-65a2-4071-908f-eaac110f174a") },
                    { new Guid("cf0a9a8a-a797-4cad-861f-8f083a2fcae1"), new DateTime(2025, 2, 24, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(545), new DateTime(2025, 3, 6, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(545), new Guid("52cd8e0e-157c-4fdd-b58b-ab1a77025328"), new Guid("f4b02a34-0e59-4cf8-90b6-de80d09f5bf8") },
                    { new Guid("ec46bc45-055a-4425-9176-c4eae3950b01"), new DateTime(2025, 2, 24, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(555), new DateTime(2025, 3, 7, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(556), new Guid("02ca5ab3-879d-43ee-8011-cfb9645e0eb0"), new Guid("bad94b84-51b7-4149-8c7b-47f58cb97216") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Message", "MessageStatus", "PublishedOn", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ce4f88f-9d45-4449-bb00-50cf2a6212ce"), "Amazing stay! CharlieBrown had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(630), 5, new Guid("f4b02a34-0e59-4cf8-90b6-de80d09f5bf8") },
                    { new Guid("bbc4cf9c-1413-4dd6-a661-d6ebeea961e4"), "Amazing stay! DianaWhite had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(633), 3, new Guid("aa3f6bb0-ce24-41c0-a8a8-23faacf8601b") },
                    { new Guid("c818d597-779b-4775-94ea-fc1044c04cba"), "Amazing stay! EdwardBlack had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(636), 3, new Guid("bad94b84-51b7-4149-8c7b-47f58cb97216") },
                    { new Guid("e71b5313-b1f2-4022-9e50-006c8b34a81b"), "Amazing stay! AliceSmith had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(622), 4, new Guid("a751c353-65a2-4071-908f-eaac110f174a") },
                    { new Guid("fff76c67-2d40-40ad-a71d-2d4ad647ae06"), "Amazing stay! BobJohnson had a wonderful experience.", 0, new DateTime(2025, 2, 19, 16, 6, 1, 266, DateTimeKind.Utc).AddTicks(627), 5, new Guid("7113759c-a0b6-426a-a198-eef3138f180b") }
                });
        }
    }
}
