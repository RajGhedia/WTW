using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 
using TechTalk.SpecFlow;


namespace WTTRAJ.Stepdef

{
  

    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver driver;
        //private string baseURL;

        [Given(@"I have enter the Willis Towers watson web site")]
        public void GivenIHaveEnterTheWillisTowersWatsonWebSite()
        {
         

            {
                driver = new ChromeDriver(@"C:\Users\raj.ghedia\Source\Repos\Drivers");
               // baseURL = "https://www.willistowerswatson.com";
                driver.Navigate().GoToUrl("https://www.willistowerswatson.com");

            }
         
        }
        
        [Given(@"I have checked it on english")]
        public void GivenIHaveCheckedItOnEnglish()
        {

            // open the Iframe and select the Agree and Proceed 
            IWebElement iframe = driver.FindElement(By.Id("3"));
            driver.SwitchTo().Frame("3");
  
            driver.FindElement(By.LinkText("Agree and Proceed")).Click();

            //Checked on  UK 
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Close'])[1]/following::button[1]")).Click();
            driver.FindElement(By.Id("btnCountrySelector")).Click();

        }
        
        [Given(@"I am on the result screen")]
        public void GivenIAmOnTheResultScreen()
        {

           
        }
        
        [Given(@"I have sorted by date")]
        public void GivenIHaveSortedByDate()
        {
            driver.FindElement(By.LinkText("Date")).Click();
        }
        
        [When(@"I press enter test")]
        public void WhenIPressEnterTest()
        {
            // Type in Test in the search at the bottom of the screen 
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Change Web Site'])[1]/following::span[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow Us on Social Media'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow Us on Social Media'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow Us on Social Media'])[1]/following::input[1]")).SendKeys("test");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow Us on Social Media'])[1]/following::span[2]")).Click();
        }
        
        [When(@"I use the refine search by function")]
        public void WhenIUseTheRefineSearchByFunction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"filier by Transportation")]
        public void WhenFilierByTransportation()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Natural Resources'])[1]/following::span[3]")).Click();


        }
        
        [Then(@"I should see the results on screen")]
        public void ThenIShouldSeeTheResultsOnScreen()
        {
            
        }
        
        [Then(@"List of title of all articles in the list is displayed")]
        public void ThenListOfTitleOfAllArticlesInTheListIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
