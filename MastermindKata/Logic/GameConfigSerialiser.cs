using System.IO;
using System.Xml.Serialization;
using MastermindKata.DTO;

namespace MastermindKata.Logic
{
    public class GameConfigSerialiser
    {
        protected static readonly XmlSerializer _serialiser = new XmlSerializer(typeof(GameConfig));

        public GameConfig ConvertFromXml(string xmlFilePath)
        {
            using (var fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                return (GameConfig)_serialiser.Deserialize(fileStream);
            }
        }

        public void Save(string filemname, GameConfig obj)
        {
            using (var fs = new FileStream(filemname, FileMode.OpenOrCreate))
            {
                _serialiser.Serialize(fs, obj);
            }
        }
    }
}
