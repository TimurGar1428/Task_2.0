using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace SteamAutorization_Test
{

    public class Tests
    {
        private IWebDriver driver;
        /// <summary>
        /// драйвер нужно сделать через синглтон для 2.1
        /// </summary>
        
        private readonly By _signInButton =
            By.XPath("//*[@id=\"global_action_menu\"]/a");
        private readonly By _loginInputBatton =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[1]/input");
        private readonly By _passwordInputButton =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[2]/input");
        private readonly By _continueButton =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[4]/button");
        private readonly By _errMassege =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/a");

        /// <summary>
        /// В дальнейшем, для хранения данных, нужно будет зазавести отдельный класс.
        /// UPD: рандомную строку нужно генерировать каждый раз
        /// </summary>

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private  string _login = RandomString(10) ;
        private  string _password = RandomString(10);
        
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://store.steampowered.com");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            var sigIn = driver.FindElement(_signInButton);
            sigIn.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var login = driver.FindElement(_loginInputBatton);//input login
            login.SendKeys(_login);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var password = driver.FindElement(_passwordInputButton);//input password
            password.SendKeys(_password);
            Assert.IsNotNull(login, "login is null");
            Assert.IsNotNull(password, "pasword is null");           

            var continueLogin = driver.FindElement(_continueButton);
            continueLogin.Click();

            //data correctness check
            var visibility = driver.FindElement(_errMassege);
            Assert.IsNull(visibility, "incorrect login or password data");

        }
        [TearDown]
        public void TernDown()
        {
            driver.Quit();
        }
    }
}