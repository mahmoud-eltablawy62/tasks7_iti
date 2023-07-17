using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num :-");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the operations:-");
            string ope = Console.ReadLine();
            Console.WriteLine("enter the second num :-");
            float num2 = float.Parse(Console.ReadLine());
            
            switch (ope)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {operations.sum(num1,num2)}");
                    break;
                    
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {operations.sub(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {operations.mul(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {operations.div(num1, num2)}");
                    break;
                case "%":
                    Console.WriteLine($"{num1} % {num2} = {operations.rem(num1, num2)}");
                    break;
            }
            

        }

    }

    static class operations
    {
        public static float sum (float N1 , float N2)
        {
            return N1 + N2;
        }

        public static float sub(float N1, float N2)
        {
            return N1 - N2;
        }

        public static float mul(float N1, float N2)
        {
            return N1 * N2;
        }

        public static float div(float N1, float N2)
        {
            return N1 / N2;
        }

        public static float rem(float N1, float N2)
        {
            return N1 % N2;
        }
    }
}