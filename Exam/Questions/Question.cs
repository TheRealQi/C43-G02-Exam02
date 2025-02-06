namespace Exam.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string header, string body, int mark, List<Answer> answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public override string ToString()
        {
            return
                $"Header: {Header}\nBody: {Body}\nMark: {Mark}\nAnswerList: {AnswerList}\nRightAnswer: {RightAnswer}";
        }

        public object Clone()
        {
            List<Answer> clonedAnswerList = new List<Answer>();
            foreach (var answer in AnswerList)
            {
                clonedAnswerList.Add(new Answer(answer.AnswerId, answer.AnswerText));
            }

            return this switch
            {
                MCQQuestion => new MCQQuestion(Header, Body, Mark, clonedAnswerList,
                    new Answer(RightAnswer.AnswerId, RightAnswer.AnswerText)),
                TFQuestion => new TFQuestion(Header, Body, Mark,
                    new Answer(RightAnswer.AnswerId, RightAnswer.AnswerText))
            };
        }

        public int CompareTo(Question other)
        {
            return other.Mark.CompareTo(this.Mark);
        }
    }
}