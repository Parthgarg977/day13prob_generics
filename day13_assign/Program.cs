using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            FindMax obj1 = new FindMax();
            while (check)
            {
                Console.Write("Select Option:\n" +
                    "1) Press 1 to find integer maximum number\n");
                int option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter 3 numbers");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int result = obj1.FindMxInteger( num1, num2, num3);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    default:
                        check = !check;
                        break;
                }
            }
        }
    }
}