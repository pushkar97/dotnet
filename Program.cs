using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter no of rows : ");
            int lineCount = Convert .ToInt32(Console.ReadLine());
            for (int i = 0; i < lineCount; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
