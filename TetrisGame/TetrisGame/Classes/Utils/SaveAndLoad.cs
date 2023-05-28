using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TetrisGame.Classes.Utils
{
    public static class SaveAndLoad
    {
        private static readonly BinaryFormatter bf = new BinaryFormatter();
        public static void Save<T>(string fileName, T data)
        {

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, data);
            }
        }

        public static T Load<T>(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    T newData = (T)bf.Deserialize(fs);
                    return newData;
                }
            }
            catch (Exception)
            {
            }

            return default;
            
        }
    }
}
