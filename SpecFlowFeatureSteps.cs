using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowTestProj
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        private static List<int> numbers = new List<int>();
        private static int sum;
        //private static int product = 1;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numbers.Add(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            numbers.ForEach(a => sum += a);
        }

        //[When(@"I press multiply")]
        //public void WhenIPressMultiply()
        //{
        //    numbers.ForEach(a => product *= a);
        //}

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(120, sum);
        }

        //[Then(@"the result should be (.*)")]
        //public void ThenTheResultShouldBe(int p0)
        //{
        //    Assert.AreEqual(100, product);
        //}
		
		// Test Comment
    }
}
