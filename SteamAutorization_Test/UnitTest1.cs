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
        //protected IWebDriver driver;
        WebDriver driver = (WebDriver)Singleton.getInstance();
        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
           // driver = new ChromeDriver();
        }
        private readonly By _language = By.XPath("//div[@id='languages']");
        private readonly By _dataRu = By.XPath("//*[@id=\"newsColumn\"]/i[3]");
        private readonly By _data = By.XPath("//*[@id=\"newsColumn\"]/i[3]");

        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void Test1()
        {
         
            string originalWindow = driver.CurrentWindowHandle;
            var PolitInfo = new MainMenyPageObject();
            PolitInfo
                .openConfPolit();
            
           

            
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            var visibilityError = driver.FindElement(_language);
            Assert.IsNotNull(visibilityError, "Активные элементы переключения языка не видны");


            String text = driver.FindElement(_dataRu).Text;
            Console.WriteLine(text);

            object actual = text;
            object expected = "Дата редакции: 1 января 2023 г."; 
            Assert.AreEqual(expected, actual, "неверная дата подписания");
           
        }
        [TearDown]
        public void TernDown()
        {
           driver.Quit();
        }
    }
}