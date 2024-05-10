using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class PastebinPage
    {
        private IWebDriver _driver;

        public PastebinPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }    

        [FindsBy(How = How.Id, Using = "postform-text")]
        public IWebElement PastebinTextarea; 

        [FindsBy(How = How.Id, Using = "select2-postform-format-container")]
        public IWebElement PastebinSyntaxHighlight;

        [FindsBy(How = How.Id, Using = "select2-postform-expiration-container")]
        public IWebElement PasteExpiration;

        [FindsBy(How = How.Id, Using = "postform-name")]
        public IWebElement PastebinName;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn -big']")]
        public IWebElement CreateBtn;

        [FindsBy(How = How.CssSelector, Using = "div.notice.-success.-post-view")]
        public IWebElement SuccessPostElement;

        [FindsBy(How = How.ClassName, Using = "info-top")]
        public IWebElement TitleTextHolder;

        [FindsBy(How = How.CssSelector, Using = "a[href='/archive/bash']")]
        public IWebElement BashContainer;


        public string CodeMessage = "git config --global user.name  \"New Sheriff in Town\"" + "\ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") " + "\ngit push origin master --force";
    }
}