using Exam.Questions;

namespace Exam.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions, List<Question> questions) : base(time, numberOfQuestions,
            questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            Console.WriteLine(this);
            int totalMarks = 0, obtainedMarks = 0;
            List<Answer> userAnswers = new List<Answer>();

            foreach (var question in Questions)
            {
                Console.WriteLine($"\nQuestion: {question.Header}");
                Console.WriteLine($"{question.Body} - Marks: {question.Mark}");
                foreach (var option in question.AnswerList)
                {
                    Console.WriteLine($"{option.AnswerId}. {option.AnswerText}");
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter your answer: ");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (question.AnswerList[answer - 1].AnswerId == question.RightAnswer.AnswerId)
                {
                    obtainedMarks += question.Mark;
                }
                userAnswers.Add(question.AnswerList[answer - 1]);
                totalMarks += question.Mark;
                Console.WriteLine("====================================");
            }
            Console.Clear();
            Console.WriteLine("Your Answers:");
            for (int i = 1; i <= Questions.Count; i++)
            {
                Console.WriteLine($"{i}) {Questions[i - 1].Body} : {userAnswers[i - 1].AnswerText}");
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Total Grade: {obtainedMarks}/{totalMarks}");
        }
    }
}