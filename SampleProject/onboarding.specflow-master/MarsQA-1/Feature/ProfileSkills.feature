Feature: Profile Skills
	A page where user can create, edit and delete their profile skills details

@mytag
Scenario:1-Create Skills details
	Given the user click on the skills tab
	When the user clicks the Add New button and enters skills and skills level
	Then the skills details added should now be saved

@mytag
Scenario:2-Update Skills details
	Given the user click on the skills tab
	When the user edits their skills details and clicks update 
	Then the skills details updated should be saved 

@mytag
Scenario:3-Delete Skills details
	Given the user click on the skills tab
	When the user removes their skills
	Then the skills should be deleted