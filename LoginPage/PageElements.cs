using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LoginPage
{
    public class PageElements
    {

        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "a0-action")]
        [CacheLookup]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "a0-primary")]
        [CacheLookup]
        public IWebElement SendButton { get; set; }

        [FindsBy(How = How.Name, Using = "page title")]
        [CacheLookup]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.ClassName, Using = "a0-forgot-pass")]
        [CacheLookup]
        public IWebElement ForgotPass { get; set; }

        public PageElements(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
    }
