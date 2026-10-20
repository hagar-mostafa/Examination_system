using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{
    
        public class TrueOrFalse: Questions
        {
            public override string Header => "True or False question";

            public TrueOrFalse()
            {
                Answer = new Answers[2];
                Answer[0] = new Answers(1, "True");
                Answer[1] = new Answers(2, "False");

            }
            public override void Add_Question()
            {
                int mark, RightAnswerId;

                Console.WriteLine("True Or False Question :");

                Console.WriteLine("Please Enter the question body:");
                Body = Console.ReadLine();


                //marks
                do
                {
                    Console.WriteLine("Please Enter the question mark :");

                } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);
                Mark = mark;


                do
                {
                    Console.WriteLine("Please Enter The ID of the correct answer (1 for True and 2 for False ):");
                } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 2);

                CorrectAnswer.AnswerId = RightAnswerId;
                CorrectAnswer.AnswerText = Answer[RightAnswerId - 1].AnswerText;


                Console.Clear();
            }


        }

    }

