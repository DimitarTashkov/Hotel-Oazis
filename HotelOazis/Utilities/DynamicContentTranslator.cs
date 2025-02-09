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
        public static class RoomsTranslator
        {
            public static string ReadMore => LanguageChanger.GetLanguage() == BgLanguage ? "Прочети повече" : "Read more";
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
            public static string DeletionSuccessful => LanguageChanger.GetLanguage() == BgLanguage ? "Успешно изтриване на стаята." : "Room deletion successful.";
            public static string DeletionFailed => LanguageChanger.GetLanguage() == BgLanguage ? "Неуспешно изтриване на стаята." : "Room deletion failed.";
        }
    }
}
