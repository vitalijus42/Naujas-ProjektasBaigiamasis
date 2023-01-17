using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HeaderDemo
    { //*[@class="header-menus"]/div/div
        private static string url = "https://autobusubilietai.lt";
        private static string allowCookiesButtonLocator = "//*[@aria-label='allow cookies']";
        private static string headerButtonMessageLocator = "//*[@class=\"header-menus\"]/div/div";
        private static string sendCopyLocator = "//*[@name='sendCopy']";
        private static string LoginLocator = "//*[@class=\"header-menus\"]/div/div[2]";
        private static string CloseButtonLocator = "//*[@class='button  only-icon is-danger button-close modal-close-button']";

        public static void ClickOnCloseButton()
        {
            Common.WaitForElementToBeClickable(CloseButtonLocator);
            Common.WaitAndClick(CloseButtonLocator);
        }

        public static void ClickOnLoginLable()
        {
            Common.WaitForElementToBeClickable(LoginLocator);
            Common.WaitAndClick(LoginLocator);
        }

        public static void ClickOnMessageElement()
        {
            Common.WaitForElementToBeClickable(headerButtonMessageLocator);
            Common.WaitAndClick(headerButtonMessageLocator);
        }

        public static void ClickOnSendCopyElement()
        {
            Common.WaitForElementToBeClickable(sendCopyLocator);
            Common.WaitAndClick(sendCopyLocator);
        }

        public static void Open()
        {
            Driver.OpenPage(url);
            Common.WaitAndClick(allowCookiesButtonLocator);
        }
    }
       
        
}
