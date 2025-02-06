using Exam.Questions;

namespace Exam.Exams
{
    public abstract class Exam : ICloneable
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        
        protected Exam(int time, int numberOfQuestions, List<Question> questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();
        
        public override string ToString()
        {
            return $"Exam Time: {Time} minutes\nNumber of Questions: {NumberOfQuestions}";
        }
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}