using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            player player = new player();
            darkmonster dark = new darkmonster();
            player.attackmonster(dark);

            lightmonster light = new lightmonster();
            player.attackmonster(light);
        }
        interface monsther
        {
            void hitfromplayer(int damage);
        }
        class darkmonster : monsther
        {
            int hp = 100;
            public void hitfromplayer(int damage)
            {
                hp = hp - damage;
                System.Console.WriteLine($"몬스터: 남은 hp {hp}");
            }
            /*
            public void hitfromplayer(int damage)
            {
                throw new NotImplementedException();
            }
            */
        }
        class lightmonster : monsther
        {
            int hp = 100;
            public void hitfromplayer(int damage)
            {
                hp = hp - (damage / 2);
                System.Console.WriteLine($"빛몬스터는 반만 맞는다 남은 hp {hp}");
            }

            
        }
        class player
        {
            int attackdamage = 15;
            public void attackmonster(monsther monsther)
            {
                System.Console.WriteLine($"플레이어: 난 몬스터를 때렸다");
                monsther.hitfromplayer(attackdamage);
            }
        }
    }
}
