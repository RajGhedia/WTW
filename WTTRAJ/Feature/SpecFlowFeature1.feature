Feature: SpecFlowFeature1
	
User story to check Willis Tower Watson 

@Main
Scenario: Chrome WTW
	Given I have enter the Willis Towers watson web site 
	And I have checked it on english 
	When I press enter test 
	Then I should see the results on screen 

Scenario: Sort by Date
	Given I am on the result screen 
	And I have sorted by date 
	When I use the refine search by function 
	And filier by Transportation 
	Then List of title of all articles in the list is displayed



