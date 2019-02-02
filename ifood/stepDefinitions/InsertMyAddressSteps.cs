using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ifood.pageObjects;

namespace ifood.stepDefinitions
{
    [Binding]
    public class InsertMyAddressSteps
    {
        AddressPage Address_Page;
        public InsertMyAddressSteps()
        {
            Address_Page = new AddressPage();
        }

        [Given(@"I have entered in ifood home page")]
        public void GivenIHaveEnteredInIfoodHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill the bar search with the CEP '(.*)'")]
        public void GivenIFillTheBarSearchWithTheCEP(string cep)
        {
            Address_Page.FillCep(driver, cep);
        }
        
        [Given(@"I have entered in address page")]
        public void GivenIHaveEnteredInAddressPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill the bar search with the number '(.*)'")]
        public void GivenIFillTheBarSearchWithTheNumber(int p0)
        {
            
        }
        
        [When(@"I press the Buscar button")]
        public void WhenIPressTheBuscarButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I go to the address page")]
        public void ThenIGoToTheAddressPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I go to the search meal page")]
        public void ThenIGoToTheSearchMealPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
