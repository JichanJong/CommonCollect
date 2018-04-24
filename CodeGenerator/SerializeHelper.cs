using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CodeGenerator
{
    public static class SerializeHelper
    {
        public static void XmlSerialize<T>(T data,string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(fs, data);
            }
        }

        public static T XmlDeserialize<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    return (T)serializer.Deserialize(fs);
                }
                catch 
                {
                    return default(T);
                }
                
            }
        }
    }
}
