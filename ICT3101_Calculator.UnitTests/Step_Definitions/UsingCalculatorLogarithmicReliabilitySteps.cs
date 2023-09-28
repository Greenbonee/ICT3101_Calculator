using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorLogarithmicReliabilitySteps
    {
        private decimal _result;

        private readonly CalculatorDetails calculatorDetails;

        public UsingCalculatorLogarithmicReliabilitySteps(CalculatorDetails calculatorDetails) // use it as ctor parameter
        {
            this.calculatorDetails = calculatorDetails;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press logarithmic failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicFailureIntensity(double p0, double p1, int p2)
        {
            _result = calculatorDetails.calculator.CurrentFailureIntensityLogModel(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press logarithmic expected failure")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicExpectedFailure(double p0, double p1, double p2)
        {
            _result = calculatorDetails.calculator.LogAverageNumberofExpectedFailures(p0, p1, p2);
        }

        [Then(@"the log failure intensity result should be ""(.*)""")]
        public void ThenTheLogFailureIntensityResultShouldBe(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the log expected failure result should be ""(.*)""")]
        public void ThenTheLogExpectedFailureResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
