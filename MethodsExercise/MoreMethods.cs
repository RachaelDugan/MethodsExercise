using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class MoreMethods

    {
         public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
         public static void Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            Console.WriteLine(sum);
        }
        public static void Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine(sum);
        }
        public static void Divide(int num1, int num2)
        {
            int sum = num1 / num2;
            Console.WriteLine(sum);
        }

        public static void AddParams(params int[] number)
        {
            int sum = 0;
            sum = sum + number.Length;
            foreach (int i in number) 
            {
            Console.WriteLine(sum + i);
            }
        }      
    }
}
