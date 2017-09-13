using System.Linq;
using System.Text;

namespace MastermindKata
{
    public class Mastermind
    {
        public string ReturnMark(string code, string guess)
        {
            var totalMatchingPosition = ReturnTotalMatchingPosition(code, guess);
            var totalMatchingColour = ReturnTotalMatchingColour(code, guess);
            return new string('b', totalMatchingPosition) + new string('w', totalMatchingColour - totalMatchingPosition);
        }

        public int ReturnTotalMatchingColour(string code, string guess)
        {
            var solutionArray = code.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Intersect(guessArray).Count();
        }

        public int ReturnTotalMatchingPosition(string code, string guess)
        {
            var solutionArray = code.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Where((t, i) => t == guessArray[i]).Count();
        }
    }
}
