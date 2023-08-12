using System;

namespace AliSalmeh_ProjectWeek5.Power_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //PowerMethod

            Console.WriteLine("Enter base number: ");
            double myBaseNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter power number: ");
            double myPowerNumber = Convert.ToDouble(Console.ReadLine());

            var myResult = Power(myBaseNumber, myPowerNumber);
            Console.WriteLine($"The result is: {myResult}");
        }

        static double Power(double baseNum, double powerNum)
        {
            double result = 1;
            if (powerNum > 0)
            {
                for (int i = 1; i <= powerNum; ++i)
                {
                    result *= baseNum;
                }
            }
            else if (powerNum < 0)
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