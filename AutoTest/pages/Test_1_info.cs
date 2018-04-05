using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTest.pages
{
    class Test_1_info
    {
        [FindsBy(How = How.TagName, Using = "title")]
        public IWebElement Title { get; set; }
        //
        [FindsBy(How = How.CssSelector, Using = "input[title='Поиск']")]
        public IWebElement SearchField { get; set; }

        //
        [FindsBy(How = How.CssSelector, Using = "input[value='Поиск в Google']")]
        public IWebElement SearchButton { get; set; }

        //
        [FindsBy(How = How.LinkText, Using = "Вікіпедія")]
        public IWebElement WikiLink { get; set; }
    }
}
