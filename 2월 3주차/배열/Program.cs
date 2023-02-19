using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            List<int> intlist = new List<int>() { 6, 2, 4, 6 };
            intlist.Add(7);
            intlist.Add(91);
            for(int index = 0; index < intlist.Count; index++)
            {
                Console.WriteLine(intlist[index]);
            }
            System.Console.WriteLine();
            intlist.Remove(7); //제거
            for (int index = 0; index < intlist.Count; index++)
            {
                Console.WriteLine(intlist[index]);
            }
            System.Console.WriteLine();

            intlist.Insert(3, 9);//몇번째 자리에 숫자넣기
            for (int index = 0; index < intlist.Count; index++)
            {
                Console.WriteLine(intlist[index]);
            }
            System.Console.WriteLine();
            intlist.Clear();
            for (int index = 0; index < intlist.Count; index++)
            {
                Console.WriteLine(intlist[index]);
            }

            float[] floatarray = new float[4];
            List<float> floatlist = new List<float>() { 3.12f, 3.0f, 2.0f, 4.5f, 6.7f };
            for(int f=0; f < floatlist.Count; f++)
            {
                Console.WriteLine(floatlist[f]);
            }
            System.Console.WriteLine();
            
            string[] stringarray = new string[4];
            List<City> citylist = new List<City>();
            City Seoul = new City();
            Seoul.name = "Seoul";
            City Doyko = new City();
            Doyko.name = "Dokyo";
            City city1 = new City();
            city1.name = "city1";
            City city2 = new City();
            city2.name = "city2";
            City city3 = new City();
            city3.name = "city3";

            citylist.Add(Seoul);
            citylist.Add(Doyko);
            citylist.Add(city1);
            citylist.Add(city2);
            citylist.Add(city3);
            for(int i = 0; i < citylist.Count; i++)
            {
                citylist[i].IntroduceCity();
            }

            Dictionary<string, string> myDic = new Dictionary<string, string>()
            {
                {"originkey" ,"origianvalue"},
                {"originkey2","origianvalue2" }
            };
            myDic.Add("addkey", "addvalue");
            myDic["thekey"] = "thekey";
            System.Console.WriteLine(myDic["originkey"]);
            System.Console.WriteLine(myDic["originkey2"]);
            System.Console.WriteLine(myDic["addkey"]);
            System.Console.WriteLine(myDic["thekey"]);

            System.Console.WriteLine();

            Dictionary<string, Monster> mybic = new Dictionary<string, Monster>();
            Monster zombie = new Monster();
            zombie.name = "zombie";
            mybic["zombie"] = zombie;
            mybic["zombie"].IntroduceMonster();
            Monster ghost = new Monster();
            ghost.name = "ghost";
            mybic["ghost"] = ghost;
            mybic["ghost"].IntroduceMonster();
            
        }
        class City
        {
            public string name;
            public void IntroduceCity()
            {
                System.Console.WriteLine($"도시이름은 {name}");
            }
        }

        class Monster
        {
            public string name;
            public void IntroduceMonster()
            {
                System.Console.WriteLine($"몬스터 종류는 {name}");
            }
        }
    }
}
