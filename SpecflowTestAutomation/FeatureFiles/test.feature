Feature: Testing Google

Scenario: Running a google search

Given I am on the google homepage
When I search for webdriver
Then the page title is as expected

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	
