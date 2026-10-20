using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{

    class FinalExam : Exam
    {
        public Questions[] Questions { get; set; }
        public int Grade { get; set; }
        public Answers[] Answer { get; set; }
        public FinalExam() { }
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            int TypeOfQuestion;
            Questions = new Questions[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                do
                {
                    Console.Write($"Please Choose The Type Of Question Number ({i + 1})  ( 1 for MCQ || 2 for True Or False ):");
                } while (!int.TryParse(Console.ReadLine(), out TypeOfQuestion) || TypeOfQuestion < 1 || TypeOfQuestion > 2);

                Console.Clear(); // To new make window 


                if (TypeOfQuestion == 1)
                {
                    Questions[i] = new MCQ();
                    Questions[i].Add_Question();
                }
                else if (TypeOfQuestion == 2)
                {
                    Questions[i] = new TrueOrFalse();
                    Questions[i].Add_Question();
                }
            }
        }
        public override void ShowExam()
        {
            int StudentAnswer, TotalMark = 0, Grade = 0;
            foreach (var Question in Questions)
            {

                Console.WriteLine(Question);

                //Choices of question

                for (int i = 0; i < Question.Answer.Length; i++)
                {
                    Console.WriteLine(Question.Answer[i]);
                }
                Console.WriteLine("---------------------------");


                // Answer from User


                if (Question.Header == "MCQ Question")
                {


                    do
                    {
                        Console.WriteLine("Enter number of your answer:");

                    }
                    while ((!int.TryParse(Console.ReadLine(), out StudentAnswer)) || (StudentAnswer < 1 || StudentAnswer > 4));

                    Question.StudentAnswer.AnswerId = StudentAnswer;
                    Question.StudentAnswer.AnswerText = Question.Answer[StudentAnswer - 1].AnswerText;

                    Console.WriteLine("======================================================");
                }
                else if (Question.Header == "True or False question")
                {


                    do
                    {
                        Console.WriteLine("Enter number of your answer:");

                    }
                    while ((!int.TryParse(Console.ReadLine(), out StudentAnswer)) || (StudentAnswer < 1 || StudentAnswer > 2));

                    Question.StudentAnswer.AnswerId = StudentAnswer;
                    Question.StudentAnswer.AnswerText = Question.Answer[StudentAnswer - 1].AnswerText;
                    Console.WriteLine("======================================================");
                }


                Console.WriteLine();
                Console.Clear();


                TotalMark += Question.Mark;

            }
            for (int i = 0; i < Questions.Length; i++)
            {

                if (Questions[i].CorrectAnswer.AnswerId == Questions[i].StudentAnswer.AnswerId)
                {
                    Grade += Questions[i].Mark;
                }
                Console.WriteLine($"Question({i + 1}) :{Questions[i].Body}");
                Console.WriteLine($"Your Answer is : {Questions[i].StudentAnswer.AnswerText}");
                Console.WriteLine($"The Correct Answer is : {Questions[i].CorrectAnswer.AnswerText}");

            }
            Console.WriteLine($"Your Grade is {Grade} from {TotalMark}");


        }
    }

}
