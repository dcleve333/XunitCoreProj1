
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace XunitCoreProj1.Common

{
    public class Drivers
    {
        protected static IWebDriver Driver { get; set; }

        public void StartBrowser(Enums.Browser browser)
        {

            switch (browser)
            {
                case Enums.Browser.Firefox:
                    Driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    Driver.Manage().Window.Maximize();
                    break;
                case Enums.Browser.Chrome:
                    Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    Driver.Manage().Window.Maximize();
                    break;
                case Enums.Browser.Edge:
                    Driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    Driver.Manage().Window.Maximize();
                    break;
                case Enums.Browser.IE:
                InternetExplorerOptions options = new InternetExplorerOptions {  IgnoreZoomLevel= true };
                    Driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
                    Driver.Manage().Window.Maximize();
                    break;

                default:
                    break;

            }
        }

       public static IEnumerable<object[]> BrowserData =>
            new List<object[]>
                {
                    new object[] {Enums.Browser.Firefox},
                    new object[] {Enums.Browser.Chrome},
                    new object[] {Enums.Browser.Edge},
                    new object[] {Enums.Browser.IE}
                }; 


    }
}