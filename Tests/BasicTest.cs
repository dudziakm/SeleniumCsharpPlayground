using NUnit.Framework;
using SeleniumTestCsharp.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTestCsharp;
namespace SeleniumTestCsharp.Tests
{
    [TestFixture]
    public class BasicTest
    {
        [SetUp]
        public void StartUpTest()
        {
            Browsers.Init();
        }
        [TearDown]
        public void EndTest()
        {
            Browsers.Close();
        }
        [Test]
        public void HelloWorldTest()
        {
            //Pages.home.isAt();
            //Pages.home.EnterSearchText("Hello World");
        }

    }
}
