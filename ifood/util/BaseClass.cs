using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace ifood.util
{
    public class BaseClass
    {
        public static IWebDriver driver = null;
        string browser = "";
        public static string url = "";

        public BaseClass()
        {
            url = ConfigurationManager.AppSettings["URL"];
            browser = ConfigurationManager.AppSettings["Browser"];
        }

        public void InstanceDriver()
        {
            switch (browser)
            {
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

        }

    }
}
