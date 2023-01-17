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
using Tests.BaseClasses;

namespace Tests
{
    internal class SearchTripTest : BaseSearchTripDemo
    {
        [SetUp]
        public void SetUp()
        {
            Driver.CreateDriver();
            SearchTrip.Open();
            
        }
        [Test]
        public void SearchTripTest1()
        {
            string expectedText = "Vilnius - Kaunas";
            //SearchTrip.ClickOnFromField();
            //SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-from')]");
            SearchTrip.EnterTextToFromField("Vilnius");
           /* SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-to')]")*/;
            SearchTrip.EnterTextToToField("Kaunas");
            //SearchTrip.HoverTheMouseOverAndClick("//*[@class='datepicker-input-container']");
            //SearchTrip.ClickOnTimeField();
            SearchTrip.ClickOnSearchTrip();
            string actualText = SearchTrip.GetTheSelectedText();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test] 
        public void ReturnTicketSearchTest()
        {
            string ExpectedText = "Pasirinkite kelionę pirmyn";
            //SearchTrip.ClickOnFromField();
            //SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-from')]");
            SearchTrip.EnterTextToFromField("Vilnius");
            //SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-to')]");
            SearchTrip.EnterTextToToField1("Ignalina");
            SearchTrip.Click();

            //SearchTrip.HoverTheMouseOverTicketBackward("");
            ////SearchTrip.HoverTheMouseOver("//*[@aria-label='Mon Jan 23 2023']");
            //SearchTrip.HoverTheMouseOver("//*[@for='return-time']");
            //SearchTrip.EnterTextToReturnTimeField("");
            SearchTrip.ClickOnSearchTrip1();
            string ActualText = SearchTrip.GetTheSelectedTextListName();

            Assert.AreEqual(ExpectedText, ActualText);

           //[Test]


        }
           [TearDown]
           public void TearDown()
           {
            Driver.CloseDriver();
        }

    }
}