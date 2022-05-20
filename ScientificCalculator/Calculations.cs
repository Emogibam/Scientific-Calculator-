using System;
namespace ScientificCalculator
{
    public static class Calculations
    {
        public static long CalFactorial(int number)
        {
            if(number == 0)
                return 1;

            return number * CalFactorial(number - 1);
        }

        public static decimal BasicOperation (decimal a, decimal b, string opt)
        {
            switch (opt)
            {
                case "1":
                    return a + b;
                case "2":
                    return a - b;
                case "3":
                    return a * b;
                case "4":
                    return a / b;
                case "5":
                    return a % b;
                default:
                    return -1;
            }
        }


        public static double LogOperation (double num, string opt)
        {
            if (opt == "L")
                return Math.Log(num);

            return Math.Log10(num);
        }


        public static double ExpOperation (double basenum, double exponent)
        {
            return Math.Pow(basenum, exponent);
        }

        public static double TrigOperation (double angle, int operation, int option)
        {
            switch (operation)
            {
                case 1:
                    return Math.Cos(ConvertAngle(angle, option));
                case 2:
                    return Math.Sin(ConvertAngle(angle, option));
                case 3:
                    return Math.Tan(ConvertAngle(angle, option));
                case 4:
                    return Math.Cosh(ConvertAngle(angle, option));
                case 5:
                    return Math.Sinh(ConvertAngle(angle, option));
                case 6:
                    return Math.Tanh(ConvertAngle(angle, option));
                default:
                    return -1;
            }
        }


        private static double ConvertAngle (double angle, int option)
        {
            if(option == 1)
                return Math.PI * angle / 180.0;
            if (option == 2)
                return angle * 1.1111;

            return angle;
        }

        
    }
}
