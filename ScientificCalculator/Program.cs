using System;

namespace ScientificCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayUI display = new DisplayUI();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello; You are Welcome to Scientific Calculator");
            Console.ResetColor();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Type help to show options");
            Console.WriteLine(">");
            string inputline = Console.ReadLine().Trim();

            while(!inputline.Equals("") && !inputline.Equals("exit"))
            {
                if(inputline.Equals("1"))
                {
                    display.BasicOperations();
                }
                else if (inputline.Equals("2"))
                {
                    display.TrigOperations();
                }
                else if (inputline.Equals("3"))
                {
                    display.ExpOperation();
                }
                else if (inputline.Equals("4"))
                {
                    display.LogOperation();
                }
                else if (inputline.Equals("5"))
                {
                    display.ProbOperation();
                }

                else if (inputline.ToLower().Equals("help"))
                {
                    display.help();
                }

                else
                {
                    Console.WriteLine("command not recognized, please type to see all option");
                }

                Console.WriteLine(">");

                inputline = Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
