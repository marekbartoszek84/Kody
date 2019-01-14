using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidateMachine.Model;
using ValidateMachine.Validator;

namespace UnitTestProject1
{
    public class MovieFlowchart : Flowchart<Movie, MovieResult>
    {
        public MovieFlowchart()
        {
            var chart = this;

            chart.AddShape("CheckTitle")
                    .Requires(m => m.Name)
                    .WithArrowPointingTo("NotEnoughInformation").AndRule(TitleNullOrEmpty)
                    .WithArrowPointingTo("CheckLength").AndRule(TitleNotNullOrEmpty)
                .AddShape("CheckLength")
                    .Requires(m => m.Length)
                    .WithArrowPointingTo("BadMovie").AndRule(LengthIsTooLong)
                    .WithArrowPointingTo("GoodMovie").AndRule(LengthIsJustRight)
                    .WithArrowPointingTo("CheckReleaseDate").AndRule(LengthExists)
                .AddShape("CheckReleaseDate")
                    .Requires(m => m.ReleaseDate)
                    .WithArrowPointingTo("BadMovie").AndRule(TooOld)
                    .WithArrowPointingTo("GoodMovie").AndRule(HasReleaseDate)
                .AddShape("BadMovie").YieldsResult(MovieResult.BadMovie)
                .AddShape("GoodMovie").YieldsResult(MovieResult.GoodMovie)
                .AddShape("NotEnoughInformation").YieldsResult(MovieResult.NotEnoughInformation);
        }

        Func<Movie, bool> TitleNullOrEmpty = m => String.IsNullOrEmpty(m.Name);
        Func<Movie, bool> TitleNotNullOrEmpty = m => !String.IsNullOrEmpty(m.Name);
        Func<Movie, bool> LengthIsTooLong = m => m.Length > 240;

        Func<Movie, bool> LengthIsJustRight = m => m.Length == 75;

        Func<Movie, bool> LengthExists = m => m.Length>0;

        Func<Movie, bool> TooOld = m => m.ReleaseDate!=null && 
                                        m.ReleaseDate.Year >1900 &&
                                        m.ReleaseDate.Year < 2000;

        Func<Movie, bool> HasReleaseDate = m => m.ReleaseDate!=null;
    }
}
