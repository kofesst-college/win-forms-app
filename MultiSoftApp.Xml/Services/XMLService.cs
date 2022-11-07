using System;
using System.IO;
using System.Xml.Serialization;
using MultiSoftApp.Services.Utils;

namespace MultiSoftApp.Xml.Services
{
    public static class XmlService
    {
        public static OperationResult<TValue> SaveObject<TValue>(string filePath, TValue value)
        {
            try
            {
                var directory = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    filePath
                );
                var xmlSerializer = new XmlSerializer(typeof(TValue));
                using (var writer = new StreamWriter(directory))
                {
                    xmlSerializer.Serialize(writer, value);
                }

                return new Success<TValue>(value);
            }
            catch (Exception exception)
            {
                return new Failed<TValue>(exception);
            }
        }

        public static OperationResult<TValue> ReadObject<TValue>(string filePath)
        {
            try
            {
                var directory = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    filePath
                );
                var xmlSerializer = new XmlSerializer(typeof(TValue));
                using (var reader = new StreamReader(directory))
                {
                    var value = xmlSerializer.Deserialize(reader);
                    if (value.GetType() != typeof(TValue))
                    {
                        throw new Exception("Could not deserialize object");
                    }
                
                    return new Success<TValue>((TValue) value);
                }
            }
            catch (Exception exception)
            {
                return new Failed<TValue>(exception);
            }
        }
    }
}