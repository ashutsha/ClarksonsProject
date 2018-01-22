Feature:  Verify section name and images next to the news	

Scenario: Check that if section name is present in left side menu
	Given I am on google news page
	When I go to sections
	Then I should see 'U.K' in section names

	Scenario: Check that images are displayed next to all news
	Given I am on google news page
	Then I should see images next to each news on page

