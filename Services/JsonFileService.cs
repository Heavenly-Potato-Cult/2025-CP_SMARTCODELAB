using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class JsonFileService
    {
        public static void SaveToFile<T>(T obj, string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes the JSON human-readable
                });

                File.WriteAllText(filePath, jsonString);
                Console.WriteLine($"Object saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public static T LoadFromFile<T>(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found", filePath);
                }

                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
                return default;
            }
        }

        public static T LoadFromText<T>(string content)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
                return default;
            }
        }

        public static string GetObjectJsonText<T>(T obj) 
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                WriteIndented = true // Makes the JSON human-readable
            });
        }
    }
}
