

using GeniyIdiot.Common;

namespace CSharpEssentials
{
    public static class GameConsole
    {
        public static void ShowStartGameMenu()
        {
            Console.WriteLine($"Добро пожаловать в ГЕНИЙ_ИДИОТ");

            while (true)
            {
                Console.WriteLine(" 1.Начать новую игру");
                Console.WriteLine(" 2.Посмотреть результаты игр");
                Console.WriteLine(" -3.Удалить пользователя из результатов");
                Console.WriteLine(" 4.Добавить вопрос");
                Console.WriteLine(" 5.Удалить вопрос");
                Console.WriteLine(" 6.Выйти из игры");

                var inputUser = Console.ReadLine();
                if (int.TryParse(inputUser, out int inputNumber))
                {
                    switch (inputNumber)
                    {
                        case 1:
                            StartGame();
                            ShowStartGameMenu();
                            return;
                        case 2:
                            Console.Clear();
                            ShowDiagnosesTable();
                            ShowStartGameMenu();
                            return;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("НЕ РЕАЛИЗОВАНО");
                            ShowStartGameMenu();
                            return;
                        case 4:
                            AddMenuQuestion();
                            ShowStartGameMenu();
                            return;
                        case 5:
                            Console.Clear();
                            RemoveMenuQuestion();
                            ShowStartGameMenu();
                            return;
                        case 6:

                            return;
                    }
                }

                Console.WriteLine($"{Environment.NewLine}введите номер варианта ответа");
            }
        }


        public static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("На каждый вопрос вам даётся 10 секунд времени на ответ");
            Console.WriteLine("Введите ваше имя");
            string inputUserName = Console.ReadLine();
            var user = new Users(inputUserName);
            var NumberQuestion = 0;

            Console.Clear();
            while (true)
            {
                var questions = StorageQuestion.GetListQuestion();
                NumberQuestion = questions.Count;

                for (int i = 0; questions.Count != 0; i++)
                {
                    var startTime = DateTime.Now;
                    var rndIndex = new Random().Next(0, questions.Count);

                    Console.WriteLine($"Вопрос {i + 1}:");
                    Console.WriteLine(questions[rndIndex].Text);

                    int inputUserAnswer = GameConsole.GetValidNumber();
                    TimeSpan elapsed = DateTime.Now - startTime;

                    Console.Clear();
                    if (elapsed.TotalSeconds > 10)
                    {
                        Console.WriteLine("Время истекло");
                    }
                    else if (inputUserAnswer == questions[rndIndex].Answer)
                    {
                        user.addCount();
                    }

                    questions.RemoveAt(rndIndex);
                }

                var percentageAnswer = StorageDiagnostic.GetCorrectPercentage(user.CounterCorrectAnswers, NumberQuestion);
                user.Diagnosis = StorageDiagnostic.GetDiagnosis(percentageAnswer);

                Console.WriteLine("Вы прошли тест, ваши результаты:");
                Console.WriteLine($"Ваше имя:{user.Name}");
                Console.WriteLine($"Кол-во правильных ответов:{user.CounterCorrectAnswers}");
                Console.WriteLine($"Ваш диагноз:{user.Diagnosis}");
                Console.WriteLine();

                Console.WriteLine("Желаете перепройти тест?");
                Console.WriteLine("1.Да  2.Нет");

                if (!GetValidRepsonse())
                {
                    StorageDiagnostic.SaveDiagnosis(user);
                    Console.Clear();
                    break;
                }
                user.ResetCounter();
            }
        }


        //показать таблицу резульатов
        public static void ShowDiagnosesTable()
        {
            var userLineResult = StorageDiagnostic.GetUserDiagnoses();

            if (userLineResult.Count == 0)
            {
                Console.WriteLine($"Таблица пустая... Никто еще не проходил тест.{Environment.NewLine}");
                return;
            }

            Console.WriteLine($"{Environment.NewLine}{"id",-3}{"Name",-15}{"Points",-8}{"Диагноз",-5}");
            Console.WriteLine($"---------------------------------");
            for (int i = 0; i < userLineResult.Count; i++)
            {
                var name = userLineResult[i].Name;
                var points = userLineResult[i].CounterCorrectAnswers;
                var diagnosis = userLineResult[i].Diagnosis;

                Console.WriteLine($"{i + 1,-3}{name,-15}{points,-8}{diagnosis,-5}");
            }

            Console.WriteLine();
        }


        //добавление вопроса
        public static void AddMenuQuestion()
        {
            Console.Clear();
            Console.WriteLine("Введите вопрос который хотите добавить:");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = GameConsole.GetValidNumber();

            Console.Clear();
            Console.WriteLine($"Вопрос: {text}?");
            Console.WriteLine($"Ответ: {answer}?");
            Console.WriteLine("Добавляем данный вопрос?");
            Console.WriteLine("1.Да  2.Нет");

            if (GetValidRepsonse())
            {
                StorageQuestion.AppendQuestion(answer, text);
            }

            Console.Clear();
        }


        //удаление вопроса
        public static void RemoveMenuQuestion()
        {
            var listQuestions = StorageQuestion.GetListQuestion();

            for (int i = 0; i < listQuestions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listQuestions[i].Text}");
            }

            while (true)
            {
                Console.WriteLine("Какой вопрос удаляем? напиши номер вопроса");
                var inputNumber = GetValidNumber();
                if (inputNumber <= listQuestions.Count && inputNumber > 0)
                {
                    listQuestions.RemoveAt(inputNumber - 1);
                    break;
                }
                Console.WriteLine($"Введите от 1 до {listQuestions.Count}");
            }

            StorageQuestion.ClearQuestion();
            foreach (var item in listQuestions)
            {
                StorageQuestion.AppendQuestion(item.Answer, item.Text);
            }

            Console.Clear();
        }


        //Добиваемся ввода ответа ввиде числа от пользователя
        public static int GetValidNumber()
        {
            while (true)
            {
                string question = Console.ReadLine();
                try
                {
                    return int.Parse(question);
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"{Environment.NewLine}Недопустимый ввод числа, ваше число слишком большое");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{Environment.NewLine}Нужно ввести корректное число");
                }
            }
        }


        //Узнаем хочет ли пользователь начать сначала
        public static bool GetValidRepsonse()
        {
            while (true)
            {
                var inputUser = Console.ReadLine().ToUpper();

                if (inputUser == "ДА" || inputUser == "1")
                {
                    return true;
                }
                if (inputUser == "НЕТ" || inputUser == "2")
                {
                    return false;
                }

                Console.WriteLine($"{Environment.NewLine}Ответ не корректный");
                Console.WriteLine("Желаете перепройти тест? 1-да  2-нет");
            }
        }


    }
}
