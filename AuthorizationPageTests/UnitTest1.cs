using AuthorizationPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AuthorizationPageTests
{
    public class Tests
    {
        private IWebDriver _webDriver;




        private readonly By _verification = By.XPath("//div[@class='Auth_Title__3NDeg']");
        public const string exspectedText = "рекетнмс╙лн бюл";
        //public const string exspectedText = "hi";
        const string mainUrl = "https://helsi.me/";

        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            
            _webDriver.Manage().Window.Maximize();

            _webDriver.Navigate().GoToUrl(mainUrl);
            WaitUntil.ShouldLocate(_webDriver, mainUrl);
        }

        [Test]
        public void LoginAsUser_StandartBehavior_Logined()
        {

            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                .SingIn()
                .LogIn(UserNameForTests.phone, UserNameForTests.password);

            WaitUntil.WaitElement(_webDriver, _verification);
            string verificationText = _webDriver.FindElement(_verification).Text;
        

            Assert.AreEqual(exspectedText, verificationText, "this text is not correct");

            
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();

        }
    }
}