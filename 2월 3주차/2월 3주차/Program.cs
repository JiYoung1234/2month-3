using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2월_3주차
{
    class Program
    {
        private static int plus(int s, int t)
        {
            int resultnumber = s + t;
            return resultnumber;
        }
        private static int minus(int s, int t)
        {
            int resultnumber = s - t;
            return resultnumber;
        }
        private static int multipl(int s, int t)
        {
            int resultnumber = s * t;
            return resultnumber;
        }
        private static int div(int s, int t)
        {
            int resultnumber = s / t;
            return resultnumber;
        }
        static void Main(string[] args)
        {
            string nn1, nn2;
            nn1 = System.Console.ReadLine();
            int s = Convert.ToInt32(nn1);
            string s3 = System.Console.ReadLine();
            nn2 = System.Console.ReadLine();
            int t = Convert.ToInt32(nn2);

            if (s3 == "+")
            {
                int NewInt = plus(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "-")
            {
                int NewInt = minus(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "*")
            {
                int NewInt = multipl(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "/")
            {
                int NewInt = div(s, t);
                System.Console.WriteLine(NewInt);
            }
            else
            {
                System.Console.WriteLine("잘못된 부호입니다.");
            }
        }
    }
}
