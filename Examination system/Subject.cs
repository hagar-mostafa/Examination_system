using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{

    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Questions question { get; set; }
        public Subject() { }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        int TypeOfExam, NumQuestions, TypeOfQuestion;
        int time;

        public void CreateExam()
        {
            do
            {
                Console.Write("Please Enter The Type Of Exam ( 1 for practical and 2 for final):");
            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam) && TypeOfExam < 1 || TypeOfExam > 2);

            do
            {
                Console.Write("Enter The Time Of The Exam (30 to 180 minutes ) : ");
            } while (!int.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.Write("Enter The Number Of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumQuestions));

            Console.Clear();
            Questions[] questions = new Questions[NumQuestions];

            //practical exam
            if (TypeOfExam == 1)
            {
                Exam = new PracticalExam(time, NumQuestions);
            }
            else
            {
                //final exam
                Exam = new FinalExam(time, NumQuestions);
            }

            Console.Clear();

            Exam.CreateListOfQuestions();
        }
    }
}
