using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class VerifySectionNameAndImage
    {
        private TopStoriesGooglePage tpage;

        [Given(@"I am on google news page")]
        public void GivenIAmOnGoogleNewsPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [When(@"I go to sections")]
        public void WhenIGoToSections()
        {
            //   ScenarioContext.Current.Pending();
        }

        [Then(@"I should see '(.*)' in section names")]
        public void ThenIShouldSeeInSectionNames(string secName)
        {
            tpage = new TopStoriesGooglePage(ObjectRepository.Driver);

            Assert.IsTrue(tpage.verifySectionName(secName), secName+" is not present in Sections, Please check.");
        }

        [Then(@"I should see images next to each news on page")]
        public void ThenIShouldSeeImagesNextToEachNewsOnPage()
        {
            tpage = new TopStoriesGooglePage(ObjectRepository.Driver);
            Assert.IsTrue(tpage.checkImagesForNews(), "Check images are not present for all news on page");

        }


    }
}
