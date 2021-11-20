using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ProfileLanguageSteps
    {
        [Given(@"the user click on the language tab")]
        public void GivenTheUserClickOnTheLanguageTab()
        {
            ProfileLanguagePage.UserClickOnTheLanguageTab();
        }

        [When(@"the user clicks the Add New button and enters language and language level")]
        public void WhenTheUserClicksTheAddNewButtonAndEntersLanguageAndLanguageLevel()
        {
            ProfileLanguagePage.UserClicksTheAddNewButtonAndEntersLanguageAndLanguageLevel();
        }

        [Then(@"the language details added should now be saved")]
        public void ThenTheLanguageDetailsAddedShouldNowBeSaved()
        {
            ProfileLanguagePage.LanguageDetailsAddedShouldNowBeSaved();
        }

        [When(@"the user edits their language details and clicks update")]
        public void WhenTheUserEditsTheirLanguageDetailsAndClicksUpdate()
        {
            ProfileLanguagePage.UserEditsTheirLanguageDetailsAndClicksUpdate();

        }

        [Then(@"the language details updated should be saved")]
        public void ThenTheLanguageDetailsUpdatedShouldBeSaved()
        {
            ProfileLanguagePage.LanguageDetailsUpdatedShouldBeSaved();
        }



        [When(@"the user removes their language")]
        public void WhenTheUserRemovesTheirLanguage()
        {
            ProfileLanguagePage.UserRemovesTheirLanguage();
        }




        [Then(@"the language should be deleted")]
        public void ThenTheLanguageShouldBeDeleted()
        {
            ProfileLanguagePage.LanguageShouldBeDeleted();
        }
    }
}