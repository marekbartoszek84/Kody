using System;
using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateMachine;
using ValidateMachine.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class MovieValidateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            EvaluateValidate validator = new EvaluateValidate();
            var fixture = new Fixture();
            Movie movieObject = new Movie { Name = "Test", Length = 22, ReleaseDate = new DateTime(2002,01,01) };
            bool isValidateOk =validator.IsValid(movieObject);
            Assert.IsTrue(isValidateOk);
        }
    }
}
