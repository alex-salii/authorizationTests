using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationPageTests.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _singInButton = By.XPath("//div[@class='Header_actions-item__3He6C']");

        public MainMenuPageObject(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public AuthorizationPageObject SingIn()
        {
            _webDriver.FindElement(_singInButton).Click();

            return new AuthorizationPageObject(_webDriver);
        }
    }
}
