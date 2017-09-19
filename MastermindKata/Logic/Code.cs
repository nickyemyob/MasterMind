using System;
using System.Linq;
using MastermindKata.Interface;

namespace MastermindKata.Logic
{
    public class Code
    {
        private static readonly Random Random = new Random();
        private string _defaultColor;
        private readonly int _codeLength = 4;
        private IGameConfigService GameConfigService { get; }

        public Code(IGameConfigService gameConfigService)
        {
            GameConfigService = gameConfigService;
        }

        public string Generate()
        {
            _defaultColor = GameConfigService.GetDefaultColor();
            var randomCode = new string(Enumerable.Repeat(_defaultColor, _codeLength)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
            return randomCode.Select(s => s + ",").Aggregate((s, q) => s + q).TrimEnd(',');
        }
    }
}
