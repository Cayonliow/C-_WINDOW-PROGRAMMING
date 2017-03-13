using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int price = 120, qty = 50;
            int number, direction, shift, answer=0;
            Console.WriteLine("請輸入十進位數字：");
            number = int.Parse( Console.ReadLine());
            Console.WriteLine("向左或向右移動< 左為1，右為2 > ");
     
            direction = int.Parse(Console.ReadLine());
            switch (direction)
            {
                case 1: break;
                case 2: break;

                default:
                   
                        Console.WriteLine("您所輸入的值不為1也不為2 > ");
                        Console.Read();

                    break;
            }
            Console.WriteLine("移動幾位 < 以2進位的狀態下移動 > ");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=========我是分割線=========");
            Console.WriteLine();
            Console.WriteLine("您所輸入的值為：{0}",number);
            Console.Write("您所輸入的值向");
            if(direction == 1)
            {
                Console.Write("左");
                answer = number << shift;
            }
            else if (direction == 2)
            {
                Console.Write("右");
                answer = number >> shift;
            }
            Console.WriteLine("移動{0}位後,結果為{1}", shift,answer);
            Console.Read();





        }
    }
}
