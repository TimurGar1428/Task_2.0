using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SteamAutorization_Test.PageObjects;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace SteamAutorization_Test
{

    public class BaseTests
    {
        protected IWebDriver driver;
        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
           // driver = new ChromeDriver();
        }
        private readonly By _language = By.XPath("//div[@id='languages']");

        [SetUp]
        public void Setup()
        {
            
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            driver= new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://store.steampowered.com");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
           // var mainMenu = new MainMenyPageObject(driver);
           // mainMenu
             //    .SignIn()
            ///     .Login(UserNameForTests.StartLogin, UserNameForTests.StartLoginPassword);

            //Assert.IsNotNull(login, "login is null");
            // Assert.IsNotNull(password, "pasword is null");
            // 
            var PolitInfo = new MainMenyPageObject(driver);
            PolitInfo
                .openConfPolit()
                .ConfPolitCheck();
            
            var visibilityError = driver.FindElement(_language);
            Assert.IsNull(visibilityError, "Активные элементы переключения языка не видны");

            // var visibilitySpiner = driver.FindElement(AutorizationPageObjects._spinerAction);
            // Assert.IsNotNull(visibilitySpiner, "Loading element is not displayed");

            //data correctness check
            //var visibilityError = driver.FindElement(_errMassege);
            // Assert.IsNull(visibilityError, "incorrect login or password data");

        }
        [TearDown]
        public void TernDown()
        {
          //  driver.Quit();
        }
    }
}