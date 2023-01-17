using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAutorization_Test
{
    internal class SteamAutorization
    {
        private IWebDriver driver;

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

    }

}
