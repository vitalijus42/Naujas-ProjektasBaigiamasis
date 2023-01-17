using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class HeaderDemoTests
    {
        [SetUp]
        public void setup()
        {
            Driver.CreateDriver();
            HeaderDemo.Open();
        }
        [Test]
        public void HeaderTestMessageFunctionalityTest()
        {
            HeaderDemo.ClickOnMessageElement();
            HeaderDemo.ClickOnSendCopyElement();
            HeaderDemo.ClickOnMessageSendButton();
        }
        [Test]
        public void LoginOpenAndCloseFunctionalityTest()
        {
            HeaderDemo.ClickOnLoginLable();
            HeaderDemo.ClickOnCloseButton();
        }
        [TearDown]
        public void teardown()
        {
            Driver.CloseDriver();
        }
    }
}
