//done
namespace GeniyIdiot.Common
{
    //объект (вопрос, ответ)
    public class Question
    {
        public string Text { get; }
        public int Answer { get; }

        public Question(int answer, string text)
        {
            Answer = answer;
            Text = text;
        }
    }
}