using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class TopStoriesGooglePage : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        private String tabSection = "//c-wiz//*[@class='XvhY1d']//*[@class='uyYuVb oJeWuf']//span[contains(text(),'{0}')]";
        private By newsLocator = By.XPath("//*[@class='deQdld']//c-wiz[@class='lPV2Xe k3Pzib']//*[@class='X20oP'][contains(@jsaction,'click')]");
        private By imagesLocator = By.XPath("//*[@class='deQdld']//c-wiz[@class='lPV2Xe k3Pzib']/div/div/a/img");


        #endregion

        public TopStoriesGooglePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        public bool verifySectionName(string secName)
        {
            By tabSectionName = By.XPath(string.Format(tabSection,secName));
            return IsElementPresent(tabSectionName);
        }

        public bool checkImagesForNews()
        {
            bool imagesPresent = false;    
            int totalNewscount = FindElements(newsLocator).Count;
            int totalImgCount = FindElements(imagesLocator).Count;
            Console.WriteLine("Total news Count: " + totalNewscount + ", Total image Count: " +totalImgCount);
            if (totalNewscount != totalImgCount)
            {
                return false;
            }
            foreach (IWebElement image in FindElements(imagesLocator))
            {
                if (image.GetAttribute("src").Contains("https://"))
                {
                    imagesPresent = true;
                }
                else
                      return false;
            }
            return imagesPresent;
        }


       
    }
}
