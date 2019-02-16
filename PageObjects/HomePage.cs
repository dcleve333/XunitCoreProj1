using OpenQA.Selenium;
using XunitCoreProj1.Extensions;

namespace XunitCoreProj1.PageObjects

{
     class HomePage
    {
private IWebDriver Driver;

        public HomePage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }


        By firstArticle = By.PartialLinkText("TggFS Test API");



        public void newmethod()
        {
            WaitExtensions.WaitForElementToAppear(Driver, 30, firstArticle);
            
          
        }
    }


}
