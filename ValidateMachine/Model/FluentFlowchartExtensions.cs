using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ValidateMachine.Validator;

namespace ValidateMachine.Model
{
    public static class FluentFlowchartExtensions
    {
        public static Flowchart<T, R> AddShape<T, R>(this Flowchart<T, R> chart, string shapeName)
        {
            var shape = new Schape<T, R> { Name = shapeName };
            chart.Shapes.Add(shape);
            return chart;
        }

        public static Flowchart<T, R> YieldsResult<T, R>(this Flowchart<T, R> chart, R result)
        {
            chart.LastShape().Result = result;
            return chart;
        }

        public static Flowchart<T, R> Requires<T, R>(this Flowchart<T, R> chart, Expression<Func<T, object>> field)
        {
            var specifier = new PropertySpecifier<T>(field);
            chart.LastShape().RequiredField = specifier;
            return chart;
        }

        public static Flowchart<T, R> WithArrowPointingTo<T, R>(this Flowchart<T, R> chart, string pointsTo)
        {
            var arrow = new Arrow<T> { PointsTo = pointsTo };
            chart.LastShape().Arrows.Add(arrow);
            return chart;
        }

        public static Flowchart<T, R> AndRule<T, R>(this Flowchart<T, R> chart, Func<T, bool> rule)
        {
            chart.LastShape().LastArrow().Rule = rule;
            return chart;
        }

        public static Schape<T, R> LastShape<T, R>(this Flowchart<T, R> chart)
        {
            return chart.Shapes[chart.Shapes.Count - 1];
        }

        public static Arrow<T> LastArrow<T, R>(this Schape<T, R> shape)
        {
            return shape.Arrows[shape.Arrows.Count - 1];
        }
    }
}
