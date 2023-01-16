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
        public void TicketReturnTest()
        {

            string ExpectedText = "Klaida!";
            TicketReturn.HoverTheMouseOver("//*[@class='button  is-inverted is-small ']");
            TicketReturn.HoverTheMouseOver("//div[contains(text(),'Neturiu bilieto numerio')");
            TicketReturn.HoverTheMouseOver("//*[@class='field-container__field ']");
            TicketReturn.EnterTextCity("Alytus");
            TicketReturn.HoverTheMouseOver("//*[@class='field-container__field ']/input[2]");
            TicketReturn.EnterTextName("nznznz");
            TicketReturn.HoverTheMouseOver("//*[@class='button  ticket-search-submit ']/");

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
    

