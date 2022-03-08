Feature: SpecFlowFeature1
	simple shopping list

@mytag
Scenario: add something to an empty List
	Given The list is empty
	And the textbox contains Banana
	When the AddButton is pressed
	Then the listbox should contain Banana

	@mytag
Scenario: add apple to an empty List
	Given The list is empty
	And the textbox contains apple
	When the AddButton is pressed
	Then the listbox should contain apple