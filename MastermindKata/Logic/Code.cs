using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindKata.Logic
{
    public class Code
    {
        private static readonly Random Random = new Random();
        private readonly string _defaultColor = "rgyc";
        private readonly int _codeLength = 4;

        public string Generate()
        {
            return new string(Enumerable.Repeat(_defaultColor, _codeLength)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
