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
        WebDriver driver = (WebDriver)Singleton.getInstance();      
        [SetUp]
        public void Setup()
        {            
            
        }

        [Test]
        public void Test_PrivacyPolicy()
        {         
            string originalWindow = driver.CurrentWindowHandle;
            var PolitInfo = new MainMenyPageObject();
            PolitInfo.openConfPolit();  //переход на страницу политики           
           
            foreach (string window in driver.WindowHandles) //перевод драйвера на новую страницу
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            var checData = new StringRedaktor();
            checData.ConfPolitCheck();// проверка видимости элементов и корректности даты
            Assert.IsTrue(checData.ConfPolitCheck(), "Неверная дата подписания политики конфиденциальности");

            var CheckLang = new ConfPoliticPageObject();
            CheckLang.langCheck();//чек работоспособности элементов 
            driver.SwitchTo().Window(originalWindow);
        }
        [Test]
        public void TestGameSearch()
        {
            string originalWindow = driver.CurrentWindowHandle;
            var GameSerch = new MainMenyPageObject();
            GameSerch.gameSerch();

            foreach (string window in driver.WindowHandles) //перевод драйвера на новую страницу
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }

            EnviromentConstantWriter enviromentConstantWriter= new EnviromentConstantWriter();
            enviromentConstantWriter.WriteDown();

        }

        [TearDown]
        public void TernDown()
        {
          driver.Quit();
        }
    }
}