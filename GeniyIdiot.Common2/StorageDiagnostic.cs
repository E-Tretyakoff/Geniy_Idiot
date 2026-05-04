using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class StorageDiagnostic
    {
        private const string path = @".\DiagnosticInfo.txt";


        //Получить список диагнозов
        public static List<Users> GetUserDiagnoses()
        {
            if (!FileManager.ExistsFile(path))
            {
                return new List<Users>();
            }

            var fileData = FileManager.GetData(path);
            var userResult = JsonConvert.DeserializeObject<List<Users>>(fileData);
            return userResult;
        }

        //записываем в тектовый документ результат
        public static void SaveDiagnosis(Users user)
        {
            var userResult = GetUserDiagnoses();
            userResult.Add(user);
            SaveListDiagnosis(userResult);
        }

        //сохранение Json формат
        public static void SaveListDiagnosis(List<Users> user)
        {
            var jsonData = JsonConvert.SerializeObject(user, Formatting.Indented);
            FileManager.Append(path, jsonData);
        }

        //получить результат
        public static string GetDiagnosis(double count)
        {
            switch (count)
            {
                case 0: return "Идиот";
                case <= 20: return "Кретин";
                case <= 40: return "Дурак";
                case <= 60: return "Нормальный";
                case <= 80: return "Талант";
                case <= 100: return "Гений";
                default: return "Неопределён";
            }
        }

        //получаем % правильных ответов
        public static double GetCorrectPercentage(int questionsCount, int questionsAnserCount)
        {
            return questionsCount / (double)questionsAnserCount * 100;
        }



    }
}
