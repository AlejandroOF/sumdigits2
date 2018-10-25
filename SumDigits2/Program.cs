using System;

namespace SumDigits2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
            string a = Console.ReadLine();
            int sum = 0;
            int n;

            foreach (char num in a)
            {

                n = Int32.Parse(num + "");

                sum = sum + n;

            }

            Console.WriteLine("Suma= ", sum);

            Console.ReadKey();

        }
    }
}
