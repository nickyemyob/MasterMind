using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastermindKata.Interface;

namespace MastermindKata.Logic
{
    public class GameConfigService : IGameConfigService
    {
        private readonly IGameConfigSerialiser _gameConfigSerialiser;

        public GameConfigService(IGameConfigSerialiser gameConfigSerialiser)
        {
            _gameConfigSerialiser = gameConfigSerialiser;
        }

        public string GetDefaultColor()
        {
            var gameConfig = _gameConfigSerialiser.ConvertFromXml("..\\..\\GameConfig\\NormalMode.xml");
            return gameConfig.DefaultColour;
        }
    }
}
