using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Utilities
{
    public static class LanguageChanger
    {
        private static string _bgLanguage = "bg-BG";
        private static string _enLanguage = "en-US";
        private static string _currentLanguage = "bg-BG";

        public static void ChangeLanguage(string language)
        {
            if (language == _bgLanguage)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(_bgLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(_bgLanguage);
                _currentLanguage = _bgLanguage;
            }
            else if (language == _enLanguage)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(_enLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(_enLanguage);
                _currentLanguage = _enLanguage;
            }
        }
        public static string GetLanguage() 
        {
            return _currentLanguage;
        }
    }
}



