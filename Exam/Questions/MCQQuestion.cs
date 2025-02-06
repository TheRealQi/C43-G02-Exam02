namespace Exam.Questions
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, List<Answer> answersList, Answer answer) : base(header,
            body, mark, answersList, answer)
        {
        }
    }
}