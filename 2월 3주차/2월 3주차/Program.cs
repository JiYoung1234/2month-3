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

            //나이 계산하기
            System.Console.WriteLine("태어난 년도를 입력하세요: ");
            string yearss=System.Console.ReadLine();
            int year = Convert.ToInt32(yearss);
            switch (year % 12)
            {
                case 0:
                    System.Console.WriteLine($"당신의 나이는 {2023-year+1}이고, 원숭이띠는 입니다.");
                    break;
                case 1:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 닭띠입니다.");
                    break;
                case 2:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 개띠입니다.");
                    break;
                case 3:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 돼지띠입니다.");
                    break;
                case 4:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 쥐띠입니다.");
                    break;
                case 5:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 소띠입니다.");
                    break;
                case 6:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 호랑이띠입니다.");
                    break;
                case 7:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 토끼띠입니다.");
                    break;
                case 8:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 용띠입니다.");
                    break;
                case 9:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 뱀띠입니다.");
                    break;
                case 10:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 말띠입니다.");
                    break;
                case 11:
                    System.Console.WriteLine($"당신의 나이는 {2023 - year + 1}이고, 띠는 양띠입니다.");
                    break;
            }


            
        }
        //1. 통장 클래스
        class Bank
        {
            //2.본통장 클래스에는 잔고(int)가있음
            public int bankMoney;
            //3. 입금 / 출금 / 이체 메소드 보유하고 있다.
            public void PutMoney(int putMoney)
            {
                bankMoney = bankMoney + putMoney;
            }
            public void OutMoney(int outMoney)
            {
                bankMoney = bankMoney - outMoney;
            }
            class Abank : Bank
            {
                int bankMoney = 1000000;
            }
            class Bbank : Bank
            {
                int bankMoney = 1000000;
            }
        }
        //4. 통장 클래스를 가지고 2개의 인스턴스를 만든다(A통장/B통장)
        //5. 수중에 100만원을 가지고 있는 것으로 시작한다.(int)
        //6. Main에서 선택지를 띄운다. While문을 이용해서 특정 키가 들어올 때까지 계속 반복한다.
        //   선택지는 1.입금 2.출금 3.이체 3개가 있다.
        //   여기서 선택지는 항상 A통장 기준이다.
        //7. 입금을 선택하고 금액을 입력하면, 수중의 돈이 줄어들고 A통장의 금액은 추가된다.
        //   A통장의 잔액이 출력된다.
        //8. 출금을 선택하고 금액을 입력하면, 수중의 돈이 늘어나고 A통장의 금액은 줄어든다.
        //   A통장의 잔액이 출력된다.
        //9. 이체를 선택하고 금액을 입력하면, A통장의 금액이 줄어들고, B통장의 금액이 늘어난다.
        //   A통장과 B통장의 잔액을 출력한다.
    }
}
