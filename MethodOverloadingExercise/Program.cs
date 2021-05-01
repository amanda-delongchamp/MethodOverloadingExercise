using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(2, 2);
            var answer2 = Add(2444m, .23533m);
            var answer3 = Add(10, 100, true);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool maybe)
        {
            int total = num1 + num2;

            if (maybe == true)
            {
                if (total == 1)
                {
                    return $"{total} dollar";
                }
                else
                {
                    return $"{total} dollars";
                }
            }
            else
            {
                return $"{total}";
            }
        }
    }
}
