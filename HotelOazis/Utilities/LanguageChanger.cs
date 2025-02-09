using HotelOazis.Common.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelOazis.Common.Constants.GlobalConstants;

namespace HotelOazis.Utilities
{
    public static class LanguageChanger
    {
        private static string _currentLanguage = BgLanguage;

        public static void ChangeLanguage(string language)
        {
            if (language == BgLanguage)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(BgLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(BgLanguage);
                _currentLanguage = BgLanguage;
            }
            else if (language == EnLanguage)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(EnLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(EnLanguage);
                _currentLanguage = EnLanguage;
            }
        }
        public static string GetLanguage() 
        {
            return _currentLanguage;
        }
    }
}



