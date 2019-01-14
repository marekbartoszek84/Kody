using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateMachine.Validator
{
    public class EvaluationResults<T, R>
    {
        public R Result { get; set; }
        public List<PropertySpecifier<T>> RequiredFields { get; set; }
    }
}
