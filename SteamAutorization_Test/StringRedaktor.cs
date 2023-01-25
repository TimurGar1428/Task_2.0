using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SteamAutorization_Test
{
    internal class StringRedaktor
    {
        WebDriver driver = (WebDriver)Singleton.getInstance();

        private readonly By _data =
            By.XPath("//*[@id=\"newsColumn\"]/i[3]");
        bool exp = false;
        public bool ConfPolitCheck()
        {

            String text = driver.FindElement(_data).Text;
            string s = text;
            var result = s.Split(' ').Skip(4).Take(1).FirstOrDefault();
            Regex regex = new Regex("\\b\\d{4}\\b");

            object actual = regex.Match(s);
            string actual_year = actual.ToString();
            string expected_year = DateTime.Now.Year.ToString();


           
            if (actual_year == expected_year)
            {
                exp = true;
            }
            return exp;            
        }
    }
}
