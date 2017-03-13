using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public struct TABLE
        {
            public string student;
            public int eng, math;
            public int seatNumber;
        }


        static void Main(string[] args)
        {
            bool countFirst = true;
            while (1 == 1)
            {
                Console.WriteLine("1> Insert\t2> Print the Result\t3> Sort<with the the result of Chinese>\t\t-1> Exit ");
                int order;
                int size;
                int seat;
                TABLE[] ttable;
                int[] chin;
                bool[] check;
                int record = 1;

                do
                {
                    order = int.Parse(Console.ReadLine());
                    if (order == -1)    return;

                    if (order != 1)
                    {
                        Console.WriteLine("The table is empty, Please insert again");
                        Console.WriteLine("1> Insert\t2> Print the Result\t3> Sort<with the the result of Chinese>\t\t-1> Exit ");
                    }

                } while (countFirst == true && order != 1);

                Console.WriteLine("Please insert the number of students in the class (This is needed with the first time of insertion)");
                size = int.Parse(Console.ReadLine());
                size = size + 1;
                chin = new int[size];
                ttable = new TABLE[size];
                check = new bool[size];

                for (int i = 0; i < size; i++)
                    check[i] = false;

                while (1 == 1)
                {
                    Console.WriteLine("1> Insert\t2> Print the Result\t3> Sort<with the the result of Chinese>\t\t-1> Exit ");

                    order = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    switch (order)
                    {
                        case 1:
                            Console.WriteLine("Please insert the seat number: ");
                            seat = int.Parse(Console.ReadLine());
                            /*do
                            {
                                seat = int.Parse(Console.ReadLine());
                                if (check[seat] == true)
                                    Console.WriteLine("The seat number has been inserted, Please insert again: ");

                            } while (check[seat] == true);*/

                            Console.WriteLine("Please insert the name: ");
                            ttable[record].student = Console.ReadLine();

                            Console.WriteLine("Please insert the result of the Chinese subject: ");
                            chin[record] = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please insert the result of the English subject: ");
                            ttable[record].eng = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please insert the result of the Mathematics subject: ");
                            ttable[record].math = int.Parse(Console.ReadLine());

                            ttable[record].seatNumber = seat;
                            check[seat] = true;
                            record++;

                            break;

                        case 2:
                            Console.WriteLine("seat\tchin\teng\tmath\tname");
                            Console.WriteLine("===========================================");
                            for (int i = 1; i < size; i++)
                            {
                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ttable[i].seatNumber, chin[i], ttable[i].eng, ttable[i].math, ttable[i].student);
                            }

                            break;

                        case 3:
                            Array.Sort(chin, ttable);
                            break;
                        case (-1): break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}