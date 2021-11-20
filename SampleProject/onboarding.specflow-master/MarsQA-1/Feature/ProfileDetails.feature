Feature: Profile Details
	A page where user can choose their profile details from dropdowns

@mytag
Scenario:1-Select Availability 
	Given the user is in profile page
	And the user clicks on Availability
	Then the user selects option from availability dropdown

Scenario:2-Select Hours 
	Given the user is in profile page
	And the user Clicks on Hours field
	Then the user selects option from hours dropdown


Scenario:3-Select Earn Target
	Given the user is in profile page
	And the user Clicks on Earn Target field
	Then the user selects option earn target dropdown