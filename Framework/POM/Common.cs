
using SeleniumExtras;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace Framework.POM
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static string GetElementText(string locator)
        {
            return GetElement (locator).Text;
        }
        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }
       


        internal static void WaitAndClick(string locator)
        {
            WaitForElementToBeClickable(locator);
            ClickElement(locator);
        }
        internal static void MoveMousePauseAndClick(string locator, string text)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());

            actions.MoveToElement(element);
            actions.MoveByOffset(2, 2);
            actions.Pause(TimeSpan.FromSeconds(2));
            actions.Perform();

            
        }
    }
}
