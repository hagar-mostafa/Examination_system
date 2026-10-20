using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{

    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Questions[] Question { get; set; }


        public Exam() { }
        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;

        }

        public abstract void ShowExam();

        public abstract void CreateListOfQuestions();

    }
}
