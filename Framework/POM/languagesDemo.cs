using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class languagesDemo
    {
        private static string url = "https://autobusubilietai.lt";
        private static string allowCookiesButton = "//*[@aria-label='allow cookies']";
        private static string languageLocatorButton = "//*[@class='language-dropdown dropdown ']/div";
        public static string EnglishLanguageLocator = "en";
        private static string DropdownHeaderButtonLocator = "header-en";

        public static void ClickEnglishLanguageButton()
        {
            Common.WaitForElementToBeClickable(EnglishLanguageLocator);
            Common.WaitAndClick(EnglishLanguageLocator);
        }

        public static void HoverTheMouseOver(string text)
        {
            Common.MoveMousePauseAndClick(languageLocatorButton, text);
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
    }
}
