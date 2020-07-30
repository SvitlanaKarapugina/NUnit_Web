using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonTest.Core
{
    public class DriverManager
    {
        public static IWebDriver Driver { get; set; } = null;


        private static IWebDriver CreateDriver()
        {

            Driver = new ChromeDriver();
            return Driver;
        }

        public void LaunchBrowser()
        {
            Driver = CreateDriver();
            Driver.Manage().Window.Maximize();
        }
    }

}
