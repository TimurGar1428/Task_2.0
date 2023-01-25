using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SteamAutorization_Test.PageObjects
{
    internal class ConfPoliticPageObject
    {
        WebDriver driver = (WebDriver)Singleton.getInstance();

        public readonly By _language =
            By.XPath("//div[@id='languages']");
      
        private readonly By _EngLanguge =
           By.XPath("//*[@id=\"languages\"]/a[1]");

        private readonly By _SpaLanguage =
           By.XPath("//*[@id=\"languages\"]/a[2]");

        private readonly By _FraLanguage =
           By.XPath("//*[@id=\"languages\"]/a[3]");

        private readonly By _GerLanguage =
           By.XPath("//*[@id=\"languages\"]/a[4]");

        private readonly By _ItaLanguage =
           By.XPath("//*[@id=\"languages\"]/a[5]");

        private readonly By _RusLanguage =
           By.XPath("//*[@id=\"languages\"]/a[6]");
      
        private readonly By _JapLanguage =
           By.XPath("//*[@id=\"languages\"]/a[7]");

        private readonly By _PorLanguage =
           By.XPath("//*[@id=\"languages\"]/a[8]");

        private readonly By _BraLanguage =
           By.XPath("//*[@id=\"languages\"]/a[9]");
              
        public void langCheck()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_EngLanguge).Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_SpaLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_FraLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_GerLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_ItaLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_RusLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_JapLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_PorLanguage).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_BraLanguage).Click();

        }

    }
}
