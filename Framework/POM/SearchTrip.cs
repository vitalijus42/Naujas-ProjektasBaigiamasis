using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.POM
{
    public class SearchTrip
    {
        private static string url = "https://autobusubilietai.lt";
        private static string allowCookiesButton = "//*[@aria-label='allow cookies']";
        private static string fromFieldLocator = "//*[@class='form-input' and contains(@aria-controls,'route-from')]";
        private static string toFieldLocator = "//*[@class='form-input' and contains(@aria-controls,'route-to')]";
        private static string toDateLocator = "//*[@class='datepicker-input-container']";
        private static string toTimeLocator = "//*[@class='datepicker-container ']/label[2]";
        private static string toSearchLocator = "//*[@class='button  is-danger is-big ']";
        private static string elementTextLocator = "//*[@class='search-results-list__route title-primary']";
        private static string fromReturnTimeLocator = "//*[@for='return-time']";
        private static string elementListNameLocator = "//*[@class='search-results-list__route title-primary']";

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.WaitAndClick(allowCookiesButton);
        }
        public static void ClickOnFromField()
        {
            
            Common.WaitAndClick(fromFieldLocator);
        }

        public static void EnterTextToFromField(string text)
        {
            Common.WaitForElementToBeClickable(fromFieldLocator);
            Common.SendKeysToElement(fromFieldLocator, "Vilnius");
            Common.ClickElement("//*[@id='react-autowhatever-route-from']/ul/li[1]");
        }

        public static void ClickOnToField()
        {
            Common.WaitForElementToBeClickable(toFieldLocator);
            Common.WaitAndClick(toFieldLocator);
        }

        public static void EnterTextToToField(string text)
        {
            Common.WaitForElementToBeClickable(toFieldLocator);
            Common.SendKeysToElement(toFieldLocator, "Kaunas");
        }

        public static void ClickOnDateField()
        {
            Common.WaitForElementToBeClickable(toDateLocator);
            Common.WaitAndClick(toDateLocator);
        }

        public static void ClickOnTimeField()
        {
            Common.WaitForElementToBeClickable(toTimeLocator);
            Common.WaitAndClick(toTimeLocator);
        }

        public static void ClickOnSearchTrip()
        {
            Common.WaitForElementToBeClickable(toSearchLocator);
            Common.WaitAndClick(toSearchLocator);
        }

        public static void HoverTheMouseOver(string text)
        {
            Common.MoveMousePauseAndClick(fromFieldLocator, text);
        }

        public static string GetTheSelectedText()
        {
            return Common.GetElementText(elementTextLocator);
        }

        public static void EnterTextToReturnTimeField(string text)
        {
            Common.WaitForElementToBeClickable(fromReturnTimeLocator);
            Common.SendKeysToElement(fromReturnTimeLocator, "1450");
        }

        public static string GetTheSelectedTextListName()
        {
            return Common.GetElementText(elementListNameLocator);
        }

        public static void Click()
        {
            Common.ClickElement("//*[@for='ticket-backward-checkbox']");
        }

        public static void ClickOnSearchTrip1()
        {
            Common.ClickElement("//*[@class='search-form-button']/button");
        }

        public static void HoverTheMouseOverTicketBackward(string text)
        {
            Common.MoveMousePauseAndClick("//*[@for='ticket-backward-checkbox']", text);
        }

        public static void EnterTextToToField1(string text)
        {
            Common.WaitForElementToBeClickable(toFieldLocator);
            Common.SendKeysToElement(toFieldLocator, "Ignalina");
            Common.ClickElement("//*[@id='react-autowhatever-route-to']/ul/li[1]");
        }

        public static void HoverTheMouseOverAndClick(string text)
        {
            Common.MoveMousePauseAndClick(fromFieldLocator, text);
        }
    }
}

    
