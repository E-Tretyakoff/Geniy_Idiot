using System.Text;

namespace GeniyIdiot.Common
{
    public class FileManager
    {
        //Добавляем текст в файл котором указан путь
        public static void Append(string path, string text)
        {
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
        }


        //Очистить тектовый файл
        public static void Clear(string path)
        {
            File.WriteAllText(path, string.Empty);
        }


        //Получить текст из файла
        public static string GetData(string path)
        {
            return File.ReadAllText(path);
        }


        //проверка на существует ли файл
        public static bool ExistsFile(string path)
        {
            return File.Exists(path);
        }
    }
}