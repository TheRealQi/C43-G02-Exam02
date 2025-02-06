using Exam.Questions;

namespace Exam.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions, List<Question> questions) : base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine(this);
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
                Console.WriteLine("====================================");
            }
            Console.Clear();
            Console.WriteLine("Right Answers:");
            for (int i = 1; i <= Questions.Count; i++)
            {
                Console.WriteLine($"{i}) {Questions[i - 1].RightAnswer.AnswerText}"); 
            }
        }
    }
}