using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            int p,q;
            Console.WriteLine("Enter two numbers: ");

            x=Console.ReadLine();
            y=Console.ReadLine();   

            bool b1 = int.TryParse(x, out p);
            bool b2 = int.TryParse(y, out q);

            if(b1==true && b2== true)
            {
                Console.WriteLine(p+q);

            }
            Console.ReadLine();

        }
    }
}