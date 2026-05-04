//вроде все пучком
namespace GeniyIdiot.Common
{
    //объект пользователей
    public class Users
    {
        public string Name { get; private set; }
        public int CounterCorrectAnswers { get; private set; }
        public string Diagnosis { get; set; }


        public Users(string name, int counterCorrectAnswers = 0, string diagnosis = "Неизвестно")
        {
            Name = name;
            CounterCorrectAnswers = counterCorrectAnswers;
            Diagnosis = diagnosis;
        }


        public void ResetCounter()
        {
            CounterCorrectAnswers = 0;
        }

        public void addCount()
        {
            CounterCorrectAnswers++;
        }
    }
}