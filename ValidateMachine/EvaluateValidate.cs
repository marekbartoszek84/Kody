using System;
using System.Linq;
using ValidateMachine.Model;

namespace ValidateMachine
{
    public class EvaluateValidate
    {
        public bool IsValid(Movie movie)
        {
            Func<Movie, bool>[] rules =
            {
                m=>string.IsNullOrEmpty(m.Name),
                m=>m.Length <20 || m.Length>100,
                m=>m.ReleaseDate.Year<2000
            };
            return rules.All(r => r(movie)==false);
        }
    }
}
