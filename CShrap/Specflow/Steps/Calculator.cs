﻿using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Specflow.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private double _result;
        private Table _data;

        [Given(@"I have entered (.*) into the calculator of Value(\d+)")]

        public void GivenIHaveEnteredIntoTheCalculator(int value, int sequence)
        {
            switch (sequence)
            {
                case 1:
                    Calculator.Value1 = value;
                    break;
                case 2:
                    Calculator.Value2 = value;
                    break;
            }
        }

        [Given(@"I have entered values from excel into the calculator")]
        public void GivenIHaveEnteredValuesFromExcelIntoTheCalculator(Table table)
        {
            if (_data == null)
            {
                _data = table;
            }
            Calculator.Value1 = Convert.ToDouble(_data.Rows[0]["Value1"]);
            Calculator.Value2 = Convert.ToDouble(_data.Rows[0]["Value2"]);
        }

        [When(@"I ""(.*)""")]
        public void WhenIProcess(string type)
        {
            switch (type)
            {
                case "Plus":
                    _result = Calculator.Plus();
                    break;
                case "Minus":
                    _result = Calculator.Minus();
                    break;
                case "Multiply":
                    _result = Calculator.Multiply();
                    break;
                case "Devide":
                    _result = Calculator.Devide();
                    break;
            }
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            Assert.AreEqual(result, _result);
        }
    }



}
