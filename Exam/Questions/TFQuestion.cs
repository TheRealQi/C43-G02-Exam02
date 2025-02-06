namespace Exam.Questions
{
    public class TFQuestion : Question
    {
        public TFQuestion(string header, string body, int mark, Answer correctAnswer) : base(header, body, mark,
            new List<Answer> { new Answer(1, "True"), new Answer(2, "False") }, correctAnswer)
        {
        }
    }
}