using OpenQA.Selenium;

namespace ShopTests
{
    internal class AuthenticationPage
    {
        private IWebDriver driver;

        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}