using System;
using System.Collections.Generic;
using System.Text;
using ValidateMachine.Model;
using ValidateMachine.Validator;

namespace ValidateMachine
{
    public class MovieFlowchart : Flowchart<Movie, MovieResult>
    {
        public MovieFlowchart()
        {
            var shape = new Schape<Movie, MovieResult> { Name = "Sprawdzamy Nazwe" };

            //this.LastShape

            //this.Shapes.Add(shape);

            //chart.AddShape("CheckTitle")
            //        .Requires(m => m.Name)
            //        .WithArrowPointingTo("CheckLength").AndRule(m => !String.IsNullOrEmpty(m.Name));
        }
    }
}
