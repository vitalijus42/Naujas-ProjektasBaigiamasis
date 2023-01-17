using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

        public static void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        
        public static void TakeScreenshot(string fullName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string ScrrenshotName = $"{screenshotsDirectoryPath}\\scr-{Guid.NewGuid()}.png";

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
        }
    }
}
//*[@class='preloader__spinner']
//span[contains(text(),'Sisters') and not(contains(@class,'mobile')) ]
//*[@class='form-input' and contains(@aria-controls,'route-from')]
//*[@id='ticket-backward-checkbox']
//*[@id='return-date']
//*[@id='return-time']
//span[contains(text(),'Ieškoti kelionės')]
//*[@id='depart-date']
//*[@id='depart-time']
//*[@class='search-results']
//*[class='field-container__field-error']
//*[@id='by Ticket']
//*[@id='byTravel']
//*[(@class= 'form-input')]
//*[(@class= 'form-input ')]
//*[@id='destination-date']
//*[@class='alert-content'}/div[2]
//*[@class='button  ticket-search-submit']
//*[@class='form-input ']
//*[@class='form-input has-icon']
//*[class='button  ']






