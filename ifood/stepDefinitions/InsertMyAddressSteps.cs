using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ifood.pageObjects;
using ifood.util;

namespace ifood.stepDefinitions
{
    [Binding]

    public class InsertMyAddressStep : BaseClass
    {
        BaseClass baseClass = null;
        IWebDriver driver = null;
        AddressPage addressPage = null;

        public InsertMyAddressStep ()
        {
            baseClass = new BaseClass();
            addressPage = new AddressPage();
        }

        [BeforeScenario]
        public void IniciateSteps()
        {
            this.baseClass.InstanceDriver();
            driver = BaseClass.driver;
        }

        [AfterScenario]
        public void closeTests()
        {
            driver.Quit();
        }

        [Given(@"I have entered in ifood home page")]
            public void GivenIHaveEnteredInIfoodHomePage()
            {
                driver.Url = BaseClass.url;
            }

        [Given(@"I fill the bar search with the CEP '(.*)'")]
        public void GivenIFillTheBarSearchWithTheCEP(string cep)
        {
                addressPage.FillCep(driver, cep);
        }

        [Given(@"I have entered in address page")]
        public void GivenIHaveEnteredInAddressPage(string number)
        {
           
        }

        [Given(@"I fill the bar search with the number '(.*)'")]
        public void GivenIFillTheBarSearchWithTheNumber(string number)
        {
            addressPage.FillNumber(driver, number);
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
