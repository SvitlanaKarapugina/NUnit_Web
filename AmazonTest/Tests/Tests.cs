using AmazonTest.Core;
using AmazonTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace AmazonTest
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
            // Create web driver instance for Internet Explorer
            new DriverManager().LaunchBrowser();
        }

        [Test]
        public void Test1()
        {
            HomePage homePage = new HomePage();
            homePage.openHomePage();
        }
    }
}