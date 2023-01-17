using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAutorization_Test.PageObjects
{
    class AutorizationPageObjects
    {
        private IWebDriver _webdriver;

        private readonly By _loginInputBatton =
           By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[1]/input");
        private readonly By _passwordInputButton =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[2]/input");
        private readonly By _continueButton =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/div[4]/button");
        private readonly By _errMassege =
            By.XPath("/html/body/div[1]/div[7]/div[6]/div/div[1]/div/div/div/div[2]/div/form/a");
        private readonly By _spinerAction =
            By.XPath("//*[@id=\"responsive_page_template_content\"]/div/div[1]/div/div/div/div[2]/div/form/div[4]/button/div/div");


        //public AutorizationPageObjects(IWebDriver webdriver)
        //{
        //    _webdriver = webdriver;
        //}

        //public MainMenyPageObject Login(string login, string password)
        //{
        //    _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    _webdriver.FindElement(_loginInputBatton).SendKeys(login);            

        //    _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    _webdriver.FindElement(_passwordInputButton).SendKeys(password);
        //    _webdriver.FindElement(_continueButton).Click();

        //    return new MainMenyPageObject(_webdriver);

        //}
    }
}

