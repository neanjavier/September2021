using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ProfileSkillsSteps
    {
        [Given(@"the user click on the skills tab")]
        public void GivenTheUserClickOnTheSkillsTab()
        {
            ProfileSkillsPage.UserClickOnTheSkillsTab();
        }

        [When(@"the user clicks the Add New button and enters skills and skills level")]
        public void WhenTheUserClicksTheAddNewButtonAndEntersSkillsAndSkillsLevel()
        {
            ProfileSkillsPage.UserClicksTheAddNewButtonAndEntersSkillsAndSkillsLevel();
        }

        [Then(@"the skills details added should now be saved")]
        public void ThenTheSkillsDetailsAddedShouldNowBeSaved()
        {
            ProfileSkillsPage.SkillsDetailsAddedShouldNowBeSaved();
        }

        [When(@"the user edits their skills details and clicks update")]
        public void WhenTheUserEditsTheirSkillsDetailsAndClicksUpdate()
        {
            ProfileSkillsPage.UserEditsTheirSkillsDetailsAndClicksUpdate();

        }

        [Then(@"the skills details updated should be saved")]
        public void ThenTheSkillsDetailsUpdatedShouldBeSaved()
        {
            ProfileSkillsPage.SkillsDetailsUpdatedShouldBeSaved();
        }



        [When(@"the user removes their skills")]
        public void WhenTheUserRemovesTheirSkills()
        {
            ProfileSkillsPage.UserRemovesTheirSkills();
        }




        [Then(@"the skills should be deleted")]
        public void ThenTheSkillsShouldBeDeleted()
        {
            ProfileSkillsPage.SkillsShouldBeDeleted();
        }
    }
}