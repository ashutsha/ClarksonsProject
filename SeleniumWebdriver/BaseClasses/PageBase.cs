using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebdriver.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;

        
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver,this);
            this.driver = _driver;
        }
              
        public string Title
        {
            get { return driver.Title; }
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public ICollection<IWebElement> FindElements(By locator)
        {
            return driver.FindElements(locator);
        }

        public bool IsElementPresent(By locator)
        {
            
            bool elementPresent = this.FindElements(locator).Count>0;
            return elementPresent;
        }

       

        public void typeClean(By locatorOfInpitField, String text)
        {
            IWebElement input = this.FindElement(locatorOfInpitField);
            if (!input.GetAttribute("value").Equals(text))
            {
                input.Clear();
                if (text != null)
                {
                    if (!text.Equals(""))
                    {
                        input.SendKeys(text);
                    }
                }
            }
        }
    }
}
