using System;
using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateMachine;
using ValidateMachine.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class OfferTest
    {
        [TestMethod]
        public void OfferNameIsEmptyTest()
        {
            var chart = new OfferFlowchart();
            var fixture = new Fixture();
            Offer offer = fixture.Create<Offer>();
            offer.Name = "";

            Assert.AreEqual(OfferResult.BadOffer, chart.Evaluate(offer).Result);
        }
        [TestMethod]
        public void OfferNameIsNotEmptyTest()
        {
            var chart = new OfferFlowchart();
            var fixture = new Fixture();
            Offer offer = fixture.Create<Offer>();

            Assert.AreEqual(OfferResult.GoodOffer, chart.Evaluate(offer).Result);
        }
        [TestMethod]
        public void OfferPriceIsNullTest()
        {
            var chart = new OfferFlowchart();
            var fixture = new Fixture();
            Offer offer = fixture.Create<Offer>();
            offer.Price = 0;
            Assert.AreEqual(OfferResult.BadOffer, chart.Evaluate(offer).Result);
        }
        [TestMethod]
        public void OfferPriceIsNotNullTest()
        {
            var chart = new OfferFlowchart();
            var fixture = new Fixture();
            Offer offer = fixture.Create<Offer>();
            offer.Price = 101;
            var result = chart.Evaluate(offer).Result;
            Assert.AreEqual(OfferResult.GoodOffer, result);
        }
    }
}
