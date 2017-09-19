using MastermindKata.DTO;

namespace MastermindKata.Interface
{
    public interface IGameConfigSerialiser
    {
        GameConfig ConvertFromXml(string xmlFilePath);
        void Save(string filemname, GameConfig obj);
    }
}