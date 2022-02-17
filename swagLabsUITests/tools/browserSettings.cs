using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace swagLabsUITests.tools
{
    internal class BrowserSettings
        
      
    {
        public IWebDriver GetBrowser()
        {
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);

            driver.Quit();

            return driver;
        }
    }
}
