using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.OpenPage("https://autobusubilietai.lt");
            Common.WaitAndClick("//*[@aria-label='allow cookies']");
            
        }
    }
}
