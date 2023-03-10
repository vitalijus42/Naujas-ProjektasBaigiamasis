using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.POM
{
    public class TicketReturn
    {
        private static string url = "https://autobusubilietai.lt";
        private static string allowCookiesButton = "//*[@aria-label='allow cookies']";
        private static string returnButtonLocator = "//*[@class='button  is-inverted is-small ']";
        private static string toCityFieldLocator = "//*[@class='field-container__field ']/input";
        private static string toNameFieldLocator = "//*[@class='field-container__field ']/input[2]";
        private static string ErrorLocator = "//*[@class='alert-spacing']";
        private static string ByTicketNumberLocator = "//*[@class='radio ']";
        private static string ContinueButtonLocator = "//*[@class='button  ticket-search-submit']";

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.WaitAndClick(allowCookiesButton);
        }
        public static void EnterTextCity(string text)
        {
            Common.WaitForElementToBeClickable(toCityFieldLocator);
            Common.SendKeysToElement(toCityFieldLocator, text); ;
        }

        public static void EnterTextName(string text)
        {
            Common.WaitForElementToBeClickable(toCityFieldLocator);
            Common.SendKeysToElement(toNameFieldLocator, text); ;
        }

        public static string GetErrorText()
        {
            return Common.GetElementText(ErrorLocator);
        }

        public static void HoverTheMouseOver(string text)
        {
            Common.MoveMousePauseAndClick(returnButtonLocator, text);
        }

        

        public static void HoverTheMouseOverReturnTicket(string text)
        {
            Common.MoveMousePauseAndClick(returnButtonLocator, text);
        }

        public static void ClickNoTicketNumber(string v)
        {
            Common.WaitForElementToBeClickable("//*[@class='know-box-action-subcol']");
            Common.WaitAndClick("//*[@class='know-box-action-subcol']");
        }

        public static void ClickReturnTicket()
        {
            Common.WaitForElementToBeClickable("//*[@class='know-box-action-subcol']");
            Common.WaitAndClick("//*[@class='know-box-action-subcol']"); ;
        }

        public static void ClickIHaveTicketNumber()
        {
            Common.WaitForElementToBeClickable(ByTicketNumberLocator);
            Common.WaitAndClick(ByTicketNumberLocator);
        }

        public static void ClickContinueButton()
        {
            Common.WaitForElementToBeClickable(ContinueButtonLocator);
            Common.WaitAndClick(ContinueButtonLocator);
        }
    }
}
