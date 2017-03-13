using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, size;
            Console.WriteLine("Please choose >1 Square >2 Triangle");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: break;
                case 2: break;

                default:
                    Console.WriteLine("The number you inserted is not valid ");
                    Console.Read();
                    break;
            }
            Console.WriteLine("Please insert the size you want to create");
            size = int.Parse(Console.ReadLine());
            
            if(number==1)
            {
                int k;
                for (k=1;k<=size;k++)
                {
                    int j;
                    for (j = 1; j <= size; j++)
                    {
                        Console.Write("{0}",k);
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                while (size==1)
                {
                    Console.WriteLine("The size of number you inserted is too small, please insert again");
                    size = int.Parse(Console.ReadLine());
                }
                while (size%2!=1)
                {
                    Console.WriteLine("The size of number you inserted is not an odd number, please insert again");
                    size = int.Parse(Console.ReadLine());
                }

                int tmp = size;
                int c = 1;
                for (int u=1;u<=size;u++)
                {
                    for (int d = 0; d < tmp-1; d++)
                        Console.Write(" ");

                    for (int d = 0; d < c; d++)
                        Console.Write("{0}",u);
                    tmp--;
                    c=c+2;
                    Console.WriteLine();
                }

            }
            Console.Read();
        }
    }
}
