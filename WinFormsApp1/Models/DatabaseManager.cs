using System.Text.Encodings.Web;
using System.Text.Json;

namespace lombard.Models
{
    public class DatabaseManager //клас для керування базою даних
    {
        private const string FilePath = "database.json";

        public static void SaveData(PawnshopDatabase database)
        {
            var json = JsonSerializer.Serialize(database, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(FilePath, json);
        }

        public static PawnshopDatabase LoadData()
        {
            if (!File.Exists(FilePath))
                return new PawnshopDatabase();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<PawnshopDatabase>(json) ?? new PawnshopDatabase();
        }
    }
}