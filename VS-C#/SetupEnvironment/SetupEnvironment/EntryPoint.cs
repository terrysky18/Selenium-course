using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        TestChrome();       //open page in Chrome
        Thread.Sleep(1000);
        TestIE();           //open page in Internet Explorer
    }

    static void TestChrome()
    {
        IWebDriver driver = new ChromeDriver();     //initialise webdriver
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        Thread.Sleep(3000);     //pause for 3 seconds
        driver.Quit();
    }

    static void TestIE()
    {
        IWebDriver driver = new InternetExplorerDriver();     //initialise webdriver
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        Thread.Sleep(3000);     //pause for 3 seconds
        driver.Quit();
    }
}
