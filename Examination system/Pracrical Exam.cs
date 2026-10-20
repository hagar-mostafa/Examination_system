using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{
    // Remeber practical exam contain MCQ only
    class PracticalExam : Exam
    {
        public Questions[] Questions { get; set; }
        public Answers[] Answer { get; set; }
        public PracticalExam() { }
        // Base constructor to apply principle DRY (don't repeat ur self)

        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void CreateListOfQuestions()
        {
            Questions = new MCQ[NumberOfQuestions];
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQ();
                Questions[i].Add_Question();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {

            int studentAnswer, TotalMark = 0, Grade = 0;

            foreach (var Question in Questions)
            {
                Console.WriteLine(Question);
                for (int i = 0; i < Question.Answer.Length; i++)
                {
                    Console.WriteLine(Question.Answer[i]);
                }
                Console.WriteLine("=======================================================");

                do
                {
                    Console.WriteLine("Please Enter Number Of Your Answer  :");
                } while (!int.TryParse(Console.ReadLine(), out studentAnswer) || studentAnswer < 1 || studentAnswer > 3);

                Question.StudentAnswer.AnswerId = studentAnswer;
                Question.StudentAnswer.AnswerText = Question.Answer[studentAnswer - 1].AnswerText;
                Console.WriteLine("=======================================================");


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
                Console.WriteLine($"Your Answer => {Questions[i].StudentAnswer.AnswerText}");
                Console.WriteLine($"The Correct Answer => {Questions[i].CorrectAnswer.AnswerText}");

            }
            Console.WriteLine($"Your Grade is {Grade} from {TotalMark}");
        }
    }
}
