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
        private static string languageLocatorButton = "//*[@class='language-dropdown dropdown ']/div";
        public static string EnglishLanguageLocator = "//*[@id='react-autowhatever-route-to']/ul/li[1]";
        private static string DropdownHeaderButtonLocator = "//*[@lang='en']";

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

        public static void HoverTheMouseOverAndClickOnElement(string text)
        {
            Common.MoveMousePauseAndClick(languageLocatorButton, text);
        }
    }
}
