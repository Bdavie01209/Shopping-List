using TechTalk.SpecFlow;
using ShoppingList;
using FluentAssertions;

namespace Calctests.Specs.Steps
{
    [Binding]
    public sealed class ShoppingListSteps
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private ShoppingListData TestShopingList = new ShoppingListData();

        public ShoppingListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"The list is empty")]
        public void GivenTheListIsEmpty()
        {
            foreach (string i in TestShopingList.Items)
            {
                TestShopingList.RemoveItem(i);
            } 
        }


        [Given(@"the textbox contains (.*)")]
        public void GivenTheTextboxContainsBanana(string input)
        {
            TestShopingList.textbox = input;
        }


        [When(@"the AddButton is pressed")]
        public void WhenTheAddButtonIsPressed()
        {
            TestShopingList.AddItem(TestShopingList.textbox);
        }


        [Then(@"the listbox should contain (.*)")]
        public void ThenTheListboxShouldContain(string resultexpected)
        {
            string[] result = (string[])TestShopingList.Items;
            result[0].Should().Be(resultexpected);

        }

    }
}
