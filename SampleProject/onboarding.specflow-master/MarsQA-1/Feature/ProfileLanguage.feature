Feature: Profile Language
	A page where user can create, edit and delete their profile language details

@mytag
Scenario:1-Create Language details
	Given the user click on the language tab
	When the user clicks the Add New button and enters language and language level
	Then the language details added should now be saved

@mytag
Scenario:2-Update Language details
	Given the user click on the language tab
	When the user edits their language details and clicks update 
	Then the language details updated should be saved 

@mytag
Scenario:3-Delete Language details
	Given the user click on the language tab
	When the user removes their language
	Then the language should be deleted