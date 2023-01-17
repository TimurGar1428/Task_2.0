using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAutorization_Test
{
    public static class Singleton
    {       
         public static IWebDriver driver;
         public static IWebDriver getInstance()
         {
           if (driver == null)
           {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--incognito");
                driver = new ChromeDriver(chromeOptions);
                driver.Navigate().GoToUrl("https://store.steampowered.com");
                driver.Manage().Window.Maximize();
            }
           return driver;
         }
        
    }
}
