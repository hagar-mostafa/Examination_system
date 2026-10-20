using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

       public Answers() { } // when i make object in mcq class i don't need to put 2 prameters so i do this prameterless constructor
        public Answers(int Id, string Text)
        {
            AnswerId = Id;
            AnswerText = Text;
        }

        public override string ToString()
        {
            return $"{AnswerId} - {AnswerText}";
        }


    }
}
