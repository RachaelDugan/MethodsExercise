using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine("How many siblings do you have?");
            string siblings = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            Console.Write("Hello world! I am the great an powerfull " + name);
            Console.Write("! I love wearing fancy " + color);
            Console.Write(" capes. In my spare time I like to juggle " + food);
            Console.Write(". I can get " + siblings);
            Console.WriteLine(" items in the air at once!");
            Console.WriteLine("My lucky numbers are -");



            //second exercise
            MoreMethods.Add(4, 9);
            MoreMethods.Subtract(71, 36);
            MoreMethods.Multiply(5, 9);
            MoreMethods.Divide(25, 5);

        }
    }
}

