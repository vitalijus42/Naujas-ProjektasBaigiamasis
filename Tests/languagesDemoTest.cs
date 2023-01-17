using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Net.NetworkInformation;

namespace Tests
{
    internal class languagesDemotests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.CreateDriver();
            languagesDemo.Open();
        }
        [Test]
        public void ChangeLanguageDropdown()
        {

            string ExpectedLanguage = "EN";
            languagesDemo.HoverTheMouseOverAndClickOnElement("");
            languagesDemo.ClickEnglishLanguageButton();
            string actualLanguage = languagesDemo.GetTheSelectedLanguage();

            Assert.AreEqual(ExpectedLanguage, actualLanguage);  


        }
        [TearDown]
        public void teardown()
        {
            Driver.CloseDriver();
        }




    }
}

