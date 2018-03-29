using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace LoginPage
{
    [Binding]
    [TestFixture]
    public class LoginSteps
    {
        IWebDriver driver = new FirefoxDriver();

        [Given(@"I open the login page")]
        public void GivenIOpenTheLoginPage()
        {
            driver.Navigate().GoToUrl("http://home.mindvalley.com");            
        }

        [Given(@"I open the library page")]
        public void GivenIOpenTheLibraryPage()
        {
            driver.Navigate().GoToUrl("http://home.mindvalley.com/library");
        }
        
        [When(@"I click on ""(.*)"" link")]
        public void WhenIClickOnLink(string p0)
        {
            var pageelements = new PageElements(driver);
            pageelements.ForgotPass.Click();
        }
        
        [When(@"I enter text ""(.*)"" into ""(.*)"" field")]
        public void WhenIEnterTextIntoField(string p0, string p1)
        {
            
            var pageelements = new PageElements(driver);
            if (p1 == "username")
            {
                pageelements.UserName.SendKeys(p0);
            }
            else if (p1 == "password")
            {
                pageelements.Password.SendKeys(p0);
            }
            
        }
        
        [When(@"I press the ""(.*)"" button")]
        public void WhenIPressTheButton(string p0)
        {
            var pageelements = new PageElements(driver);
            pageelements.LoginButton.Click();
        }
        
        [When(@"I enter text """"(.*)""username"" field")]
        public void WhenIEnterTextUsernameField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter text """"(.*)""password"" field")]
        public void WhenIEnterTextPasswordField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the ""(.*)"" page")]
        public void ThenIShouldSeeThePage(string p0)
        {
            var pageelements = new PageElements(driver);
            Assert.That(driver.Title, Is.EqualTo(p0));
        }
        
        [Then(@"I should see ""(.*)"" field highlighted in red")]
        public void ThenIShouldSeeFieldHighlightedInRed(string p0)
        {
            var pageelements = new PageElements(driver);
            if (p0 == "username")
            {
                Assert.AreEqual((pageelements.UserName.GetCssValue("border-left-color")), "rgb(220, 78, 65)");
            //    pageelements.UserName.GetCssValue("color");
            }
            else if (p0 == "password")
            {
                Assert.AreEqual((pageelements.Password.GetCssValue("border-left-color")), "rgb(220, 78, 65)");
            }
        }
        
        [Then(@"I should see ""(.*)"" error message")]
        public void ThenIShouldSeeErrorMessage(string p0)
        {
            var pageelements = new PageElements(driver);
            IWebElement bodyTag = driver.FindElement(By.TagName("body"));
            if (bodyTag.Text.Contains(p0))
            {
                Assert.Pass();
            }
        }
        
        [Then(@"I should see the ""(.*)"" section in the page")]
        public void ThenIShouldSeeTheSectionInThePage(string p0)
        {
            var pageelements = new PageElements(driver);
            IWebElement bodyTag = driver.FindElement(By.TagName("body"));
            if (bodyTag.Text.Contains(p0))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        
        [Then(@"I should see the email field")]
        public void ThenIShouldSeeTheEmailField()
        {
            var pageelements = new PageElements(driver);
            bool isElementDisplayed = pageelements.UserName.Displayed;
            Assert.True(isElementDisplayed);


            //if (pageelements.UserName.Displayed)
            //{
            //    Assert.Pass();
            //}
            
        }
        [Then(@"I should see the send button")]
        public void ThenIShouldSeeTheSendButton()
        {
            var pageelements = new PageElements(driver);
            bool isElementDisplayed = pageelements.SendButton.Displayed;
            Assert.True(isElementDisplayed);
        }

        [Then(@"I should see the login button")]
        public void ThenIShouldSeeTheLoginButton()
        {
            var pageelements = new PageElements(driver);
            bool isElementDisplayed = pageelements.LoginButton.Displayed;
            Assert.True(isElementDisplayed);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
