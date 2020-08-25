using System;

namespace statementGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade out of 100 ?");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("................................");

            if (grade >= 95)
            {
                Console.WriteLine("You got an A +");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (grade >= 85)
            {
                Console.WriteLine("You got a B +");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (grade >= 75)
            {
                Console.WriteLine("You got a C +.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You got a C.");
            }
            else if (grade >= 65)
            {
                Console.WriteLine("You got a D + :( ");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got a D: '( ");
            }
            else if (grade <= 64 && grade >= 61)
            {
                Console.WriteLine("You found my lucky number but sorry you still failed!");
            }
            else
            {
                Console.WriteLine("You failed!");
            }
        }
    }
}
