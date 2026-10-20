using Examination_system;
using System.Diagnostics;
#nullable disable
namespace Examination_system
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Subject student1 = new Subject(1 , "C#");
            student1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam ( Y | N) :");

            char c = char.Parse(Console.ReadLine());
            Console.Clear();
            if (c == 'Y' || c == 'y')
            {
                // all time functions is searched 
                Stopwatch sw = new Stopwatch();
                sw.Start();
                student1.Exam.ShowExam();
                Console.WriteLine($"Time = {sw.Elapsed}");
            }
            else
                Console.WriteLine("Thank you ");


        }
    }
}