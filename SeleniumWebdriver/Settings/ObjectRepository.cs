using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.PageObject;

namespace SeleniumWebdriver.Settings
{
    public static class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static TopStoriesGooglePage hPage;
       
    }
}
