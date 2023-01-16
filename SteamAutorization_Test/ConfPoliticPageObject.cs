using OpenQA.Selenium;
using SteamAutorization_Test.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAutorization_Test
{
    internal class ConfPoliticPageObject
    {
        private IWebDriver _webdriver;
        private readonly By _EngLanguge =
           By.XPath("//*[@id=\"languages\"]/a[1]");
        private readonly By _SpanLanguage = 
           By.XPath("//*[@id=\"languages\"]/a[2]");

        public ConfPoliticPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public MainMenyPageObject ConfPolitCheck()
        {
            _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _webdriver.FindElement(_EngLanguge).Click();

            _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _webdriver.FindElement(_SpanLanguage).Click();

            return new MainMenyPageObject(_webdriver);

        }

    }
}
