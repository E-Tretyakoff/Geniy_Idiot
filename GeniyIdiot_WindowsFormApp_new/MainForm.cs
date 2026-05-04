using GeniyIdiot.Common;

namespace GeniyIdiot_WindowsFormApp_new
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Users user;
        private int numberQuestion;

        private int second;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeMenu();
            welcomeForm.ShowDialog();

            user = new Users(welcomeForm.NameUser);
            numberQuestion = 1;
            questions = StorageQuestion.GetShuffledQuestions();

            questionTextlabel.Text = questions[0].Text;
            questionNumberlabel.Text = $"Вопрос №{numberQuestion}";
            StartTimer();
            nextButton.Enabled = true;
        }


        private void ShowNextQuestion()
        {
            questionTextlabel.Text = questions[0].Text;
            questionNumberlabel.Text = $"Вопрос №{numberQuestion}";
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            var userInput = userAnswertextBox.Text;

            if (int.TryParse(userInput, out int userAnswer))
            {
                if (userAnswer == questions[0].Answer)
                {
                    user.addCount();
                }
            }


            questions.RemoveAt(0);

            if (questions.Count == 0)
            {
                var correctPercentage = StorageDiagnostic.GetCorrectPercentage(user.CounterCorrectAnswers, numberQuestion);
                user.Diagnosis = StorageDiagnostic.GetDiagnosis(correctPercentage);

                nextButton.Enabled = false;
                StopTimer();

                MessageBox.Show($"{user.Name}: {user.Diagnosis}", "Ваш диагноз");
                StorageDiagnostic.SaveDiagnosis(user);
            }
            else
            {
                numberQuestion++;
                ShowNextQuestion();

                StartTimer();
            }
        }


        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numberQuestion = 1;
            user.ResetCounter();
            StartTimer();

            questions = StorageQuestion.GetShuffledQuestions();

            questionTextlabel.Text = questions[0].Text;
            questionNumberlabel.Text = $"Вопрос №{numberQuestion}";

            nextButton.Enabled = true;
        }


        private void выйтиИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ShowTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TableForm = new TableMenu();
            TableForm.ShowDialog();
        }


        private void StartTimer()
        {
            second = 10;
            timer1.Start();
            labelTimer.Visible = true;
        }
        private void StopTimer()
        {
            timer1.Stop();
            labelTimer.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = second--.ToString();
            if (second < 0)
            {
                StopTimer();
                nextButton.PerformClick();
            }
        }
    }
}
