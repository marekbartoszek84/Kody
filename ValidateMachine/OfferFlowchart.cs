using System;
using System.Collections.Generic;
using System.Text;
using ValidateMachine.Model;
using ValidateMachine.Validator;

namespace ValidateMachine
{
    public class OfferFlowchart : Flowchart<Offer, OfferResult>
    {
        public OfferFlowchart()
        {
            var charts = this;
            charts.AddShape("CheckName")
                .Requires(o => o.Name)
                    .WithArrowPointingTo("BadOffer").AndRule(NameIsNull)
                    .WithArrowPointingTo("CheckPrice").AndRule(NameIsNotNull)
            .AddShape("CheckPrice")
                .Requires(o=>o.Price)
                    .WithArrowPointingTo("BadOffer").AndRule(PriceIsNull)
                    .WithArrowPointingTo("GoodOffer").AndRule(PriceIsNotNull)
            .AddShape("BadOffer").YieldsResult(OfferResult.BadOffer)
            .AddShape("GoodOffer").YieldsResult(OfferResult.GoodOffer);
        }
        Func<Offer, bool> NameIsNull = m => String.IsNullOrEmpty(m.Name);
        Func<Offer, bool> NameIsNotNull = m => !String.IsNullOrEmpty(m.Name);
        Func<Offer, bool> PriceIsNull = m => m.Price==0;
        Func<Offer, bool> PriceIsNotNull = m => m.Price > 0;

    }
}
