using System;

namespace MethodsExercise
{
    class Program
    {
        public static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }
        public static int Subtract(params int[] values)
        {
            int difference = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                difference -= values[i];
            }
            return difference;
        }

        public static int Multiply(params int[] values)
        {
            int product = 1;
            foreach (int value in values)
            {
                product *= value;
            }
            return product;
        }

        public static int Divide(params int[] values)
        {
            int quotient = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                quotient /= values[i];
            }
            return quotient;
        }

        public static int Modulus(params int[] values)
        {
            int remainder = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                remainder %= values[i];
            }
            return remainder;
        }

        static void Main(string[] args)
        {
            Add(10, 20, 30);

            Subtract(100, 50, 25);

            Multiply(2, 3, 4);

            Divide(8, 4, 2);

            Modulus(7, 3, 2);
        }
    }
}
