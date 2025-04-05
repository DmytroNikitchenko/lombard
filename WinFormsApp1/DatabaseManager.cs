using System.Text.Json;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class DatabaseManager //клас для керування базою даних
    {
        private const string FilePath = "database.json";

        public static void SaveData(PawnshopDatabase database)
        {
            var json = JsonSerializer.Serialize(database, new JsonSerializerOptions { WriteIndented = true });
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
