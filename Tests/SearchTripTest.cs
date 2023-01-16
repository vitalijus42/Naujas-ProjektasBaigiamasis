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
    internal class SearchTripTest
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
            SearchTrip.ClickOnFromField();
            SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-from')]");
            SearchTrip.EnterTextToFromField("Vilnius");
            SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-to')]");
            SearchTrip.EnterTextToToField("Kaunas");
            SearchTrip.HoverTheMouseOver("//*[@class='datepicker-input-container']");
            SearchTrip.ClickOnTimeField();
            SearchTrip.ClickOnSearchTrip();
            string actualText = SearchTrip.GetTheSelectedText();

            Assert.AreEqual(expectedText, actualText);
           }
        [Test] 
        public void ReturnTicketSearchTest ()
        {
            string ExpectedText = "Pasirinkite kelionę pirmyn";
            SearchTrip.ClickOnFromField();
            SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-from')]");
            SearchTrip.EnterTextToFromField("Vilnius");
            SearchTrip.HoverTheMouseOver("//*[@class='form-input' and contains(@aria-controls,'route-to')]");
            SearchTrip.EnterTextToToField("Ignalina");
     
            SearchTrip.HoverTheMouseOver("//*[@id='ticket-backward-checkbox']");
            SearchTrip.HoverTheMouseOver("//*[@aria-label='Mon Jan 23 2023']");
            SearchTrip.HoverTheMouseOver("//*[@id='return-time']");
            SearchTrip.EnterTextToReturnTimeField("{Home}1234");
            SearchTrip.HoverTheMouseOver("//span[contains(text(),'Ieškoti kelionės')]");
            string ActualText = SearchTrip.GetTheSelectedTextListName();

            Assert.AreEqual(ExpectedText, ActualText);


        }
           [TearDown]
           public void TearDown()
           {
            Driver.CloseDriver(); 
           }




    }
}