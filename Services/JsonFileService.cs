using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
namespace SmartCodeLab.Services
{
    public class JsonFileService
    {

        public static string GetObjectJsonText<T>(T obj) 
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                WriteIndented = true // Makes the JSON human-readable
            });
        }

        public static T GetObjectFromText<T>(string text)
        {
            return JsonSerializer.Deserialize<T>(text);
        }
    }
}
