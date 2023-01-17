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
        WebDriver driver = (WebDriver)Singleton.getInstance();
        private readonly By _signInButton =
            By.XPath("//*[@id=\"global_action_menu\"]/a");
        private readonly By _confPolitic =
            By.XPath("//*[@id=\"footer_text\"]/div[2]/a[1]");

        //public MainMenyPageObject(IWebDriver webDriver)
        //{
        //    _webDriver = webDriver;
        //}
        /// 
        //public AutorizationPageObjects SignIn()
        //{
        //    driver.FindElement(_signInButton).Click();

        //    return new AutorizationPageObjects(driver);
        //}
       
        ///
        public ConfPoliticPageObject openConfPolit()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_confPolitic).Click();
            
            return new ConfPoliticPageObject(driver);

        }
    }
}
