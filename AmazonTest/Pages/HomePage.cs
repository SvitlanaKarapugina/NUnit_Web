using AmazonTest.Core;
using AmazonTest.Elements;

namespace AmazonTest.Pages
{
    public class HomePage : HomePageElements
    {

        public HomePage openHomePage()
        {
            DriverManager.Driver.Navigate().GoToUrl("https://medium.com");
            return this;
        }
    }
}
