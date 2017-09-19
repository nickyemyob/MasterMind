using MastermindKata.DTO;
using MastermindKata.Interface;

namespace MastermindKata.Mock
{
    public class MockGameConfigSerialiser : IGameConfigSerialiser
    {
        public GameConfig ConvertFromXml(string xmlFilePath)
        {
            return new GameConfig(){DefaultColour = "rgycw"};
        }

        public void Save(string filemname, GameConfig obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
