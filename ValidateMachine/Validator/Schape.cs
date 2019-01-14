using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ValidateMachine.Validator
{
    public class Schape<TData, TResult>
    {
        public Schape()
        {
            Arrows = new List<Arrow<TData>>();
            Result = default(TResult);
        }
        public TResult Result { get; set; }
        public string Name { get; set; }
        public PropertySpecifier<TData> RequiredField { get; set; }
        public List<Arrow<TData>> Arrows { get; set; }
    }
}
