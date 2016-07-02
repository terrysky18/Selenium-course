using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;

class Selectors
{
    static void Main()
    {
        NoElementException();
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

    static void SelectorByClass()
    {
        string test_site = "http://testing.todorvachev.com/selectors/class-name/";
        IWebDriver browser = new ChromeDriver();
        browser.Navigate().GoToUrl(test_site);

        string class_name = "testClass";
        IWebElement element = browser.FindElement(By.ClassName(class_name));

        if (element.Displayed)
        {
            // element found in the page
            GreenMessage(element.Text);
            GreenMessage("Indeed, element found in the page");
        }
        else
        {
            RedMessage("Element not found");
        }
        var name = System.Console.ReadLine();
        browser.Quit();
    }

    static void SelectorByPath()
    {
        string test_site = "http://testing.todorvachev.com/selectors/css-path/";
        IWebDriver browser = new ChromeDriver();
        browser.Navigate().GoToUrl(test_site);

        string cssPath = "#post-108 > div > figure > img";  //preferred selector
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebElement cssPath_element = browser.FindElement(By.CssSelector(cssPath));
        IWebElement xPath_element = browser.FindElement(By.XPath(xPath));

        if (cssPath_element.Displayed)
        {
            // element found in the page
            GreenMessage("Indeed, CSS path element found in the page");
        }
        else
        {
            RedMessage("CSS path element not found");
        }

        if (xPath_element.Displayed)
        {
            // element found in the page
            GreenMessage("Indeed, Xpath element found in the page");
        }
        else
        {
            RedMessage("Xpath element not found");
        }

        var name = System.Console.ReadLine();
        browser.Quit();
    }

    static void NoElementException()
    {
        // The function demonstrates how to 
        string test_site = "http://testing.todorvachev.com/selectors/css-path/";
        IWebDriver browser = new ChromeDriver();
        browser.Navigate().GoToUrl(test_site);

        string cssPath = "#post-108 > div > figre > img";  //purposely wrong path string

        // use try-catch to handle the exception
        try
        {
            IWebElement cssPath_element = browser.FindElement(By.CssSelector(cssPath));
            if (cssPath_element.Displayed)
            {
                GreenMessage("Indeed, CSS path element found in the page");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("CSS path element not found");
        }
        var name = System.Console.ReadLine();
        browser.Quit();
    }
}
