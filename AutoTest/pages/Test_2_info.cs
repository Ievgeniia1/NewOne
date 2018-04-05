using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTest.pages
{
    class Test_2_info
    {
        [FindsBy(How = How.XPath, Using = "//div[@style='margin: 0; padding: -27px 0 0 0; float: right; font-family:verdana, Arial, Helvetica, sans-serif; font-size: 90%; text-align: right; line-height: 135%;']/a[1]")]
        public IWebElement WikiDayMonth { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@style='margin: 0; padding: -27px 0 0 0; float: right; font-family:verdana, Arial, Helvetica, sans-serif; font-size: 90%; text-align: right; line-height: 135%;']/a[2]")]
        public IWebElement WikiYear { get; set; }
    }
}
