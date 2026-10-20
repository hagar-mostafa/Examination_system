using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace Examination_system
{

    // I need this class abstract because i want to make it base class and i don't need to take object from it
    // and it can contain abstract methods which are methods without implementation that must be implemented by derived classes.
    public abstract class Questions
    {
        public abstract string Header { get; }
        public string  Body { get; set; }
        public int Mark { get; set; }
        public Answers[] Answer { get; set; }
        public Answers CorrectAnswer { get; set; }
        public Answers StudentAnswer { get; set; }
        public Questions()
        {
            CorrectAnswer = new Answers();
            StudentAnswer = new Answers();
        }
        public override string ToString()
        {
            return $" {Body}\t \t Mark: {Mark}";
        }
        public abstract void Add_Question();
    }
}

