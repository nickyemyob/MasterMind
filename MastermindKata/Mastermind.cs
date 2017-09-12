using System.Linq;

namespace MastermindKata
{
    public class Mastermind
    {
        public string ReturnMark(string solution, string guess)
        {
            return "b";
        }

        public int ReturnTotalMatchingColour(string solution, string guess)
        {
            var solutionArray = solution.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Intersect(guessArray).Count();
        }

        public int ReturnTotalMatchingPosition(string solution, string guess)
        {
            var solutionArray = solution.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Where((t, i) => t == guessArray[i]).Count();
        }
    }
}
