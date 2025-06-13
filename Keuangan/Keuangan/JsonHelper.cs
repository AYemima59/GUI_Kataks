using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonHelper
{
    public static List<T> LoadList<T>(string filePath)
    {
        if (!File.Exists(filePath))
            return new List<T>();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }

    public static void SaveList<T>(string filePath, List<T> list)
    {
        string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}