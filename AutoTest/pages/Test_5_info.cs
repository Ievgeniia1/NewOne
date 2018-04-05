using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTest.pages
{
    class Test_5_info
    {
        //
        [FindsBy(How = How.Id, Using = "searchInput")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "searchButton")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Тестовий випадок")]
        public IWebElement ArticleLink { get; set; }
    }
}
