using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorizationPageTests.PageObjects
{
    class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _inputNumberPhone = By.XPath("//input[@id='phone']");
        private readonly By _submitButton = By.XPath("//button[@type='submit']");
        private readonly By _inputPassword = By.XPath("//input[@id='password']");

        

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject LogIn( string phone, string password)
        {
            WaitUntil.WaitElement(_webDriver, _inputNumberPhone);
            _webDriver.FindElement(_inputNumberPhone).SendKeys(phone);

            _webDriver.FindElement(_submitButton).Click();

            WaitUntil.WaitElement(_webDriver, _inputPassword);

            _webDriver.FindElement(_inputPassword).SendKeys(password);
          
            _webDriver.FindElement(_submitButton).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}
