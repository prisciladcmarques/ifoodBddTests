using OpenQA.Selenium;

namespace ifood.pageObjects
{
    public class AddressPage
    {
        public void FillCep(IWebDriver driver, string cep)
        {
            string cepBarSearchXpath = "//input[@class='buscarCep submitCep'][@type='submit']";
            driver.FindElement(By.XPath(cepBarSearchXpath)).SendKeys(cep);
        }
        public void FillNumber(IWebDriver driver, string number)
        {
            string numberBarSearchXpath = "//div/input[@type='tel'][@placeholder='Nº'][@class='field5 streetNumber']";
            driver.FindElement(By.XPath(numberBarSearchXpath)).SendKeys(number);
        }
    }
}
