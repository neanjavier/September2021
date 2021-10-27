Feature: Addition
	As TurnUp Portal Admin
	I would like to create, edit and delete time and material record
	So I can manage employees time and material records successfully
	
@tmtest @regression
Scenario: create time and material record with valid details
	Given I have logged into turnup portal successfully
	And I have navigated to the time and material page
	When I create time and material record
	Then the result should be created successfully

@tmtest @regression
Scenario Outline: edit time and material record with valid details
	Given I have logged into turnup portal successfully
	And I have navigated to the time and material page
	When I update '<Code>' and '<Type>' on an existing time and material record
	Then the result should have the updated '<Code>' and '<Type>'

	Examples:
	| Code | TypeCode |
	| test_Nean_edited1 | T |
	| test_Nean_edited2 | M |