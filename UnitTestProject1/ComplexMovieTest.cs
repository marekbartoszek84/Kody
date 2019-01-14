using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateMachine.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class ComplexMovieTest
    {
        [TestMethod]
        public void MovieWithoutTitleNeedsMoreInformation()
        {
            var chart = new MovieFlowchart();
            var movie = new Movie { Name = "" };
            var result = chart.Evaluate(movie).Result;

            Assert.AreEqual(MovieResult.NotEnoughInformation, result);
        }
        [TestMethod]
        public void MovieWithTitleAndLength75IsGood()
        {
            var chart = new MovieFlowchart();
            var movie = new Movie { Name = "Test", Length=715, ReleaseDate = new DateTime(2099,11,2)};
            var result = chart.Evaluate(movie).Result;

            Assert.AreEqual(MovieResult.GoodMovie, result);
        }
    }
}
