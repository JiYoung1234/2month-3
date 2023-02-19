using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 랜덤
{
    class Program
    {
        public enum theplay
        {
            idle,
            walk,
            name,
        }
        public string name { get; private set; }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomint = rand.Next(0, 10);
            System.Console.WriteLine((randomint));

            
            theplay theplays = theplay.idle;
            switch (theplays)
            {
                case theplay.idle:
                    System.Console.WriteLine("난 공격한다");
                    break;
                case theplay.walk:
                    System.Console.WriteLine("난 걷는다");
                    break;
            }
        }
    }
}
