using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelOazis.Migrations
{
    /// <inheritdoc />
    public partial class fixMediaSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
