using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumTest
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver=new ChromeDriver();

        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://kbkdist.ru/";
            Assert.That(webDriver.Title, Is.EqualTo("Образовательная платформа Калининградского бизнес-колледжа"));
            //webDriver.Close();
        }
        [TestCase]
        public void LoginKBK()
        {
            webDriver.Url = "https://kbkdist.ru/login/index.php";
            IWebElement login = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[1]/input"));
            login.SendKeys("rakdav");

            IWebElement password = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[2]/input"));
            password.SendKeys("rakdav");

            IWebElement click = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/button"));
            click.Click();
        }

        [TestCase]
        public void GoToLogin()
        {
            webDriver.Url = "https://kbkdist.ru/";
            IWebElement go = webDriver.FindElement(By.XPath("/html/body/nav/div/ul/li[2]/div/span/a"));
            go.Click();
        }

            [TearDown]
        public void testEnd()
        {
            //Assert.Pass();
        }
    }
}