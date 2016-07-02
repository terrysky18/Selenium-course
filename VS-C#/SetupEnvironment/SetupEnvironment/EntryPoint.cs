using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        QuickTestChrome();
    }
    
    static void QuickTestChrome()
    {
        // Open Chrome and navigate to a test page then close Chrome
        IWebDriver driver = new ChromeDriver();     //initialise webdriver
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        Thread.Sleep(3000);     //pause for 3 seconds
        driver.Quit();
    }

    static void QuickTestIE()
    {
        // Open Internet Explorer and navigate to a test page then close IE
        IWebDriver driver = new InternetExplorerDriver();     //initialise webdriver
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        //Thread.Sleep(3000);     //pause for 3 seconds
        driver.Quit();
    }
}
