using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "y";
            while (flag == "y")
            {
                //1.讓使用者輸入兩個數字，判斷第二個數字是不是第一個數字的倍數
                Console.WriteLine("請輸入第一個數字：");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("請輸入第二個數字：");
                int b = Convert.ToInt16(Console.ReadLine());
                if ((b % a) == 0)
                {
                    Console.WriteLine("第二個數字是第一個數字的倍數");
                }
                else
                {
                    Console.WriteLine("第二個數字不是第一個數字的倍數");
                }
                Console.WriteLine("是否要繼續？y/n");
                if (Console.ReadLine() == "n")
                {
                    flag = "n";
                }
            }
        }
    }
}
