using System;

namespace AliSalmeh_ProjectWeek5.Power_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Power Method

            Console.WriteLine("Enter base number: ");
            double baseNumber = GetUserInput();

            Console.WriteLine("Enter power number: ");
            double powerNumber = GetUserInput();

            var result = Power(baseNumber, powerNumber);
            Console.WriteLine($"The result is: {result}");
        }

        static double GetUserInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static double Power(double baseNum, double powerNum)
        {
            double result = 1;

            if (powerNum == 0)
            {
                return 1;
            }
            else if (powerNum > 0)
            {
                for (int i = 1; i <= powerNum; ++i)
                {
                    result *= baseNum;
                }
            }
            else
            {
                for (int i = -1; i >= powerNum; --i)
                {
                    result /= baseNum;
                }
            }
            return result;
        }
    }
}