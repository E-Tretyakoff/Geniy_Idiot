

using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class StorageQuestion
    {
        private const string path = @".\QuestionsInfo.txt";


        //получить список вопросов
        public static List<Question> GetListQuestion()
        {
            if (!FileManager.ExistsFile(path))
            {
                var questionDefault = GetDefaultQuestions();
                Save(questionDefault);

                return questionDefault;
            }

            var fileData = FileManager.GetData(path);
            var questionList = JsonConvert.DeserializeObject<List<Question>>(fileData);

            return questionList;
        }


        //Добавление вопроса
        public static void AppendQuestion(int answer, string text)
        {
            var questionList = GetListQuestion();
            questionList.Add(new Question(answer, text));
            Save(questionList);
        }

        //сохранение Json формат
        static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileManager.Append(path, jsonData);
        }

        //Очистить список вопросов
        public static void ClearQuestion()
        {
            FileManager.Clear(path);
        }


        //получиьт дефолтные вопросы
        public static List<Question> GetDefaultQuestions()
        {
            var questions = new List<Question>
            {
                new Question(6,"Сколько будет два плюс два умноженное на два?"),
                new Question(9,"Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?"),
                new Question(25,"На двух руках 10 пальцев. Сколько пальцев на 5 руках?"),
                new Question(60,"Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?"),
                new Question(2,"Пять свечей горело, две потухли. Сколько свечей осталось?")
            };
            return questions;
        }


        //Рандомайзер массива 
        public static List<Question> GetShuffledQuestions()
        {
            var questions = GetListQuestion();
            var questionsNew = new List<Question>();
            for (int i = 0; questions.Count != 0; i++)
            {
                var rndIndex = new Random().Next(0, questions.Count);
                questionsNew.Add(questions[rndIndex]);
                questions.RemoveAt(rndIndex);
            }
            return questionsNew;
        }

    }
}
