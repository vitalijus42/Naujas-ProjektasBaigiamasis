using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.POM
{
    public class languagesDemo
    {
        private static string url = "https://autobusubilietai.lt";
        private static string allowCookiesButton = "//*[@aria-label='allow cookies']";
        private static string languageLocatorButton = "//*[@class='language-dropdown dropdown ']";
        public static string EnglishLanguageLocator = "/*[@class='dropdown-content']/div[2]";
        private static string DropdownHeaderButtonLocator = "//*[@lang='en']";
        private static string MainLanguageLocator = "//*[@lang='lt']";

        public static void ClickEnglishLanguageButton()
        {
            Common.WaitForElementToBeClickable(EnglishLanguageLocator);
            Common.WaitAndClick(EnglishLanguageLocator);
        }

        

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.WaitAndClick(allowCookiesButton);
        }

        public static string GetTheSelectedLanguage()
        {
            return Common.GetElementText(DropdownHeaderButtonLocator);
        }

        

        public static void ClickLanguagesButtonOnHeader()
        {
            Common.WaitForElementToBeClickable(MainLanguageLocator);
            Common.WaitAndClick(MainLanguageLocator);
        }
    }
}
