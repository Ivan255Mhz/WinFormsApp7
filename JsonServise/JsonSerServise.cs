using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp7.JsonServise
{
    public class JsonSerServise
    {
        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
        };

        public string Serialeze<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, _options);
        }

        public T? Deserialeze<T>(string Json) 
        {
            return JsonSerializer.Deserialize<T>(Json, _options);
        }

        public void SaveToFile<T>(string path, T obj) 
        {
            var json = Serialeze(obj);
            File.WriteAllText(path, json);
        }

        public T? LoadFormFile<T>(string path) 
        {
            if (!File.Exists(path))
            {
                return default;
            }

            var json = File.ReadAllText(path);
            
            return Deserialeze<T?>(json);
        }
    }
}
