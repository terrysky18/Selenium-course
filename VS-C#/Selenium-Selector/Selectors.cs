using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;

class Selectors
{
    static void Main()
    {
        SelectorByID();
    }

    private static void GreenMessage(string message)
    {
        // set foreground colour
        System.Console.ForegroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine(message);
        // reset foreground colour to default
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        // set foreground colour
        System.Console.ForegroundColor = System.ConsoleColor.Red;
        System.Console.WriteLine(message);
        // reset foreground colour to default
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }

    static void SelectorByName()
    {
        IWebDriver browser = new ChromeDriver();
        browser.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        //find the elements in the code
        IWebElement element = browser.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            // element found in the page
            GreenMessage("Indeed, element found in the page");
        }
        else
        {
            // element not found
            RedMessage("Element not found");
        }
        var name = System.Console.ReadLine();
        browser.Quit();
    }

    static void SelectorByID()
    {
        string test_site = "http://testing.todorvachev.com/selectors/id/";
        IWebDriver browser = new ChromeDriver();
        browser.Navigate().GoToUrl(test_site);

        string test_id = "testImage";
        IWebElement element = browser.FindElement(By.Id(test_id));

        if (element.Displayed)
        {
            // element found in the page
            GreenMessage("Indeed, element found in the page");
        }
        else
        {
            RedMessage("Element not found");
        }
        var name = System.Console.ReadLine();
        browser.Quit();
    }
}
