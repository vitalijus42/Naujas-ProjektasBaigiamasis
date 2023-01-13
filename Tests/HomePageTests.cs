
using Framework;
using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class HomePageTests
    {
        [Test]
        public void Test()
        {
            Driver.CreateDriver();
            HomePage.Open();
        }
    }
}
