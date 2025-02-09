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
            public static string ReadMore => LanguageChanger.GetLanguage() == BgLanguage ? "Прочети повече" : "Read more";
            public static string ItemName => LanguageChanger.GetLanguage() == BgLanguage ? "Име:" : "Name:";
            public static string ItemDescription => LanguageChanger.GetLanguage() == BgLanguage ? "Описание:" : "Description:";
            public static string WriteReviewPlaceholder => LanguageChanger.GetLanguage() == BgLanguage ? "Напиши своето ревю тук..." : "Write your review here...";
            public static string WritenOn => LanguageChanger.GetLanguage() == BgLanguage ? "На:" : "On:";
            public static string WritenAt => LanguageChanger.GetLanguage() == BgLanguage ? "В:" : "At:";
            public static string UpdateReview => LanguageChanger.GetLanguage() == BgLanguage ? "Обнови" : "Edit";
            public static string SendReview => LanguageChanger.GetLanguage() == BgLanguage ? "Изпрати" : "Send";

            public static string Reserve => LanguageChanger.GetLanguage() == BgLanguage ? "Резервирай" : "Reserve";
            public static string Edit => LanguageChanger.GetLanguage() == BgLanguage ? "Редактирай" : "Edit";
            public static string Delete => LanguageChanger.GetLanguage() == BgLanguage ? "Изтрий" : "Delete";
            public static string Available => LanguageChanger.GetLanguage() == BgLanguage ? "Налична:" : "Available:";
            public static string IsAvailable => LanguageChanger.GetLanguage() == BgLanguage ? "Да" : "Yes";
            public static string IsNotAvailable => LanguageChanger.GetLanguage() == BgLanguage ? "Не" : "No";

            public static string RoomNumber => LanguageChanger.GetLanguage() == BgLanguage ? "Стая:" : "Room:";
            public static string RoomType => LanguageChanger.GetLanguage() == BgLanguage ? "Тип:" : "Type:";
            public static string Error => LanguageChanger.GetLanguage() == BgLanguage ? "Грешка" : "Error";
            public static string Success => LanguageChanger.GetLanguage() == BgLanguage ? "Успех" : "Success";
            public static string DeletionSuccessful => LanguageChanger.GetLanguage() == BgLanguage ? "Успешно изтриване" : "Deletion successful.";
            public static string DeletionFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно изтриване" : "Deletion failed.";
            public static string EditFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно редактиране" : " Edit Failed";

        }
    }
}
