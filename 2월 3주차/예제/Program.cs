
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 예제
{
    interface Entity
    {
        void Attack(Entity entity);//공격하기
        void Takedamage(); // 공격받기
        void Avoid(); //회피하기
        void ReduceHP(); //피해하기
    }
    class Player : Entity
    {
        public int hp = 3;
        public void Attack(Entity entity)
        {
            System.Console.WriteLine("플레이어가 몬스터를 공격함");
            entity.Takedamage();
        }

        public void Avoid()
        {
            System.Console.WriteLine("플레이어가 회피함");
        }

        public void ReduceHP()
        {
            hp--;
            System.Console.WriteLine($"플레이어가 데미지를 입음! 플레이어 체력 : {hp}");
        }

        public void Takedamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0)    //0인 경우 데미지 안받음
            {
                Avoid();
            }
            else            // 1인 경우 데미지 받음
            {
                ReduceHP();
            }
        }
    }
    class Monster : Entity
    {
        public int hp = 3;
        public void Attack(Entity entity)
        {
            System.Console.WriteLine("몬스터가 플레이어를 공격함");
            entity.Takedamage();
        }

        public void Avoid()
        {
            System.Console.WriteLine("몬스터가 회피함");
        }
        

        public void ReduceHP()
        {
            hp--;
            System.Console.WriteLine($"몬스터가 데미지를 입음! 몬스터 체력 {hp}");
        }

        public void Takedamage()
        {
            Random rand = new Random();
            int randint = rand.Next(0, 2);
            if (randint == 0)  //0인 경우 데미지 안받음
            {
                Avoid();
            }
            else  //1인 경우 데미지를 받음
            {
                ReduceHP();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();
            while(player.hp != 0 && monster.hp != 0)
            {
                player.Attack(monster);
                Thread.Sleep(500);
                System.Console.WriteLine();
                monster.Attack(player);
                Thread.Sleep(500);

                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            if (player.hp == 0)
            {
                System.Console.WriteLine("플레이어가 죽었습니다");
            }
            if(monster.hp==0)
            {
                System.Console.WriteLine("몬스터가 죽었습니다");
            }
        }
    }
    
}
