using System;
using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateMachine.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class MovieObjectTest
    {
        [TestMethod]
        public void TestMovieName()
        {
            var fixture = new Fixture();
            string movieName = fixture.Create<string>();
            Movie movie = new Movie { Name = movieName };

            Assert.AreEqual(movieName, movie.Name);
        }
    }
}
