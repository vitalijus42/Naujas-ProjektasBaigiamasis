using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class TicketReturnTests
    {   
        [SetUp]
        public void SetUp()
        {
            Driver.CreateDriver();
            TicketReturn.Open();
        }
        [Test]
        public void TicketReturnAlertTest()
        {
            string ExpectedText = "Klaida!";
            TicketReturn.ClickReturnTicket();
            TicketReturn.ClickIHaveTicketNumber();
            //TicketReturn.HoverTheMouseOver("//*[@class='field-container__field ']");
            TicketReturn.EnterTextCity("Alytus");
            //TicketReturn.HoverTheMouseOver("//*[@class='field-container__field ']/input[2]");
            TicketReturn.EnterTextName("nznznz");
            TicketReturn.ClickContinueButton();

            string ActualText = TicketReturn.GetErrorText();

            Assert.AreEqual(ExpectedText, ActualText);

        }
        [TearDown]
        public void teardown()
        {
            Driver.CloseDriver();
        }




    }
}
    

