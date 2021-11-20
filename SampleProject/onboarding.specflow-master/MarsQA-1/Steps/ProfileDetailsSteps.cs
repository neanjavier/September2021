using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ProfileDetailsSteps
    {
        [Given(@"the user is in profile page")]
        public void GivenTheUserIsInProfilePage()
        {
            ProfileDetailsPage.UserIsInProfilePage();
        }

        [Given(@"the user clicks on Availability")]
        public void GivenTheUserClicksOnAvailability()
        {
            ProfileDetailsPage.UserClicksOnAvailability();
        }

        [Then(@"the user selects option from availability dropdown")]
        public void ThenTheUserSelectsOptionFromAvailabilityDropdown()
        {
            ProfileDetailsPage.UserSelectsOptionFromAvailabilityDropdown();
        }

        [Given(@"the user Clicks on Hours field")]
        public void GivenTheUserClicksOnHoursField()
        {
            ProfileDetailsPage.UserClicksOnHoursField();
        }

        [Then(@"the user selects option from hours dropdown")]
        public void ThenTheUserSelectsOptionFromHoursDropdown()
        {
            ProfileDetailsPage.UserSelectsOptionFromHoursDropdown();
        }

        [Given(@"the user Clicks on Earn Target field")]
        public void GivenTheUserClicksOnEarnTargetField()
        {
            ProfileDetailsPage.UserClicksOnEarnTargetField();
        }


        [Then(@"the user selects option earn target dropdown")]
        public void ThenTheUserSelectsOptionEarnTargetDropdown()
        {
            ProfileDetailsPage.UserSelectsOptionEarnTargetDropdown();
        }

    }
}