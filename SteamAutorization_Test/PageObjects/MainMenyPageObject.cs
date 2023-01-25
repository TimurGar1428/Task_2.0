using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        private readonly By _serchTerm = 
            By.XPath("//*[@id=\"store_nav_search_term\"]");
        private readonly By _serchButton =
            By.XPath("//*[@id=\"store_search_link\"]/img");

        public GameSerchPageObject gameSerch()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_serchTerm).SendKeys("Dota2"); // подтягивать из тест даты
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_serchButton).Click();

            return new GameSerchPageObject();
            // я завис на моменте сериализации таблицы в json
            // но я разберусь и доделаю


        }
        ///
        public ConfPoliticPageObject openConfPolit()
        {
            IWebElement iframe = driver.FindElement(_confPolitic);
            new Actions(driver)
                .ScrollToElement(iframe)
                .Perform();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(_confPolitic).Click();
            
            return new ConfPoliticPageObject(); //driver

        }
    }
}
