using System;
using Xunit;
using XunitCoreProj1.Common;
using XunitCoreProj1.PageObjects;

namespace XunitCoreProj1.Tests
{
    public class UnitTest1: Drivers
    {
        [Fact]

        public void Test1()
        {   
            try{   
            var homePage = new HomePage(Driver);
          StartBrowser(Enums.Browser.Chrome);
       
            Driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
            homePage.newmethod();
            }
            finally{
            Driver.Quit();
            }

        }

        [Theory]
        [MemberData(nameof(Drivers.BrowserData))]
        public void Test2(Enums.Browser browser)
        { 
            try{
            StartBrowser(browser);

            var homePage = new HomePage(Driver);

            Driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
            homePage.newmethod();
            }
            finally{
            Driver.Quit();
            }
        }


         [Theory]
        [InlineData(Enums.Browser.Chrome)]
       // [InlineData(Enums.Browser.IE)]
        public void Test3(Enums.Browser browser)
        {

            try{
            StartBrowser(browser);

            var homePage = new HomePage(Driver);

            Driver.Navigate().GoToUrl(@"https://automatetheplanet.com/multiple-files-page-objects-item-templates/");
            homePage.newmethod();

            }
            finally{
            Driver.Quit();
            }
        }
    }
}
