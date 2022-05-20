using System;

namespace ScientificCalculator
{
    public  class DisplayUI
    {
        readonly string options = @"Options:
        1           For Basic Opertaions like +, -, /, *
        2           For Trigonometric cosine, tangent, sine etc
        3           For Exponential the power of n
        4           For Logarithm and base 10
        5           For number factorial";


        public  void BasicOperations ()
        {
            string operators = "Choose 1 for addition \n 2 for Subtraction \n " +
                "3 for Multiplication \n 4 for Division \n 5 for Modulo ";

            while(true)
            {
                Console.WriteLine("Enter a number: ");

                decimal firstOpt = Convert.ToDecimal(Console.ReadLine().Trim());

                Console.WriteLine("Enter a another number: ");

                decimal secondOpt = Convert.ToDecimal(Console.ReadLine().Trim());

                Console.WriteLine(operators);
                string inputOperator = Console.ReadLine().Trim();

                decimal result = Calculations.BasicOperation(firstOpt, secondOpt, inputOperator);

                Console.WriteLine("Answer is {0}", result);

                Console.WriteLine("Do you want to perform another operation, enter 0 or any key to exit");

                string x = Console.ReadLine().Trim();

                if (x != "0")
                    break;
            }

        }


        public void help()
        {
            Console.WriteLine(options);
        }

        public void TrigOperations()
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");

                double angle = Convert.ToDouble(Console.ReadLine().Trim());

                Console.WriteLine("Enter the operation:\n 1 for Cosine\n 2 for Sine \n 3 for Tangent \n 4 for Cosh \n 5 for Sinh \n 6 for Tanh");

                int operation = Convert.ToInt16(Console.ReadLine().Trim());

                Console.WriteLine("Enter result type\n 1 for Degree\n 2 for Radian \n 3 for Gradient ");
                int option = Convert.ToInt16(Console.ReadLine().Trim());


                double result = Calculations.TrigOperation(angle, operation, option);

                Console.WriteLine("Answer is {0}", result);

                Console.WriteLine("Do you want to perform another operation, enter 0 or any key to exit");

                string x = Console.ReadLine().Trim();

                if (x != "0")
                    break;
            }
        }

        public void ProbOperation ()
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");

                int firstOpt = Convert.ToInt16(Console.ReadLine().Trim());

      
                long result = Calculations.CalFactorial(firstOpt);

                Console.WriteLine("Answer is {0}", result);

                Console.WriteLine("Do you want to perform another operation, enter 0 or any key to exit");

                string x = Console.ReadLine().Trim();

                if (x != "0")
                    break;
            }
        }

        public void LogOperation ()
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");

                double firstOpt = Convert.ToDouble(Console.ReadLine().Trim());

                Console.WriteLine("Enter L for Logarithm and B for base 10 logarithm: ");

                string opt = Console.ReadLine().Trim();

                double result = Calculations.LogOperation(firstOpt, opt);

                Console.WriteLine("Answer is {0}", result);

                Console.WriteLine("Do you want to perform another operation, enter 0 or any key to exit");

                string x = Console.ReadLine().Trim();

                if (x != "0")
                    break;
            }
        }

        public void ExpOperation ()
        {
            while (true)
            {
                Console.WriteLine("Enter a base number: ");

                double baseNumber = Convert.ToDouble(Console.ReadLine().Trim());

                Console.WriteLine("Enter a exponent number ");

                double exponentNumber = Convert.ToDouble(Console.ReadLine().Trim());

                double result = Calculations.ExpOperation(baseNumber, exponentNumber);

                Console.WriteLine("Answer is {0}", result);

                Console.WriteLine("Do you want to perform another operation, enter 0 or any key to exit");

                string x = Console.ReadLine().Trim();

                if (x != "0")
                    break;
            }
        }
    }
}
