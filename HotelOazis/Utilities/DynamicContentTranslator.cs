using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelOazis.Common.Constants.GlobalConstants;

namespace HotelOazis.Utilities
{
    public static class DynamicContentTranslator
    {
        public static class EntitiesTranslation
        {
            public static string Username => LanguageChanger.GetLanguage() == BgLanguage ? "Потребителско име" : "Username";
            public static string UsernameExists => LanguageChanger.GetLanguage() == BgLanguage ? "Потребителското име е заето!" : "Such username exists!";

            public static string Password => LanguageChanger.GetLanguage() == BgLanguage ? "Парола" : "Password";
            public static string ProfilePicture => LanguageChanger.GetLanguage() == BgLanguage ? "Снимката е задължителна" : "Picture is required";
            public static string ProfileRegistered => LanguageChanger.GetLanguage() == BgLanguage ? "Успешна регистрация на потребител!" : "Profile registered successfully!";
            public static string ProfileUpdatedSuccessfully => LanguageChanger.GetLanguage() == BgLanguage ? "Успешна обновяване на потребител!" : "Profile updated successfully!";
            public static string ProfileUpdateFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно обновяване на потребител!" : "Failed to update profile! Please try again!";
            public static string ProfileDeleteWarning => LanguageChanger.GetLanguage() == BgLanguage ? "Сигурни ли сте че желаета да изтриете акаунта? Това е необратим процес!" : "Are you sure you want to delete your account? This action cannot be undone!";
            public static string ProfileDeletionSuccessful => LanguageChanger.GetLanguage() == BgLanguage ? "Акаунта ви бе успешно премахнат!" : "Your account has been deleted successfully!";
            public static string ProfileDeletionFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Акаунта ви не бе премахнат. Моля опитайте пак или се свържете с администратор!" : "Failed to delete the account! Please try again!";

            public static string EmptyInputData => LanguageChanger.GetLanguage() == BgLanguage ? "Моля попълнете всички задължителни полета!" : "Please fill in all input fields!";
            public static string EmptyOrInvalidImage => LanguageChanger.GetLanguage() == BgLanguage ? "Възникна грешка при обработката на снимката ви!" : "An error occured while processing your image!";
            public static string InvalidUserCredentials => LanguageChanger.GetLanguage() == BgLanguage ? "Невалидно потребителско име или парола!" : "Invalid username or password!";
            public static string RoomIsAlreadyReservated => LanguageChanger.GetLanguage() == BgLanguage ? "Избраната стая е вече резервирана в този диапазон!" : "The selected room is already reserved for the chosen dates!";
            public static string RoomIsUnavailable => LanguageChanger.GetLanguage() == BgLanguage ? "Избраната стая е неналична!" : "The selected room is currently inavailable!";
            public static string RoomNumberExists => LanguageChanger.GetLanguage() == BgLanguage ? "Стая с този номер вече съществува!" : "Such room number already exists";
            public static string InvalidCheckOutDate => LanguageChanger.GetLanguage() == BgLanguage ? "Датата на напускане трябва да бъде след датата на пристигане!" : "Check-out date must be later than check-in date!";
            public static string EmptyReviewMessage => LanguageChanger.GetLanguage() == BgLanguage ? "Моля попълнете текстовото поле преди да изпратите ревю!" : "Please write a review before submitting!";


            public static string ReadMore => LanguageChanger.GetLanguage() == BgLanguage ? "Прочети повече" : "Read more";
            public static string ItemName => LanguageChanger.GetLanguage() == BgLanguage ? "Име:" : "Name:";
            public static string ItemDescription => LanguageChanger.GetLanguage() == BgLanguage ? "Описание:" : "Description:";
            public static string WriteReviewPlaceholder => LanguageChanger.GetLanguage() == BgLanguage ? "Напиши своето ревю тук..." : "Write your review here...";
            public static string WritenOn => LanguageChanger.GetLanguage() == BgLanguage ? "На:" : "On:";
            public static string WritenAt => LanguageChanger.GetLanguage() == BgLanguage ? "В:" : "At:";
            public static string Update => LanguageChanger.GetLanguage() == BgLanguage ? "Обнови" : "Edit";
            public static string SendReview => LanguageChanger.GetLanguage() == BgLanguage ? "Изпрати" : "Send";

            public static string Reserve => LanguageChanger.GetLanguage() == BgLanguage ? "Запази" : "Reserve";
            public static string ReservedBy => LanguageChanger.GetLanguage() == BgLanguage ? "Резервирано от:" : "Reserved by:";
            public static string Cancel => LanguageChanger.GetLanguage() == BgLanguage ? "Откажи" : "Cancel";

            public static string Edit => LanguageChanger.GetLanguage() == BgLanguage ? "Редактирай" : "Edit";
            public static string Delete => LanguageChanger.GetLanguage() == BgLanguage ? "Изтрий" : "Delete";
            public static string AvailableMessage => LanguageChanger.GetLanguage() == BgLanguage ? "Налична" : "Available";
            public static string UnavailableMessage => LanguageChanger.GetLanguage() == BgLanguage ? "Неналична" : "Unavailable";

            public static string IsAvailableAnswer => LanguageChanger.GetLanguage() == BgLanguage ? "Да" : "Yes";
            public static string IsNotAvailableAnswer => LanguageChanger.GetLanguage() == BgLanguage ? "Не" : "No";

            public static string RoomNumber => LanguageChanger.GetLanguage() == BgLanguage ? "Стая:" : "Room:";
            public static string DaysReserved => LanguageChanger.GetLanguage() == BgLanguage ? "Резервирани дни:" : "Days Reserved:";
            public static string Price => LanguageChanger.GetLanguage() == BgLanguage ? "Цена:" : "Total price:";
            public static string CheckIn => LanguageChanger.GetLanguage() == BgLanguage ? "Настаняване:" : "Check in:";
            public static string CheckOut => LanguageChanger.GetLanguage() == BgLanguage ? "Напускане:" : "Check out:";
            public static string Confirmation => LanguageChanger.GetLanguage() == BgLanguage ? "Потвърждение" : "Confirmation";
            public static string ConfirmationMessage => LanguageChanger.GetLanguage() == BgLanguage ? "Сигурни ли сте, че искате да откажете резервацията?" : "Are you sure you want to cancel your reservation?";


            public static string RoomType => LanguageChanger.GetLanguage() == BgLanguage ? "Тип:" : "Type:";
            public static string Error => LanguageChanger.GetLanguage() == BgLanguage ? "Грешка" : "Error";
            public static string Success => LanguageChanger.GetLanguage() == BgLanguage ? "Успех" : "Success";
            public static string DeletionSuccessful => LanguageChanger.GetLanguage() == BgLanguage ? "Успешно изтриване" : "Deletion successful.";
            public static string DeletionFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно изтриване" : "Deletion failed.";
            public static string EditFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно редактиране" : "Edit Failed";
            public static string EditSucceeded => LanguageChanger.GetLanguage() == BgLanguage ? "Успешно редактиране" : "Updated successfully";

            public static string CreateFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно създаване" : "Create Failed";
            public static string CreatedSuccessfully => LanguageChanger.GetLanguage() == BgLanguage ? "Успешно създаване" : "Created successfully";

            public static string FieldLength => LanguageChanger.GetLanguage() == BgLanguage ? "{0} трябва да е минимум {1} символа" : "{0} should be atleast {1} characters long";
        }
    }
}
