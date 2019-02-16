using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace XunitCoreProj1.Extensions
{
public static class WaitExtensions

{



    public static void WaitForElementToAppear(IWebDriver Driver, int waitTime, By waitingElement)
    {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(waitingElement));
           
    }

}
}