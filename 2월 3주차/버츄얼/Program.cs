using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 버츄얼
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Darkmonster darkmonster = new Darkmonster();
            zombie zombie = new zombie();
            ghoul ghoul = new ghoul();

            darkmonster.Attackplayer(player);
            System.Console.WriteLine();
            zombie.Attackplayer(player);
            System.Console.WriteLine();
            ghoul.Attackplayer(player);
        }
        
    }
    //abstrack
    abstract class Darkmonser
    {
        int attackvalue = 10;
        public abstract void Attackplayer(Player player);
    }
    class Darkmonster
    {
        int attackvalue = 10;
        public virtual void Attackplayer(Player player) //virtual은 안에 있는 내용을 바꿀수도있다.
        {
            System.Console.WriteLine("monster:player attack");
            player.Hitfrommonster(attackvalue);
        }
    }
    class Player
    {
        int hp = 100;
        public void Hitfrommonster(int Attackvalue)
        {
            hp = hp - Attackvalue;
            System.Console.WriteLine($"my hp {hp}");
        }
    }
    class zombie : Darkmonster
    {
        public override void Attackplayer(Player player)
        {
            base.Attackplayer(player);
            System.Console.WriteLine("monster(zombie) : player bleeding");
        }
    }
    class ghoul : Darkmonster
    {
        public override void Attackplayer(Player player)
        {
  
            System.Console.WriteLine("monster(ghoul) : player cursel");
        }
    }
}
