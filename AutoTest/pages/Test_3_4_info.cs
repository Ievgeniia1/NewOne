/* Описывает главную страницу */
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTest.pages
{
    class Test_3_4_info
    {

        [FindsBy(How = How.LinkText, Using = "Поточні події")]
        public IWebElement LinkEvents { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@style='border:1px solid #aaa;border-top:0px solid white;padding:5px;margin-bottom:3ex;']/center/b/a[1]")]
        public IWebElement CurentMonth { get; set; }
       
    }
}
