using Exam.Questions;

namespace Exam.Exams
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.WriteLine("Choose the exam type (1 for Practical Exam, 2 for Final Exam): ");
            int examType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exam time in minutes: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of questions: ");
            int numberOfQuestions = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            List<Question> questions = new List<Question>();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Creating Question {i + 1}");
                Console.WriteLine("Please choose the question type (1 for MCQ, 2 for True or False): ");
                int questionType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the question body: ");
                string questionBody = Console.ReadLine();
                Console.WriteLine("Enter the question mark: ");
                int questionMark = Convert.ToInt32(Console.ReadLine());

                if (questionType == 1)
                {
                    Console.WriteLine("Enter the number of MCQ options: ");
                    int numberOfOptions = Convert.ToInt32(Console.ReadLine());
                    List<Answer> answerList = new List<Answer>();
                    for (int j = 1; j <= numberOfOptions; j++)
                    {
                        Console.WriteLine($"Enter option {j} body: ");
                        string optionBody = Console.ReadLine();
                        answerList.Add(new Answer(j, optionBody));
                    }

                    Console.WriteLine("Enter the right answer number: ");
                    int rightAnswerNumber = Convert.ToInt32(Console.ReadLine());
                    questions.Add(new MCQQuestion($"MCQ Question - Marks: {questionMark}", questionBody, questionMark,
                        answerList, answerList[rightAnswerNumber - 1]));
                }
                else if (questionType == 2)
                {
                    Console.WriteLine("Enter the right answer (1 for True or 2 for False): ");
                    int rightAnswerNumber = Convert.ToInt32(Console.ReadLine());
                    Answer rightAnswer = rightAnswerNumber == 1 ? new Answer(1, "True") : new Answer(2, "False");
                    questions.Add(new TFQuestion($"True or False Question - Marks: {questionMark}", questionBody,
                        questionMark, rightAnswer));
                }
                Console.Clear();
            }
            if (examType == 1)
            {
                Exam = new PracticalExam(time, numberOfQuestions, questions);
            }
            else if (examType == 2)
            {
                Exam = new FinalExam(time, numberOfQuestions, questions);
            }
            Console.Clear();
        }
    }
}