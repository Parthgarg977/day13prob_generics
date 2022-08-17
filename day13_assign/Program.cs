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
                    "1) Press 1 to find integer maximum number\n"+
                    "2) Press 2 to find float maximum number\n");
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
                    case 2:
                        Console.WriteLine("Enter 3 numbers");
                        float numf1 = float.Parse(Console.ReadLine());
                        float numf2 = float.Parse(Console.ReadLine());
                        float numf3 = float.Parse(Console.ReadLine());
                        float resultf = obj1.FindMxInteger(numf1, numf2, numf3);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + resultf);// To display Maximum Number
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