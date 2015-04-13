Feature: Ordering answers

Scenario: The answer with the highest vote gets to the top
	Given There is a question "What is your favourite colour?" with the answers
		| Answer         | Vote |
		| Red            | 1    |
		| Cucumber Green | 1    |
	When you upvote the answer "Cucumber Green"
	Then the answer "Cucumber Green" should be on top
