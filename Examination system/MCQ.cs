using Examination_system;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#nullable disable
class MCQ : Questions
{
    private const int OptionsCount = 4;

    public override string Header => "MCQ Question";

    public MCQ()
    {
        Answer = new Answers[OptionsCount];
    }

    public override void Add_Question()
    {
        Console.WriteLine(Header);

        int mark, rightAnswer;

        Console.WriteLine("Please enter question body:");
        Body = Console.ReadLine();

        // Make sure the mark is a positive integer
        do
        {
            Console.WriteLine("Please enter the mark of the question:");
        } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

        Mark = mark;

        // Set choices
        Console.WriteLine("Choices of Questions :");
        for (int i = 0; i < OptionsCount; i++)

        {
            Console.Write($"Please enter choice number {i + 1}: ");
            string text = Console.ReadLine();

            Answer[i] = new Answers(i + 1, text);
        }

        // Take the correct answer from the teacher
        do
        {
            Console.WriteLine($"Please enter the ID of the correct answer (1 to {OptionsCount}):");
        } while (!int.TryParse(Console.ReadLine(), out rightAnswer) || rightAnswer < 1 || rightAnswer > OptionsCount);

        CorrectAnswer = Answer[rightAnswer - 1];

  // Using Clear to make the screen blank after writing question
        Console.Clear();

    }
}
