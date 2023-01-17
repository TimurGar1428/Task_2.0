using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAutorization_Test.PageObjects
{
    internal class MainMenyPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _signInButton =
            By.XPath("//*[@id=\"global_action_menu\"]/a");
        private readonly By _confPolitic =
            By.XPath("//*[@id=\"footer_text\"]/div[2]/a[1]");

        public MainMenyPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        /// 
        public AutorizationPageObjects SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();

            return new AutorizationPageObjects(_webDriver);
        }
       
        ///
        public ConfPoliticPageObject openConfPolit()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _webDriver.FindElement(_confPolitic).Click();
            return new ConfPoliticPageObject(_webDriver);

        }
    }
}
