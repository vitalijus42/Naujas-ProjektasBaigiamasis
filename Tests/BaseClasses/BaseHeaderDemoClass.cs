using Framework;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
namespace Tests.BaseClasses
{
    internal class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
        {
            Driver.CreateDriver();
        }
        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
            }
            Driver.CloseDriver();
        }

    }
}
