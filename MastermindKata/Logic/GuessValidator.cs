using System;
using System.Collections.Generic;
using System.Linq;
using MastermindKata.Interface;

namespace MastermindKata.Logic
{
    public class GuessValidator : IGuessValidator
    {
        public void CheckForComma(string guess)
        {
            if (!guess.Contains(','))
            {
                throw new ArgumentException("Guess should contain commas between colours.");
            }
        }

        public void CheckForInvalidColour(string guess)
        {
            const string defaultColour = "rgycw";
            var invalidColour = guess.Split(',').Where(colour => !defaultColour.Contains(colour.ToString())).ToList();
            if (invalidColour.Any())
            {
                throw new ArgumentException("Guess should only contains r,g,y,c. Invalid colours are: " + string.Join(",", invalidColour));
            }
              
        }
    }
}
