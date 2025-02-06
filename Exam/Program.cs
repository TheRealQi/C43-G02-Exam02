using System.Diagnostics;
using Exam.Exams;

namespace Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "c#");
            subject.CreateExam();
            
            Console.WriteLine("Do you want to start the exam? (y for Yes, n for No): ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }
        }
    }
}